///////////////////////////////////////////////////////////
//  PanelAbmvEntidad.cs
//  Implementación del panel ABMV para la entidad Usuario
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.excepciones;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioPersistentLibrary;
using scioPersistentLibrary.acceso;
using scioPersistentLibrary.orden;
using scioSecureLibrary.dominio;
using scioToolLibrary;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;
using sgmpro.dominio.configuracion.repos;

namespace cuConfigurarUsuarios {
    public partial class PanelAbmvUsuario : PanelABMV<Usuario>, IControladorWinList {
        protected WinSelect<Usuario> _wsu;
        protected WinListConAccionExtra<Cuenta> _wlc;
        private readonly CUListSesiones _listSesiones;
        private readonly CUListSetGenerico<Perfil> _listPerfiles;
        private readonly CUListSetRol _listRoles;
        private IVistaPanelList _panelSesiones, _panelRoles, _panelPerfiles;

        /// <summary>
        ///   Constructor de la clase que inicializa los componentes 
        ///   visuales y luego carga los datos del objeto a mostrar.
        /// </summary>
        public PanelAbmvUsuario(IControladorEditable<Usuario> unControlador) : base(unControlador) {
            try {
                InitializeComponent();

                _listSesiones = new CUListSesiones {Padre = this};
                _listSesiones.Ordenamiento.Add(Orden.Desc("FechaLogon"));

                _listRoles = new CUListSetRol {
                    Disponibles = RepositorioGenerico<Rol>.GetAliveAll(),
                    Padre = this
                };

                _listPerfiles = new CUListSetGenerico<Perfil> {
                    Disponibles = RepositorioGenerico<Perfil>.GetAliveAll(),
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
                _listSesiones.ObjetoMaster =
                    _listRoles.ObjetoMaster =
                    _listPerfiles.ObjetoMaster =
                    _objeto;

                _listSesiones.Filtros.Clear();

                _listRoles.Configurados = _objeto.Roles;
                _listPerfiles.Configurados = _objeto.Perfiles;

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
                ctrlTxtLegajo.Text = _objeto.Legajo.ToString();
                ctrlTxtNombre.Text = _objeto.Nombre;
                ctrlTxtEmpleado.Text = _objeto.Empleado;
                ctrlTxtPassword.Text = _objeto.Password;
                txtFechaUMod.Text = (_objeto.FechaUMod == Fechas.FechaNull)
                                        ? ""
                                        : _objeto.FechaUMod.ToString();
                lblCuentas.Text = string.Format(
                    "El Usuario posee {0} cuentas asignadas.", Cuentas.CountByGestor(_objeto));
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
                    _panelSesiones = _listSesiones.getPanelListado(EModoVentana.VIEW);
                    _panelSesiones.Contenedor = this;
                    tabSesiones.Controls.Add((Control)_panelSesiones);
                    tabSesiones.Controls["PanelListABMV"].Dock = DockStyle.Fill;

                    _panelPerfiles = _listPerfiles.getPanelListado(_controlador.ModoVista);
                    _panelPerfiles.Contenedor = this;
                    tabPerfiles.Controls.Add((Control)_panelPerfiles);
                    tabPerfiles.Controls["PanelListSet"].Dock = DockStyle.Fill;

                    _panelRoles = _listRoles.getPanelListado(_controlador.ModoVista);
                    _panelRoles.Contenedor = this;
                    tabRoles.Controls.Add((Control)_panelRoles);
                    tabRoles.Controls["PanelListSet"].Dock = DockStyle.Fill;
                } else {
                    _panelSesiones.refrescarListado(_listSesiones.ColsInvisibles);
                    tabSesiones.Refresh();

                    _panelPerfiles.refrescarListado(_listPerfiles.ColsInvisibles);
                    tabPerfiles.Refresh();

                    _panelRoles.refrescarListado(_listRoles.ColsInvisibles);
                    tabRoles.Refresh();
                }

                tabSesiones.Text = string.Format("Sesiones ({0})", _listSesiones.Cuenta);
                tabPerfiles.Text = string.Format("Perfiles ({0})", _objeto.Perfiles.Count);
                tabRoles.Text = string.Format("Roles ({0})", _objeto.Roles.Count);
            } catch (Exception e) {
                throw new DataErrorException("SUBLISTADO-NOK", e.ToString());
            }
        }

