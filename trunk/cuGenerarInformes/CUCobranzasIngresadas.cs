﻿using System;
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
    public class CUCobranzasIngresadas : IControladorCasoUso, ICUReportes {
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
        public const string _STR_SQL = "select * from v_lista_cobranzas";

        /// <summary>
        /// Implementa el método de la interfaz.
        /// </summary>
        public bool iniciar(object padre, params object[] valor) {
            #region Modificar en cada implementación
            // Crea el panel de filtro dorrespondiente
            var pnlFiltro = new PanelFiltroCobranzasIngresadas();
            const string tituloVentana = "Cobranzas Ingresadas";
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
            ventana.Width = 900;
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
            var unReporte = new RCobranzas();
            unReporte.SetDataSource(TablaFiltro);
            unReporte.SetParameterValue("FchDesde", (DateTime) parametros[0]);
            unReporte.SetParameterValue("FchHasta", (DateTime) parametros[1]);
            return unReporte;
        }

        /// <summary>
        /// Filtra los datos en función del filtro enviado
        /// por el Panel Filtro que implementa IPanelFiltro. 
        /// Este metodo es el mismo en todas las implementaciones
        /// de ICUReportes.
        /// </summary>
        public void filtrarDatos(String filtro, params Object[] parametros) {
            if (TablaBase == null)
                TablaBase = Persistencia.EjecutarSqlSelect(_STR_SQL, Sistema.Controlador.CadenaConexion);

            TablaFiltro = TablaBase.DefaultView;
            TablaFiltro.RowFilter = filtro;

           // Setea el reporte en el visor
            PanelVisor.setReporte(getReporte(parametros));
        }

        // Setea a los pagos seleccionados de acuerdo al boton de Rendidos
        public void setRendidos(Int32 rnd, DateTime fchRnd)
        {
            if (TablaFiltro.Count.Equals(0)) return;
            
            var builder = new StringBuilder();
            builder.Append(String.Format("update pago set pag_rendido = {0},pag_fecharend = '{1}' where pag_id in (",rnd,fchRnd.ToShortDateString()));
            foreach (DataRowView dataRowView in TablaFiltro)
            {
                builder.Append(String.Format("'{0}',", dataRowView["Id"]));
                // Actualiza el reporte
                dataRowView["Rendido"] = rnd;
                dataRowView["FechaRend"] = fchRnd;
            }
            builder.Append(")");
            var strsql = builder.ToString().Replace(",)", ")");
            Persistencia.EjecutarSqlDML(strsql, Sistema.Controlador.CadenaConexion);
        }
    }
}