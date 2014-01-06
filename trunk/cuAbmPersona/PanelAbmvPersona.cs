///////////////////////////////////////////////////////////
//  PanelAbmvPersona.cs
//  Implementación del panel ABMV para la entidad Persona
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using cuAbmContacto;
using cuAbmCuenta;
using cuAbmGestion;
using cuAbmRelacion;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.enums;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;

namespace cuAbmPersona {
    public partial class PanelAbmvPersona : PanelABMV<Persona> {
        private readonly CUListCuentas _listCuentas;
        private readonly CUListGestiones _listGestiones;
        private readonly CUListContactos _listContactos;
        private readonly CUListRelaciones _listRelaciones;
        private double _saldoActualTotal;
        private double _pagosEfectuados;
        private double _pagosHonorario;
        private long _maxDiasDeuda;
        private bool _poseeConvenio;
        private string _strFechaUltGestion;
        private IVistaPanelList _panelCuentas, _panelGestiones, _panelContactos, _panelRelaciones;

        /// <summary>
        ///   Constructor de la clase que inicializa los componentes 
        ///   visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvPersona(IControladorEditable<Persona> controlador) : base(controlador) {
            try {
                InitializeComponent();

                _listCuentas = new CUListCuentas {
                    Padre = this
                };
                _listCuentas.ColsInvisibles.Add("Titular");

                _listGestiones = new CUListGestiones {
                    Padre = this
                };
                _listGestiones.ColsInvisibles.Add("Contactado");

                _listContactos = new CUListContactos {
                    Padre = this
                };
                _listContactos.ColsInvisibles.Add("Persona");

                _listRelaciones = new CUListRelaciones {
                    Padre = this
                };
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
                _listCuentas.ObjetoMaster =
                    _listGestiones.ObjetoMaster =
                    _listRelaciones.ObjetoMaster =
                    _listContactos.ObjetoMaster = _objeto;

                _listCuentas.Filtros.Clear();
                _listGestiones.Filtros.Clear();
                _listContactos.Filtros.Clear();
                _listRelaciones.Filtros.Clear();

                cargarControles();
                cargarDatos();
                cargarTabs();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarControles() {
            cargarComboSexo();
            cargarComboTipoIVA();
            cargarComboEstadoCivil();
            cargarComboEstadoEconomico();
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                getDatosPersona();
                // Texto
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtDNI.Text = _objeto.DNI;
                ctrlTxtCuit.Text = _objeto.Cuit;
                ctrlTxtProfesion.Text = _objeto.Profesion;
                ctrlTxtTrabajo.Text = _objeto.Trabajo;
                ctrlTxtComentario.Text = _objeto.Comentario;
                // Booleano
                convenio.Checked = _poseeConvenio;
                // Números
                txtSaldoTotal.Text = string.Format("{0:C}", _saldoActualTotal);
                txtTotalPagado.Text = string.Format("{0:C}", _pagosEfectuados);
                txtPagadoHonor.Text = string.Format("{0:C}", _pagosHonorario);
                txtMaxDiasDeudor.Text = string.Format("{0} días", _maxDiasDeuda);
                // Fechas
                txtUltGestion.Text = _strFechaUltGestion;
                txtFechaUMod.Text = (_objeto.FechaUMod <= Fechas.FechaNull)
                                        ? ""
                                        : _objeto.FechaUMod.ToString();
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
                    _panelCuentas = _listCuentas.getPanelListado(_controlador.ModoVista);
                    _panelCuentas.Contenedor = this;
                    tabCuentas.Controls.Clear();
                    tabCuentas.Controls.Add((Control)_panelCuentas);
                    tabCuentas.Controls["PanelListABMV"].Dock = DockStyle.Fill;

                    _panelGestiones = _listGestiones.getPanelListado(_controlador.ModoVista);
                    _panelGestiones.Contenedor = this;
                    DataGridView dgv = (DataGridView)_panelGestiones.getControlListado();
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                    // ReSharper disable PossibleNullReferenceException
                    if (dgv.Columns != null && dgv.Columns["ResultadoDesc"] != null)
                        dgv.Columns["ResultadoDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    // ReSharper restore PossibleNullReferenceException
                    tabGestiones.Controls.Clear();
                    tabGestiones.Controls.Add((Control)_panelGestiones);
                    tabGestiones.Controls["PanelListABMV"].Dock = DockStyle.Fill;

                    _panelContactos = _listContactos.getPanelListado(_controlador.ModoVista);
                    _panelContactos.Contenedor = this;
                    tabContactos.Controls.Clear();
                    tabContactos.Controls.Add((Control)_panelContactos);
                    tabContactos.Controls["PanelListABMV"].Dock = DockStyle.Fill;

                    _panelRelaciones = _listRelaciones.getPanelListado(_controlador.ModoVista);
                    _panelRelaciones.Contenedor = this;
                    tabRelaciones.Controls.Add((Control)_panelRelaciones);
                    tabRelaciones.Controls["PanelListABMV"].Dock = DockStyle.Fill;
                } else {
                    _panelContactos.refrescarListado(_listContactos.ColsInvisibles);
                    _panelCuentas.refrescarListado(_listCuentas.ColsInvisibles);
                    _panelGestiones.refrescarListado(_listGestiones.ColsInvisibles);
                    _panelRelaciones.refrescarListado(_listRelaciones.ColsInvisibles);
                }

                tabCuentas.Text = string.Format("Cuentas ({0})", _listCuentas.Cuenta);
                tabCuentas.Refresh();
                tabGestiones.Text = string.Format("Gestiones ({0})", _listGestiones.Cuenta);
                tabGestiones.Refresh();
                tabContactos.Text = string.Format("Contactos ({0})", _listContactos.Cuenta);
                tabContactos.Refresh();
                tabRelaciones.Text = string.Format("Relaciones ({0})", _listRelaciones.Cuenta);
                tabRelaciones.Refresh();
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
                    !(ctrlTxtNombre.Text == (_objeto.Nombre ?? "") && ctrlTxtDNI.Text == _objeto.DNI &&
                      ctrlTxtCuit.Text == (_objeto.Cuit ?? "") &&
                      ctrlTxtDNI.Text == (_objeto.DNI ?? "") &&
                      ctrlTxtComentario.Text == (_objeto.Comentario ?? "") &&
                      ctrlTxtProfesion.Text == (_objeto.Profesion ?? "") &&
                      ctrlTxtTrabajo.Text == (_objeto.Trabajo ?? "") &&
                      ctrlTxtTipoIVA.SelectedItem == _objeto.TipoIVA &&
                      ctrlTxtEstadoCivil.SelectedItem == _objeto.EstadoCivil &&
                      ctrlTxtEstadoEconomico.SelectedItem == _objeto.Economia &&
                      ctrlTxtComboSexo.SelectedItem == _objeto.Sexo);
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Nombre = ctrlTxtNombre.Text;
                _objeto.DNI = ctrlTxtDNI.Text;
                _objeto.Cuit = ctrlTxtCuit.Text;
                _objeto.Profesion = ctrlTxtProfesion.Text;
                _objeto.Trabajo = ctrlTxtTrabajo.Text;
                _objeto.Comentario = ctrlTxtComentario.Text;
                _objeto.Sexo = (Parametro)ctrlTxtComboSexo.SelectedItem;
                _objeto.TipoIVA = (Parametro)ctrlTxtTipoIVA.SelectedItem;
                _objeto.EstadoCivil = (Parametro)ctrlTxtEstadoCivil.SelectedItem;
                _objeto.Economia = (Parametro)ctrlTxtEstadoEconomico.SelectedItem;
                _objeto.FechaUMod = DateTime.Now;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion

        #region controles
        /// <summary>
        ///   Este método carga el combo de tipos de Sexo.
        ///   Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboSexo() {
            ctrlTxtComboSexo.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLike(ETipoParametro.BASE, "SEXO"))) {
                    ctrlTxtComboSexo.Items.Add(p);

                    if (_objeto.Sexo != null && _objeto.Sexo.Equals(p))
                        ctrlTxtComboSexo.SelectedItem = p;
                }

