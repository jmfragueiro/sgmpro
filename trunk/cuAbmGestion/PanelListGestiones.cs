///////////////////////////////////////////////////////////
//  PanelListGestiones.cs
//  Implementación del panel de listado para la entidad Gestión
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using cuBandejaEntrada;
using scioBaseLibrary;
using scioBaseLibrary.helpers;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioSecureLibrary.dominio;
using scioSecureLibrary.dominio.repos;
using scioToolLibrary.enums;
using sgmpro.dominio.gestion;
using sgmpro.dominio.gestion.repos;

namespace cuAbmGestion {
    public partial class PanelListGestiones : PanelListABMV<Gestion> {
        private static readonly string _estadoFinal = Parametros.GetByClave("ESTADOGESTION.FINALIZADA").Nombre;
        private static readonly string _estadoCreada = Parametros.GetByClave("ESTADOGESTION.CREADA").Nombre;
        private static readonly Parametro _postal = Parametros.GetByClave("TIPOGESTION.POSTAL");
        private static readonly Parametro _terreno = Parametros.GetByClave("TIPOGESTION.TERRENO");
        private static readonly Parametro _telefonica = Parametros.GetByClave("TIPOGESTION.TELEFONICA");
        private static readonly Parametro _backoffice = Parametros.GetByClave("TIPOGESTION.BACKOFFICE");
        private DataRow _migestion;
        private EModoVentana _modoVista;
        private readonly Timer _timTimer = new Timer();
        private readonly Usuario _usuario;
        protected Gestion _gestion;
        protected long _sesiones, _gestiones, _tiempoGestion, _tiempoInactivo;
        private bool _hayGestion = true;

        /// <summary>
        /// La actual bajo gestión, para marcarla en listado de gestiones.
        /// </summary>
        protected Gestion _gestionActual;

        /// <summary>
        /// Constructor de la clase que primero ejecuta la inicialización
        /// por defecto y luego asigna el controlador asociado al listado
        /// (para agregar, mostrar, editar o borrar). Debería lanzar una
        /// VistaErrorExcetion si hay un problema.
        /// </summary>
        /// <param name="controlador">
        /// El objeto controlador de la ventana.
        /// </param>
        public PanelListGestiones(IControladorListable<Gestion> controlador) : base(controlador) {
            _usuario = Sistema.Controlador.SecurityService.getUsuario();
            _timTimer.Tick += timTimer_Tick;
            _timTimer.Interval = (int) Parametros.GetByClave("GESTION.TIEMPOASIGAUTO").Valorlong*1000;
        }

        /// <summary>
        /// Constructor de la clase que primero ejecuta la inicialización
        /// por defecto y luego asigna el controlador asociado al listado
        /// (para agregar, mostrar, editar o borrar) y además una gestión
        /// actual (para marcarla dentro del listado). Debería lanzar una
        /// VistaErrorExcetion si hay un problema.
        /// </summary>
        /// <param name="controlador">
        /// El objeto controlador de la ventana.
        /// </param>
        /// <param name="gestionActual">
        /// La gestión actualmente bajo gestión.
        /// </param>
        public PanelListGestiones(IControladorListable<Gestion> controlador, Gestion gestionActual) : base(controlador) {
            _gestionActual = gestionActual;
        }

        #region panellist
        /// <summary>
        /// Este método establece el modo en que se visualiza
        /// el listado (qué botones se muestran) de acuerdo al
        /// modo de vista del controlador asociado.
        /// </summary>
        public override void setModoVista() {
            setModoVista(_controlador.ModoVista);
        }

        /// <summary>
        /// Este método establece el modo en que se visualiza
        /// el listado (qué botones se muestran) de acuerdo al
        /// modo de vista del controlador asociado.
        /// </summary>
        public override void setModoVista(EModoVentana modo) {
            // Por las dudas siempre que refresca 
            // el modo de vista, se para el timer
            _timTimer.Stop();

            // Luego setea el modo de vista
            _modoVista = modo;
            switch (modo) {
                case EModoVentana.FULL:
                    setFullView();
                    break;
                case EModoVentana.ADD:
                    setAgregable();
                    break;
                case EModoVentana.GESTION:
                    setGestionable();
                    break;
                default:
                    setReadOnly();
                    break;
            }
        }

