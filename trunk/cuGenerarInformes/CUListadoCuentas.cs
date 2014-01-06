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
    public class CUListadoCuentas : IControladorCasoUso, ICUReportes {
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
        public const string STR_SQL = "select * from v_lista_cuentas";

        /// <summary>
        /// Implementa el método de la interfaz.
        /// </summary>
        public bool iniciar(object padre, params object[] valor) {
            #region Modificar en cada implementación
            /// Crea el panel de filtro dorrespondiente
            PanelFiltroListaCuentas pnlFiltro = new PanelFiltroListaCuentas();
            const string TITULO_VENTANA = "Estado de Cuentas";
            #endregion

            /// Setea el control al panel de filtro
            pnlFiltro.setControl(this);

            /// Crea el panel visor del reporte
            PanelVisor = new PanelVisorReporte();
            PanelVisor.setPanelFiltro(pnlFiltro);
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
            bool detalle = (bool) parametros[0];
            ReportDocument unReporte;
            
            if (detalle)
                unReporte =  new RCuentas();
            else
                unReporte = new RResumenCuentas();

            unReporte.SetDataSource(TablaFiltro);
            return unReporte;
        }

        /// <summary>
        /// Filtra los datos en función del filtro enviado
        /// por el Panel Filtro que implementa IPanelFiltro. 
        /// Este metodo es el mismo en todas las implementaciones
        /// de ICUReportes.
        /// </summary>
        public void filtrarDatos(string filtro, params object[] parametros) {
            if (TablaBase == null)
                TablaBase = Persistencia.EjecutarSqlSelect(STR_SQL, Sistema.Controlador.CadenaConexion);

            TablaFiltro = TablaBase.DefaultView;
            TablaFiltro.RowFilter = filtro;

            // Setea el reporte en el visor
            PanelVisor.setReporte(getReporte(parametros));
        }
    }
}