                if (ctrlTxtComboSexo.SelectedItem == null && ctrlTxtComboSexo.Items.Count >= 1)
                    ctrlTxtComboSexo.SelectedItem = ctrlTxtComboSexo.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        ///   Este método carga el combo de tipos de IVA.
        ///   Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboTipoIVA() {
            ctrlTxtTipoIVA.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLike(ETipoParametro.BASE, "CONDICIONIVA"))) {
                    ctrlTxtTipoIVA.Items.Add(p);

                    if (_objeto.TipoIVA != null && _objeto.TipoIVA.Equals(p))
                        ctrlTxtTipoIVA.SelectedItem = p;
                }

                if (ctrlTxtTipoIVA.SelectedItem == null && ctrlTxtTipoIVA.Items.Count >= 1)
                    ctrlTxtTipoIVA.SelectedItem = ctrlTxtTipoIVA.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        ///   Este método carga el combo de Estado Civil.
        ///   Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboEstadoCivil() {
            ctrlTxtEstadoCivil.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLike(ETipoParametro.BASE, "ESTADOCIVIL"))) {
                    ctrlTxtEstadoCivil.Items.Add(p);

                    if (_objeto.EstadoCivil != null && _objeto.EstadoCivil.Equals(p))
                        ctrlTxtEstadoCivil.SelectedItem = p;
                }

                if (ctrlTxtEstadoCivil.SelectedItem == null && ctrlTxtEstadoCivil.Items.Count >= 1)
                    ctrlTxtEstadoCivil.SelectedItem = ctrlTxtEstadoCivil.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }

        /// <summary>
        ///   Este método carga el combo de Estado Económico.
        ///   Se lanza VistaErrorException si hay un problema.
        /// </summary>
        private void cargarComboEstadoEconomico() {
            ctrlTxtEstadoEconomico.Items.Clear();
            try {
                foreach (Parametro p in
                    (Parametros.GetByTipoClaveLike(ETipoParametro.BASE, "ESTADOECONOMICO"))) {
                    ctrlTxtEstadoEconomico.Items.Add(p);

                    if (_objeto.Economia != null && _objeto.Economia.Equals(p))
                        ctrlTxtEstadoEconomico.SelectedItem = p;
                }

                if (ctrlTxtEstadoEconomico.SelectedItem == null && ctrlTxtEstadoEconomico.Items.Count >= 1)
                    ctrlTxtEstadoEconomico.SelectedItem = ctrlTxtEstadoEconomico.Items[0];
            } catch (Exception e) {
                Sistema.Controlador.mostrar("PANEL-NOK", ENivelMensaje.ERROR, e.ToString(), true);
                Contenedor.cerrar();
            }
        }
        #endregion

        #region metodos helpers
        /// <summary>
        ///   Este método calcula los datos de la persona, según
        ///   todas sus cuentas (en las que figura como titular)
        ///   y según las gestiones en las que fué contactado.
        /// </summary>
        public void getDatosPersona() {
            _saldoActualTotal = _pagosEfectuados = _pagosHonorario = 0;
            _maxDiasDeuda = 0;
            _strFechaUltGestion = "";
            _poseeConvenio = false;

            foreach (Cuenta cta in _objeto.getCuentasTitular()) {
                _saldoActualTotal += cta.getMontoSaldoTotalActual();
                _pagosEfectuados += cta.getMontoPagadoTotal();

                foreach (Pago p in cta.getPagos())
                    _pagosHonorario += p.Honorarios;

                if (_maxDiasDeuda < cta.getAntiguedadDeuda())
                    _maxDiasDeuda = cta.getAntiguedadDeuda();

                if (cta.ConvenioActivo != null)
                    _poseeConvenio = true;
            }

            if (_objeto.getGestionesContactado().Count > 0)
                _strFechaUltGestion = (_objeto.getGestionesContactado()[0]).FechaCierre.ToString();
        }
        #endregion
    }
}