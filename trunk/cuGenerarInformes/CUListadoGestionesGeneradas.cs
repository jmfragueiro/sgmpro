using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using cuGenerarInformes.Reportes;
using scioBaseLibrary;
using scioBaseLibrary.interfases;
using scioPersistentLibrary;
using scioReportLibrary;

namespace cuGenerarInformes {
    /// <summary>
    /// Genera el listado de gestiones realizadas.
    /// Tiene difrentes filtros: por rango_fechas,
    /// operador, tipo_gestion.
    /// </summary>
    public class CUListadoGestionesGeneradas : IControladorCasoUso, ICUReportes {
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
        public string _STR_SQL = "select * from v_listaGestionesGeneradas where ID = '";

        public bool iniciar(object padre, params object[] valor) {
            #region Modificar en cada implementación
            /// Carga los datos iniciales desde la vista correspondiente
            _STR_SQL += valor[0] + "'";
            const string TITULO_VENTANA = "Gestiones Generadas en una Lista de Gestión";
            #endregion

            /// Crea el panel visor del reporte
            PanelVisor = new PanelVisorReporte();
            PanelVisor.setPanelFiltro(null);

            if (TablaBase == null)
                TablaBase = Persistencia.EjecutarSqlSelect(_STR_SQL, Sistema.Controlador.CadenaConexion);

            ReportDocument unReporte = new RGestionesGeneradas();
            unReporte.SetDataSource(TablaBase);

            /// Setea el reporte en el visor
            PanelVisor.setReporte(unReporte);
            PanelVisor.Dock = DockStyle.Fill;

            /// Crea y carga la ventana de visualización
            FrmVisualizador ventana = new FrmVisualizador {MdiParent = ((Form) padre)};
            ventana.Controls.Add(PanelVisor);
            ventana.Text = TITULO_VENTANA;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();

            return false;
        }

        /// <summary>
        /// Implementa el método de la interfaz.
        /// </summary>
        public void aceptarParametros(params object[] valor) {}

        /// <summary>
        /// Devuelve el report document. Se configura 
        /// dependiendo del reporte por incluye la customización
        /// del pasaje de los parámetros correspondientes.
        /// </summary>
        public ReportDocument getReporte(params Object[] parametros) {
            return null;
        }

        /// <summary>
        /// Filtra los datos en función del filtro enviado
        /// por el Panel Filtro que implementa IPanelFiltro. 
        /// Este metodo es el mismo en todas las implementaciones
        /// de ICUReportes.
        /// </summary>
        public void filtrarDatos(string filtro, params object[] parametros) {}
    }
}