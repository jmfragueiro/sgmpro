using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using cuGenerarInformes.Reportes;
using scioBaseLibrary;
using scioBaseLibrary.interfases;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;

namespace cuGenerarInformes {
    public class CUGenerarRecibo : IControladorCasoUso {
        #region IControladorCasoUso Members
        public object Padre { get; set; }

        /// <summary>
        /// Implementa el método de la interfaz.
        /// </summary>
        public bool iniciar(object padre, params object[] valor) {
            Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION, "Iniciando proceso de impresion...");
            var reporte = new ReportDocument();

            // Establece el padre del caso de uso
            Padre = padre;

            // Verifica la correcta recepción de los parámetros
            if (valor.Length == 0)
                return false;

            try {
                // Intenta obtener el recibo recibido como parámetro.
                // Si este es el caso, el mismo estará en la primer
                // posición del array.
                var unRecibo = (Recibo) valor[0];
                Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION, "Imprimiendo Recibo: " + unRecibo);

                // Obtiene el segundo parámetro. Si tiene un valor es una reimpresion
                bool esReimpresion = (valor.GetLength(0).Equals(3));
                Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION, "Es RE-Impresion: " + esReimpresion);

                // Variable para guardar la cantidad de copias a imprimir según el tipo de comprobante (por default 2)
                short copias = 2;
                
