using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using scioBaseLibrary;
using scioPersistentLibrary;
using scioReportLibrary;
using scioToolLibrary;
using scioToolLibrary.enums;

namespace cuGenerarInformes {
    /// <summary>
    /// Panel que contiene los filtros correspondientes al 
    /// Reporte de Cobranzas ingresadas.
    /// Implementa la Interfaz IPanelFiltros.
    /// </summary>
    public partial class PanelFiltroCobranzasConsolidado : UserControl, IPanelFiltros {
        /// <summary>
        /// Controlador. Debe implementar el ICUReportes
        /// </summary>
        private ICUReportes _control;

        /// <summary>
        /// Constructor
        /// </summary>
        public PanelFiltroCobranzasConsolidado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los componentes con los valores a filtrar.
        /// </summary>
        private void cargaControles() {
            string strCnx = Sistema.Controlador.CadenaConexion;

            // Carga el check list de clientes
            const string strSql = "select distinct cliente from v_lista_cobranzas_consolidado";
            var clientes = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            for (int i = 0; i < clientes.Rows.Count; i++)
                chkListaEntidades.Items.Add(clientes.Rows[i][0]);

            ///// Carga el check list de Tipo de pago
            //strSql = "select distinct par_nombre as Tipo from parametro p " +
            //            "inner join Pago g on g.pag_tipo = p.par_id " +
            //                "and par_nombre <> 'HONORARIOS' and par_nombre <> 'GASTOS'";
            //DataTable conceptos = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            //for (int i = 0; i < conceptos.Rows.Count; i++)
            //    chkTipoPago.Items.Add(conceptos.Rows[i][0]);

            // Carga las fechas actuales
            dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Today;  

            //Marca todas las entidades y tipos de pago por default
            chkTodosEntidades.Checked = true;
            chkTodosTipoPago.Checked = true;
        }

        /// <summary>
        /// Arma los filtros que se aplicarán para regenerar
        /// el reporte. Depende de cada implementación del 
        /// IPanelFiltros.
        /// </summary>
        private string armaFiltro() {
            var sb = new StringBuilder();

            /// Filtro de período
            sb.Append(String.Format(" where Pago >= '{0}' and Pago <= '{1}'", 
                    ((DateTime) dtpFechaDesde.Value).ToShortDateString(),
                    ((DateTime)dtpFechaHasta.Value).AddDays(1).Date.ToShortDateString()));

            /// Si no selecciona ningún filtro, genera una excepción.
            if (chkListaEntidades.CheckedItems.Count != 0 )
            {
                /// Filtros de entidades
                sb.Append(" and (");
                foreach (object item in chkListaEntidades.CheckedItems)
                    sb.Append(string.Format("Cliente = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");

                return sb.ToString();
            }

            throw new Exception(Mensaje.TextoMensaje("REPORTE-NOFILTRO"));
        }

        /// <summary>
        /// Setea el control para el manejo del panel
        /// de filtros.
        /// </summary>
        public void setControl(ICUReportes unControl) {
            /// Carga el control
            _control = unControl;
            /// Carga los componentes
            cargaControles();
        }

        /// <summary>
        /// Evento del boton Filtrar
        /// </summary>
        private void btnFiltrar_Click(object sender, EventArgs e) {
            Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("REPORTE-AYUDA"));
            Cursor = Cursors.WaitCursor;

            try {
                _control.filtrarDatos(armaFiltro(),dtpFechaDesde.Value,dtpFechaHasta.Value);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("REPORTE-ERROR", ENivelMensaje.ERROR, ex.ToString(), true);
            } finally {
                Cursor = Cursors.Default;
                Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("AYUDA-LISTO"));
            }
        }

        /// <summary>
        /// Evento que maneja la seleccion/deseleccion de todos 
        /// los items del listado de Entidades
        /// </summary>
        private void chkTodosEntidades_CheckedChanged(object sender, EventArgs e) {
            /// Recorre toda la lista seteando el mismo estado que el
            /// check "Todos"
            for (int i = 0; i < chkListaEntidades.Items.Count; i++)
                chkListaEntidades.SetItemCheckState(i, chkTodosEntidades.CheckState);
        }
    }
}