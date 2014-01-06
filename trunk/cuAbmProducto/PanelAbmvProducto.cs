///////////////////////////////////////////////////////////
//  PanelAbmvProducto.cs
//  Implementación del panel ABMV para la entidad Relacion
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using cuAbmCuenta;
using cuAbmTramo;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using sgmpro.dominio.configuracion;

namespace cuAbmProducto {
    public partial class PanelAbmvProducto : PanelABMV<Producto> {
        private readonly CUListCuentas _listCuentas;
        private readonly CUListTramos _listTramos;
        private IVistaPanelList _panelTramos, _panelCuentas;

        /// <summary>
        /// Constructor de la clase que inicializa los componentes 
        /// visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvProducto(IControladorEditable<Producto> controlador) : base(controlador) {
            try {
                InitializeComponent();

                _listCuentas = new CUListCuentas {
                    Padre = this
                };
                _listCuentas.ColsInvisibles.Add("Entidad");
                _listCuentas.ColsInvisibles.Add("Producto");

                _listTramos = new CUListTramos {
                    Padre = this
                };
                _listTramos.ColsInvisibles.Add("Producto");
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
                _listCuentas.ObjetoMaster = _listTramos.ObjetoMaster = _objeto;
                _listCuentas.Filtros.Clear();
                _listTramos.Filtros.Clear();

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
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                ctrlTxtImputacion.Text = _objeto.FormulaImputacion;
                // Booleanos
                ctrlChkActivada.Checked = _objeto.Activado;
                ctrlChkActualizar.Checked = _objeto.Actualizar;
                ctrlChkTemporal.Checked = _objeto.TramosTemporales;
                ctrlChkDeudaCuotas.Checked = _objeto.DeudaEnCuotas;
                ctrlChkUnificar.Checked = _objeto.UnificaGastos;
                // Clases
                if (_objeto.Entidad != null)
                    txtEntidad.Text = _objeto.Entidad.ToString();
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

                    _panelTramos = _listTramos.getPanelListado(_controlador.ModoVista);
                    _panelTramos.Contenedor = this;
                    tabTramos.Controls.Clear();
                    tabTramos.Controls.Add((Control)_panelTramos);
                    tabTramos.Controls["PanelListABMV"].Dock = DockStyle.Fill;
                } else {
                    _panelCuentas.refrescarListado((_listCuentas.ColsInvisibles));
                    _panelTramos.refrescarListado(_listTramos.ColsInvisibles);
                }

                tabCuentas.Text = string.Format("Cuentas Asociadas ({0})", _listCuentas.Cuenta);
                tabCuentas.Refresh();

                tabTramos.Text = string.Format("Tramos de Gestión ({0})", _listTramos.Cuenta);
                tabTramos.Refresh();
            } catch (Exception e) {
                throw new DataErrorException("SUBLISTADO-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return !(ctrlTxtDescripcion.Text.Equals(_objeto.Descripcion ?? string.Empty)
                         && ctrlTxtCodigo.Text.Equals(_objeto.Codigo ?? string.Empty)
                         && ctrlTxtImputacion.Text.Equals(_objeto.FormulaImputacion ?? string.Empty) 
                         && ctrlTxtNombre.Text == _objeto.Nombre
                         && ctrlChkActivada.Checked == _objeto.Activado
                         && ctrlChkActualizar.Checked == _objeto.Actualizar
                         && ctrlChkDeudaCuotas.Checked == _objeto.DeudaEnCuotas
                         && ctrlChkUnificar.Checked == _objeto.UnificaGastos
                         && _objeto.TramosTemporales == ctrlChkTemporal.Checked);
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
                _objeto.Nombre = ctrlTxtNombre.Text;
                _objeto.Codigo = ctrlTxtCodigo.Text;
                _objeto.FormulaImputacion = ctrlTxtImputacion.Text;
                _objeto.Activado = ctrlChkActivada.Checked;
                _objeto.Actualizar = ctrlChkActualizar.Checked;
                _objeto.TramosTemporales = ctrlChkTemporal.Checked;
                _objeto.DeudaEnCuotas = ctrlChkDeudaCuotas.Checked;
                _objeto.UnificaGastos = ctrlChkUnificar.Checked;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion
    }
}