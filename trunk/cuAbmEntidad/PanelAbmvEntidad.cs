///////////////////////////////////////////////////////////
//  PanelAbmvEntidad.cs
//  Implementación del panel ABMV para la entidad Entidad
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using cuAbmCuenta;
using cuAbmParametro;
using cuAbmProducto;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.enums;
using sgmpro.dominio.configuracion;

namespace cuAbmEntidad {
    public partial class PanelAbmvEntidad : PanelABMV<Entidad> {
        private readonly CUListCuentas _listCuentas;
        private readonly CUListProductos _listProductos;
        private readonly CUListSetParametros _listTiposGestion;
        private readonly CUListSetParametros _listTiposFactura;
        private readonly CUListSetParametros _listFormasPago;
        private readonly CUListSetTipoConv _listTiposConvenio;
        private IVistaPanelList _panelCuentas, _panelProductos, _panelTg, _panelTf, _panelFp, _panelTc;

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvEntidad(IControladorEditable<Entidad> unControlador) : base(unControlador) {
            try {
                InitializeComponent();

                _listCuentas = new CUListCuentas {
                    Padre = this
                };
                _listCuentas.ColsInvisibles.Add("Entidad");

                _listProductos = new CUListProductos {
                    Padre = this
                };
                _listProductos.ColsInvisibles.Add("Entidad");

                _listTiposGestion = new CUListSetParametros {
                    Disponibles = Parametros.GetByTipoClaveLike(ETipoParametro.GESTION, "TIPOGESTION"),
                    Padre = this
                };
                _listTiposGestion.ColsInvisibles.Add("Clave");
                _listTiposGestion.ColsInvisibles.Add("Clase");
                _listTiposGestion.ColsInvisibles.Add("Tipo");
                _listTiposGestion.ColsInvisibles.Add("Valorint");
                _listTiposGestion.ColsInvisibles.Add("Valordouble");
                _listTiposGestion.ColsInvisibles.Add("Valordouble2");

                _listTiposFactura = new CUListSetParametros {
                    Disponibles = Parametros.GetByTipoClaveLike(ETipoParametro.GESTION, "TIPOFACTURA"),
                    Padre = this
                };
                _listTiposFactura.ColsInvisibles.Add("Clave");
                _listTiposFactura.ColsInvisibles.Add("Clase");
                _listTiposFactura.ColsInvisibles.Add("Tipo");
                _listTiposFactura.ColsInvisibles.Add("Valorint");
                _listTiposFactura.ColsInvisibles.Add("Valordouble");
                _listTiposFactura.ColsInvisibles.Add("Valordouble2");

                _listFormasPago = new CUListSetParametros {
                    Disponibles = Parametros.GetByTipoClaveLike(ETipoParametro.GESTION, "FORMAPAGO"),
                    Padre = this
                };
                _listFormasPago.ColsInvisibles.Add("Clave");
                _listFormasPago.ColsInvisibles.Add("Clase");
                _listFormasPago.ColsInvisibles.Add("Tipo");
                _listFormasPago.ColsInvisibles.Add("Valorint");
                _listFormasPago.ColsInvisibles.Add("Valordouble");
                _listFormasPago.ColsInvisibles.Add("Valordouble2");

                _listTiposConvenio = new CUListSetTipoConv {
                    Disponibles = RepositorioGenerico<TipoConvenio>.GetAliveAll(),
                    Padre = this
                };
            } catch (Exception e) {
                throw new VistaErrorException("PANEL-NOK", e.ToString());
            }
        }

