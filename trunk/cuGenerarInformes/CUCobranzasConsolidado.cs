using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using cuGenerarInformes.Reportes;
using scioBaseLibrary;
using scioBaseLibrary.interfases;
using scioPersistentLibrary;
using scioReportLibrary;

namespace cuGenerarInformes
{
    /// <summary>
    /// Genera el reporte para las cobranzas ingresadas en un determinado rango de fechas
    /// Permite filtrar por Fechas límites y por cliente.
    /// </summary>
    public class CUCobranzasConsolidado : IControladorCasoUso, ICUReportes
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
        //public const string _STR_SQL = "select * from v_lista_cobranzas_consolidado as l";
        public const string _STR_SQL = "select l.Cliente,sum(l.Anticipo) Anticipo,sum(l.Cuota) Cuota,sum(l.PagoParcial) PagoParcial, "+
                                       "sum(l.Cancelacion) Cancelacion,sum(l.Canc_c_quita) Canc_c_quita,sum(l.Pago_Suc) Pago_Suc, "+
                                       "sum(l.Dep_Bancario) Dep_Bancario,sum(l.Dep_Judicial) Dep_Judicial,sum(l.Otros) Otros from v_lista_cobranzas_consolidado l ";
        /// <summary>
        /// Implementa el método de la interfaz.
        /// </summary>
        public bool iniciar(object padre, params object[] valor)
        {
            #region Modificar en cada implementación
            /// Crea el panel de filtro dorrespondiente
            var pnlFiltro = new PanelFiltroCobranzasConsolidado();
            const string tituloVentana = "Cobranzas Mensuales Consolidadas";
            #endregion

            /// Setea el control al panel de filtro
            pnlFiltro.setControl(this);

            /// Crea el panel visor del reporte
            PanelVisor = new PanelVisorReporte();
            PanelVisor.setPanelFiltro(pnlFiltro);
            PanelVisor.Dock = DockStyle.Fill;

            /// Crea y carga la ventana de visualización
            var ventana = new FrmVisualizador { MdiParent = ((Form)padre) };
            ventana.Controls.Add(PanelVisor);
            ventana.Text = tituloVentana;
            ventana.Show();

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
            var unReporte = new RCobranzasConsolidado();
            unReporte.SetDataSource(TablaFiltro);
            //unReporte.SetParameterValue("TipoPago", parametros[0].ToString());
            unReporte.SetParameterValue("Desde", parametros[0].ToString());
            unReporte.SetParameterValue("Hasta", parametros[1].ToString());
            return unReporte;
        }

        /// <summary>
        /// Filtra los datos en función del filtro enviado
        /// por el Panel Filtro que implementa IPanelFiltro. 
        /// Este metodo es el mismo en todas las implementaciones
        /// de ICUReportes.
        /// </summary>
        public void filtrarDatos(String filtro, params Object[] parametros)
        {
            var sb = new StringBuilder();
            sb.Append(_STR_SQL);
            sb.Append(filtro);
            sb.Append(" group by l.Cliente");

            //if (TablaBase == null)
            TablaBase = Persistencia.EjecutarSqlSelect(sb.ToString(), Sistema.Controlador.CadenaConexion);

            TablaFiltro = TablaBase.DefaultView;
            //TablaFiltro.RowFilter = filtro;

            /// Setea el reporte en el visor
            PanelVisor.setReporte(getReporte(parametros));
        }
    }
}
