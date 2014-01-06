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
    public partial class PanelFiltroListaGestiones : UserControl, IPanelFiltros {
        /// <summary>
        /// Controlador. Debe implementar el ICUReportes
        /// </summary>
        private ICUReportes _control;

        /// <summary>
        /// Constructor
        /// </summary>
        public PanelFiltroListaGestiones() {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el combo del tipo de gestion. Este combo se carga primero
        /// antes que lo demas controles porque todos se alimentan del 
        /// valor del este.
        /// </summary>
        private void cargaComboTipo() {
            // Carga los datos iniciales
            string strCnx = Sistema.Controlador.CadenaConexion;
            // Carga el combo de tipos de gestion
            const string strSql = "select distinct(par_nombre) from parametro where par_clave like 'TIPOGESTION%' order by par_nombre";
            DataTable tipoGestiones = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            for (int i = 0; i < tipoGestiones.Rows.Count; i++)
                cmbTipoGestion.Items.Add(tipoGestiones.Rows[i][0]);
        }

        /// <summary>
        /// Carga los componentes con los valores a filtrar.
        /// </summary>
        private void cargaControles() {
            // Carga los datos iniciales
            string strCnx = Sistema.Controlador.CadenaConexion;
            string strSql;

            // Carga el check list de usuarios
            if (chkListaUsuarios.Items.Count <= 0) {
                strSql = "select distinct(usu_empleado) from usuario order by usu_empleado";
                DataTable usuarios = Persistencia.EjecutarSqlSelect(strSql, strCnx);
                for (int i = 0; i < usuarios.Rows.Count; i++)
                    chkListaUsuarios.Items.Add(usuarios.Rows[i][0]);
            }

            // Carga el check list de Estados
            if (chkEstadosGestion.Items.Count <= 0) {
                strSql = "select distinct(par_nombre) from parametro where par_clave like 'ESTADOGESTION%' order by par_nombre";
                DataTable estados = Persistencia.EjecutarSqlSelect(strSql, strCnx);
                for (int i = 0; i < estados.Rows.Count; i++)
                    chkEstadosGestion.Items.Add(estados.Rows[i][0]);
            }

            // Carga el check list de Resultados
            if (chkResultados.Items.Count <= 0) {
                strSql = "select distinct(par_nombre) from parametro where par_clave like 'RESULTADOGESTION%' order by par_nombre";
                DataTable resultados = Persistencia.EjecutarSqlSelect(strSql, strCnx);
                for (int i = 0; i < resultados.Rows.Count; i++)
                    chkResultados.Items.Add(resultados.Rows[i][0]);
            }

            // Carga los Picker del fecha con el día de hoy
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;

            // Setea todas las opciones por default
            chkTodosEstado.Checked = true;
            chkTodoResultados.Checked = true;
            chkTodosUsuarios.Checked = true;
        }

        /// <summary>
        /// Arma los filtros que se aplicarán para regenerar
        /// el reporte. Depende de cada implementación del 
        /// IPanelFiltros.
        /// </summary>
        private string armaFiltro() {
            var sb = new StringBuilder();

            // Filtros de fecha
            sb.Append(string.Format("FechaInicio >= '{0}' ", 
                ((DateTime)dtpFechaDesde.Value).Date.ToShortDateString()));
            sb.Append(string.Format("and FechaInicio <= '{0}' ",
                ((DateTime)dtpFechaHasta.Value).AddDays(1).Date.ToShortDateString()));

            // Si no selecciona ningún filtro, genera una excepción.
            if (chkListaUsuarios.CheckedItems.Count != 0 &&
                chkEstadosGestion.CheckedItems.Count != 0) {
                // Filtros de usuarios
                sb.Append(" and (");
                foreach (object item in chkListaUsuarios.CheckedItems)
                    sb.Append(string.Format("Usuario = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");

                // Filtros de estados de gestion
                sb.Append(" and (");
                foreach (object item in chkEstadosGestion.CheckedItems)
                    sb.Append(string.Format("Estado = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");
            } else
                throw new Exception(Mensaje.TextoMensaje("REPORTE-NOFILTRO"));

            // Filtros de resultados
            if (chkResultados.CheckedItems.Count != 0) {                
                sb.Append(" and (");
                foreach (object item in chkResultados.CheckedItems)
                    sb.Append(string.Format("Resultado = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");
            }
            else sb.Append(" and (Resultado is null)");

            // filtro de tipo de gestion
            if (cmbTipoGestion.SelectedItem != null)
                sb.Append(string.Format(" and (TipoGestion = '{0}')", cmbTipoGestion.SelectedItem));

            return sb.ToString();
        }

        /// <summary>
        /// Setea el control para el manejo del panel
        /// de filtros.
        /// </summary>
        public void setControl(ICUReportes unControl) {
            // Carga el control
            _control = unControl;
            // Carga el combo de tipo de gestiones
            cargaComboTipo();
            // Carga los componentes
            cargaControles();
        }

        /// <summary>
        /// Evento del boton Filtrar
        /// </summary>
        private void btnFiltrar_Click(object sender, EventArgs e) {
            Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("REPORTE-AYUDA"));
            Cursor = Cursors.WaitCursor;

            try {
                _control.filtrarDatos(armaFiltro(), dtpFechaDesde.Value, dtpFechaHasta.Value, rbDetalle.Checked);
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
            // Recorre toda la lista seteando el mismo estado que el
            // check "Todos"
            for (int i = 0; i < chkListaUsuarios.Items.Count; i++)
                chkListaUsuarios.SetItemCheckState(i, chkTodosUsuarios.CheckState);
        }

        /// <summary>
        /// Evento que maneja la seleccion/deseleccion de todos 
        /// los items del listado de Tipos de Pago
        /// </summary>
        private void chkTodosTipoPago_CheckedChanged(object sender, EventArgs e) {
            for (int i = 0; i < chkEstadosGestion.Items.Count; i++)
                chkEstadosGestion.SetItemCheckState(i, chkTodosEstado.CheckState);
        }

        /// <summary>
        /// Evento que maneja la seleccion/deseleccion de todos 
        /// los items del listado de Formas de Pago
        /// </summary>
        private void chkTodoFormaPago_CheckedChanged(object sender, EventArgs e) {
            for (int i = 0; i < chkResultados.Items.Count; i++)
                chkResultados.SetItemCheckState(i, chkTodoResultados.CheckState);
        }
    }
}