        /// <summary>
        /// Este método oculta los botones de acción de la toolbar para
        /// </summary>
        protected override void setReadOnly() {
            base.setReadOnly();

            toolStrip1.Items["btnGestion"].Visible = false;
            toolStrip1.Items["btnImprimir"].Visible = false;
            toolStrip1.Items["btnImprimirTodo"].Visible = false;
            toolStrip1.Items["btnSiguiente"].Visible = false;
            toolStrip1.Items["btnBreak"].Visible = false;

            if (_modoVista != EModoVentana.LIST)
                toolStrip1.Items["btnCuenta"].Visible = false;

            // Luego de establecer el modo de vista verifica permisos
            aplicarListPermisos(toolStrip1, "GESTION");
        }

        /// <summary>
        /// Este método muestra los botones de edicion de la toolbar para
        /// dejar al listado en un modo de full edición (con add y remove).
        /// </summary>
        protected override void setFullView() {
            base.setReadOnly();

            toolStrip1.Items["btnGestion"].Visible = true;
            toolStrip1.Items["btnImprimir"].Visible = true;
            toolStrip1.Items["btnImprimirTodo"].Visible = true;
            toolStrip1.Items["btnCuenta"].Visible = true;
            toolStrip1.Items["btnSiguiente"].Visible = true;
            toolStrip1.Items["btnBreak"].Visible = true;

            if (toolStrip1.Items["btnBreak"].Enabled)
                toolStrip1.Items["btnCuenta"].Enabled = false;

            // Luego de establecer el modo de vista verifica permisos
            aplicarListPermisos(toolStrip1, "GESTION");
        }

        /// <summary>
        /// Este método muestra solo el botón de agregar de la toolbar para
        /// dejar al listado en un modo de Agregable (solamente con add).
        /// </summary>
        protected override void setAgregable() {
            base.setAgregable();

            toolStrip1.Items["btnGestion"].Visible = false;
            toolStrip1.Items["btnImprimir"].Visible = false;
            toolStrip1.Items["btnImprimirTodo"].Visible = false;
            toolStrip1.Items["btnCuenta"].Visible = false;
            toolStrip1.Items["btnSiguiente"].Visible = false;
            toolStrip1.Items["btnBreak"].Visible = false;

            // Luego de establecer el modo de vista verifica permisos
            aplicarListPermisos(toolStrip1, "GESTION");
        }

        /// <summary>
        /// Este método muestra los botones para cuando hay que gestionar.
        /// </summary>
        protected void setGestionable() {
            base.setReadOnly();

            toolStrip1.Items["btnGestion"].Visible = true;
            toolStrip1.Items["btnImprimir"].Visible = true;
            toolStrip1.Items["btnImprimirTodo"].Visible = true;
            toolStrip1.Items["btnCuenta"].Visible = true;
            toolStrip1.Items["btnSiguiente"].Visible = false;
            toolStrip1.Items["btnBreak"].Visible = false;

            // Luego de establecer el modo de vista verifica permisos
            aplicarListPermisos(toolStrip1, "GESTION");
        }

        /// <summary>
        /// Este método es el encargado de ejecutar las tareas necesarias
        /// luego de que se ha ejecutado (y ha finalizado) la acción que
        /// se asocia a un botón del listado.
        /// </summary>
        protected override void postAccion() {
            refrescarListado(_controlador.ColsInvisibles);

            if (_controlador.Padre is IVistaPanelAbmv)
                ((IVistaPanelAbmv)_controlador.Padre).cargarTabs();
            else if (_controlador.Padre is WinTreeConfig)
                ((WinTreeConfig) _controlador.Padre).getControlador()
                    .alActualizarListado(((WinTreeConfig) _controlador.Padre).getNodoSeleccionado());
            else if (_controlador.Padre is WinBandejaEntrada)
                ((WinBandejaEntrada) _controlador.Padre).getControlador()
                    .alActualizarListado(((WinBandejaEntrada) _controlador.Padre).getNodoSeleccionado());

            if (_hayGestion && _controlador.ModoVista == EModoVentana.FULL) {
                btnBreak.Enabled = true;
                btnCuenta.Enabled = false;
                refrescarDatos();
                _timTimer.Start();
            }
        }

