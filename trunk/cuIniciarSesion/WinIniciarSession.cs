///////////////////////////////////////////////////////////
//  WinIniciarSession.cs
//  Implementación de la ventana de nuevo inicio de sesion 
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using scioBaseLibrary;
using scioToolLibrary.enums;

namespace cuIniciarSesion {
    /// <summary>
    /// Esta clase implementa la ventana del caso de uso 'Iniciar
    /// Sesion' y completa las tareas descritas en el mismo por 
    /// sobre lo que ya realiza la clase del caso de uso.
    /// </summary>
    public partial class WinIniciarSession : Form {
        private readonly CUIniciarSesion _controlador;

        /// <summary>
        /// Constructor de la clase que primero asigna el padre (CUIniciarSesion)
        /// y luego inicializa la interfaz grafica de la ventana.
        /// </summary>
        /// <param name="controlador">
        /// Un objeto de la clase CUIniciarSesion que representa al padre de
        /// la ventana (el propio caso de uso).
        /// </param>
        public WinIniciarSession(CUIniciarSesion controlador) {
            _controlador = controlador;
            InitializeComponent();
        }

        /// <summary>
        /// Este método se lanza cuando se hace click en el botón
        /// cancelar y se encarga de lanzar el eventode  cierre de 
        /// la ventana.
        /// </summary>
        /// <param name="sender">
        /// El Objeto que lanza el evento manejado.
        /// </param>
        /// <param name="e">
        /// Los argumentos y opciones asociadas al evento manejado.
        /// </param>
        private void bntCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        /// <summary>
        /// Este método se lanza cuando se hace click en el botón 'Iniciar' 
        /// y se encarga de cumplimentar los pasos del caso de uso relativos 
        /// al camino básico de inicio de sesión. Si hay algúna excepción que
        /// se lanza, entonces muestra un mensaje de error.
        /// </summary>
        /// <param name="sender">
        /// El Objeto que lanza el evento manejado.
        /// </param>
        /// <param name="e">
        /// Los argumentos y opciones asociadas al evento manejado.
        /// </param>
        private void btnIniciar_Click(object sender, EventArgs e) {
            if (txtUsuario.Text != null && !txtUsuario.Text.Equals(""))
                try {
                    Cursor = Cursors.WaitCursor;
                    _controlador.iniciarSesion(txtUsuario.Text, txtPass.Text);
                    Close();
                } catch (Exception ex) {
                    Sistema.Controlador.mostrar("SESION-INIT-ERROR", ENivelMensaje.ERROR, ex.ToString(), true);
                    txtPass.Text = "";
                } finally {
                    Cursor = Cursors.Default;
                }
            else Sistema.Controlador.mostrar("SESION-INIT-NODATA", ENivelMensaje.ERROR, null, false);
        }
    }
}