///////////////////////////////////////////////////////////
//  PanelAbmvConvenio.cs
//  Implementación del panel ABMV para la entidad Convenio
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using cuAbmPago;
using Microsoft.Office.Interop.Word;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.helpers;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioPersistentLibrary;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;
using Application=System.Windows.Forms.Application;

namespace cuAbmConvenio {
    public partial class PanelAbmvConvenio : PanelABMV<Convenio> {
        private Convenio _original;
        protected Cuenta _cuenta;
        private long _cuotas;
        private bool _pregenerado;
        private string _prequita, _preanticipo, _pregastosan;
        private double _deudaOrigen;
        private TipoConvenio _tipo;
        private readonly CUListCuotas _listCuotas;
        private readonly CUListPagos _listPagos;        
        private IVistaPanelList _panelCuotas, _panelPagos;

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvConvenio(IControladorEditable<Convenio> controlador) : base(controlador) {
            try {
                InitializeComponent();

                _listCuotas = new CUListCuotas {Padre = this};
                _listCuotas.ColsInvisibles.Add("Cuenta");
                _listCuotas.ColsInvisibles.Add("Convenio");

                _listPagos = new CUListPagos {Padre = this};
            } catch (Exception e) {
                throw new VistaErrorException(Mensaje.TextoMensaje("PANEL-NOK"), e.ToString());
            }
        }