        /// <summary>
        /// Este metodo debería ejecutarse al mostrar el listado.
        /// </summary>
        public override void alMostrar(params object[] parametros) {
            refrescarDatos();

            // Si estamos en gestion total => se inicia el timer
            if (_controlador.ModoVista == EModoVentana.FULL)
                _timTimer.Start();
        }

        /// <summary>
        /// Este metodo debería ejecutarse al ocultar el listado.
        /// </summary>
        public override void alOcultar(params object[] parametros) {
            _timTimer.Stop();
        }
        #endregion panellist

        #region helpers
        /// <summary>
        /// Este método refresca la información de estadísticas
        /// </summary>
        protected void refrescarDatos() {
            if (!(ParentForm is WinBandejaEntrada))
                return;

            _sesiones = _gestiones = _tiempoGestion = _tiempoInactivo = 0;
            foreach (Sesion s in Sesiones.GetByUsuarioDia(_usuario, DateTime.Now.Date)) {
                _sesiones++;
                _gestiones += s.Gestiones;
                _tiempoGestion += s.TiempoActivo;
                _tiempoInactivo += s.TiempoInactivo;
            }

            ((WinBandejaEntrada) ParentForm).setSesiones(_sesiones);
            ((WinBandejaEntrada) ParentForm).setGestiones(_gestiones);

            TimeSpan tg = DateTime.Now.AddSeconds(_tiempoGestion) - DateTime.Now;
            ((WinBandejaEntrada) ParentForm).setTiempoGestion(tg);

            TimeSpan ti = DateTime.Now.AddSeconds(_tiempoInactivo) - DateTime.Now;
            ((WinBandejaEntrada) ParentForm).setTiempoInactivo(ti);
        }
        #endregion helpers

        #region interface
        /// <summary>
        /// Este método es llamado cuando se presiona enter sobre el listado.
        /// Fue creado para reaccionar de una forma estándar, y por defecto es
        /// como si fuera un doble click, pero el método puede ser sobrepasado.
        /// </summary>
        protected override void alPresionarEnter() {
            btnGestion.PerformClick();
        }

        /// <summary>
        /// Este método responde al botón Gestion. Debería 'mostrar' 
        /// cualquier error que pudiese ocurrir y no propagar ninguna 
        /// excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        protected void btnGestion_Click(object sender, EventArgs e) {
            if (dgvListado.CurrentRow == null)
                Sistema.Controlador.mostrar("ROW-MUST", ENivelMensaje.ERROR, null, false);
            else
                try {
                    _timTimer.Stop();
                    CUCaller.CallCU("cuGestionar", this, new object[] {(getObjetoActual()).Cuenta, getObjetoActual()});
                } catch (Exception ex) {
                    Sistema.Controlador.mostrar("ACTION-GESTION-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                } finally {
                    postAccion();
                }
        }

        /// <summary>
        /// Este método responde al botón Gestion. Debería 'mostrar' 
        /// cualquier error que pudiese ocurrir y no propagar ninguna 
        /// excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        protected void btnSiguiente_Click(object sender, EventArgs e) {
            btnBreak_Click(sender, e);

            Gestion ges = Gestiones.ObtenerSiguienteGestion(_usuario, new[]{_telefonica, _backoffice});
            if (ges == null) {
                if (_hayGestion) {
                    Sistema.Controlador.mostrar("ERROR-GESTIONESAUTO-NOMORE", ENivelMensaje.INFORMACION, null, false);
                    _hayGestion = false;
                    btnSiguiente.Enabled = false;
                }                
                return;
            }