        #region panelabmv
        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        protected override void postSetObjeto() {
            try {
                _listCuentas.ObjetoMaster =
                    _listProductos.ObjetoMaster =                    
                    _listTiposGestion.ObjetoMaster =
                    _listTiposFactura.ObjetoMaster =
                    _listFormasPago.ObjetoMaster =
                    _listTiposConvenio.ObjetoMaster = _objeto;

                _listCuentas.Filtros.Clear();
                _listProductos.Filtros.Clear();

                _listTiposGestion.Configurados = _objeto.TiposGestion;
                _listTiposFactura.Configurados = _objeto.TiposRecibo;
                _listFormasPago.Configurados = _objeto.FormasPago;
                _listTiposConvenio.Configurados = _objeto.TiposConvenio;

                cargarDatos();
                cargarTabs();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                // Texto
                ctrlTxtCodigo.Text = _objeto.Codigo;
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtCuit.Text = _objeto.Cuit;
                ctrlTxtDireccion.Text = _objeto.Direccion;
                ctrlTxtCodigoPostal.Text = _objeto.Cp;
                ctrlTxtTelefono.Text = _objeto.Telefono;
                ctrlTxtFax.Text = _objeto.Fax;
                ctrlTxtContacto.Text = _objeto.Contacto;
                ctrlTxtEmail.Text = _objeto.Email;
                // Booleanos
                ctrlChkActiva.Checked = _objeto.Activada;
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
                    _panelCuentas = _listCuentas.getPanelListado(_controlador.ModoVista);
                    _panelCuentas.Contenedor = this;
                    tabCuentas.Controls.Clear();
                    tabCuentas.Controls.Add((Control)_panelCuentas);
                    tabCuentas.Controls["PanelListABMV"].Dock = DockStyle.Fill;

                    _panelProductos = _listProductos.getPanelListado(_controlador.ModoVista);
                    _panelProductos.Contenedor = this;
                    tabProductos.Controls.Clear();
                    tabProductos.Controls.Add((Control)_panelProductos);
                    tabProductos.Controls["PanelListABMV"].Dock = DockStyle.Fill;

                    _panelTg = _listTiposGestion.getPanelListado(_controlador.ModoVista);
                    _panelTg.Contenedor = this;
                    tabTiposGestion.Controls.Clear();
                    tabTiposGestion.Controls.Add((Control)_panelTg);
                    tabTiposGestion.Controls["PanelListSet"].Dock = DockStyle.Fill;

                    _panelTf = _listTiposFactura.getPanelListado(_controlador.ModoVista);
                    _panelTf.Contenedor = this;
                    tabTiposFactura.Controls.Clear();
                    tabTiposFactura.Controls.Add((Control)_panelTf);
                    tabTiposFactura.Controls["PanelListSet"].Dock = DockStyle.Fill;

                    _panelFp = _listFormasPago.getPanelListado(_controlador.ModoVista);
                    _panelFp.Contenedor = this;
                    tabFormasPago.Controls.Clear();
                    tabFormasPago.Controls.Add((Control)_panelFp);
                    tabFormasPago.Controls["PanelListSet"].Dock = DockStyle.Fill;

                    _panelTc = _listTiposConvenio.getPanelListado(_controlador.ModoVista);
                    _panelTc.Contenedor = this;
                    tabTiposConvenio.Controls.Clear();
                    tabTiposConvenio.Controls.Add((Control)_panelTc);
                    tabTiposConvenio.Controls["PanelListSet"].Dock = DockStyle.Fill;
                } else {
                    _panelCuentas.refrescarListado(_listCuentas.ColsInvisibles);
                    _panelFp.refrescarListado(_listFormasPago.ColsInvisibles);
                    _panelProductos.refrescarListado(_listProductos.ColsInvisibles);
                    _panelTc.refrescarListado(_listTiposConvenio.ColsInvisibles);
                    _panelTf.refrescarListado(_listTiposFactura.ColsInvisibles);
                    _panelTg.refrescarListado(_listTiposGestion.ColsInvisibles);
                }

                tabCuentas.Text = string.Format("Cuentas Asociadas ({0})", _listCuentas.Cuenta);
                tabCuentas.Refresh();
                tabProductos.Text = string.Format("Productos ({0})", _listProductos.Cuenta);
                tabProductos.Refresh();
                tabTiposGestion.Text = string.Format("Tipos de Gestión ({0})", _objeto.TiposGestion.Count);
                tabTiposGestion.Refresh();
                tabTiposFactura.Text = string.Format("Tipos de Recibos ({0})", _objeto.TiposRecibo.Count);
                tabTiposFactura.Refresh();
                tabFormasPago.Text = string.Format("Formas de Pago ({0})", _objeto.FormasPago.Count);
                tabFormasPago.Refresh();
                tabTiposConvenio.Text = string.Format("Tipos de Convenio ({0})", _objeto.TiposConvenio.Count);
                tabTiposConvenio.Refresh();
            } catch (Exception e) {
                throw new DataErrorException("SUBLISTADO-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return !((_objeto.Codigo ?? "") == ctrlTxtCodigo.Text
                         && (_objeto.Nombre ?? "") == ctrlTxtNombre.Text
                         && (_objeto.Cuit ?? "") == ctrlTxtCuit.Text
                         && (_objeto.Direccion ?? "") == ctrlTxtDireccion.Text
                         && (_objeto.Cp ?? "") == ctrlTxtCodigoPostal.Text
                         && (_objeto.Telefono ?? "") == ctrlTxtTelefono.Text
                         && (_objeto.Fax ?? "") == ctrlTxtFax.Text
                         && (_objeto.Contacto ?? "") == ctrlTxtContacto.Text
                         && (_objeto.Email ?? "") == ctrlTxtEmail.Text
                         && _objeto.Activada == ctrlChkActiva.Checked);
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Codigo = ctrlTxtCodigo.Text;
                _objeto.Nombre = ctrlTxtNombre.Text;
                _objeto.Cuit = ctrlTxtCuit.Text;
                _objeto.Direccion = ctrlTxtDireccion.Text;
                _objeto.Cp = ctrlTxtCodigoPostal.Text;
                _objeto.Telefono = ctrlTxtTelefono.Text;
                _objeto.Fax = ctrlTxtFax.Text;
                _objeto.Contacto = ctrlTxtContacto.Text;
                _objeto.Email = ctrlTxtEmail.Text;
                _objeto.Activada = ctrlChkActiva.Checked;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion panelabmv
    }
}