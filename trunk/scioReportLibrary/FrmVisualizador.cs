using System;
using System.Windows.Forms;

namespace scioReportLibrary
{
    /// <summary>
    /// Ventana para la visualización de los reportes.
    /// </summary>
    public partial class FrmVisualizador : Form
    {
        public FrmVisualizador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor que admite la asignación del nombre
        /// del formulario
        /// </summary>
        /// <param name="caption"></param>
        public FrmVisualizador(String caption)
        {
            InitializeComponent();
            Text = caption;
        }

        private void FrmVisualizador_Load(object sender, EventArgs e)
        {
        }
    }
}