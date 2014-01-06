using System;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;

namespace scioReportLibrary
{
    /// <summary>
    /// Interfaz que implementan los CU
    /// que van a generar reportes.
    /// </summary>
    public interface ICUReportes
    {
        /// <summary>
        /// Tabla con los datos orginales para el reporte.
        /// Sin aplicar ningun filtro
        /// </summary>
        DataTable TablaBase { get; set; }
        /// <summary>
        /// DataView que contiene los datos con el ultimo
        /// filtro aplicado.
        /// </summary>
        DataView TablaFiltro { get; set; }
        /// <summary>
        /// Panel de visualización del reporte.
        /// </summary>
        PanelVisorReporte PanelVisor { get; set; }

        /// <summary>
        /// Método que interactua con el PanelFiltro.
        /// Recibe el filtro y los parámetros en caso 
        /// de corresponder, regenera el reporte y
        /// lo vuelve a mostrar.
        /// </summary>
        /// <param name="filtro">Filtro para un DataView</param>
        /// <param name="parametros">Lista de parámetros. Depende de cada reporte.</param>
        void filtrarDatos(String filtro, params Object[] parametros);

        /// <summary>
        /// Devuelve el report document. Se configura 
        /// dependiendo del reporte por incluye la customización
        /// del pasaje de los parámetros correspondientes.
        /// </summary>
        /// <returns>Reporte</returns>
        ReportDocument getReporte(params Object[] parametros);
    }
}