                // Analiza que tipo de recibo debe generar
                Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION, "Determinando template a utilizar...");
                switch (unRecibo.Tipo.Clave) {
                    case "TIPOFACTURA.A":
                        Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION,
                                                   "Template: TIPOFACTURA.A => GetReporteFactura(unRecibo, 'A')");
                        reporte = GetReporteFactura(unRecibo, "A");
                        break;
                    case "TIPOFACTURA.B":
                        Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION,
                                                   "Template: TIPOFACTURA.B => " + ((esReimpresion)
                                                                                        ? "GetReporteFacturaRe(unRecibo, 'B')"
                                                                                        : "GetReporteFactura(unRecibo, 'B')"));
                        reporte = (esReimpresion) ? GetReporteFacturaRe(unRecibo, "B") : GetReporteFactura(unRecibo, "B");
                        copias = 1;
                        break;
                    case "TIPOFACTURA.C":
                        Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION,
                                                   "Template: TIPOFACTURA.C => GetReporteFactura(unRecibo, 'C')");
                        reporte = GetReporteFactura(unRecibo, "C");
                        break;
                    case "TIPOFACTURA.RECIBOPROPIO":
                        Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION,
                                                   "Template: TIPOFACTURA.RECIBOPROPIO => " + ((esReimpresion)
                                                                                                   ? "GetReporteReciboRe(unRecibo)"
                                                                                                   : "GetReporteRecibo(unRecibo)"));
                        reporte = (esReimpresion) ? GetReporteReciboRe(unRecibo) : GetReporteRecibo(unRecibo);
                        copias = 1;
                        break;
                    case "TIPOFACTURA.RECIBOPOR3":
                        Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION,
                                                   "Template: TIPOFACTURA.RECIBOPOR3 => no code...");
                        break;
                }

                if (reporte == null) {
                    Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION, "CUIDADO: No se obtuvo reporte...");
                    return false;
                }

                Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION, "Reporte obtenido: " + reporte);
                var dialogVentana = new PrintDialog {AllowPrintToFile = false, PrinterSettings = {Copies = copias}};

                Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION, "Cuadro de Dialogo generado...");
                DialogResult dialogResultado = dialogVentana.ShowDialog();
                if (dialogResultado == DialogResult.OK) {
                    Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION, "Resultado Cuadro de Dialogo: OK");
                    PrinterSettings settings = dialogVentana.PrinterSettings;
                    Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION, "Impresion Seteada");
                    reporte.PrintOptions.PrinterName = settings.PrinterName;
                    Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION, "Imprimiendo a: " + reporte.PrintOptions.PrinterName);
                    reporte.PrintToPrinter(settings.Copies, settings.Collate, settings.FromPage, settings.ToPage);
                } else {
                    Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION, "Resultado Cuadro de Dialogo: NOK");
                }
            } catch (Exception e) {
                Sistema.Controlador.logear("ERROR-IMPRIMIR-RECIBO", ENivelMensaje.ERROR, e.ToString());
                return false;
            }

            // Si todos los pasos salieron bien retorna true
            Sistema.Controlador.logear("GENERICO", ENivelMensaje.INFORMACION, "Recibo Impreso");
            return true;
        }

        /// <summary>
        /// Implementa el método de la interfaz.
        /// </summary>
        public void aceptarParametros(params object[] valor) {}
        #endregion

        /// <summary>
        /// Devuelve el documento a imprimir de la factura
        /// dependiendo de la letra correspondiente, pasada
        /// como parámetro.
        /// </summary>
        /// <param name="unRecibo">Instancia de Recibo del
        /// tipo factura</param>
        /// <param name="letra">Letra correspondiente al tipo
        /// de factura</param>
        /// <returns>Factura</returns>
        private static ReportDocument GetReporteFactura(Recibo unRecibo, String letra) {
            try {
                // Establece la dirección para la factura
                Contacto cto = unRecibo.Pago.Cuenta.Titular.getContactoPrincipal();
                string direccion = cto.Calle
                                   + (cto.Puerta != null
                                          ? "Nº " + cto.Puerta
                                          : "S/N")
                                   + (cto.PisoDepto != null
                                          ? "Po/Dto: " + cto.PisoDepto
                                          : "");
                string localidad = cto.Localidad.Nombre
                                   + ", " + cto.Provincia.Nombre
                                   + "(" + cto.Cp + ")";

                // Inserta el Header del recibo. Crea una instancia de la
                // tabla Factura que se encuentra en el componente DSInforme
                var ds = new DSInformes();

                ds.Factura.AddFacturaRow(
                    unRecibo.Numero,
                    unRecibo.Fecha,
                    string.Format("{0} (Cód.:{1})", unRecibo.Pago.Cuenta.Titular.Nombre, unRecibo.Pago.Cuenta.Codigo),
                    direccion,
                    localidad,
                    unRecibo.Pago.Cuenta.Titular.TipoIVA.Nombre,
                    unRecibo.Pago.Cuenta.Titular.Cuit,
                    unRecibo.Pago.FormaPago.Nombre,
                    unRecibo.getSubTotal(),
                    0,
                    unRecibo.getSubTotal(),
                    unRecibo.getMontoIva(),
                    unRecibo.Importe,
                    unRecibo.Pago.Cuenta.Entidad.Nombre);

                // Genera las líneas 
                ds.Lineas.AddLineasRow(
                    ds.Factura[0],
                    1,
                    1,
                    unRecibo.Concepto.Nombre,
                    (unRecibo.Tipo.Clave != "TIPOFACTURA.A")
                        ? 0
                        : unRecibo.Importe,
                    unRecibo.Importe);

                // Crea el reporte
                //ReportDocument reporte = (letra == "A") ? new RFactura() : new RFactura();
                var reporte = new RFactura();
                reporte.SetDataSource(ds);
                return reporte;
            } catch (Exception e) {
                Sistema.Controlador.logear("ERROR-IMPRIMIR-RECIBO", ENivelMensaje.ERROR, e.ToString());
                throw;
            }
        }

        /// <summary>
        /// Devuelve el documento a reimprimir de la factura
        /// dependiendo de la letra correspondiente, pasada
        /// como parámetro.
        /// </summary>
        /// <param name="unRecibo">Instancia de Recibo del
        /// tipo factura</param>
        /// <param name="letra">Letra correspondiente al tipo
        /// de factura</param>
        /// <returns>Factura</returns>
        private static ReportDocument GetReporteFacturaRe(Recibo unRecibo, String letra) {
            try {
                // Establece la dirección para la factura
                Contacto cto = unRecibo.Pago.Cuenta.Titular.getContactoPrincipal();
                string direccion = cto.Calle
                                   + (cto.Puerta != null
                                          ? "Nº " + cto.Puerta
                                          : "S/N")
                                   + (cto.PisoDepto != null
                                          ? "Po/Dto: " + cto.PisoDepto
                                          : "");
                string localidad = cto.Localidad.Nombre
                                   + ", " + cto.Provincia.Nombre
                                   + "(" + cto.Cp + ")";

                // Inserta el Header del recibo. Crea una instancia de la
                // tabla Factura que se encuentra en el componente DSInforme
                var ds = new DSInformes();

                ds.Factura.AddFacturaRow(
                    unRecibo.Numero,
                    unRecibo.Fecha,
                    string.Format("{0} (Cód.:{1})", unRecibo.Pago.Cuenta.Titular.Nombre, unRecibo.Pago.Cuenta.Codigo),
                    direccion,
                    localidad,
                    unRecibo.Pago.Cuenta.Titular.TipoIVA.Nombre,
                    unRecibo.Pago.Cuenta.Titular.Cuit,
                    unRecibo.Pago.FormaPago.Nombre,
                    unRecibo.getSubTotal(),
                    0,
                    unRecibo.getSubTotal(),
                    unRecibo.getMontoIva(),
                    unRecibo.Importe,
                    unRecibo.Pago.Cuenta.Entidad.Nombre);

                // Genera las líneas 
                ds.Lineas.AddLineasRow(
                    ds.Factura[0],
                    1,
                    1,
                    unRecibo.Concepto.Nombre,
                    (unRecibo.Tipo.Clave != "TIPOFACTURA.A")
                        ? 0
                        : unRecibo.Importe,
                    unRecibo.Importe);

                // Crea el reporte
                //ReportDocument reporte = (letra == "A") ? new RFactura() : new RFactura();
                var reporte = new RFacturaRe();
                reporte.SetDataSource(ds);
                return reporte;
            } catch (Exception e) {
                Sistema.Controlador.logear("ERROR-IMPRIMIR-RECIBO", ENivelMensaje.ERROR, e.ToString());
                throw;
            }
        }

        /// <summary>
        /// Devuelve el documento a imprimir para el recibo
        /// correspondiente
        /// </summary>
        /// <param name="unRecibo">Recibo</param>
        /// <returns>Documento a imprimir</returns>
        private static ReportDocument GetReporteRecibo(Recibo unRecibo) {
            try {
                // Inserta el Header del recibo. Crea una instancia de la
                // tabla Factura que se encuentra en el componente DSInforme
                var ds = new DSInformes();

                // Carga los datos del recibo en la tabla. Esta se
                // utilizará para completar el informe.
                ds.Recibo.AddReciboRow(
                    unRecibo.Numero,
                    unRecibo.Concepto.Nombre,
                    unRecibo.Importe,
                    string.Format("{0}. {1}", unRecibo.Pago.Tipo.Nombre, unRecibo.Descripcion),
                    unRecibo.Fecha,
                    string.Format("{0} (Cód.:{1})", unRecibo.Pago.Cuenta.Titular.Nombre, unRecibo.Pago.Cuenta.Codigo),
                    unRecibo.Pago.Cuenta.Codigo,
                    Numalet.ToString(unRecibo.Importe),
                    1,
                    unRecibo.Pago.Cuenta.Entidad.Nombre);
                // Crea el reporte
                var reporte = new RRecibo();
                reporte.SetDataSource(ds);
                return reporte;
            } catch (Exception e) {
                Sistema.Controlador.logear("ERROR-IMPRIMIR-RECIBO", ENivelMensaje.ERROR, e.ToString());
                throw;
            }
        }

        /// <summary>
        /// Devuelve el documento a reimprimir para el recibo
        /// correspondiente
        /// </summary>
        /// <param name="unRecibo">Recibo</param>
        /// <returns>Documento a imprimir</returns>
        private static ReportDocument GetReporteReciboRe(Recibo unRecibo) {
            try {
                // Inserta el Header del recibo. Crea una instancia de la
                // tabla Factura que se encuentra en el componente DSInforme
                var ds = new DSInformes();

                // Carga los datos del recibo en la tabla. Esta se
                // utilizará para completar el informe.
                ds.Recibo.AddReciboRow(
                    unRecibo.Numero,
                    unRecibo.Concepto.Nombre,
                    unRecibo.Importe,
                    string.Format("{0}. {1}", unRecibo.Pago.Tipo.Nombre, unRecibo.Descripcion),
                    unRecibo.Fecha,
                    string.Format("{0} (Cód.:{1})", unRecibo.Pago.Cuenta.Titular.Nombre, unRecibo.Pago.Cuenta.Codigo),
                    unRecibo.Pago.Cuenta.Codigo,
                    Numalet.ToString(unRecibo.Importe),
                    1,
                    unRecibo.Pago.Cuenta.Entidad.Nombre);
                // Crea el reporte
                var reporte = new RReciboRe();
                reporte.SetDataSource(ds);
                return reporte;
            } catch (Exception e) {
                Sistema.Controlador.logear("ERROR-IMPRIMIR-RECIBO", ENivelMensaje.ERROR, e.ToString());
                throw;
            }
        }
    }
}