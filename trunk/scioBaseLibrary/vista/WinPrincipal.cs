///////////////////////////////////////////////////////////
//  WinPrincipal.cs
//  Implementación de la ventana principal de la aplicación
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.helpers;
using scioBaseLibrary.interfases;
using scioBaseLibrary.Properties;
using scioParamLibrary.dominio;
using scioParamLibrary.dominio.repos;
using scioPersistentLibrary;
using scioPersistentLibrary.enums;
using scioToolLibrary;
using scioToolLibrary.enums;

namespace scioBaseLibrary.vista {
    /// <summary>
    /// En el framework de trabajo de SCIO, esta clase implementa la 
    /// ventana principal del sistema, la cual posee un menú, y una
    /// barra de estado, que son construidos y gestionados por ella.
    /// La clase también se encarga de gestionar las selecciones del
    /// menú y presenta un método para mostrar un mensaje en pantalla.
    /// </summary>
    public partial class WinPrincipal : Form, IVistaVentanaPpal {
        #region IVistaVentanaPPal
        /// <summary>
        /// El controlador de sistema para el sistema de quien es la ventana. 
        /// </summary>
        public IControladorSistema Sistema {
            get {
                if (_sistema == null)
                    throw new VistaErrorException("VISTA-NOREADY");
                return _sistema;
            }
        }
        protected IControladorSistema _sistema;

