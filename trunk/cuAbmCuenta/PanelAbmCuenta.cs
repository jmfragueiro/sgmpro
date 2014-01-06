///////////////////////////////////////////////////////////
//  PanelAbmCuenta.cs
//  Implementación del panel ABM para la entidad Cuenta
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using cuAbmConvenio;
using cuAbmDeuda;
using cuAbmGestion;
using cuAbmPago;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.helpers;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.enums;
using scioSecureLibrary.dominio;
using scioSecureLibrary.enums;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;

namespace cuAbmCuenta {
    public partial class PanelAbmCuenta : PanelABMV<Cuenta> {
        protected IList<Deuda> _deudaActiva;
        protected Convenio _convenioActivo;
        protected WinSelect<Persona> _ws;
        protected WinSelect<Usuario> _wsu;
        private readonly CUListPagos _listPagos;
        private readonly CUListDeudas _listDeudas;
        private readonly CUListCuotas _listCuotas;
        private readonly CUListConveniosHisto _listConvenios;
        private readonly CUListGestiones _listGestiones;
        private readonly CUListEstadosCuenta _listEstados;
        private IVistaPanelList _panelCuotas, _panelPagos, _panelDeudas, _panelConvs, _panelGestiones, _panelEstados;

        /// <summary>
        ///   Constructor de la clase que inicializa los componentes 
        ///   visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmCuenta(IControladorEditable<Cuenta> controlador) : base(controlador) {
            try {
                InitializeComponent();

                _listPagos = new CUListPagos {Padre = this};
                _listCuotas = new CUListCuotas {Padre = this};
                _listDeudas = new CUListDeudas {Padre = this};
                _listConvenios = new CUListConveniosHisto {Padre = this};
                _listGestiones = new CUListGestiones {Padre = this};
                _listEstados = new CUListEstadosCuenta {Padre = this};
                _listDeudas.ColsInvisibles.Add("Cuenta");
                _listConvenios.ColsInvisibles.Add("Cuenta");
                _listGestiones.ColsInvisibles.Add("Cuenta");
                _listEstados.ColsInvisibles.Add("Cuenta");
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panelabmv
        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        protected override void postSetObjeto() {
            try {
                _listGestiones.ObjetoMaster =
                    _listPagos.ObjetoMaster =
                    _listDeudas.ObjetoMaster =
                    _listConvenios.ObjetoMaster =
                    _listEstados.ObjetoMaster = _objeto;

                if (_objeto.ConvenioActivo != null)
                    if (_objeto.ConvenioActivo.convenioDebeCaer() &&
                        Sistema.Controlador.mostrar("PREGUNTA-BAJAR-CONVENIO",
                            ENivelMensaje.PREGUNTA, null, false) == DialogResult.Yes)
                        try {
                            _objeto.bajarConvenioActivo();
                            _objeto.save();
                        } catch (Exception e) {
                            Sistema.Controlador.mostrar("ERROR-FATAL", ENivelMensaje.ERROR, e.ToString(), true);
                        }
                    else
                        _convenioActivo = _objeto.ConvenioActivo;
                else
                    _convenioActivo = null;

                _listPagos.Filtros.Clear();
                _listDeudas.Filtros.Clear();
                _listCuotas.Filtros.Clear();
                _listConvenios.Filtros.Clear();
                _listGestiones.Filtros.Clear();
                _listEstados.Filtros.Clear();

                cargarDatos();
                cargarControles();
                cargarTabs();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarControles() {
            cargarComboEntidad();
            cargarComboProducto();
            cargarComboEstado();
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Texto
                ctrlTxtCodigo.Text = _objeto.Codigo;
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                ctrlTxtExpediente.Text = _objeto.Expediente;
                txtLegales.Text = _objeto.Legales;
                ctrlTxtVigencia.Text = _objeto.Vigencia.ToString();
                // Fechas
                ctrlFechaElegible.Value = (_objeto.FechaElegible <= Fechas.FechaNull)
                                              ? Fechas.FechaNull
                                              : _objeto.FechaElegible;
                ctrlTxtFechaElegible.Text = (ctrlFechaElegible.Value <= Fechas.FechaNull)
                                                ? null
                                                : ctrlFechaElegible.Value.ToShortDateString();

                fechaAlta.Text = (_objeto.FechaAlta <= Fechas.FechaNull)
                                     ? ""
                                     : _objeto.FechaAlta.ToString();

                ctrlFechaAsignada.Value = (_objeto.FechaAsignacion <= Fechas.FechaNull)
                                              ? DateTime.Now
                                              : _objeto.FechaAsignacion;
                ctrlTxtFechaAsignada.Text = ctrlFechaAsignada.Value.ToShortDateString();
                // Numeros
                txtAntCta.Text = _objeto.getAntiguedadCuenta().ToString();
                txtPagadoAHoy.Text = _objeto.getMontoPagadoTotal().ToString();
                // Booleanos
                ctrlChkActivada.Checked = _objeto.Activada;
                chkVerSoloOrigen.Checked = true;
                // Clases
                txtTitular.Tag = null;
                txtTitular.Text = string.Empty;
                if (_objeto.Titular != null) {
                    txtTitular.Tag = _objeto.Titular;
                    txtTitular.Text = txtTitular.Tag.ToString();
                }
                txtGarante.Tag = null;
                txtGarante.Text = string.Empty;
                if (_objeto.Garante != null) {
                    txtGarante.Tag = _objeto.Garante;
                    txtGarante.Text = txtGarante.Tag.ToString();
                }
                txtConvenio.Tag = null;
                txtConvenio.Text = string.Empty;
                if (_convenioActivo != null) {
                    txtConvenio.Tag = _convenioActivo;
                    txtConvenio.Text = txtConvenio.Tag.ToString();
                }
                txtLista.Tag = null;
                txtLista.Text = string.Empty;
                if (_objeto.ListaAsignada != null) {
                    txtLista.Tag = _objeto.ListaAsignada;
                    txtLista.Text = txtLista.Tag.ToString();
                }
                txtGestor.Tag = null;
                txtGestor.Text = string.Empty;
                if (_objeto.Gestor != null) {
                    txtGestor.Tag = _objeto.Gestor;
                    txtGestor.Text = txtGestor.Tag.ToString();
                }
                if (_objeto.Producto != null) {
                    Tramo tr = _objeto.Producto.getTramoCorrespondiente(_objeto);
                    txtTramo.Text = (tr == null)
                                        ? "N/D"
                                        : tr.ToString();
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-LOADNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarTabs() {
            try {
                if (_enProceso) {
                    _panelPagos = _listPagos.getPanelListado(_controlador.ModoVista);
                    _panelPagos.Contenedor = this;
                    tabPagos.Controls.Clear();
                    tabPagos.Controls.Add((Control)_panelPagos);
                    tabPagos.Controls["PanelListABMV"].Dock = DockStyle.Fill;

                    _panelDeudas = _listDeudas.getPanelListado(_controlador.ModoVista);
                    _panelDeudas.Contenedor = this;
                    tabDeudas.Controls.Clear();
                    tabDeudas.Controls.Add((Control)_panelDeudas);
                    tabDeudas.Controls["PanelListABMV"].Dock = DockStyle.Fill;

                    if (_convenioActivo != null) {
                        _listCuotas.ObjetoMaster = _convenioActivo;
                        _panelCuotas = _listCuotas.getPanelListado(_controlador.ModoVista);
                        _panelCuotas.Contenedor = this;
                        tabCuotas.Controls.Clear();
                        tabCuotas.Controls.Add((Control)_panelCuotas);
                        tabCuotas.Controls["PanelListABMV"].Dock = DockStyle.Fill;
                    } else
                        tabCuotas.Controls.Clear();

                    _panelConvs = _listConvenios.getPanelListado(EModoVentana.VIEW);
                    _panelConvs.Contenedor = this;
                    tabHistConvenios.Controls.Clear();
                    tabHistConvenios.Controls.Add((Control)_panelConvs);
                    tabHistConvenios.Controls["PanelListABMV"].Dock = DockStyle.Fill;

                    _panelGestiones = _listGestiones.getPanelListado(EModoVentana.VIEW);
                    _panelGestiones.Contenedor = this;
                    tabGestiones.Controls.Clear();
                    tabGestiones.Controls.Add((Control)_panelGestiones);
                    tabGestiones.Controls["PanelListABMV"].Dock = DockStyle.Fill;

                    _panelEstados = _listEstados.getPanelListado(EModoVentana.VIEW);
                    _panelEstados.Contenedor = this;
                    tabHistEstados.Controls.Clear();
                    tabHistEstados.Controls.Add((Control)_panelEstados);
                    tabHistEstados.Controls["PanelListABMV"].Dock = DockStyle.Fill;
                } else {
                    _panelDeudas.refrescarListado(_listDeudas.ColsInvisibles);
                    _panelPagos.refrescarListado(_listPagos.ColsInvisibles);
                    _panelGestiones.refrescarListado(_listGestiones.ColsInvisibles);
                    _panelConvs.refrescarListado(_listConvenios.ColsInvisibles);
                    _panelEstados.refrescarListado(_listEstados.ColsInvisibles);
                    if (_convenioActivo != null)
                        _panelCuotas.refrescarListado(_listCuotas.ColsInvisibles);
                }

                tabCuotas.Text = (_convenioActivo != null)
                                     ? string.Format(
                                         "Convenio Activo (saldo ${0})", _convenioActivo.getMontoSaldoTotalActual())
                                     : "Convenio Activo";
                tabCuotas.Refresh();
                tabPagos.Text = string.Format("Pagos ({0})", _listPagos.Cuenta);
                tabPagos.Refresh();
                tabDeudas.Text = string.Format("Deudas ({0})", _listDeudas.Cuenta);
                tabDeudas.Refresh();
                tabHistConvenios.Text = string.Format("Historial Convenios ({0})", _listConvenios.Cuenta);
                tabHistConvenios.Refresh();
                tabGestiones.Text = string.Format("Gestiones ({0})", _listGestiones.Cuenta);
                tabGestiones.Refresh();
                tabHistEstados.Text = string.Format("Historial Estados ({0})", _listEstados.Cuenta);
                tabHistEstados.Refresh();

                // Recarga los valores del resumen
                cargarResumen(chkVerSoloOrigen.Checked);
            } catch (Exception e) {
                throw new DataErrorException("SUBLISTADO-NOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return
                    !(ctrlTxtDescripcion.Text == (_objeto.Descripcion ?? "")
                      && ctrlTxtCodigo.Text == (_objeto.Codigo ?? "")
                      && ctrlTxtVigencia.Text == _objeto.Vigencia.ToString()
                      && ctrlChkActivada.Checked == _objeto.Activada
                      && ctrlFechaAsignada.Value == _objeto.FechaAsignacion
                      && ctrlFechaElegible.Value == _objeto.FechaElegible
                      && ctrlTxtExpediente.Text == _objeto.Expediente
                      && txtTitular.Tag == _objeto.Titular
                      && txtGarante.Tag == _objeto.Garante
                      && txtGestor.Tag == _objeto.Gestor
                      && comboEntidad.SelectedItem == (_objeto.Entidad ?? comboEntidad.SelectedItem)
                      && comboProducto.SelectedItem == (_objeto.Producto ?? comboProducto.SelectedItem)
                      && ctrlTxtComboEstado.SelectedItem == (_objeto.Estado ?? ctrlTxtComboEstado.SelectedItem));
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Entidad = (Entidad)comboEntidad.SelectedItem;
                _objeto.Descripcion = ctrlTxtDescripcion.Text;
                _objeto.Codigo = ctrlTxtCodigo.Text;
                _objeto.Activada = ctrlChkActivada.Checked;
                _objeto.FechaAsignacion = (ctrlFechaAsignada.Value <= Fechas.FechaNull)
                                              ? DateTime.Now
                                              : ctrlFechaAsignada.Value;
                _objeto.FechaElegible = (ctrlFechaElegible.Value <= Fechas.FechaNull)
                                            ? Fechas.FechaNull
                                            : ctrlFechaElegible.Value;
                _objeto.Vigencia = Convert.ToInt64(
                    (ctrlTxtVigencia.Text ?? "").Equals("")
                        ? "0"
                        : ctrlTxtVigencia.Text);
                _objeto.Titular = (Persona)txtTitular.Tag;
                _objeto.Garante = (Persona)txtGarante.Tag;
                _objeto.Gestor = (Usuario)txtGestor.Tag;
                _objeto.Producto = (Producto)comboProducto.SelectedItem;
                _objeto.Estado = (Parametro)ctrlTxtComboEstado.SelectedItem;
                _objeto.Expediente = ctrlTxtExpediente.Text;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion panelabmv

        #region controles
        /// <summary>
        ///   Este método carga el combo de Entidades de la cuenta.
        ///   Lanza una VistaErrorException si tiene algún problema.
        /// </summary>
        private void cargarComboEntidad() {
            comboEntidad.Items.Clear();
            comboEntidad.ReadOnly = false;
            try {
                foreach (Entidad ent in RepositorioGenerico<Entidad>.GetAll()) {
                    comboEntidad.Items.Add(ent);

                    if (_objeto.Entidad != null && _objeto.Entidad.Equals(ent)) {
                        comboEntidad.SelectedItem = ent;
                        comboEntidad.ReadOnly = true;
                    }
                }

                if (comboEntidad.SelectedItem == null && comboEntidad.Items.Count >= 1)
                    comboEntidad.SelectedItem = comboEntidad.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        ///   Este método carga el combo de Producto de la cuenta.
        ///   Lanza una VistaErrorException si tiene algún problema.
        /// </summary>
        private void cargarComboProducto() {
            comboProducto.Items.Clear();
            comboProducto.ReadOnly = false;
            try {
                foreach (Producto p in ((Entidad)comboEntidad.SelectedItem).getProductosActivos()) {
                    comboProducto.Items.Add(p);

                    if (_objeto.Producto != null && _objeto.Producto.Equals(p)) {
                        comboProducto.SelectedItem = p;
                        comboProducto.ReadOnly = true;
                    }
                }

                if (comboProducto.SelectedItem == null && comboProducto.Items.Count >= 1)
                    comboProducto.SelectedItem = comboProducto.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        ///   Este método carga el combo de Estado de la cuenta.
        ///   Lanza una VistaErrorException si tiene algún problema.
        /// </summary>
        private void cargarComboEstado() {
            ctrlTxtComboEstado.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLike(ETipoParametro.GESTION, "ESTADOCUENTA"))) {
                    ctrlTxtComboEstado.Items.Add(p);

                    if (_objeto.Estado != null && _objeto.Estado.Equals(p))
                        ctrlTxtComboEstado.SelectedItem = p;
                }

                if (ctrlTxtComboEstado.SelectedItem == null && ctrlTxtComboEstado.Items.Count >= 1)
                    ctrlTxtComboEstado.SelectedItem = ctrlTxtComboEstado.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }
        #endregion controles

        #region metodos helpers
        /// <summary>
        ///   Este método carga el cuadro de resumen de panel.
        /// </summary>
        /// <param name = "soloOrigen">
        ///   Especifica toma solo deuda origen o si tomar tb no informada.
        /// </param>
        public void cargarResumen(bool soloOrigen) {
            double capital = 0, interes = 0, honorarios = 0, gastos = 0, total = 0;

            foreach (Deuda dd in _objeto.getDeudaInformada()) {
                capital += dd.Capital;
                interes += dd.Interes;
                honorarios += dd.Honorarios;
                gastos += dd.Gastos;
                total += dd.Total;
            }

            if (!soloOrigen)
                foreach (Deuda dd in _objeto.getDeudaNoInformada()) {
                    capital += dd.Capital;
                    interes += dd.Interes;
                    honorarios += dd.Honorarios;
                    gastos += dd.Gastos;
                    total += dd.Total;
                }

            txtCapital.Text = capital.ToString();
            txtHonorarios.Text = honorarios.ToString();
            txtInteres.Text = interes.ToString();
            txtGastos.Text = gastos.ToString();
            txtTotal.Text = total.ToString();
            txtAntiguedad.Text = _objeto.getAntiguedadDeuda().ToString();
        }

        /// <summary>
        ///   Implementación del método de la interfase.
        /// </summary>
        public override void setEditable() {
            base.setEditable();
            // Solo se puede cambiar el estado de activación de la cuenta
            // o su expediente si se tiene permiso para cancelar una cuenta
            // (lo mismo para los campos fecha asignada y fecha elegible)
            if (_controlador.ModoVista > EModoVentana.VIEW) {
                ctrlChkActivada.Enabled = ctrlBtnCancelar.Visible;
                ctrlTxtExpediente.ReadOnly = !ctrlBtnCancelar.Visible;
                ctrlTxtFechaAsignada.ReadOnly = !ctrlBtnCancelar.Visible;
                ctrlFechaAsignada.Enabled = ctrlBtnCancelar.Visible;
                ctrlTxtFechaElegible.ReadOnly = !ctrlBtnCancelar.Visible;
                ctrlFechaElegible.Enabled = ctrlBtnCancelar.Visible;
            }
        }

        /// <summary>
        ///   Este método verifica que se pueda odificar la cuenta (por 
        ///   ejemplo que la cuenta este activa o el usuario pueda hacerlo).
        /// </summary>
        private void verificarAntesDeModificar() {
            if (!_enProceso && _controlador.ModoVista != EModoVentana.ADD) {
                if (!_objeto.Activada)
                    throw new DataErrorException("ERROR-CUENTA-NOGESTIONABLE");
                if (_objeto.Gestor != null
                    && !_objeto.Gestor.Equals(Sistema.Controlador.SecurityService.getUsuario()))
                    throw new DataErrorException("ERROR-NO-GESTOR-PARA-ESTADO");
            }
        }
        #endregion metodos helpers

        #region interface
        /// <summary>
        ///   Este método responde al botón Ver Tramo. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerTramo_Click(object sender, EventArgs e) {
            try {
                if (_objeto != null)
                    CUCaller.CallCU(
                        "cuAbmTramo", this, new object[] {EModoVentana.VIEW, _objeto.getTramo()});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        ///   Este método responde al cambio de Entidad seleccionada para
        ///   refrescar el listado de las Productos válidos. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlComboEntidad_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                verificarAntesDeModificar();

                if (comboEntidad.SelectedItem != null)
                    cargarComboProducto();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        ///   Este método responde al cambio de Provincia seleccionada para
        ///   refrescar el listado de las Localidades válidas. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtComboEstado_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                // Verifica si la cuenta está en un estado "controlable" 
                // (PARAMETRO.VALORBOOL=1), o si se pasa a un estado así 
                // entonces solo se puede cambiar su estado si se tiene 
                // permiso para cancelar una cuenta. Tambien se verifica 
                // si la cuenta tiene gestor, en cuyo caso solo el gestor
                // puede cambiarle el estado de manera específica.
                if (!_enProceso)
                    if (_controlador.ModoVista > EModoVentana.VIEW)
                        if (ctrlTxtComboEstado.SelectedItem != null)
                            // Aca se verifica si es un estado controlado
                            if ((_objeto.Estado != null && _objeto.Estado.Valorbool)
                                || ((Parametro)ctrlTxtComboEstado.SelectedItem).Valorbool) {
                                if (!ctrlBtnCancelar.Visible) {
                                    Sistema.Controlador.mostrar(
                                        "ERROR-NO-PERMISO-PARA-ESTADO", ENivelMensaje.ERROR, null, false);
                                    // Vuelve a colocar el estado que tenía
                                    _enProceso = true;
                                    ctrlTxtComboEstado.SelectedItem = ctrlTxtComboEstado.Items[0];
                                    foreach (object p in ctrlTxtComboEstado.Items)
                                        if (_objeto.Estado != null && _objeto.Estado.Equals(p))
                                            ctrlTxtComboEstado.SelectedItem = p;
                                    _enProceso = false;
                                } else if (!Sistema.Controlador.SecurityService.getUsuario().poseePermiso(
                                        Parametros.GetByClave("MENU.INTERFACES.DESASIGNAR"), ETipoPermiso.EJECUTAR)) {
                                    Sistema.Controlador.mostrar(
                                        "ERROR-NO-PERMISO-PARA-DESASIGNAR", ENivelMensaje.ERROR, null, false);
                                    // Vuelve a colocar el estado que tenía
                                    _enProceso = true;
                                    ctrlTxtComboEstado.SelectedItem = ctrlTxtComboEstado.Items[0];
                                    foreach (object p in ctrlTxtComboEstado.Items)
                                        if (_objeto.Estado != null && _objeto.Estado.Equals(p))
                                            ctrlTxtComboEstado.SelectedItem = p;
                                    _enProceso = false;
                                }
                                // Aca se verifica si es usuario gestor de cuenta
                            } else if (_objeto.Gestor != null
                                       && !_objeto.Gestor.Equals(Sistema.Controlador.SecurityService.getUsuario())) {
                                Sistema.Controlador.mostrar(
                                    "ERROR-NO-GESTOR-PARA-ESTADO", ENivelMensaje.ERROR, null, false);
                                // Vuelve a colocar el estado que tenía
                                _enProceso = true;
                                ctrlTxtComboEstado.SelectedItem = ctrlTxtComboEstado.Items[0];
                                foreach (object p in ctrlTxtComboEstado.Items)
                                    if (_objeto.Estado != null && _objeto.Estado.Equals(p))
                                        ctrlTxtComboEstado.SelectedItem = p;
                                _enProceso = false;
                            }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        ///   Este método responde al botón Ver Titular. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerTitular_Click(object sender, EventArgs e) {
            try {
                if (txtTitular.Tag != null)
                    CUCaller.CallCU("cuAbmPersona", this, new[] {EModoVentana.VIEW, txtTitular.Tag});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        ///   Este método responde al botón Buscar Titular. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFindTitular_Click(object sender, EventArgs e) {
            try {
                verificarAntesDeModificar();

                if (_ws == null)
                    _ws = new WinSelect<Persona>("cuAbmPersona.CUListPersonas");

                _ws.ShowDialog();

                if (_ws.Seleccion != null) {
                    txtTitular.Tag = _ws.Seleccion;
                    txtTitular.Text = txtTitular.Tag.ToString();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        ///   Este método responde al botón Ver Garante. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void btnVerGarante_Click(object sender, EventArgs e) {
            try {
                if (txtGarante.Tag != null)
                    CUCaller.CallCU("cuAbmPersona", this, new[] {EModoVentana.VIEW, txtGarante.Tag});
                else
                    Sistema.Controlador.mostrar("ACTION-VIEW-MUST-SELECT", ENivelMensaje.ERROR, null, false);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        ///   Este método responde al botón Buscar Garante. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFindGarante_Click(object sender, EventArgs e) {
            try {
                verificarAntesDeModificar();

                if (_ws == null)
                    _ws = new WinSelect<Persona>("cuAbmPersona.CUListPersonas");

                _ws.ShowDialog();

                if (_ws.Seleccion != null) {
                    txtGarante.Tag = _ws.Seleccion;
                    txtGarante.Text = txtGarante.Tag.ToString();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        ///   Este método responde al botón de cancelación de la cuenta. 
        ///   Verifica que, si la cuenta tiene usuario gestor, sea este.
        ///   Debería 'mostrar' cualquier error y no propagar excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlBtnCancelar_Click(object sender, EventArgs e) {
            try {
                verificarAntesDeModificar();

                if (Sistema.Controlador.mostrar("PREGUNTA-NOUNDO-ACTION", ENivelMensaje.PREGUNTA, null, false)
                    == DialogResult.Yes) {
                    _objeto.Activada = false;
                    _objeto.setearEstado(Parametros.GetByClave("ESTADOCUENTA.CTA.-DESASIGNADA-POR-CLIENTE"));
                    _objeto.Descripcion += " ** DESASIGNADA POR "
                                           + Sistema.Controlador.SecurityService.getUsuario().Nombre;
                    _objeto.save();
                    Sistema.Controlador.mostrar("CANCEL-CUENTA-OK", ENivelMensaje.INFORMACION, null, true);
                    ((Form)Parent).Close();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            }
        }

        /// <summary>
        ///   Este método responde al botón Ver Convenio.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
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
        ///   Este método responde al botón Ver Solo Origen.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void chkVerSoloOrigen_CheckedChanged(object sender, EventArgs e) {
            try {
                cargarResumen(chkVerSoloOrigen.Checked);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        ///   Este método responde al botón Ver Solo Origen.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlChkActivada_CheckedChanged(object sender, EventArgs e) {
            try {
                if (!_enProceso && _objeto.Gestor != null
                    && !_objeto.Gestor.Equals(Sistema.Controlador.SecurityService.getUsuario()))
                    throw new DataErrorException("ERROR-NO-GESTOR-PARA-ESTADO");
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                _enProceso = true;
                ctrlChkActivada.Checked = !ctrlChkActivada.Checked;
                _enProceso = false;
            }
        }

        /// <summary>
        ///   Este método responde al cambiar la visibilidad del boton de cancelar cuenta.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlBtnCancelar_VisibleChanged(object sender, EventArgs e) {
            // Solo se puede cambiar el estado de activación de la cuenta
            // o su expediente si se tiene permiso para cancelar una cuenta
            // (lo mismo para los campos fecha asignada y fecha elegible)
            if (_controlador.ModoVista > EModoVentana.VIEW) {
                ctrlChkActivada.Enabled = ctrlBtnCancelar.Visible;
                ctrlTxtExpediente.ReadOnly = !ctrlBtnCancelar.Visible;
                ctrlTxtFechaAsignada.ReadOnly = !ctrlBtnCancelar.Visible;
                ctrlFechaAsignada.Enabled = ctrlBtnCancelar.Visible;
                ctrlTxtFechaElegible.ReadOnly = !ctrlBtnCancelar.Visible;
                ctrlFechaElegible.Enabled = ctrlBtnCancelar.Visible;
            }
        }

        /// <summary>
        ///   Este método responde al del datetimepicker de Fecha Asignada. 
        ///   Debería 'mostrar' cualquier error que ocurriese y no propagar 
        ///   ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFechaAsignada_ValueChanged(object sender, EventArgs e) {
            try {
                verificarAntesDeModificar();

                string fecha = (ctrlFechaAsignada.Value <= Fechas.FechaNull)
                                   ? DateTime.Now.ToString()
                                   : ctrlFechaAsignada.Value.ToString();

                if (!ctrlTxtFechaAsignada.Text.Equals(fecha))
                    ctrlTxtFechaAsignada.Text = fecha;

                if (_objeto != null)
                    txtAntCta.Text = _objeto.getAntiguedadCuenta().ToString();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("DATA-NOK", ENivelMensaje.ERROR, ex.ToString(), false);
                if (_objeto != null) {
                    _enProceso = true;
                    ctrlFechaAsignada.Value = (_objeto.FechaAsignacion <= Fechas.FechaNull)
                                                  ? DateTime.Now
                                                  : _objeto.FechaAsignacion;
                    _enProceso = false;
                }
            }
        }

        /// <summary>
        ///   Este método responde al del datetimepicker de Fecha Elegible. 
        ///   Debería 'mostrar' cualquier error que ocurriese y no propagar 
        ///   ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFechaElegible_ValueChanged(object sender, EventArgs e) {
            try {
                verificarAntesDeModificar();

                string fecha = (ctrlFechaElegible.Value <= Fechas.FechaNull)
                                   ? null
                                   : ctrlFechaElegible.Value.ToString();

                if (!ctrlTxtFechaElegible.Text.Equals(fecha))
                    ctrlTxtFechaElegible.Text = fecha;
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("DATA-NOK", ENivelMensaje.ERROR, ex.ToString(), false);
                if (_objeto != null) {
                    _enProceso = true;
                    ctrlFechaElegible.Value = (_objeto.FechaElegible <= Fechas.FechaNull)
                                                  ? DateTime.Now
                                                  : _objeto.FechaElegible;
                    _enProceso = false;
                }
            }
        }

        /// <summary>
        ///   Este método responde al cambio de fecha del convenio desde el 
        ///   propio campo. Debería 'mostrar' cualquier error que ocurriese y 
        ///   no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtFechaAsignada_Validated(object sender, EventArgs e) {
            try {
                verificarAntesDeModificar();

                DateTime fecha = Convert.ToDateTime(ctrlTxtFechaAsignada.Text);
                if (ctrlFechaAsignada.Value != fecha) {
                    _objeto.FechaAsignacion = fecha;
                    ctrlFechaAsignada.Value = fecha;
                }

                if (_objeto != null)
                    txtAntCta.Text = _objeto.getAntiguedadCuenta().ToString();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("DATA-NOK", ENivelMensaje.ERROR, ex.ToString(), false);
                _enProceso = true;
                ctrlTxtFechaAsignada.Text = ctrlFechaAsignada.Value.ToShortDateString();
                _enProceso = false;
            }
        }

        /// <summary>
        ///   Este método responde al cambio de fecha del convenio desde el 
        ///   propio campo. Debería 'mostrar' cualquier error que ocurriese y 
        ///   no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlTxtFechaElegible_Validated(object sender, EventArgs e) {
            try {
                verificarAntesDeModificar();

                DateTime fecha = Convert.ToDateTime(ctrlTxtFechaElegible.Text);
                if (ctrlFechaElegible.Value != fecha) {
                    _objeto.FechaElegible = fecha;
                    ctrlFechaElegible.Value = fecha;
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("DATA-NOK", ENivelMensaje.ERROR, ex.ToString(), false);
                _enProceso = true;
                ctrlTxtFechaElegible.Text = ctrlFechaElegible.Value.ToShortDateString();
                _enProceso = false;
            }
        }

        /// <summary>
        ///   Este método responde al botón Buscar Gestor. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlFindGestor_Click(object sender, EventArgs e) {
            try {
                if (_wsu == null)
                    _wsu = new WinSelect<Usuario>("cuConfigurarUsuarios.CUListUsuarios");

                _wsu.ShowDialog();

                if (_wsu.Seleccion != null) {
                    txtGestor.Tag = _wsu.Seleccion;
                    txtGestor.Text = txtGestor.Tag.ToString();
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), false);
            }
        }

        /// <summary>
        ///   Este método responde al botón Buscar Gestor. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlDelGestor_Click(object sender, EventArgs e) {
            try {
                txtGestor.Tag = null;
                txtGestor.Text = null;
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), false);
            }
        }

        /// <summary>
        ///   Este método responde al botón Buscar Gestor. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlDelFechaElegible_Click(object sender, EventArgs e) {
            try {
                verificarAntesDeModificar();

                ctrlFechaElegible.Value = Fechas.FechaNull;
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), false);
            }
        }

        /// <summary>
        ///   Este método responde al botón Cancelar Saldo. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlDelDeuda_Click(object sender, EventArgs e) {
            try {
                if (Sistema.Controlador.mostrar("PREGUNTA-NOUNDO-ACTION", ENivelMensaje.PREGUNTA, null, false)
                    == DialogResult.Yes) {
                    _objeto.cancelarTodasLasDeudas();
                    setearObjeto(_objeto);
                    Sistema.Controlador.mostrar("PROCESO-OK", ENivelMensaje.INFORMACION, null, true);
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), false);
            }
        }
        #endregion interface
    }
}