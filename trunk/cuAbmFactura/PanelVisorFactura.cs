using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using cuAbmFactura.Reportes;

namespace cuAbmFactura
{
    public partial class PanelVisorFactura : UserControl
    {
        public PanelVisorFactura()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Setea el report viewer con el reporte recibido como 
        /// parametro
        /// </summary>
        /// <param name="unReporte"></param>
        public void setReporte(ReportDocument unReporte)
        {
            this.viewer.ReportSource = unReporte;
        }
    }
}
