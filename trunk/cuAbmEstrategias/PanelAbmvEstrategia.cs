///////////////////////////////////////////////////////////
//  PanelAbmvEstrategia.cs
//  Implementación del panel ABMV para la entidad Estrategia
//  de la aplicación.
//  Generated Manualmente
//  Created on:      01-sep-2009 12:00:00
//  Original author: Fernando
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using cuAbmPredicado;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.interfaces;
using sgmpro.dominio.configuracion;

namespace cuAbmEstrategia {
    public partial class PanelAbmvEstrategia : PanelABMV<Estrategia> {
        private readonly CUListPredicados _listPredicados;
        private IVistaPanelList _panelPredicados;

        /// <summary>
        ///   Constructor de la clase que inicializa los componentes 
        ///   visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvEstrategia(IControladorEditable<Estrategia> controlador) : base(controlador) {
            try {
                InitializeComponent();

                _listPredicados = new CUListPredicados {
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
                _listPredicados.ObjetoMaster = _objeto;
                _listPredicados.Filtros.Clear();

                cargarDatos();
                cargarTabs();
            } catch (Exception e) {
                throw new DataErrorException("DATA-SETNOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void cargarDatos() {
            try {
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
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
                    _panelPredicados = _listPredicados.getPanelListado(_controlador.ModoVista);
                    _panelPredicados.Contenedor = this;
                    tabPredicados.Controls.Clear();
                    tabPredicados.Controls.Add((Control)_panelPredicados);
                    tabPredicados.Controls["PanelListABMV"].Dock = DockStyle.Fill;
                } else
                    _panelPredicados.refrescarListado(_listPredicados.ColsInvisibles);

                tabPredicados.Text = string.Format("Predicados ({0})", _listPredicados.Cuenta);
                tabPredicados.Refresh();
            } catch (Exception e) {
                throw new DataErrorException("SUBLISTADO-NOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override void actualizarObjeto() {
            try {
                _objeto.Nombre = ctrlTxtNombre.Text;
                _objeto.Descripcion = ctrlTxtDescripcion.Text;
                _objeto.FechaUMod = DateTime.Now;
                _objeto.FechaAlta = DateTime.Now;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return !(ctrlTxtNombre.Text == _objeto.Nombre &&
                         ctrlTxtDescripcion.Text == _objeto.Descripcion);
            } catch (Exception e) {
                throw new DataErrorException("DATA-DIRTYNOK", e.ToString());
            }
        }
        #endregion panelabmv
    }
}