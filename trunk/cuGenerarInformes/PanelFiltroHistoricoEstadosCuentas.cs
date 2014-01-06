using System;
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
    public partial class PanelFiltroHistoricoEstadosCuentas : UserControl, IPanelFiltros {
        /// <summary>
        /// Controlador. Debe implementar el ICUReportes
        /// </summary>
        private ICUReportes _control;

        /// <summary>
        /// Constructor
        /// </summary>
        public PanelFiltroHistoricoEstadosCuentas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los componentes con los valores a filtrar.
        /// </summary>
        private void cargaControles() {
            // Carga los datos iniciales
            var strCnx = Sistema.Controlador.CadenaConexion;

            // Carga el check list de usuarios
            if (chkListaUsuarios.Items.Count <= 0)
            {
                // Obtiene el query desde un string en Resources
                var strSql = Properties.Resources.strQryGetUsers;
                var usuarios = Persistencia.EjecutarSqlSelect(strSql, strCnx);
                for (var i = 0; i < usuarios.Rows.Count; i++)
                    chkListaUsuarios.Items.Add(usuarios.Rows[i][0]);
            }

            // Carga el check list de Estados
            if (chkListaEntidades.Items.Count <= 0) {
                // Obtiene el query desde un string en Resources
                var strSql = Properties.Resources.strQryGetEntidades;
                var estados = Persistencia.EjecutarSqlSelect(strSql, strCnx);
                for (var i = 0; i < estados.Rows.Count; i++)
                    chkListaEntidades.Items.Add(estados.Rows[i][0]);
            }

            // Carga los Picker del fecha con el día de hoy
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;

            // Setea todas las opciones por default
            chkTodoEntidades.Checked = true;
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
            sb.Append(string.Format("HistFecha >= '{0}' ", 
                ((DateTime)dtpFechaDesde.Value).Date.ToShortDateString()));
            sb.Append(string.Format("and HistFecha <= '{0}' ",
                ((DateTime)dtpFechaHasta.Value).AddDays(1).Date.ToShortDateString()));

            // Si no selecciona ningún filtro, marca el check "Todos"
            chkTodosUsuarios.Checked = (chkListaUsuarios.CheckedItems.Count.Equals(0)) ? true : chkTodosUsuarios.Checked;
            chkTodoEntidades.Checked = (chkListaEntidades.CheckedItems.Count.Equals(0)) ? true: chkTodoEntidades.Checked;

           // Filtros de usuarios
            sb.Append(" and (");
            foreach (object item in chkListaUsuarios.CheckedItems)
                sb.Append(string.Format("HistUser = '{0}' or ", item));
            sb.Remove(sb.Length - 4, 4);
            sb.Append(")");

            // Filtros de entidades
            sb.Append(" and (");
            foreach (object item in chkListaEntidades.CheckedItems)
                sb.Append(string.Format("EntidadNom = '{0}' or ", item));
            sb.Remove(sb.Length - 4, 4);
            sb.Append(")");
            
            // filtro de dni
            if (!txtDniTitular.Text.Length.Equals(0)) 
                sb.Append(string.Format(" and (PersonaDni = '{0}')", txtDniTitular.Text));

            // filtro de cod de cta
            if (!txtCodCta.Text.Length.Equals(0))
                sb.Append(string.Format(" and (CtaCod = '{0}')", txtCodCta.Text));

            return sb.ToString();
        }

        /// <summary>
        /// Setea el control para el manejo del panel
        /// de filtros.
        /// </summary>
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
            Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("REPORTE-AYUDA"));
            Cursor = Cursors.WaitCursor;

            try {
                _control.filtrarDatos(armaFiltro(), dtpFechaDesde.Value, dtpFechaHasta.Value);
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
            for (int i = 0; i < chkListaEntidades.Items.Count; i++)
                chkListaEntidades.SetItemCheckState(i, chkTodoEntidades.CheckState);
        }

        /// <summary>
        /// Evento que maneja la seleccion/deseleccion de todos 
        /// los items del listado de Tipos de Pago
        /// </summary>
        private void chkTodosUsuarios_CheckedChanged(object sender, EventArgs e) {
            for (int i = 0; i < chkListaUsuarios.Items.Count; i++)
                chkListaUsuarios.SetItemCheckState(i, chkTodosUsuarios.CheckState);
        }
       
    }
}