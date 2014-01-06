using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary;
using scioPersistentLibrary.enums;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;
using sgmpro.dominio.gestion;
using toolsGestion;
using Application = System.Windows.Forms.Application;

namespace cuGenerarInformes {
    public partial class PanelSeleccionTemplateLista : UserControl {
        private readonly Parametro _asignada = Parametros.GetByClave("ESTADOGESTION.ASIGNADA");
        /// <summary>
        ///   Controlador
        /// </summary>
        private readonly CUGenerarCarta _control;
        private readonly Parametro _creada = Parametros.GetByClave("ESTADOGESTION.CREADA");
        private readonly Parametro _finalizada = Parametros.GetByClave("ESTADOGESTION.FINALIZADA");
        private readonly ListaGestion _lista;
        private readonly Parametro _postal = Parametros.GetByClave("TIPOGESTION.POSTAL");
        private readonly Parametro _respostal = Parametros.GetByClave("RESULTADOGESTION.CORREOENTREGADO");
        private readonly Parametro _resterreno = Parametros.GetByClave("RESULTADOGESTION.TERRENOENTREGADO");
        private readonly Parametro _terreno = Parametros.GetByClave("TIPOGESTION.TERRENO");

        public PanelSeleccionTemplateLista(CUGenerarCarta unCtrl, ListaGestion unaLista) {
            InitializeComponent();
            _control = unCtrl;
            _lista = unaLista;
            cargaComboTemplates();
            inicializaDestino();
        }

        /// <summary>
        ///   Almacena el nombre de la carta seleccionada.
        ///   Es pública para poder ser recuperada desde afuera.
        /// </summary>
        public String NombreCarta { get; set; }

        /// <summary>
        ///   Carga el combobox con los templates disponibles.
        ///   Por cada template existente se carga un parámetro
        ///   con base 'CARTA'.
        /// </summary>
        private void cargaComboTemplates() {
            IList<Parametro> templates = Parametros.GetByTipoClaveLike(ETipoParametro.BASE, "CARTA");
            txtCmbNombre.DataSource = templates;
        }

        /// <summary>
        /// Inicializa el valor del campo Destino.
        /// </summary>
        private void inicializaDestino() {
            txtDestino.Text = Environment.SpecialFolder.Personal.ToString();
        }

        /// <summary>
        /// Asigna los datos de la carta seleccionada a la cuenta.
        /// </summary>
        private void txtCmbNombre_SelectedIndexChanged(object sender, EventArgs e) {
            // Muestra el nombre del template que va a utilizar
            txtDescTemplate.Text = ((Parametro) txtCmbNombre.SelectedItem).Valorstring;
        }

        /// <summary>
        /// Este evento responde al boton de Aceptar la generacion de documentos.
        /// </summary>
        /// <param name="sender">
        /// El objeto que genera el evento.
        /// </param>
        /// <param name="e">
        /// Los datos asociados al evento.
        /// </param>
        private void btnAceptar_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("GENERACION-DOC-AYUDA"));

            try {
                int creados, errores, bloqueadas;

                Sistema.Controlador.logear("GENERACION-DOCUMENTOS-INI", ENivelMensaje.INFORMACION, _lista + "/" + txtDescTemplate.Text);
                int ctdad = creados = errores = bloqueadas = 0;

                if (ParentForm != null) ParentForm.DialogResult = DialogResult.OK;

                object oMissing = Missing.Value;
                String nombreTemplate = String.Format("{0}\\Templates\\{1}", Application.StartupPath, txtDescTemplate.Text);

                // Abre el Word
                _Application oWordApp = new Microsoft.Office.Interop.Word.Application();
                oWordApp.Visible = false;
                object oTemplate = nombreTemplate;

                foreach (Gestion gestion in _lista.ListaGestiones) {
                    _Document oWordDoc = oWordApp.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);

                    try {
                        ctdad++;

                        // verifica que la gestion recien este creada y no haya sido tocada
                        // o, solo si esta asignada, sea a este usuario o por tener gestor
                        if (gestion.isAlive() &&
                            (gestion.Estado.Equals(_creada) ||
                             (gestion.Estado.Equals(_asignada) && 
                              (gestion.Usuario.Equals(Sistema.Controlador.SecurityService.getUsuario()) ||
                               gestion.Cuenta.Gestor != null)))) {
                            // si no fue tocada sigue y crea el documento
                            Cuenta cta = gestion.Cuenta;
                            Persona tit = cta.Titular;
                            Contacto con = tit.getContactoPrincipal();

                            if (oWordDoc.Bookmarks.Exists("NombreDeudor")) {
                                // Setea el valor del Bookmark          
                                object oBookMark = "NombreDeudor";
                                string texto = String.Format("{0}", tit.Nombre);
                                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                            }

                            if (oWordDoc.Bookmarks.Exists("DireccionDeudor")) {
                                // Setea el valor del Bookmark          
                                object oBookMark = "DireccionDeudor";
                                string texto = (con != null)
                                                   ? String.Format("{0} {1} {2}",
                                                                   (con.Calle ?? "[Sin Dato Calle]"),
                                                                   (con.Puerta ?? string.Empty),
                                                                   (con.PisoDepto ?? string.Empty))
                                                   : "[Sin Dato Calle]";

                                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                            }

                            if (oWordDoc.Bookmarks.Exists("CpDeudor")) {
                                // Setea el valor del Bookmark          
                                object oBookMark = "CpDeudor";
                                string texto = (con != null)
                                                   ? String.Format("{0}", (con.Cp ?? "[Sin Dato CP]"))
                                                   : "[Sin Dato CP]";
                                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                            }
                            if (oWordDoc.Bookmarks.Exists("LocalidadProvincia")) {
                                // Setea el valor del Bookmark          
                                object oBookMark = "LocalidadProvincia";
                                string texto = (con != null)
                                                   ? String.Format("{0}, {1}", con.Localidad, con.Provincia)
                                                   : "[Sin Dato Loc/Prov]";
                                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                            }

                            if (oWordDoc.Bookmarks.Exists("NombreCliente")) {
                                // Setea el valor del Bookmark          
                                object oBookMark = "NombreCliente";
                                string texto = String.Format("{0}", cta.Entidad.Nombre);
                                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                            }

                            if (oWordDoc.Bookmarks.Exists("CodigoCuenta")) {
                                // Setea el valor del Bookmark          
                                object oBookMark = "CodigoCuenta";
                                string texto = String.Format("{0}", cta.Codigo);
                                oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                            }

                            // graba el documebnto recien creado
                            string nombredoc = txtDestino.Text + "\\Doc_" + _lista.Nombre + "_" + cta.Codigo;
                            oWordDoc.SaveAs(nombredoc);
                            oWordDoc.Close();

                            // actualiza la gestion para mostrarla en proceso
                            DateTime fecha = DateTime.Now;
                            string descripcion = "DOCUMENTO GENERADO:" + nombredoc.ToUpper() + ".DOC";
                            Parametro tipo = (_lista.TipoLista.TipoGestion == _postal) ? _respostal : _resterreno;
                            saveResultado(gestion, tipo, descripcion, fecha, tit, con);

                            creados++;
                        } else {
                            bloqueadas++;
                        }
                    } catch (Exception ex) {
                        errores++;
                        oWordDoc.Close(WdSaveOptions.wdDoNotSaveChanges);
                        Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                    }
                }

