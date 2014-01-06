using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace scioReportLibrary
{
    /// <summary>
    /// Interfaz que deben implementar los paneles
    /// que contienen los filtros de cada reporte.
    /// </summary>
    public interface IPanelFiltros
    {
        /// <summary>
        /// Setea el control para el manejo del panel
        /// de filtros.
        /// </summary>
        /// <param name="unControl"></param>
        void setControl(ICUReportes unControl);
    }
}
