///////////////////////////////////////////////////////////
//  WinInicio.cs
//  Implementación de la ventana de inicio de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System.Threading;
using System.Windows.Forms;
using scioBaseLibrary.excepciones;
using scioBaseLibrary.interfases;

namespace scioBaseLibrary.vista {
    /// <summary>
    /// En el 'framework' de trabajo de SCIO, esta clase implementa la 
    /// ventana de inicio del sistema, la cual probablemente muestra un
    /// lindo fondo y los pasos de inicio del sistema. 
    /// </summary>
    public partial class WinInicio : Form, IVistaCuadroInicio {
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
        /// Constructor que inicializa componentes internos.
        /// </summary>
        public WinInicio(IControladorSistema sistema) {
            _sistema = sistema;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
            lblTitulo.Text = sistema.Titulo;
            TransparencyKey = BackColor;
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public void abrir() {
            Show();
            Refresh();
        }

        /// <summary>
        /// Implementación del método de la interfaz.
        /// </summary>
        public void iniciarSistema() {
            Refresh();
            setLabel("Estableciendo parámetros iniciales...");
            Thread.Sleep(500);

            setLabel("Iniciando Log...");
            Refresh();
            Sistema.iniciarLog();

            setLabel("Conectando a Base de Datos...");
            Refresh();
            Sistema.iniciarPersistencia();

            setLabel("Iniciando la ventana principal...");
            Refresh();
            Thread.Sleep(500);
            Close();
        }

        /// <summary>
        /// Este método establece el texto de avance dentro del cuadro.
        /// </summary>
        public void setLabel(string texto) {
            label.Text = texto;
        }
    }
}