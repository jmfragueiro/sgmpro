///////////////////////////////////////////////////////////
//  PanelAbmvRol.cs
//  Implementación del panel ABMV para la entidad Rol
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
using scioPersistentLibrary.criterios;
using scioSecureLibrary.dominio;
using scioSecureLibrary.dominio.repos;

namespace cuConfigurarUsuarios {
    public partial class PanelAbmvRol : PanelABMV<Rol> {
        private readonly CUListSetGenerico<Permiso> _listPermisos;
        private readonly CUListSetRol _listRoles;
        private readonly CUListSetGenerico<Usuario> _listUsuarios;
        private IVistaPanelList _panelPermisos, _panelUsuarios, _panelRoles;

        /// <summary>
        ///   Constructor de la clase que inicializa los componentes 
        ///   visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvRol(IControladorEditable<Rol> controlador) : base(controlador) {
            try {
                InitializeComponent();

                _listRoles = new CUListSetRol {
                    Padre = this
                };

                _listPermisos = new CUListSetGenerico<Permiso> {
                    Disponibles = Permisos.OrdenarPorNombre(RepositorioGenerico<Permiso>.GetAliveAll()),
                    Padre = this
                };

                _listUsuarios = new CUListSetGenerico<Usuario> {
                    Disponibles = Usuarios.OrdenarPorNombre(RepositorioGenerico<Usuario>.GetAliveAll()),
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
                _listPermisos.ObjetoMaster
                    = _listRoles.ObjetoMaster
                      = _listUsuarios.ObjetoMaster
                        = _objeto;

                _listRoles.Disponibles = RepositorioGenerico<Rol>.GetByCriteria(
                    true,
                    new[] {Criterios.Distinto("Id", _objeto.Id)},
                    null);

                _listRoles.Configurados = _objeto.Roles;
                _listPermisos.Configurados = _objeto.Permisos;
                _listUsuarios.Configurados = Usuarios.GetAliveByRol(_objeto);

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
                    _panelPermisos = _listPermisos.getPanelListado(_controlador.ModoVista);
                    _panelPermisos.Contenedor = this;
                    tabPermisos.Controls.Add((Control)_panelPermisos);
                    tabPermisos.Controls["PanelListSet"].Dock = DockStyle.Fill;

                    _panelRoles = _listRoles.getPanelListado(_controlador.ModoVista);
                    _panelRoles.Contenedor = this;
                    tabRoles.Controls.Clear();
                    tabRoles.Controls.Add((Control)_panelRoles);
                    tabRoles.Controls["PanelListSet"].Dock = DockStyle.Fill;

                    _panelUsuarios = _listUsuarios.getPanelListado(EModoVentana.VIEW);
                    _panelUsuarios.Contenedor = this;
                    tabUsuarios.Controls.Clear();
                    tabUsuarios.Controls.Add((Control)_panelUsuarios);
                    tabUsuarios.Controls["PanelListSet"].Dock = DockStyle.Fill;
                } else {
                    _panelPermisos.refrescarListado(_listPermisos.ColsInvisibles);
                    _panelRoles.refrescarListado(_listRoles.ColsInvisibles);
                    _panelUsuarios.refrescarListado(_listUsuarios.ColsInvisibles);
                }

                tabRoles.Text = string.Format("Roles ({0})", _objeto.Roles.Count);
                tabPermisos.Refresh();
                tabPermisos.Text = string.Format("Permisos ({0})", _objeto.Permisos.Count);
                tabRoles.Refresh();
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