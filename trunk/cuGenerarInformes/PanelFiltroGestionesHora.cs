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
    public partial class PanelFiltroGestionesHora : UserControl, IPanelFiltros {
        /// <summary>
        /// Controlador. Debe implementar el ICUReportes
        /// </summary>
        private ICUReportes _control;

        /// <summary>
        /// Constructor
        /// </summary>
        public PanelFiltroGestionesHora()
        {
            InitializeComponent();
        }

       /// <summary>
        /// Carga los componentes con los valores a filtrar.
        /// </summary>
        private void cargaControles() {
            // Carga los datos iniciales
            string strCnx = Sistema.Controlador.CadenaConexion;

            // Carga el check list de usuarios
            //string strSql = "select distinct usuario from v_lista_gestiones where usuario is not null";
            if (chkListaUsuarios.Items.Count <= 0) {
                const string strSql = "select distinct(usu_empleado) from usuario order by usu_empleado";
                var usuarios = Persistencia.EjecutarSqlSelect(strSql, strCnx);
                for (var i = 0; i < usuarios.Rows.Count; i++)
                    chkListaUsuarios.Items.Add(usuarios.Rows[i][0]);
            }

            // Carga los Picker del fecha con el día de hoy
            dtpFechaDesde.Value = DateTime.Today.AddDays(-1);

            // Setea todas las opciones por default
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
            sb.Append(string.Format("where g.ges_fechainicio >=  convert(datetime,'{0}',103) ", ((DateTime)dtpFechaDesde.Value).Date.ToShortDateString()));
            sb.Append(string.Format("and g.ges_fechainicio < convert(datetime,'{0}',103) ",
                ((DateTime)dtpFechaDesde.Value).AddDays(1).Date.ToShortDateString()));

            // Si no selecciona ningún filtro, genera una excepción.
            if (chkListaUsuarios.CheckedItems.Count != 0)
            {
                // Filtros de entidades
                sb.Append(" and (");
                foreach (object item in chkListaUsuarios.CheckedItems)
                    sb.Append(string.Format("u.usu_empleado = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");
                sb.Append(" order by g.ges_usuario, datepart (hh,g.ges_fechacierre)");

                return sb.ToString();
            }

           

            throw new Exception(Mensaje.TextoMensaje("REPORTE-NOFILTRO"));
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
                _control.filtrarDatos(armaFiltro(), dtpFechaDesde.Value);
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("REPORTE-ERROR", ENivelMensaje.ERROR, ex.ToString(), true);
            } finally {
                Cursor = Cursors.Default;
                Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("AYUDA-LISTO"));                
            }
        }

        /// <summary>
        /// Evento que maneja la seleccion/deseleccion de todos 
        /// los items del listado de Usuarios
        /// </summary>
        private void chkTodosEntidades_CheckedChanged(object sender, EventArgs e) {
            // Recorre toda la lista seteando el mismo estado que el
            // check "Todos"
            for (int i = 0; i < chkListaUsuarios.Items.Count; i++)
                chkListaUsuarios.SetItemCheckState(i, chkTodosUsuarios.CheckState);
        }
    }
}