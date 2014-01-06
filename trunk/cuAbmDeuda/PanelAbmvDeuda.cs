///////////////////////////////////////////////////////////
//  PanelAbmvDeuda.cs
//  Implementación del panel ABMV para la entidad Deuda
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.helpers;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.enums;
using scioSecureLibrary.enums;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;
using sgmpro.dominio.gestion;

namespace cuAbmDeuda {
    public partial class PanelAbmvDeuda : PanelABMV<Deuda> {
        protected Cuenta _cuenta;
        protected Convenio _convenio;
        protected WinSelect<Cuenta> _ws;
        private readonly CUListImputaciones _listImputaciones;
        private IVistaPanelList _panelPagos; 

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvDeuda(IControladorEditable<Deuda> controlador) : base(controlador) {
            try {
                InitializeComponent();
                _listImputaciones = new CUListImputaciones();
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panelabmv
        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        protected override void preSetObjeto() {
            _cuenta = null;
            _convenio = null;
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        protected override void postSetObjeto() {
            try {
                _listImputaciones.ObjetoMaster = _objeto;
                _listImputaciones.Filtros.Clear();

                label1.Visible = (_controlador.ModoVista == EModoVentana.VIEW);
                txtCuota.Visible = (_controlador.ModoVista == EModoVentana.VIEW);

                if (_objeto.Cuenta != null) {
                    _cuenta = _objeto.Cuenta;
                    _convenio = _cuenta.ConvenioActivo;
                    cargarControles();
                    cargarDatos();
                    cargarTabs();
                } else if (_objeto.Convenio != null) {
                    _cuenta = _objeto.Convenio.Cuenta;
                    _convenio = _objeto.Convenio;
                    cargarControles();
                    cargarDatos();
                    cargarTabs();
                }

                findCuenta.Enabled = (_cuenta == null);

                btnCancelarDeuda.Visible = (_objeto != null) 
                                            && (_objeto.Estado != null) 
                                            && (!_objeto.estaCancelada()) 
                                            && _objeto.isAlive();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarControles() {
            cargarComboConcepto();
            cargarComboDetalle();
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Texto
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                // Números
                ctrlTxtCapital.Text = _objeto.Capital.ToString();
                ctrlTxtInteres.Text = _objeto.Interes.ToString();
                ctrlTxtGastos.Text = _objeto.Gastos.ToString();
                ctrlTxtHonorarios.Text = _objeto.Honorarios.ToString();
                txtTotal.Text = _objeto.Total.ToString();
                txtCapitalO.Text = _objeto.CapitalO.ToString();
                txtInteresO.Text = _objeto.InteresO.ToString();
                txtGastosO.Text = _objeto.GastosO.ToString();
                txtHonorO.Text = _objeto.HonorO.ToString();
                txtTotalO.Text = (_objeto.CapitalO + _objeto.InteresO 
                                    + _objeto.GastosO + _objeto.HonorO).ToString();
                // Booleano
                ctrlChkInformada.Checked = _objeto.Informada;
                // Fechas
                if (_objeto.FechaVencimiento <= Fechas.FechaNull)
                    _objeto.FechaVencimiento = DateTime.Now;
                ctrlFecha.Value = _objeto.FechaVencimiento;
                txtFecha.Text = ctrlFecha.Value.ToString();
                if (_objeto.FechaAlta <= Fechas.FechaNull)
                    _objeto.FechaAlta = DateTime.Now;
                txtFechaAlta.Text = _objeto.FechaAlta.ToString();
                txtFechaBaja.Text = (_objeto.FechaBaja <= Fechas.FechaNull) 
                                        ? "" 
                                        : _objeto.FechaBaja.ToString();
                // Clases
                if (_objeto.Cuenta != null) {
                    txtCuenta.Tag = _objeto.Cuenta;
                    txtCuenta.Text = txtCuenta.Tag.ToString();
                }
                if (_objeto.Convenio != null) {
                    txtConvenio.Tag = _objeto.Convenio;
                    txtConvenio.Text = txtConvenio.Tag.ToString();
                    txtCuota.Text = _objeto.Cuota.ToString();
                }
                if (_objeto.Estado != null) {
                    txtEstado.Tag = _objeto.Estado;
                    txtEstado.Text = txtEstado.Tag.ToString();
                } else {
                    txtEstado.Tag = Parametros.GetByClave("ESTADODEUDA.PENDIENTE");
                    txtEstado.Text = txtEstado.Tag.ToString();
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
                    _panelPagos = _listImputaciones.getPanelListado(EModoVentana.VIEW);
                    _panelPagos.Contenedor = this;
                    tabPagos.Controls.Clear();
                    tabPagos.Controls.Add((Control) _panelPagos);
                    tabPagos.Controls["PanelListABMV"].Dock = DockStyle.Fill;
                } else
                    _panelPagos.refrescarListado(_listImputaciones.ColsInvisibles);

                tabPagos.Text = string.Format("Imputaciones Realizadas ({0})", _listImputaciones.Cuenta);
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
                return !(ctrlTxtDescripcion.Text == (_objeto.Descripcion ?? "")
                         && ctrlFecha.Value == _objeto.FechaVencimiento
                         && ctrlTxtCapital.Text == Convert.ToString(_objeto.Capital)
                         && ctrlTxtInteres.Text == Convert.ToString(_objeto.Interes)
                         && ctrlTxtHonorarios.Text == Convert.ToString(_objeto.Honorarios)
                         && ctrlTxtGastos.Text == Convert.ToString(_objeto.Gastos)
                         && ctrlChkInformada.Checked == _objeto.Informada
                         && ctrlTxtComboConcepto.SelectedItem ==
                            (_objeto.Concepto ?? ctrlTxtComboConcepto.SelectedItem)
                         && ctrlTxtComboDetalle.SelectedItem ==
                            (_objeto.Detalle ?? ctrlTxtComboDetalle.SelectedItem));
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
                _objeto.Capital = Convert.ToDouble((ctrlTxtCapital.Text ?? "").Equals("")
                                                       ? "0"
                                                       : ctrlTxtCapital.Text);
                _objeto.Interes = Convert.ToDouble((ctrlTxtInteres.Text ?? "").Equals("")
                                                       ? "0"
                                                       : ctrlTxtInteres.Text);
                _objeto.Honorarios =
                    Convert.ToDouble((ctrlTxtHonorarios.Text ?? "").Equals("")
                                         ? "0"
                                         : ctrlTxtHonorarios.Text);
                _objeto.Gastos = Convert.ToDouble((ctrlTxtGastos.Text ?? "").Equals("")
                                                      ? "0"
                                                      : ctrlTxtGastos.Text);
                _objeto.Informada = ctrlChkInformada.Checked;
                _objeto.Concepto = (Parametro) ctrlTxtComboConcepto.SelectedItem;
                _objeto.Detalle = (Parametro) ctrlTxtComboDetalle.SelectedItem;
                _objeto.Estado = (Parametro) txtEstado.Tag;
                _objeto.FechaVencimiento = (ctrlFecha.Value <= Fechas.FechaNull)
                                               ? Fechas.FechaNull
                                               : ctrlFecha.Value;
                _objeto.Cuenta = (Cuenta) txtCuenta.Tag;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion panelabmv

        #region controles
        /// <summary>
        /// Este método carga el combo de Concepto de Deuda.
        /// Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboConcepto() {
            ctrlTxtComboConcepto.Items.Clear();
            try {
                if (Sistema.Controlador.SecurityService.usuarioActualPoseePermiso("ENTIDAD.DEUDA", ETipoPermiso.TOTAL)
                    && _controlador.ModoVista != EModoVentana.VIEW)
                    ctrlTxtComboConcepto.Items.Add(Parametros.GetByClave("CONCEPTODEUDA.LEGALES"));
                else
                    foreach (Parametro p in (Parametros.GetByTipoClaveLike(ETipoParametro.GESTION, "CONCEPTODEUDA")))
                        // hasta los conceptos de orden <= 10 se pueden seleccionar a mano
                        if (p.Orden < 11 || _controlador.ModoVista == EModoVentana.VIEW) {
                            ctrlTxtComboConcepto.Items.Add(p);

                            if (_objeto.Concepto != null && _objeto.Concepto.Equals(p))
                                ctrlTxtComboConcepto.SelectedItem = p;
                        }

                if (ctrlTxtComboConcepto.SelectedItem == null && ctrlTxtComboConcepto.Items.Count >= 1)
                    ctrlTxtComboConcepto.SelectedItem = ctrlTxtComboConcepto.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        /// Este método carga el combo de Detalle de Deuda.
        /// Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboDetalle() {
            ctrlTxtComboDetalle.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLike(ETipoParametro.GESTION, "DETALLEDEUDA"))) {
                    ctrlTxtComboDetalle.Items.Add(p);

                    if (_objeto.Detalle != null && _objeto.Detalle.Equals(p))
                        ctrlTxtComboDetalle.SelectedItem = p;
                }

                if (ctrlTxtComboDetalle.SelectedItem == null && ctrlTxtComboDetalle.Items.Count >= 1)
                    ctrlTxtComboDetalle.SelectedItem = ctrlTxtComboDetalle.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }
        #endregion controles

        #region metodos helpers
        /// <summary>
        /// Este método recalcula el valor de total.
        /// </summary>
        private void recalcularTotal() {
            try {
                Double cap = Convert.ToDouble(
                    ((ctrlTxtCapital.Text ?? "").Equals("")
                     || (ctrlTxtCapital.Text ?? "").Equals("-"))
                        ? "0"
                        : ctrlTxtCapital.Text);
                Double inte = Convert.ToDouble(
                    ((ctrlTxtInteres.Text ?? "0").Equals("")
                     || (ctrlTxtInteres.Text ?? "").Equals("-"))
                        ? "0"
                        : ctrlTxtInteres.Text);
                Double hon = Convert.ToDouble(
                    ((ctrlTxtHonorarios.Text ?? "0").Equals("")
                     || (ctrlTxtHonorarios.Text ?? "").Equals("-"))
                        ? "0"
                        : ctrlTxtHonorarios.Text);
                Double gas = Convert.ToDouble(
                    ((ctrlTxtGastos.Text ?? "0").Equals("")
                     || (ctrlTxtGastos.Text ?? "").Equals("-"))
                        ? "0"
                        : ctrlTxtGastos.Text);

                Double tot = cap + inte + hon + gas;
                txtTotal.Text = tot.ToString();
            } catch (Exception e) {
                Sistema.Controlador.mostrar("ERROR-FORMAT-ELEMENTO", ENivelMensaje.ERROR, e.ToString(), false);
            }
        }
        #endregion metodos helpers

        #region interface
        /// <summary>
        /// Este método responde al del datetimepicker de Fecha Cierre. 
        /// Debería 'mostrar' cualquier error que ocurriese y no propagar 
        /// ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFecha_TextChanged(object sender, EventArgs e) {
            txtFecha.Text = (ctrlFecha.Value <= Fechas.FechaNull)
                                ? ""
                                : ctrlFecha.Value.ToString();
        }

        /// <summary>
        /// Este método responde al botón Buscar Cuenta. Debería 'mostrar' 
        /// cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFindCuenta_Click(object sender, EventArgs e) {
            try {
                if (_ws == null)
                    _ws = new WinSelect<Cuenta>("cuAbmCuenta.CUListCuentas");

                _ws.ShowDialog();

                if (_ws.Seleccion != null) {
                    _objeto.Cuenta = _ws.Seleccion;
                    setearObjeto(_objeto);
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al botón Ver Cuenta. 
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
        /// Este método responde al botón Ver Convenio. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerConvenio_Click(object sender, EventArgs e) {
            try {
                if (txtConvenio.Tag != null)
                    CUCaller.CallCU("cuAbmConvenio", this, new[] {EModoVentana.VIEW, txtConvenio.Tag});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        /// Este método responde al cambio de concepto de deuda. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtComboConcepto_SelectedIndexChanged(object sender, EventArgs e) {
            Parametro concepto = (Parametro) ctrlTxtComboConcepto.SelectedItem;

            if (!_enProceso && concepto != null) {
                ctrlTxtCapital.Enabled = true;
                ctrlTxtInteres.Enabled = true;
                ctrlTxtGastos.Enabled = true;
                ctrlTxtHonorarios.Enabled = true;

                if (concepto.Equals(Parametros.GetByClave("CONCEPTODEUDA.HONORARIO"))) {
                    ctrlTxtCapital.Text = null;
                    ctrlTxtCapital.Enabled = false;
                    ctrlTxtInteres.Text = null;
                    ctrlTxtInteres.Enabled = false;
                    ctrlTxtGastos.Text = null;
                    ctrlTxtGastos.Enabled = false;
                }

                if (concepto.Equals(Parametros.GetByClave("CONCEPTODEUDA.GASTO"))) {
                    ctrlTxtCapital.Text = null;
                    ctrlTxtCapital.Enabled = false;
                    ctrlTxtInteres.Text = null;
                    ctrlTxtInteres.Enabled = false;
                    ctrlTxtHonorarios.Text = null;
                    ctrlTxtHonorarios.Enabled = false;
                }

                recalcularTotal();
            }
        }

        /// <summary>
        /// Este método responde al cambio de valor en algun campo de importe de deuda. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtCapital_TextChanged(object sender, EventArgs e) {
            recalcularTotal();
        }

        /// <summary>
        /// Este método responde al boton de cancelacion de la deuda. 
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnCancelarDeuda_Click(object sender, EventArgs e) {
            try {
                if (Sistema.Controlador.mostrar("PREGUNTA-CANCEL-MANUAL-DEUDA", ENivelMensaje.PREGUNTA, null, false) == DialogResult.Yes) {
                    _objeto.cancelarSinPago(DateTime.Now, "Ejecutado manualmente desde la aplicación");
                    var gestion = new Gestion {
                                                  Cuenta = _cuenta,
                                                  Tipo = Parametros.GetByClave("TIPOGESTION.BACKOFFICE"),
                                                  Contactado = _cuenta.Titular,
                                                  Contacto = _cuenta.Titular.getContactoPrincipal(),
                                                  Estado = Parametros.GetByClave("ESTADOGESTION.FINALIZADA"),
                                                  FechaInicio = DateTime.Now,
                                                  FechaCierre = DateTime.Now,
                                                  FechaUMod = DateTime.Now,
                                                  Resultado = Parametros.GetByClave("RESULTADOGESTION.OTRORESULTADO"),
                                                  ResultadoDesc = "CANCELACION MANUAL DE DEUDA: " + _objeto
                                              };
                    _cuenta.agregarGestion(gestion);
                    _objeto.save();
                    Sistema.Controlador.mostrar("CANCEL-MANUAL-DEUDA-OK", ENivelMensaje.INFORMACION, null, false);
                    Contenedor.cerrar();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("CANCEL-MANUAL-DEUDA-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }
        #endregion interface
    }
}