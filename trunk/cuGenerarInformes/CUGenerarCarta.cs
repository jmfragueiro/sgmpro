using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using scioBaseLibrary.interfases;
using scioReportLibrary;
using scioToolLibrary;
using sgmpro.dominio.configuracion;
using sgmpro.dominio.gestion;

namespace cuGenerarInformes {
    public class CUGenerarCarta : IControladorCasoUso {
        private Gestion _gestionEnCurso;
        private ListaGestion _listaEnCurso;

        #region IControladorCasoUso Members
        public object Padre { get; set; }

        public bool iniciar(object padre, params object[] valor) {
            // Asigna el padre
            Padre = padre;

            // Obtiene la gestión correspondiente
            if (valor.Count() < 2)
                return false;
           
            // Imprime una sola o genera toda una lista
            if (valor[1] is Gestion && ((Gestion)valor[1]).Tipo != null) {
                _gestionEnCurso = valor[1] as Gestion;

                // Crea el panel para seleccionar el template de la carta
                var panel = new PanelSeleccionTemplate(this) {Dock = DockStyle.Fill};

                // Crea el formulario
                var ventana = 
                    new FrmVisualizador(
                        String.Format("{0} - Imprimir carta", _gestionEnCurso.Tipo.Valorstring)) {
                                    Owner = (Form) Padre,
                                    Size = new Size(540, 125),
                                    MaximizeBox = false,
                                    MinimizeBox = false,
                                    FormBorderStyle =
                                        FormBorderStyle.FixedSingle
                                };

                // Agrega el panel al formulario
                ventana.Controls.Add(panel);
                DialogResult resultado = ventana.ShowDialog();

                if (resultado == DialogResult.OK) {
                    // Asigna el nombre de la carta seleccionada a la descripción
                    // del resultado de la gestión
                    _gestionEnCurso.ResultadoDesc += panel.NombreCarta;
                    _gestionEnCurso.save();
                }

                return true;
            }

            if (valor[1] is ListaGestion) {
                _listaEnCurso = valor[1] as ListaGestion;

                // Crea el panel para seleccionar el template de la carta
                var panel = new PanelSeleccionTemplateLista(this, _listaEnCurso) { Dock = DockStyle.Fill };

                // Crea el formulario
                var ventana =
                    new FrmVisualizador(
                        String.Format("{0} - Generar Documentos", _listaEnCurso.Nombre))
                        {
                            Owner = (Form)Padre,
                            Size = new Size(540, 165),
                            MaximizeBox = false,
                            MinimizeBox = false,
                            FormBorderStyle =
                                FormBorderStyle.FixedSingle
                        };

                // Agrega el panel al formulario
                ventana.Controls.Add(panel);
                DialogResult resultado = ventana.ShowDialog();
            }

            return false;
        }

        /// <summary>
        /// Implementa el método de la interfaz.
        /// </summary>
        public void aceptarParametros(params object[] valor) {}
        #endregion

        /// <summary>
        /// Retorna el nombre del deudor.
        /// </summary>
        /// <returns>Nombre del intimado</returns>
        public String getNombrePersona() {
            try {
                return _gestionEnCurso.Cuenta.Titular.Nombre;
            } catch {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-SINOMBRE"));
            }
        }

        /// <summary>
        /// Retorna la dirección (Calle y altura) del deudor
        /// </summary>
        public String getDireccionDeudor() {
            try {
                Contacto unContacto = _gestionEnCurso.Cuenta.Titular.getContactoPrincipal();
                var sb = new StringBuilder();
                sb.Append(unContacto.Calle);
                sb.Append(" ");
                sb.Append(unContacto.Puerta);
                return sb.ToString();
            } catch {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Retorna el código postal del deudor.
        /// </summary>
        public String getCpDeudor() {
            try {
                Contacto unContacto = _gestionEnCurso.Cuenta.Titular.getContactoPrincipal();
                return unContacto.Cp;
            } catch {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Retorna la localidad del deudor.
        /// </summary>
        public String getLocalidadDeudor() {
            try {
                Contacto unContacto = _gestionEnCurso.Cuenta.Titular.getContactoPrincipal();
                var sb = new StringBuilder();
                sb.AppendFormat("{0}, {1}", unContacto.Localidad, unContacto.Provincia);
                return sb.ToString();
            } catch {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Retorna el nombre de la Entidad Cliente.
        /// </summary>
        public String getNombreCliente() {
            try {
                return _gestionEnCurso.Cuenta.Entidad.Nombre;
            } catch {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Devuelve el código de la cuenta del deudor.
        /// </summary>
        public String getCodigoCuenta() {
            try {
                return _gestionEnCurso.Cuenta.Codigo;
            } catch {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }
    }
}