using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace scioReportLibrary {
    /// <summary>
    /// Permite visualizar un reporte. Esta clase solamente es contenedora
    /// de reportes, con lo cual los mismos deben estar generados
    /// antes de asignarlas a esta clase.
    /// </summary>
    public partial class PanelVisorReporte : UserControl {
        /// <summary>
        /// Constructor
        /// </summary>
        public PanelVisorReporte() {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el reporte al visor.
        /// </summary>
        /// <param name="unReporte">Reporte a visualizar</param>
        public void setReporte(ReportDocument unReporte) {
            viewer.ReportSource = unReporte;
            viewer.Refresh();
        }

        private void PanelVisorReporte_Load(object sender, EventArgs e) {
            viewer.Refresh();
        }

        /// <summary>
        /// Carga el panel que contendra los filtros para generar
        /// el listado.
        /// </summary>
        /// <param name="unPanel"></param>
        public void setPanelFiltro(IPanelFiltros unPanel) {
            if (unPanel == null) {
                splitContainer1.Panel1Collapsed = true;
                return;
            }
            var unPnlFiltro = (UserControl) unPanel;
            unPnlFiltro.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(unPnlFiltro);
        }

        public void ocultarPanelFiltro()
        {
            splitContainer1.Panel1Collapsed = true;
        }
    }
}