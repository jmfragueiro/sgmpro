///////////////////////////////////////////////////////////
//  PanelAbmvPerfil.cs
//  Implementación del panel ABMV para la entidad Perfil
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioPersistentLibrary.acceso;
using scioSecureLibrary.dominio;
using scioSecureLibrary.dominio.repos;

namespace cuConfigurarUsuarios {
    public partial class PanelAbmvPerfil : PanelABMV<Perfil> {
        private readonly CUListSetGenerico<Usuario> _listUsuarios;
        private IVistaPanelList _panelUsuarios;

        /// <summary>
        ///   Constructor de la clase que inicializa los componentes 
        ///   visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvPerfil(IControladorEditable<Perfil> controlador) : base(controlador) {
            try {
                InitializeComponent();

                _listUsuarios = new CUListSetGenerico<Usuario> {
                    Disponibles = RepositorioGenerico<Usuario>.GetAliveAll(),
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
                _listUsuarios.ObjetoMaster = _objeto;
                _listUsuarios.Configurados = Usuarios.GetAliveByPerfil(_objeto);

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
                // Texto
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtDescripcion.Text = _objeto.Descripcion;
                // Booleanos
                ctrlChkActivo.Checked = _objeto.Activado;
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
                    _panelUsuarios = _listUsuarios.getPanelListado(EModoVentana.VIEW);
                    _panelUsuarios.Contenedor = this;
                    tabUsuarios.Controls.Clear();
                    tabUsuarios.Controls.Add((Control)_panelUsuarios);
                    tabUsuarios.Controls["PanelListSet"].Dock = DockStyle.Fill;
                } else
                    _panelUsuarios.refrescarListado(_listUsuarios.ColsInvisibles);

                tabUsuarios.Text = string.Format("Usuarios ({0})", _listUsuarios.Configurados.Count);
                tabUsuarios.Refresh();
            } catch (Exception e) {
                throw new DataErrorException("SUBLISTADO-NOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return !((_objeto.Nombre ?? "") == ctrlTxtNombre.Text
                         && (_objeto.Descripcion ?? "") == ctrlTxtDescripcion.Text
                         && _objeto.Activado == ctrlChkActivo.Checked);
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
                _objeto.Descripcion = ctrlTxtDescripcion.Text;
                _objeto.Activado = ctrlChkActivo.Checked;
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion
    }
}