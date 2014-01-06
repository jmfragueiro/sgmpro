using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using cuGenerarInformes.Reportes;
using scioBaseLibrary;
using scioBaseLibrary.interfases;
using scioPersistentLibrary;
using scioReportLibrary;

namespace cuGenerarInformes
{
    public class CUEstadoCuentaDeudor: IControladorCasoUso, ICUReportes 
    {
        /// <summary>
        /// Tabla con los datos orginales para el reporte.
        /// Sin aplicar ningun filtro
        /// </summary>
        public DataTable TablaBase { get; set; }
        /// <summary>
        /// DataView que contiene los datos con el ultimo
        /// filtro aplicado.
        /// </summary>
        public DataView TablaFiltro { get; set; }
        /// <summary>
        /// Panel de visualización del reporte.
        /// </summary>
        public PanelVisorReporte PanelVisor { get; set; }
        /// <summary>
        /// El padre del caso de uso (quien lo llama o gestiona).
        /// </summary>
        public object Padre { get; set; }
        /// <summary>
        /// La cadena del select primario del reporte
        /// </summary>
        private readonly string _strSql = Properties.Resources.strQryVistaEstadoCtaDeudores;

        public bool iniciar(object padre, params object[] valor)
        {
            #region Modificar en cada implementación
            // Carga los datos iniciales desde la vista correspondiente
            const string TITULO_VENTANA = "Estado de Cuenta del Deudor";
            #endregion

            
          // Crea el panel visor del reporte
            PanelVisor = new PanelVisorReporte {Dock = DockStyle.Fill};
            PanelVisor.ocultarPanelFiltro();

            filtrarDatos(String.Format("Cuenta = '{0}'",(String) valor[1]),valor);

            // Crea y carga la ventana de visualización
            var ventana = new FrmVisualizador();
            ventana.Controls.Add(PanelVisor);
            ventana.Text = TITULO_VENTANA;
            ventana.ShowDialog();

            return false;
        }

        /// <summary>
        /// Implementa el método de la interfaz.
        /// </summary>
        public void aceptarParametros(params object[] valor) { }

        /// <summary>
        /// Devuelve el report document. Se configura 
        /// dependiendo del reporte por incluye la customización
        /// del pasaje de los parámetros correspondientes.
        /// </summary>
        public ReportDocument getReporte(params Object[] parametros)
        {
            var unReporte = new REstadoCuentaDeudor();
            unReporte.SetDataSource(TablaFiltro);
            unReporte.SetParameterValue("Entidad", (String)parametros[0]);
            unReporte.SetParameterValue("Cuenta", (String)parametros[1]);
            unReporte.SetParameterValue("Nombre", (String)parametros[2]);
            unReporte.SetParameterValue("Capital", (Double)parametros[3]);
            unReporte.SetParameterValue("Interes", (Double)parametros[4]);
            unReporte.SetParameterValue("Honorarios", (Double)parametros[5]);
            unReporte.SetParameterValue("Gastos", (Double)parametros[6]);
            unReporte.SetParameterValue("Total", (Double)parametros[7]);
            return unReporte;
        }

        /// <summary>
        /// Filtra los datos en función del filtro enviado
        /// por el Panel Filtro que implementa IPanelFiltro. 
        /// Este metodo es el mismo en todas las implementaciones
        /// de ICUReportes.
        /// </summary>
        public void filtrarDatos(string filtro, params object[] parametros)
        {
            if (TablaBase == null)
                TablaBase = Persistencia.EjecutarSqlSelect(_strSql, Sistema.Controlador.CadenaConexion);

            TablaFiltro = TablaBase.DefaultView;
            TablaFiltro.RowFilter = filtro;

            // Setea el reporte en el visor
            PanelVisor.setReporte(getReporte(parametros));
        }
    }
}
