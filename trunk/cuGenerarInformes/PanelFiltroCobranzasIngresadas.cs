#region

using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using scioBaseLibrary;
using scioPersistentLibrary;
using scioReportLibrary;
using scioToolLibrary;
using scioToolLibrary.enums;

#endregion

namespace cuGenerarInformes
{
    /// <summary>
    ///   Panel que contiene los filtros correspondientes al 
    ///   Reporte de Cobranzas ingresadas.
    ///   Implementa la Interfaz IPanelFiltros.
    /// </summary>
    public partial class PanelFiltroCobranzasIngresadas : UserControl, IPanelFiltros
    {
        /// <summary>
        ///   Controlador. Debe implementar el ICUReportes
        /// </summary>
        private ICUReportes _control;

        /// <summary>
        ///   Constructor
        /// </summary>
        public PanelFiltroCobranzasIngresadas()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   Carga los componentes con los valores a filtrar.
        /// </summary>
        private void cargaControles()
        {
            // Carga los datos iniciales
            string strCnx = Sistema.Controlador.CadenaConexion;

            // Carga el check list de clientes
            string strSql = "select distinct cliente from v_lista_cobranzas";
            DataTable clientes = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            for (int i = 0; i < clientes.Rows.Count; i++)
                chkListaEntidades.Items.Add(clientes.Rows[i][0]);

            // Carga el check list de Tipo de pago
            strSql = "select distinct concepto from v_lista_cobranzas";
            DataTable conceptos = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            for (int i = 0; i < conceptos.Rows.Count; i++)
                chkTipoPago.Items.Add(conceptos.Rows[i][0]);

            // Carga el check list de Formas de pago
            strSql = "select distinct formapago from v_lista_cobranzas";
            DataTable formasPago = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            for (int i = 0; i < formasPago.Rows.Count; i++)
                chkFormaPago.Items.Add(formasPago.Rows[i][0]);

            // Carga el check list de Formas de pago
            strSql = "select distinct estado from v_lista_cobranzas";
            DataTable estado = Persistencia.EjecutarSqlSelect(strSql, strCnx);
            for (int i = 0; i < estado.Rows.Count; i++)
                chkEstado.Items.Add(estado.Rows[i][0]);

            // Carga los Picker del fecha con el día de hoy
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;

            // Marca todos los checks
            chkTodoEstado.Checked = true;
            chkTodoFormaPago.Checked = true;
            chkTodosEntidades.Checked = true;
            chkTodosTipoPago.Checked = true;

            // Inicializa el combo
            cmbFiltroRend.Text = @"Todos";
        }

        /// <summary>
        ///   Arma los filtros que se aplicarán para regenerar
        ///   el reporte. Depende de cada implementación del 
        ///   IPanelFiltros.
        /// </summary>
        private string armaFiltro()
        {
            var sb = new StringBuilder();

            // Filtros de fecha
            sb.Append(string.Format("FechaPago >= '{0}' ", ((DateTime) dtpFechaDesde.Value).Date.ToShortDateString()));
            sb.Append(string.Format("and FechaPago <= '{0}' ",
                                    ((DateTime) dtpFechaHasta.Value).AddDays(1).Date.ToShortDateString()));

            // Si no selecciona ningún filtro, genera una excepción.
            if (chkListaEntidades.CheckedItems.Count != 0 && chkTipoPago.CheckedItems.Count != 0 &&
                chkFormaPago.CheckedItems.Count != 0 && chkEstado.CheckedItems.Count != 0)
            {
                // Filtros de entidades
                sb.Append("and (");
                foreach (object item in chkListaEntidades.CheckedItems)
                    sb.Append(string.Format("Cliente = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");

                // Filtros de tipos de pago
                sb.Append("and (");
                foreach (object item in chkTipoPago.CheckedItems)
                    sb.Append(string.Format("Concepto = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");

                // Filtros de Formas de pago
                sb.Append("and (");
                foreach (object item in chkFormaPago.CheckedItems)
                    sb.Append(string.Format("FormaPago = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");

                // Filtros de Estados de Pago
                sb.Append("and (");
                foreach (object item in chkEstado.CheckedItems)
                    sb.Append(string.Format("Estado = '{0}' or ", item));
                sb.Remove(sb.Length - 4, 4);
                sb.Append(")");

                // Filtro de Rendición
                if (!cmbFiltroRend.Text.Equals("Todos")) 
                    sb.Append(string.Format("and (Rendido = {0}) ", (cmbFiltroRend.Text.Equals("Rendidos")) ? 1 : 0));

                return sb.ToString();
            }

            throw new Exception(Mensaje.TextoMensaje("REPORTE-NOFILTRO"));
        }

        /// <summary>
        ///   Setea el control para el manejo del panel
        ///   de filtros.
        /// </summary>
        public void setControl(ICUReportes unControl)
        {
            // Carga el control
            _control = unControl;
            // Carga los componentes
            cargaControles();
        }

        /// <summary>
        ///   Evento del boton Filtrar
        /// </summary>
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("REPORTE-AYUDA"));
            Cursor = Cursors.WaitCursor;

            try
            {
                _control.filtrarDatos(armaFiltro(), dtpFechaDesde.Value, dtpFechaHasta.Value);
            }
            catch (Exception ex)
            {
                Sistema.Controlador.mostrar("REPORTE-ERROR", ENivelMensaje.ERROR, ex.ToString(), true);
            }
            finally
            {
                Cursor = Cursors.Default;
                Sistema.Controlador.Winppal.setAyuda(Mensaje.TextoMensaje("AYUDA-LISTO"));
            }
        }

        /// <summary>
        ///   Evento que maneja la seleccion/deseleccion de todos 
        ///   los items del listado de Entidades
        /// </summary>
        private void chkTodosEntidades_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListaEntidades.Items.Count; i++)
                chkListaEntidades.SetItemCheckState(i, chkTodosEntidades.CheckState);
        }

        /// <summary>
        ///   Evento que maneja la seleccion/deseleccion de todos 
        ///   los items del listado de Tipos de Pago
        /// </summary>
        private void chkTodosTipoPago_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkTipoPago.Items.Count; i++)
                chkTipoPago.SetItemCheckState(i, chkTodosTipoPago.CheckState);
        }

        /// <summary>
        ///   Evento que maneja la seleccion/deseleccion de todos 
        ///   los items del listado de Formas de Pago
        /// </summary>
        private void chkTodoFormaPago_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkFormaPago.Items.Count; i++)
                chkFormaPago.SetItemCheckState(i, chkTodoFormaPago.CheckState);
        }

        /// <summary>
        ///   Evento que maneja la seleccion/deseleccion de todos 
        ///   los items del listado de Estado de Gestión
        /// </summary>
        private void chkTodoEstado_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkEstado.Items.Count; i++)
                chkEstado.SetItemCheckState(i, chkTodoEstado.CheckState);
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            marcarDesmarcar(1,DateTime.Today,sender,e);
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            marcarDesmarcar(0, Fechas.FechaNull, sender, e);
        }

        private void marcarDesmarcar(int valor,DateTime fecha, object sender, EventArgs e)
        {
            DialogResult desicion = MessageBox.Show(String.Format("Desea actualizar al estado {0}?", (valor == 1) ? "Rendido" : "No Rendido"),
                    @"Rendición",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (desicion.Equals(DialogResult.Cancel)) return;
            ((CUCobranzasIngresadas)_control).setRendidos(valor, fecha);
            btnFiltrar_Click(sender, e);
        }
    }
}