        /// <summary>
        /// Constructor de la clase que primero asigna el padre (un objeto
        /// de la clase Sistema) y luego inicializa la interfaz grafica de 
        /// la ventana, inlcuyendo el menu principal y barra de estado.
        /// </summary>
        public WinPrincipal(IControladorSistema sistema) {
            _sistema = sistema;
            IsMdiContainer = true;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Implementa el método de la interfaz.
        /// </summary>       
        public void setTitulo(string titulo) {
            Text = titulo;
        }

        /// <summary>
        /// Este método maneja la generación del menu para la ventana.
        /// </summary>
        public void setMenu(params object[] parametros) {
            SuspendLayout();
            Sistema.generarMenu(this, _mainMenu, _toolBar);
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// Este método inicializa la barra de estado del sistema colocando
        /// los valores de textos iniciales.
        /// </summary>
        public void setBarraEstado() {
            setAyuda(Mensaje.TextoMensaje("AYUDA-LISTO"));
            setExtra1(Mensaje.TextoMensaje("EXTRA1-INICIAL"));
            setExtra2(Persistencia.Controlador.Nombre);
        }

        /// <summary>
        /// Este método muestra una cadena en la 1ra. sección de la 
        /// barra de estado (pensada para ayudas y tips).
        /// </summary>
        /// <param name="texto">
        /// La cadena a mostrarse en la 1ra. sección de la barra.
        /// </param>
        public void setAyuda(string texto) {
            _stAyuda.Text = texto;
        }

        /// <summary>
        /// Este método muestra una cadena en la 2da. sección de la 
        /// barra de estado (pensada para mostrar el usuario).
        /// </summary>
        /// <param name="texto">
        /// La cadena a mostrarse en la 2da. sección de la barra.
        /// </param>
        public void setExtra1(string texto) {
            _stExtra1.Text = texto;
        }

        /// <summary>
        /// Este método muestra una cadena en la 3ra. sección de la 
        /// barra de estado (pensada para mostrar la base).
        /// </summary>
        /// <param name="texto">
        /// La cadena a mostrarse en la 3ra. sección de la barra.
        /// </param>
        public void setExtra2(string texto) {
            _stExtra2.Text = texto;
        }
        #endregion

        #region helpers
        /// <summary>
        /// Implementa el Método de la Interfaz.
        /// </summary>
        public virtual DialogResult mostrarMensaje(string mensaje, ENivelMensaje nivel, string extra) {
            MessageBoxButtons mb = MessageBoxButtons.OK;
            MessageBoxIcon mi = MessageBoxIcon.Information;

            try {
                if (nivel == ENivelMensaje.ERROR || nivel == ENivelMensaje.FATAL)
                    mi = MessageBoxIcon.Error;

                if (nivel == ENivelMensaje.PREGUNTA) {
                    mb = MessageBoxButtons.YesNo;
                    mi = MessageBoxIcon.Question;
                }

                string miextra = string.Empty;
                if (extra != null) {
                    int pos = extra.LastIndexOf("***");
                    miextra = ((pos > 0) ? extra.Substring(0, pos).Replace("***", string.Empty) : extra);
                }

                string msj = string.Format(
                    "{0}\r\n{1}",
                    Mensaje.TextoMensaje(mensaje).Replace("***", string.Empty) +
                    ((nivel == ENivelMensaje.FATAL)
                         ? "\r\nDebería terminar la operación y salir del Sistema."
                         : string.Empty),
                    miextra);
                DialogResult res = 
                    MessageBox.Show(msj, string.Format("{0}", Mensaje.TextoMensaje("TITULO-SHOW")), mb, mi);

                return res;
            } catch (Exception e) {
                throw new VistaErrorException("MENSAJE-NOK", e.ToString());
            }
        }

        /// <summary>
        /// Este método intenta el cierre de sesión para el usuario. No 
        /// se manejan aquí excepciones por lo que podría volver con un 
        /// AccesoErrorException o un SesionErrorException.
        /// </summary>
        public void cerrarSesion() {
            setAyuda("USUARIO-CERRANDO");
            Sistema.logear("USUARIO-CERRANDO", ENivelMensaje.INFORMACION, null);
            if (Sistema.SecurityService.haySesionActiva())
                Sistema.SecurityService.terminarSesion();
            setMenu();
            setExtra1(Mensaje.TextoMensaje("EXTRA1-INICIAL"));
            setAyuda("AYUDA-LISTO");
        }

        /// <summary>
        /// Este método verifica si se ha seleccionado una opción de menú 
        /// que puede manejarse 'localmente' (desde esta clase), en cuyo
        /// caso lo hace ejecutando el método correspondiente.
        /// </summary>
        /// <param name="opcion">
        /// La opción de menu elegida (guardada en la propiedad 'Tag').
        /// </param>
        /// <returns>
        /// Retorna true si es opcion local (ha sido manejada), sino false.
        /// </returns>
        private bool isOpcionLocal(string opcion) {
            try {
                switch (opcion) {
                    case "cuAcercaDe":
                        EjecutarMenuAcercade();
                        return true;
                    case "cuCerrarSistema":
                        Close();
                        return true;
                    case "cuCerrarSesion":
                        cerrarSesion();
                        return true;
                    case "cuBackupSistema":
                        ejecutarMenuBackup();
                        return true;
                    default:
                        return false;
                }
            } catch (Exception e) {
                Sistema.mostrar("VISTA-MENU-EXE-NOK", ENivelMensaje.ERROR, e.Message, true);
                return true;
            }
        }
        #endregion helpers

        #region opciones locales menu
        /// <summary>
        /// Este método responde a la opción de menu 'Salir del Sistema'
        /// realizando la consulta al usuario correspondiente.
        /// </summary>
        private static void EjecutarMenuAcercade() {
            (new WinAcercaDe { Icon = Resources.icono, Text = Mensaje.TextoMensaje("ACERCADE")}).Show();
        }

        /// <summary>
        /// Este método responde a la opción de menu 'Ejecutar Backup'
        /// realizando la consulta al usuario correspondiente.
        /// </summary>
        private void ejecutarMenuBackup() {
            if (mostrarMensaje("PREGUNTA-BACKUP", ENivelMensaje.PREGUNTA, null) == DialogResult.Yes)
                try {
                    foreach (Parametro par in 
                        Parametros.GetByTipoClaveLike(ETipoParametro.BASE, "COMANDO.BACKUP."))
                        Persistencia.EjecutarSqlSelect(par.Valorstring, Sistema.CadenaConexion);
                    mostrarMensaje("BACKUP-FIN-OK", ENivelMensaje.INFORMACION, null);
                } catch (Exception e) {
                    mostrarMensaje("BACKUP-FIN-NOK", ENivelMensaje.ERROR, e.ToString());
                }
        }
        #endregion opciones locales menu

        #region interfase
        /// <summary>
        /// Delegado encargado de manejar los eventos producidos por la 
        /// selección en las opciones del menú. Primero verifica si no
        /// es una opción que pueda manejarse localmente, sino utiliza 
        /// la clase CUCaller para llamar (via reflexión) al caso de uso
        /// externo generico que haya sido asociado (guardado en la tabla 
        /// Parametro en el campo valorstring) a la opción seleccionada.
        /// </summary>
        /// <param name="who">
        /// La opción de menú (MenuItem) que ha sido seleccionada.
        /// </param>
        /// <param name="e">
        /// El objeto que contiene datos sobre el evento producido.
        /// </param>
        public void subMenuClick(object who, EventArgs e) {
            string item = "Menu Principal";
            try {
                ToolStripItem mi = (ToolStripItem)who;
                string[] cu = mi.Tag.ToString().Split(':');
                item = cu[0];

                // Primero verifica si puede manejar el mensaje de manera
                // local (vía un método propio), si puede lo hace y retorna 
                if (isOpcionLocal((string)mi.Tag))
                    return;

                // Sino, entonces crea una instancia de la clase ejecutor 
                // de casos de uso genericos externos (CUCaller) y ejecuta

                CUCaller.CallCU(item, this, cu);
            } catch {
                Sistema.mostrar("UCCALLER-NOK", ENivelMensaje.ERROR, item, true);
            }
        }

        /// <summary>
        /// Este método se llama a partir del evento de cierre de la 
        /// ventana principal y consulta para ver si debe continuar
        /// </summary>
        /// <param name="e">
        /// Los argumentos y opciones asociados al evento manejado.
        /// </param>
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if (Sistema.mostrar("PREGUNTA-SALIR", ENivelMensaje.PREGUNTA, null, false) == DialogResult.Yes)
                base.OnFormClosing(e);
            else
                e.Cancel = true;
        }

        /// <summary>
        /// Este método se llama luego del fin del evento de cierre de 
        /// la ventana principal y termina de cerrar la aplicación.
        /// </summary>
        /// <param name="e">
        /// Los argumentos y opciones asociados al evento manejado.
        /// </param>
        protected override void OnFormClosed(FormClosedEventArgs e) {
            base.OnFormClosed(e);
            Sistema.logear("APP-INIT-EXIT", ENivelMensaje.INFORMACION, null);
            cerrarSesion();
            Sistema.logear("VISTA-CLOSE", ENivelMensaje.DEBUG, "WinPrincipal");
            Sistema.cerrarSistema();
        }

        /// <summary>
        /// Este método se llama cuando la ventana se muestra por primera vez.
        /// </summary>
        /// <param name="sender">
        /// El que llama al evento.
        /// </param>
        /// <param name="e">
        /// Los argumentos y opciones asociados al evento manejado.
        /// </param>
        private void WinPrincipal_Shown(object sender, EventArgs e) {
            try {
                CUCaller.CallCU("cuIniciarSesion", this);
            } catch {
                Sistema.mostrar("UCCALLER-NOK", ENivelMensaje.ERROR, "Iniciar Sesión", true);
            }
        }
        #endregion interfase
    }
}