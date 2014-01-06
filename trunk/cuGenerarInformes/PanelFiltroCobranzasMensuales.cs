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
    public partial class PanelFiltroCobranzasMensuales : UserControl, IPanelFiltros {
        /// <summary>
        /// Controlador. Debe implementar el ICUReportes
        /// </summary>
        private ICUReportes _control;
        private string _tipos;

        /// <summary>
        /// Constructor
        /// </summary>
        public PanelFiltroCobranzasMensuales() {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los componentes con los valores a filtrar.
        /// </summary>
        private void cargaControles() {
            // Carga los datos iniciales
            string strCnx = Sistema.Controlador.CadenaConexion;

            // Carga el check list de clientes
            var strSql = "select distinct cliente from v_lista_cobranzas_mensuales";
            var clientes = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            for (int i = 0; i < clientes.Rows.Count; i++)
                chkListaEntidades.Items.Add(clientes.Rows[i][0]);

            // Carga el check list de Tipo de pago
            strSql = "select distinct tipopago from v_lista_cobranzas_mensuales";
            var conceptos = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            for (var i = 0; i < conceptos.Rows.Count; i++)
                chkTipoPago.Items.Add(conceptos.Rows[i][0]);

            // Carga el cuadro de texto con el año actual
            txtPeriodo.Text = DateTime.Today.Year.ToString();

            // Setea todas las opciones por default
            chkTodosEntidades.Checked = true;
            chkTodosTipoPago.Checked = true;
        }

        /// <summary>
        /// Arma los filtros que se aplicarán para regenerar
        /// el reporte. Depende de cada implementación del 
        /// IPanelFiltros.
        /// </summary>
        private string armaFiltro() {
            StringBuilder sb = new StringBuilder();

            /// Filtro de período
            sb.Append(String.Format("where Periodo = '{0}'", txtPeriodo.Text));

            /// Si no selecciona ningún filtro, genera una excepción.
            if (chkListaEntidades.CheckedItems.Count != 0 && chkTipoPago.CheckedItems.Count != 0) {
                /// Filtros de entidades
                sb.Append("and (");
                foreach (object item in chkListaEntidades.CheckedItems)
                    sb.Append(string.Format("Cliente = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");

                /// Filtros de tipos de pago
                sb.Append("and (");
                _tipos = null;
                foreach (object item in chkTipoPago.CheckedItems) {
                    sb.Append(string.Format("TipoPago = '{0}' or ", item));
                    _tipos += (string.IsNullOrEmpty(_tipos)) ? item : (" / " + item);
                }
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
                _control.filtrarDatos(armaFiltro(), (chkTodosTipoPago.Checked) ? "TODOS" : _tipos);
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

        /// <summary>
        /// Evento que maneja la seleccion/deseleccion de todos 
        /// los items del listado de Tipos de Pago
        /// </summary>
        private void chkTodosTipoPago_CheckedChanged(object sender, EventArgs e) {
            for (int i = 0; i < chkTipoPago.Items.Count; i++)
                if (chkTipoPago.Items[i].ToString() != "HONORARIOS")
                    chkTipoPago.SetItemCheckState(i, chkTodosTipoPago.CheckState);
            // Inhabilita / habilita la seleccion individual
            chkTipoPago.Enabled = !chkTodosTipoPago.Checked;
        }

        /// <summary>
        /// Metodo que desmarca todos los otros check de la lista.
        /// Con esto se logra que solamente una opcion pueda ser 
        /// elegida a la vez
        /// </summary>
        //private void chkTipoPago_SelectedIndexChanged(object sender, EventArgs e) {
        //    for (int i = 0; i < chkTipoPago.Items.Count; i++)
        //        if (chkTipoPago.Items[i].ToString() != sender.ToString())
        //            chkTipoPago.SetItemCheckState(i, CheckState.Unchecked);
        //}
    }
}