        /// <summary>
        ///   Ver descripción en clase base.
        /// </summary>
        public override bool isDirty() {
            try {
                return !(_objeto.Legajo.ToString() == ctrlTxtLegajo.Text
                         && (_objeto.Nombre ?? "") == ctrlTxtNombre.Text
                         && (_objeto.Empleado ?? "") == ctrlTxtEmpleado.Text
                         && (_objeto.Password ?? "") == ctrlTxtPassword.Text
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
                _objeto.Legajo = Convert.ToUInt32(ctrlTxtLegajo.Text);
                _objeto.Nombre = ctrlTxtNombre.Text;
                _objeto.Empleado = ctrlTxtEmpleado.Text;
                _objeto.Activado = ctrlChkActivo.Checked;
                _objeto.FechaUMod = DateTime.Now;

                // Por el tema de la encriptación solo debo modificar
                // el password si realmente esto ha sucedido en el panel
                if (!(ctrlTxtPassword.Text.Equals(_objeto.Password ?? "")))
                    _objeto.setCryptPassword(ctrlTxtPassword.Text);
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion

        #region helpers
        private void aplicarCambiosGestion(Usuario user) {
            try {
                string sql = "update cuenta " +
                             " set cta_gestor = " + (user != null ? ("'" + user.Id + "'") : "null") +
                             " where cta_gestor    = '" + _objeto.Id + "'";
                long res2 = Persistencia.EjecutarSqlDML(sql, Persistencia.Controlador.CadenaConexion);

                string descripcion = (user != null
                                          ? "Se pasaron " + res2 + " cuentas gestionadas por " + _objeto
                                            + " al usuario: " + user.Nombre
                                          : "Se quito la marca de gestion a " + res2 + " cuentas asignadas al usuario "
                                            + _objeto.Nombre);

                Sistema.Controlador.mostrar("PROCESO-OK", ENivelMensaje.INFORMACION, descripcion, true);
            } catch (Exception e) {
                Sistema.Controlador.logear("ERROR-NO-CHANGE-GESTOR", ENivelMensaje.ERROR, e.ToString());
                throw new DataErrorException("ERROR-NO-CHANGE-GESTOR");
            }
        }
        #endregion

        #region interface
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
        ///   Este método responde al botón Cambiar cuentas a otro Gestor. 
        ///   Debería 'mostrar' cualquier error que ocurriese y no propagar 
        ///   ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlChangeGestor_Click(object sender, EventArgs e) {
            try {
                if (Sistema.Controlador.mostrar("PREGUNTA-NOUNDO-ACTION", ENivelMensaje.PREGUNTA, null, false)
                    == DialogResult.Yes) {
                    aplicarCambiosGestion((Usuario)txtGestor.Tag);
                    txtGestor.Tag = null;
                    txtGestor.Text = null;
                    lblCuentas.Text = "El Usuario posee 0 cuentas asignadas.";
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
                if (Sistema.Controlador.mostrar("PREGUNTA-NOUNDO-ACTION", ENivelMensaje.PREGUNTA, null, false)
                    == DialogResult.Yes) {
                    aplicarCambiosGestion(null);
                    txtGestor.Tag = null;
                    txtGestor.Text = null;
                    lblCuentas.Text = "El Usuario posee 0 cuentas asignadas.";
                }
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), false);
            }
        }

        /// <summary>
        ///   Este método responde al botón Ver Cuentas. Debería 'mostrar' 
        ///   cualquier error que ocurriese y no propagar ninguna excepción.
        /// </summary>
        /// <param name = "sender">
        ///   El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name = "e">
        ///   Los argumentos del evento lanzado por el componente.
        /// </param>
        private void ctrlListCuentas_Click(object sender, EventArgs e) {
            try {
                if (_wlc == null)
                    _wlc = new WinListConAccionExtra<Cuenta>("cuAbmCuenta.CUListCuentas", this);

                _wlc.getControlador().ObjetoMaster = _objeto;
                _wlc.ShowDialog();
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-COMPLETE-NOK", ENivelMensaje.ERROR, ex.ToString(), false);
            }
        }
        #endregion interface

        # region IControladorWinList
        public string getNombreAccionExtra() {
            return "Desasignar";
        }

        public void ejecutarAccion(params object[] parametros) {
            try {
                if (parametros[0] is Cuenta) {
                    ((Cuenta)parametros[0]).Gestor = null;
                    ((Cuenta)parametros[0]).save();
                }
            } catch (Exception e) {
                throw new DataErrorException("DATA-UPDATENOK", e.ToString());
            }
        }
        #endregion
    }
}