                // close the application
                oWordApp.Application.Quit(ref oMissing, ref oMissing, ref oMissing);

                string resultado = string.Format("Procesados: {0}. Completados: {1}. Bloqueados: {2}. Errores: {3}.",
                                                 ctdad, creados, bloqueadas, errores);
                Sistema.Controlador.mostrar("GENERACION-DOCUMENTOS-FIN", ENivelMensaje.INFORMACION, resultado, true);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            } finally {
                Cursor = Cursors.Default;
                Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("AYUDA-LISTO"));
            }
        }

        /// <summary>
        ///   Cierra el formulario contenedor
        /// </summary>
        /// <param name="sender">El objeto que genera el evento
        /// </param>
        /// <param name="e">
        /// Los datos asociados al evento.
        /// </param>
        private void btnCancelar_Click(object sender, EventArgs e) {
            if (ParentForm == null) return;
            ParentForm.DialogResult = DialogResult.Cancel;
            ParentForm.Close();
        }

        /// <summary>
        /// Este evento responde al boton que permite seleccionar la 
        /// carpeta destino de los documentos.
        /// </summary>
        /// <param name="sender">
        /// El objeto que genera el evento.
        /// </param>
        /// <param name="e">
        /// Los datos asociados al evento.
        /// </param>
        private void btnOFD_Click(object sender, EventArgs e) {
            var fbdDestino = new FolderBrowserDialog {
                                                         Description = "Seleccione la carpeta donde guardar los Documentos generados",
                                                         RootFolder = Environment.SpecialFolder.Personal
                                                     };

            try {
                if (fbdDestino.ShowDialog() == DialogResult.OK)
                    txtDestino.Text = fbdDestino.SelectedPath;
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                inicializaDestino();
            }
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public void saveResultado(Gestion gestion, Parametro tipo, string descripcion, DateTime fecha, Persona titular, Contacto contacto) {
            if (gestion != null) {
                // Primero graba y actualiza algunas cosas
                try {
                    long scn = Persistencia.Controlador.iniciarTransaccion();
                    gestion.FechaInicio = fecha;
                    gestion.Resultado = tipo;
                    gestion.ResultadoDesc = descripcion;
                    gestion.Contactado = titular;
                    gestion.Contacto = contacto;
                    gestion.Usuario = Sistema.Controlador.SecurityService.getUsuario();
                    gestion.Estado = _finalizada;
                    gestion.Cuenta.agregarGestion(gestion);
                    gestion.FechaCierre = DateTime.Now;
                    gestion.save();
                    Persistencia.Controlador.commitTransaccion(scn);
                } catch (Exception e) {
                    Persistencia.Controlador.rollbackTransaccion();
                    throw new DataErrorException("DATA-SAVENOK", e.ToString());
                }

                // Finalmente ejecuta el resultado y finaliza la gestion
                try {
                    ResultadoGestion.EjecutarResultado(gestion, gestion.Resultado);
                    gestion.save();
                } catch (Exception e) {
                    throw new DataErrorException("ERROR-EJECUTAR-RESULTADO", e.ToString());
                }
            }
        }
    }
}