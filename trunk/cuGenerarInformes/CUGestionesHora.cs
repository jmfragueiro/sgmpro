using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using cuGenerarInformes.Reportes;
using scioBaseLibrary;
using scioBaseLibrary.interfases;
using scioPersistentLibrary;
using scioReportLibrary;

namespace cuGenerarInformes {
    /// <summary>
    /// Genera el reporte para las cobranzas ingresadas.
    /// Permite filtrar por Fechas límites y por cliente.
    /// </summary>
    public class CUGestionesHora : IControladorCasoUso, ICUReportes {
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
        public string _strSql = String.Empty;

        /// <summary>
        /// Implementa el método de la interfaz.
        /// </summary>
        public bool iniciar(object padre, params object[] valor) {
            #region Modificar en cada implementación
            
            // Carga el la consulta
            var sb = new StringBuilder();
            sb.Append("select u.usu_empleado Usuario, ");
            sb.Append("datepart (hh,g.ges_fechacierre) Hora,");
            sb.Append("case when (datediff(mi,(select max(t.ges_fechacierre)from gestion t where g.ges_usuario = t.ges_usuario and t.ges_fechacierre < g.ges_fechacierre),g.ges_fechainicio)>59) then datepart(mi,g.ges_fechainicio) else (datediff(mi,(select max(t.ges_fechacierre) from gestion t where g.ges_usuario = t.ges_usuario and t.ges_fechacierre < g.ges_fechacierre),g.ges_fechainicio)) end SinGestion,");
            sb.Append("datediff(mi, g.ges_fechainicio, g.ges_fechacierre) EnGestion,");
            sb.Append("(case when datediff(mi, g.ges_fechainicio, g.ges_fechacierre) > 5 then 1 else 0 end) Cuentas ");
            sb.Append("from gestion g ");
            sb.Append("inner join Usuario u on g.ges_usuario = u.usu_id ");
            //sb.Append("where g.ges_fechacierre >= convert(datetime,'14/07/2010',103) ");
            //sb.Append("and g.ges_fechacierre < convert(datetime,'15/07/2010',103)");
            //sb.Append("order by g.ges_fechacierre");
            _strSql = sb.ToString();


            // Crea el panel de filtro correspondiente
            var pnlFiltro = new PanelFiltroGestionesHora();
            const string tituloVentana = "Resumen de Gestiones Diarias x Hora";
            #endregion

            // Setea el control al panel de filtro
            pnlFiltro.setControl(this);

            // Crea el panel visor del reporte
            PanelVisor = new PanelVisorReporte();
            PanelVisor.setPanelFiltro(pnlFiltro);
            PanelVisor.Dock = DockStyle.Fill;

            // Crea y carga la ventana de visualización
            var ventana = new FrmVisualizador {MdiParent = ((Form) padre)};
            ventana.Controls.Add(PanelVisor);
            ventana.Text = tituloVentana;
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
        public ReportDocument getReporte(params Object[] parametros)
        {
            var unReporte = new RGestionesHora();
            unReporte.SetDataSource(TablaFiltro);
            unReporte.SetParameterValue("Fecha", (DateTime) parametros[0]);
            return unReporte;
        }

        /// <summary>
        /// Filtra los datos en función del filtro enviado
        /// por el Panel Filtro que implementa IPanelFiltro. 
        /// Este metodo es el mismo en todas las implementaciones
        /// de ICUReportes.
        /// </summary>
        public void filtrarDatos(String filtro, params Object[] parametros) {
            
                // En este caso se inserta el filtro en la consulta principal
                var qry = _strSql;
                qry += filtro;
                TablaBase = Persistencia.EjecutarSqlSelect(qry, Sistema.Controlador.CadenaConexion);
            

            TablaFiltro = TablaBase.DefaultView;
            //TablaFiltro.RowFilter = filtro;

            // Setea el reporte en el visor
            PanelVisor.setReporte(getReporte(parametros));
        }
    }
}