            try {
                CUCaller.CallCU("cuGestionar", this, new object[] {ges.Cuenta, ges});
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-GESTION-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            } finally {
                postAccion();
            }
        }

        /// <summary>
        /// Este método responde al botón Gestion. Debería 'mostrar' 
        /// cualquier error que pudiese ocurrir y no propagar ninguna 
        /// excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        protected void btnBreak_Click(object sender, EventArgs e) {
            _timTimer.Stop();

            if (btnBreak.Visible)
                btnBreak.Enabled = false;

            if (btnCuenta.Visible)
                btnCuenta.Enabled = true;
        }

        /// <summary>
        /// Este método responde al botón Imprimir Gestion. Debería 'mostrar' 
        /// cualquier error que pudiese ocurrir y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        protected void btnImprimir_Click(object sender, EventArgs e) {
            if (dgvListado.CurrentRow == null)
                Sistema.Controlador.mostrar("ROW-MUST", ENivelMensaje.ERROR, null, false);
            else {
                _timTimer.Stop();
                Gestion gestion = getObjetoActual();
                if (gestion.Tipo.Equals(_postal) || gestion.Tipo.Equals(_terreno))
                    try {
                        CUCaller.CallCU(
                            "cuGenerarInformes.CUGenerarCarta",
                            ParentForm,
                            new object[] {EModoVentana.VIEW, getObjetoActual()});
                    } catch (Exception ex) {
                        Sistema.Controlador.mostrar("ACTION-PRINT-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                    } finally {
                        postAccion();
                    }
                else
                    Sistema.Controlador.mostrar("ERROR-IMPRIMIR-GESTION", ENivelMensaje.ERROR, null, false);
            }
        }

        /// <summary>
        /// Este método responde al botón Imprimir Listado. Debería 'mostrar' 
        /// cualquier error que pudiese ocurrir y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        protected void btnImprimirTodo_Click(object sender, EventArgs e) {
            Sistema.Controlador.mostrar("ACTION-PRINT-NOK", ENivelMensaje.ERROR, null, false);
        }

        /// <summary>
        /// Este método responde al botón Cuenta. Debería 'mostrar' 
        /// cualquier error que pudiese ocurrir y no propagar ninguna 
        /// excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        protected void btnCuenta_Click(object sender, EventArgs e) {
            if (dgvListado.CurrentRow == null)
                Sistema.Controlador.mostrar("ROW-MUST", ENivelMensaje.ERROR, null, false);
            else
                try {
                    CUCaller.CallCU("cuAbmCuenta", this, new object[] {EModoVentana.VIEW, getObjetoActual().Cuenta});
                } catch (Exception ex) {
                    Sistema.Controlador.mostrar("ACTION-VIEW-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
                } finally {
                    postAccion();
                }
        }

        /// <summary>
        /// Este método actual al redibujarse una fila y lo que intenta es
        /// marcar de manera distinta la fila que corresponda con la gestion
        /// actual bajo gestión (de existir una).
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void dgvListado_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) {
            _migestion = ((DataRowView) dgvListado.Rows[e.RowIndex].DataBoundItem).Row;

            if (_gestionActual != null && _migestion["Id"].ToString().Equals(_gestionActual.Id.ToString())) {
                dgvListado.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgvListado.Font, FontStyle.Bold);
                dgvListado.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            } else if (!_migestion["Estado"].ToString().Equals(_estadoFinal)
                       && !_migestion["Estado"].ToString().Equals(_estadoCreada)) {
                dgvListado.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgvListado.Font, FontStyle.Bold);
                dgvListado.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
            }
        }

        /// <summary>
        /// Este método se ejecuta al cumplirse el tiempo del timer.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void timTimer_Tick(object sender, EventArgs e) {
            btnSiguiente_Click(sender, e);
        }
        #endregion interface
    }
}