        #region panelabmv
        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        protected override void postSetObjeto() {
            try {
                if (_pregenerado && _controlador.ModoVista == EModoVentana.ADD) {
                    resetObjeto();
                    _pregenerado = false;
                }

                _original = _objeto;
                _cuenta = _objeto.Cuenta;

                _listCuotas.ObjetoMaster = _objeto;
                _listCuotas.Filtros.Clear();

                _listPagos.ObjetoMaster = _objeto;
                _listPagos.Filtros.Clear();

                cargarControles();
                cargarDatos();
                cargarTabs();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarControles() {
            cargarComboTipo();
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                btnGenerar.Enabled = false;
                btnActivar.Enabled = false;
                btnDocumento.Enabled = false;

                // Siempre carga la cuenta (este o no pre/generado)
                txtCuenta.Tag = _cuenta;
                txtCuenta.Text = txtCuenta.Tag.ToString();

                // Actúa de una forma u otra dependiendo de si el convenio
                // ya fue generado (tiene fecha de alta) o aún no lo fue
                if (_objeto.FechaAlta != Fechas.FechaNull) {
                    // Primero los valores de la cabecera del convenio
                    double origen = (_objeto.CapitalOrigen + _objeto.InteresOrigen + _objeto.HonorariosOrigen + _objeto.GastosOrigen);
                    ctrlTxtDescripcion.Text = _objeto.Descripcion;
                    txtOrigen.Text = origen.ToString();
                    txtDeudaConQuita.Text = _objeto.DeudaBase.ToString();
                    ctrlTxtAnticipo.Text = _objeto.Anticipo.ToString();
                    ctrlTxtGastoA.Text = _objeto.GastosAnticipo.ToString();
                    ctrlTxtQuita.Text = _objeto.Quita.ToString();
                    txtRefinanciar.Visible = false;
                    label13.Visible = false;
                        //.Text = (origen - _objeto.Quita - _objeto.Anticipo).ToString();
                    // Etiquetas
                    lblMaxQuita.Visible = false;
                    lblMinAnticipo.Visible = false;
                    // Fechas
                    txtFechaAlta.Text = _objeto.FechaAlta.ToString();
                    ctrlFechaInicio.Value = _objeto.FechaInicio;
                    ctrlTxtFechaInicio.Text = ctrlFechaInicio.Value.ToString();
                    txtFechaBaja.Text = (_objeto.FechaBaja <= Fechas.FechaNull) ? "" : _objeto.FechaBaja.ToString();
                    //Boolean
                    ctrlChkRedondear.Checked = _objeto.Redondeado;                                        
                    // Luego el grupo de resumen del estado del convenio
                    chkActivo.Checked = _objeto.Activo;
                    txtCuotasPagas.Text = _objeto.getCuotasCanceladas().Count.ToString();
                    txtSaldo.Text = _objeto.getMontoSaldoTotalActual().ToString();
                    txtMontoFinal.Text = _objeto.MontoFinal.ToString();
                    double montoPagado = _objeto.MontoFinal - _objeto.getMontoSaldoTotalActual();
                    txtMontoPago.Text = (montoPagado < 0) ? "0" : montoPagado.ToString();
                    // Habilita o deshabilita botones de acuerdo al estado
                    btnDocumento.Enabled = true;
                    if (_controlador.ModoVista > EModoVentana.VIEW)
                        btnActivar.Enabled = !_objeto.Activo;
                    txtOrigen.ReadOnly = true;
                    ctrlTxtAnticipo.ReadOnly = true;
                    ctrlTxtGastoA.ReadOnly = true;
                    ctrlTxtQuita.ReadOnly = true;
                    cmbCuotas.ReadOnly = true;
                    cmbTipo.ReadOnly = true;
                    ctrlFechaInicio.Enabled = false;
                    ctrlTxtFechaInicio.Enabled = false;
                    ctrlChkRedondear.Enabled = false;
                } else {
                    // Primero obtienen la deuda aplicable
                    recalcularTotal();

                    // Luego establece los valores de cabecera del convenio
                    ctrlTxtAnticipo.Text = _objeto.Anticipo.ToString();
                    ctrlTxtGastoA.Text = _objeto.GastosAnticipo.ToString();
                    ctrlTxtQuita.Text = _objeto.Quita.ToString();
                    if (_objeto.FechaInicio <= Fechas.FechaNull)
                        _objeto.FechaInicio = DateTime.Now;
                    ctrlFechaInicio.Value = _objeto.FechaInicio;
                    ctrlTxtFechaInicio.Text = ctrlFechaInicio.Value.ToString();
                    ctrlChkRedondear.Checked = _objeto.Redondeado;

                    // Luego el grupo de resumen del estado del convenio
                    txtFechaAlta.Text = "";
                    txtMontoPago.Text = "";
                    txtCuotasPagas.Text = "";
                    txtSaldo.Text = "";
                    txtMontoFinal.Text = ((_objeto.MontoFinal + _objeto.Anticipo) > 0) ? (_objeto.MontoFinal + _objeto.Anticipo).ToString() : "";

                    // Actualiza las etiquetas
                    lblMinAnticipo.Visible = true;
                    lblMaxQuita.Visible = true;

                    // Habilita o deshabilita botones de acuerdo al estado
                    if (_controlador.ModoVista > EModoVentana.VIEW) {
                        btnGenerar.Enabled = true;
                        btnActivar.Enabled = false;
                        txtOrigen.ReadOnly = true;
                        ctrlTxtAnticipo.ReadOnly = false;
                        ctrlTxtGastoA.ReadOnly = false;
                        ctrlTxtQuita.ReadOnly = false;
                        cmbCuotas.ReadOnly = false;
                        cmbTipo.ReadOnly = false;
                        ctrlFechaInicio.Enabled = true;
                        ctrlTxtFechaInicio.Enabled = true;
                        ctrlChkRedondear.Enabled = true;
                    }
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarTabs() {
            try {
                if (_enProceso) {
                    _panelCuotas = _listCuotas.getPanelListado(EModoVentana.VIEW);
                    _panelCuotas.Contenedor = this;
                    tabCuotas.Controls.Clear();
                    tabCuotas.Controls.Add((Control)_panelCuotas);
                    tabCuotas.Controls["PanelListABMV"].Dock = DockStyle.Fill;

                    _panelPagos = _listPagos.getPanelListado(EModoVentana.VIEW);
                    _panelPagos.Contenedor = this;
                    tabPagos.Controls.Clear();
                    tabPagos.Controls.Add((Control)_panelPagos);
                    tabPagos.Controls["PanelListABMV"].Dock = DockStyle.Fill;
                } else {
                    _panelCuotas.refrescarListado(_listCuotas.ColsInvisibles);
                    _panelPagos.refrescarListado(_listPagos.ColsInvisibles);
                }

                tabCuotas.Text = string.Format("Cuotas ({0})", _listCuotas.Cuenta);
                tabCuotas.Refresh();
                tabPagos.Text = string.Format("Pagos ({0})", _listPagos.Cuenta);
                tabPagos.Refresh();
            } catch (Exception e) {
                throw new DataErrorException("SUBLISTADO-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return _pregenerado
                       || !(ctrlTxtDescripcion.Text == (_objeto.Descripcion ?? "")
                            && txtOrigen.Text == _objeto.DeudaBase.ToString()
                            && ctrlTxtAnticipo.Text == _objeto.Anticipo.ToString()
                            && ctrlTxtGastoA.Text == _objeto.GastosAnticipo.ToString()
                            && ctrlTxtQuita.Text == _objeto.Quita.ToString()
                            && ctrlFechaInicio.Value == _objeto.FechaInicio
                            && chkActivo.Checked == _objeto.Activo
                            && ctrlChkRedondear.Checked == _objeto.Redondeado
                            && cmbCuotas.SelectedItem.Equals(_objeto.CtdadCuotas)
                            && cmbTipo.SelectedItem.Equals(_objeto.Tipo));
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Descripcion = ctrlTxtDescripcion.Text;
                _objeto.DeudaBase = string.IsNullOrEmpty(txtDeudaConQuita.Text) ? 0 : Convert.ToDouble(txtDeudaConQuita.Text);
                _objeto.Anticipo = string.IsNullOrEmpty(ctrlTxtAnticipo.Text) ? 0 : Convert.ToDouble(ctrlTxtAnticipo.Text);
                _objeto.GastosAnticipo = string.IsNullOrEmpty(ctrlTxtGastoA.Text) ? 0 : Convert.ToDouble(ctrlTxtGastoA.Text);
                _objeto.Quita = string.IsNullOrEmpty(ctrlTxtQuita.Text) ? 0 : Convert.ToDouble(ctrlTxtQuita.Text); 
                _objeto.CtdadCuotas = (long)cmbCuotas.SelectedItem;
                _objeto.Tipo = (TipoConvenio)cmbTipo.SelectedItem;
                _objeto.Cuenta = (Cuenta)txtCuenta.Tag;
                _objeto.Activo = chkActivo.Checked;
                _objeto.Redondeado = ctrlChkRedondear.Checked;
                _objeto.MontoFinal = Math.Round(string.IsNullOrEmpty(txtMontoFinal.Text) ? 0 : Convert.ToDouble(txtMontoFinal.Text),2);
                _objeto.FechaInicio = (ctrlFechaInicio.Value <= Fechas.FechaNull)
                                          ? Fechas.FechaNull
                                          : ctrlFechaInicio.Value;
                // Se asegura de guardar el objeto recien generado
                _controlador.ObjetoEnEdicion = _objeto;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion panelabmv

        #region controles
        /// <summary>
        /// Este método carga el combo de tipos de contacto.
        /// Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboTipo() {
            cmbTipo.Items.Clear();
            try {
                foreach (TipoConvenio p in _cuenta.Entidad.TiposConvenio) {
                    cmbTipo.Items.Add(p);

                    if (_objeto.Tipo != null && _objeto.Tipo.Equals(p))
                        cmbTipo.SelectedItem = p;
                }

                if (cmbTipo.SelectedItem == null && cmbTipo.Items.Count >= 1) {
                    cmbTipo.SelectedItem = cmbTipo.Items[0];
                }
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        /// Este método recarga el combo de cuotas para reflejar lo que
        /// esta permitido según el tipo de convenio seleccionado. Se 
        /// lanza VistaErrorException si hay un problema.
        /// </summary>
        private void recargarCuotas() {
            if (cmbTipo.SelectedItem != null) {
                cmbCuotas.Items.Clear();
                try {
                    for (long i = ((TipoConvenio)cmbTipo.SelectedItem).MinCuotas;
                         i <= ((TipoConvenio)cmbTipo.SelectedItem).MaxCuotas;
                         i++) {
                        cmbCuotas.Items.Add(i);
                        if (_objeto.CtdadCuotas == i)
                            cmbCuotas.SelectedItem = i;
                    }

                    if (cmbCuotas.SelectedItem == null && cmbCuotas.Items.Count >= 1) {
                        cmbCuotas.SelectedItem = cmbCuotas.Items[0];
                        _cuotas = (long)cmbCuotas.SelectedItem;
                    }
                } catch (Exception e) {
                    Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                    Contenedor.cerrar();
                }
            }
        }    
        #endregion controles

        #region helpers
        /// <summary>
        /// Este método permite resetear la ventana (reseteando el objeto
        /// Convenio, pero manteniendo sus datos principales) de manera de
        /// poder deshacer una generación de convenio para probar de nuevo.
        /// </summary> 
        public void resetObjeto() {
            try {
                _deudaOrigen = 0;
                _objeto = new Convenio {
                    Cuenta = _original.Cuenta,
                    Descripcion = _original.Descripcion,
                    Quita = (_prequita != null) ? Convert.ToDouble(_prequita) : 0,
                    Anticipo = (_preanticipo != null) ? Convert.ToDouble(_preanticipo) : 0,
                    GastosAnticipo = (_pregastosan != null) ? Convert.ToDouble(_pregastosan) : 0,
                    CtdadCuotas = _cuotas,
                    FechaInicio = _original.FechaInicio,
                    Tipo = _tipo ?? _original.Tipo,
                    Redondeado = _original.Redondeado
                };
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        /// Este método recalcula el valor del los totales y otros que se 
        /// toman en la cabecera del convenio, y de acuerdo a lo ingresado
        /// y la deuda existente. Solo se calcula si el convenio todavía no
        /// fue generado.
        /// </summary>
        private void recalcularTotal() {
            // Si solo se esta mirando entonces no se hace nada
            if (_controlador.ModoVista == EModoVentana.VIEW)
                return;

            // Si no tiene un tipo de convenio entonces no hace nada
            if (cmbTipo.SelectedItem == null)
                return;            

            // Si esta generado o no tiene tipo no hace nada
            if (_objeto.FechaAlta != Fechas.FechaNull) {
                Sistema.Controlador.mostrar("ERROR-CONVENIO-YAGEN", ENivelMensaje.ERROR, null, false);
                return;                
            }

            // Si es la primera vez obtiene la deuda informada original
            if (_deudaOrigen <= 0)
                foreach (Deuda dd in _cuenta.getDeudaInformada()) {
                    _objeto.CapitalOrigen += dd.Capital;
                    _objeto.InteresOrigen += dd.Interes;
                    _objeto.HonorariosOrigen += dd.Honorarios;
                    _objeto.GastosOrigen += dd.Gastos;
                    _deudaOrigen += dd.Total;
                }            
            
            // Coloca la deuda origen inicial            
            txtOrigen.Text = _deudaOrigen.ToString();

            // Calcula las etiquetas si se estan mostrando
            if (lblMaxQuita.Visible) {
                double q = ((TipoConvenio) cmbTipo.SelectedItem).MaxQuita;
                double mq = (q > 1) ? q : (q *_objeto.InteresOrigen);
                lblMaxQuita.Text = string.Format("(Máximo de Quita aplicable $ {0})", Math.Round(mq, 2));
            }

            try {
                // Obtiene anticipo, gastos de anticipo, quita y tasa
                string ant = ctrlTxtAnticipo.Text;
                double anticipo = (string.IsNullOrEmpty(ant) || ant.Equals("-")) ? 0 : Convert.ToDouble(ant);

                string gasa = ctrlTxtGastoA.Text;
                double gatosant = (string.IsNullOrEmpty(gasa) || gasa.Equals("-")) ? 0 : Convert.ToDouble(gasa);

                string quit = ctrlTxtQuita.Text;
                double quita = (string.IsNullOrEmpty(quit) || quit.Equals("-")) ? 0 : Convert.ToDouble(quit);

                double tasa = (((TipoConvenio)cmbTipo.SelectedItem).IVAsobreTP)
                                  ? ((((TipoConvenio)cmbTipo.SelectedItem).TasaPura/100)*1.21)
                                  : (((TipoConvenio)cmbTipo.SelectedItem).TasaPura/100);

                // Luego calcula la nueva deuda base para el convenio
                _objeto.DeudaBase = _deudaOrigen;
                if (quita > 0) {
                    string formula = "select (" +
                                     ((TipoConvenio)cmbTipo.SelectedItem).FormulaBaseConvenio
                                         .Replace("$DDO", _deudaOrigen.ToString())
                                         .Replace("$CAP", _objeto.CapitalOrigen.ToString())
                                         .Replace("$INT", _objeto.InteresOrigen.ToString())
                                         .Replace("$HON", _objeto.HonorariosOrigen.ToString())
                                         .Replace("$GAS", _objeto.GastosOrigen.ToString())
                                         .Replace("$MRF", "0")
                                         .Replace("$CTD", _objeto.CtdadCuotas.ToString())
                                         .Replace("$TAS", tasa.ToString())
                                         .Replace("$GSA", gatosant.ToString())
                                         .Replace("$ANT", anticipo.ToString())
                                         .Replace("$QUI", quita.ToString())
                                         .Replace("$SDO", "0")
                                         .Replace("$SDC", "0")
                                         .Replace("$CCT", "0")
                                         .Replace("$CTA", "0")
                                         .Replace("$MTF", "0")
                                         .Replace(',', '.')
                                         .Replace(';', ',') + ") as valor";
                    try {
                        object[] valor = Persistencia.EjecutarSqlOneRow(
                            formula, Persistencia.Controlador.CadenaConexion);
                        if (valor != null)
                            _objeto.DeudaBase = Math.Round(Convert.ToDouble(valor[0]), 2);
                    } catch (Exception e) {
                        Sistema.Controlador.logear(
                            "ERROR-CALCULO-BASE-CONVENIO",
                            ENivelMensaje.ERROR,
                            e.ToString());
                    }
                }                     

                txtDeudaConQuita.Text = _objeto.DeudaBase.ToString();
                txtRefinanciar.Text = (Math.Round((_objeto.DeudaBase - anticipo), 2)).ToString();

                // Calcula las etiquetas si se estan mostrando
                if (lblMinAnticipo.Visible) {
                    double m = ((TipoConvenio) cmbTipo.SelectedItem).ValorMinimoAnticipo;
                    double ma = (m > 1) ? m : (m *_objeto.DeudaBase);
                    lblMinAnticipo.Text = string.Format("(Mínimo de Anticipo aplicable $ {0})", Math.Round(ma, 2));
                }
            } catch (Exception e) {
                Sistema.Controlador.mostrar("ERROR-FORMAT-ELEMENTO", ENivelMensaje.ERROR, e.ToString(), false);
            }
        }
        #endregion helpers

        #region interface
        /// <summary>
        /// Este método responde al botón Ver Cuenta. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerCuenta_Click(object sender, EventArgs e) {
            try {
                if (txtCuenta.Tag != null)
                    CUCaller.CallCU("cuAbmCuenta", this, new[] {EModoVentana.VIEW, txtCuenta.Tag});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Activar Convenio. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnActivar_Click(object sender, EventArgs e) {
            try {
                chkActivo.Checked = true;
                btnActivar.Enabled = false;
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Generar Convenio. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción. Al
        /// finalizar, refresca la pantalla y el tab de cuotas.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnGenerar_Click(object sender, EventArgs e) {
            try {
                actualizarObjeto();
                validarDatos();
                _objeto.generarConvenio();
                _pregenerado = true;

                _prequita = !string.IsNullOrEmpty(ctrlTxtQuita.Text) ? ctrlTxtQuita.Text : null;
                _preanticipo = !string.IsNullOrEmpty(ctrlTxtAnticipo.Text) ? ctrlTxtAnticipo.Text : null;
                _pregastosan = !string.IsNullOrEmpty(ctrlTxtGastoA.Text) ? ctrlTxtGastoA.Text : null;
                _cuotas = ((long)cmbCuotas.SelectedItem);
                _tipo = (TipoConvenio)cmbTipo.SelectedItem;

                _listCuotas.ObjetoMaster = _objeto;
                _listCuotas.Filtros.Clear();

                _listPagos.ObjetoMaster = _objeto;
                _listPagos.Filtros.Clear();

                cargarControles();
                cargarDatos();
                cargarTabs();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Imprimir Documento. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción. Al
        /// finalizar, refresca la pantalla y el tab de cuotas.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnDocumento_Click(object sender, EventArgs e) {
            try {
                object oMissing = Missing.Value;
                String nombreTemplate = String.Format("{0}\\Templates\\TempConvenio.dot", Application.StartupPath);

                // Abre el Word
                _Application oWordApp = new Microsoft.Office.Interop.Word.Application();
                object oTemplate = nombreTemplate;
                _Document oWordDoc = oWordApp.Documents.Add(
                    ref oTemplate,
                    ref oMissing,
                    ref oMissing,
                    ref oMissing);

                oWordApp.Visible = true;

                if (oWordDoc.Bookmarks.Exists("NombreDeudor")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "NombreDeudor";
                    string texto = String.Format("{0} ", getNombrePersona());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("NombreLibrador")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "NombreLibrador";
                    string texto = String.Format("{0} ", getNombrePersona());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("DireccionDeudor")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "DireccionDeudor";
                    string texto = String.Format("{0} ", getDireccionDeudor());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("CpDeudor")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "CpDeudor";
                    string texto = String.Format("{0} ", getCpDeudor());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }
                if (oWordDoc.Bookmarks.Exists("LocalidadProvincia")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "LocalidadProvincia";
                    string texto = String.Format("{0} ", getLocalidadDeudor());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("NombreCliente")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "NombreCliente";
                    string texto = String.Format("{0} ", getNombreCliente());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("CodigoCuenta")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "CodigoCuenta";
                    string texto = String.Format("{0} ", getCodigoCuenta());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("SumaDe")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "SumaDe";
                    string texto = String.Format("{0} ", getSumaDeuda());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("MontoAnticipo")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "MontoAnticipo";
                    string texto = String.Format("{0} ", getMontoAnticipo());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("MontoPago")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "MontoPago";
                    string texto = String.Format("{0} ", getMontoAnticipo());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("CantCuotas")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "CantCuotas";
                    string texto = String.Format("{0} ", getCantidadCuotas());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("MontoCuotas")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "MontoCuotas";
                    string texto = String.Format("{0} ", getMontoCuotas());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("DiaVencCuotas")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "DiaVencCuotas";
                    string texto = String.Format("{0} ", getDiaVencCuotas());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("FechaVencCuotas")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "FechaVencCuotas";
                    string texto = String.Format("{0} ", getFechaVencimiento());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("DniDeudor")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "DniDeudor";
                    string texto = String.Format("{0} ", getDniDeudor());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("DiaDeHoy")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "DiaDeHoy";
                    string texto = String.Format("{0} ", getDiaDeHoy());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }

                if (oWordDoc.Bookmarks.Exists("DiaHoy")) {
                    // Setea el valor del Bookmark          
                    object oBookMark = "DiaHoy";
                    string texto = String.Format("{0} ", getDiaHoy());
                    oWordDoc.Bookmarks.get_Item(ref oBookMark).Range.Text = texto;
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al del datetimepicker de Fecha Inicio. 
        /// Debería 'mostrar' cualquier error que ocurriese y no propagar 
        /// ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFechaInicio_ValueChanged(object sender, EventArgs e) {
            string fecha = (ctrlFechaInicio.Value <= Fechas.FechaNull)
                               ? DateTime.Now.ToString()
                               : ctrlFechaInicio.Value.ToString();

            if (!ctrlTxtFechaInicio.Text.Equals(fecha))
                ctrlTxtFechaInicio.Text = fecha;
        }

        /// <summary>
        /// Este método responde al cambio de fecha del convenio desde el 
        /// propio campo. Debería 'mostrar' cualquier error que ocurriese y 
        /// no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtFechaInicio_Validated(object sender, EventArgs e) {
            DateTime fecha = Convert.ToDateTime(ctrlTxtFechaInicio.Text);
            if (ctrlFechaInicio.Value != fecha) {
                _objeto.FechaInicio = fecha;
                ctrlFechaInicio.Value = fecha;
            }
        }

        /// <summary>
        /// Este método responde los cambios de valores o de la cantidad de cuotas. 
        /// Debería 'mostrar' cualquier error que ocurriese y no propagar 
        /// ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtDeudaOrigen_TextChanged(object sender, EventArgs e) {
            recalcularTotal();
        }

        /// <summary>
        /// Este método responde los cambios del tipo de convenio seleccionado. 
        /// Debería 'mostrar' cualquier error que ocurriese y no propagar 
        /// ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbTipo.SelectedItem != null) {
                _tipo = (TipoConvenio)cmbTipo.SelectedItem;
                label16.Text = (_tipo.ReglaHA == 0 ? "Honor. Ant.$" : "Gastos Ant.$");
                recargarCuotas();
                recalcularTotal();
            }
        }
        #endregion interface

        #region datos para documento
        /// <summary>
        /// Retorna el nombre del deudor.
        /// </summary>
        /// <returns>Nombre del intimado</returns>
        public String getNombrePersona() {
            try {
                return _cuenta.Titular.Nombre;
            } catch {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-SINOMBRE"));
            }
        }

        /// <summary>
        /// Retorna la dirección (Calle y altura) del deudor
        /// </summary>
        public String getDireccionDeudor() {
            Contacto unContacto = _cuenta.Titular.getContactoPrincipal();
            StringBuilder sb = new StringBuilder();
            sb.Append(unContacto.Calle);
            sb.Append(" ");
            sb.Append(unContacto.Puerta);
            return sb.ToString();
        }

        /// <summary>
        /// Retorna el código postal del deudor.
        /// </summary>
        public String getCpDeudor() {
            try {
                Contacto unContacto = _cuenta.Titular.getContactoPrincipal();
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
                Contacto unContacto = _cuenta.Titular.getContactoPrincipal();
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0},{1}", unContacto.Localidad, unContacto.Provincia);
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
                return _cuenta.Entidad.Nombre;
            } catch {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Devuelve el código de la cuenta del deudor.
        /// </summary>
        public String getCodigoCuenta() {
            try {
                return _cuenta.Codigo;
            } catch {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Devuelve la suma del monto total del convenio
        /// </summary>
        /// <returns></returns>
        public String getSumaDeuda() {
            return String.Format("PESOS {0} ({1:c})", Numalet.ToString(_objeto.DeudaBase), _objeto.DeudaBase);
        }

        /// <summary>
        /// Devuelve el texto y el valor del monto de anticipo
        /// </summary>
        /// <returns></returns>
        public String getMontoAnticipo() {
            try {
                return String.Format("PESOS {0} ({1:c})", Numalet.ToString(_objeto.Anticipo), _objeto.Anticipo);
            } catch {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Devuelve la cantidad de cuotas en letra y nro.
        /// </summary>
        /// <returns></returns>
        public String getCantidadCuotas() {
            try {
                return String.Format(
                    "{0} ({1})",
                    Numalet.ToString(Convert.ToInt32(_objeto.CtdadCuotas)),
                    _objeto.CtdadCuotas);
            } catch {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Devuelve el monto de las deudas en letra y nro.
        /// </summary>
        /// <returns></returns>
        public String getMontoCuotas() {
            try {
                double valorCuota = _objeto.getCuota(1).Total;
                return String.Format("PESOS {0} ({1:c})", Numalet.ToString(valorCuota), valorCuota);
            } catch {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Devuelve dia del mes que vence cada cuota
        /// </summary>
        /// <returns></returns>
        public String getDiaVencCuotas() {
            try {
                return String.Format(" {0} ", _objeto.getCuota(1).FechaVencimiento.Day);
            } catch (Exception) {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Devuelve la fecha de vencimiento de la primera cuota
        /// </summary>
        /// <returns></returns>
        public String getFechaVencimiento() {
            try {
                return String.Format(" {0} ", _objeto.getCuota(1).FechaVencimiento.ToLongDateString());
            } catch (Exception) {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Devuelve el DNI del deudor
        /// </summary>
        /// <returns></returns>
        public String getDniDeudor() {
            try {
                return String.Format(" {0} ", _objeto.Cuenta.Titular.DNI);
            } catch (Exception) {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Devuelve la fecha actual, en formato largo
        /// /dd/ del mes de /mes/ de /aaaa/
        /// </summary>
        /// <returns></returns>
        public String getDiaDeHoy() {
            try {
                string fchLarga = DateTime.Today.ToLongDateString();
                string sinDiaSemana = fchLarga.Remove(0, fchLarga.IndexOf("de"));
                string diaDeHoy = String.Format("{0} días del mes {1}", DateTime.Today.Day, sinDiaSemana);
                return diaDeHoy;
            } catch (Exception) {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }

        /// <summary>
        /// Devuelve la fecha actual, en formato largo
        /// </summary>
        /// <returns></returns>
        public String getDiaHoy() {
            try {
                string fchLarga = DateTime.Today.ToLongDateString();
                string sinDiaSemana = fchLarga.Remove(0, fchLarga.IndexOf("de"));
                string diaDeHoy = String.Format("{0} {1}", DateTime.Today.Day, sinDiaSemana);
                return diaDeHoy;
            } catch (Exception) {
                throw new Exception(Mensaje.TextoMensaje("REPORTE-FALTADATO"));
            }
        }
        #endregion datos para documento
    }
}