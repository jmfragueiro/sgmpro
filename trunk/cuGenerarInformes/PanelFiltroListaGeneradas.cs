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
    public partial class PanelFiltroListaGeneradas : UserControl, IPanelFiltros {
        /// <summary>
        /// Controlador. Debe implementar el ICUReportes
        /// </summary>
        private ICUReportes _control;

        /// <summary>
        /// Constructor
        /// </summary>
        public PanelFiltroListaGeneradas() {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los componentes con los valores a filtrar.
        /// </summary>
        private void cargaControles() {
            // Carga los datos iniciales
            string strCnx = Sistema.Controlador.CadenaConexion;

            // Carga el check list de usuarios
            string strSql = "select distinct usuario from v_lista_gestiones where usuario is not null";
            DataTable usuarios = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            for (int i = 0; i < usuarios.Rows.Count; i++)
                chkListaUsuarios.Items.Add(usuarios.Rows[i][0]);

            // Carga el check list de Estados
            strSql = "select distinct estado from v_lista_gestiones where estado is not null";
            DataTable estados = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            for (int i = 0; i < estados.Rows.Count; i++)
                chkEstadosGestion.Items.Add(estados.Rows[i][0]);

            // Carga el check list de Resultados

            // Carga los Picker del fecha con el día de hoy
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;

            // Setea todas las opciones por default
            chkTodosEstado.Checked = true;
            chkTodosTipos.Checked = true;
        }

        /// <summary>
        /// Arma los filtros que se aplicarán para regenerar
        /// el reporte. Depende de cada implementación del 
        /// IPanelFiltros.
        /// </summary>
        /// <returns></returns>
        private string armaFiltro() {
            var sb = new StringBuilder();

            // Filtros de fecha
            sb.Append(string.Format("FechaInicio >= '{0}' ", ((DateTime)dtpFechaDesde.Value).ToShortDateString()));
            sb.Append(string.Format("and FechaInicio <= '{0}' ", ((DateTime)dtpFechaHasta.Value).ToShortDateString()));

            // Si no selecciona ningún filtro, genera una excepción.
            if (chkListaUsuarios.CheckedItems.Count != 0 && chkEstadosGestion.CheckedItems.Count != 0) {
                // Filtros de entidades
                sb.Append("and (");
                foreach (var item in chkListaUsuarios.CheckedItems)
                    sb.Append(string.Format("Usuario = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");

                // Filtros de tipos de pago
                sb.Append("and (");
                foreach (object item in chkEstadosGestion.CheckedItems)
                    sb.Append(string.Format("Estado = '{0}' or ", item));
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
        /// <param name="unControl">ICUReportes</param>
        public void setControl(ICUReportes unControl) {
            // Carga el control
            _control = unControl;
            // Carga los componentes
            cargaControles();
        }

        /// <summary>
        /// Evento del boton Filtrar
        /// </summary>
        private void btnFiltrar_Click(object sender, EventArgs e) {
            try {
                _control.filtrarDatos(armaFiltro(), dtpFechaDesde.Value, dtpFechaHasta.Value);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, @"Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Sistema.Controlador.logear(ex.ToString(), ENivelMensaje.INFORMACION, null);
            }
        }

        /// <summary>
        /// Evento que maneja la seleccion/deseleccion de todos 
        /// los items del listado de Entidades
        /// </summary>
        private void chkTodosEntidades_CheckedChanged(object sender, EventArgs e) {
            // Recorre toda la lista seteando el mismo estado que el
            // check "Todos"
            for (int i = 0; i < chkListaUsuarios.Items.Count; i++)
                chkListaUsuarios.SetItemCheckState(i, chkTodosTipos.CheckState);
        }

        /// <summary>
        /// Evento que maneja la seleccion/deseleccion de todos 
        /// los items del listado de Tipos de Pago
        /// </summary>
        private void chkTodosTipoPago_CheckedChanged(object sender, EventArgs e) {
            for (int i = 0; i < chkEstadosGestion.Items.Count; i++)
                chkEstadosGestion.SetItemCheckState(i, chkTodosEstado.CheckState);
        }
    }
}