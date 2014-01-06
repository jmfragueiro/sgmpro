///////////////////////////////////////////////////////////
//  PanelListCuentas.cs
//  Implementación del panel de listado para la entidad Cuenta
//  de la aplicación.
//  Generated a mano
//  Created on:      05-may-2009 17:23:40
//  Original author: Fito
///////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using scioBaseLibrary;
using scioBaseLibrary.helpers;
using scioControlLibrary;
using scioControlLibrary.enums;
using scioControlLibrary.interfaces;
using scioToolLibrary.enums;
using sgmpro.dominio.configuracion;

namespace cuAbmCuenta {
    public partial class PanelListCuentas : PanelListABMV<Cuenta> {
        private DataRow _mirow;
        private string _vigencia;
        private const string _CANCELADA = "CANCELACION TOTAL DE DEUDA";

        /// <summary>
        /// Constructor de la clase que primero ejecuta la inicialización
        /// por defecto y luego asigna el controlador y panel asociado al 
        /// listado (para agregar, mostrar, editar o borrar). Debería lanzar 
        /// una VistaErrorExcetion si hay un problema.
        /// </summary>
        /// <param name="controlador">
        /// El objeto controlador de la ventana.
        /// </param>
        public PanelListCuentas(IControladorListable<Cuenta> controlador) : base(controlador) { }

        #region panellist
        /// <summary>
        /// Este método establece el modo en que se visualiza
        /// el listado (qué botones se muestran) de acuerdo al
        /// modo de vista del controlador asociado.
        /// </summary>
        public override void setModoVista() {
            setModoVista(_controlador.ModoVista);
        }

        /// <summary>
        /// Este método establece el modo en que se visualiza
        /// el listado (qué botones se muestran) de acuerdo al
        /// modo de vista del controlador asociado.
        /// </summary>
        public override void setModoVista(EModoVentana modo) {
            switch (modo) {
                case EModoVentana.EDIT:
                case EModoVentana.FULL:
                case EModoVentana.LIST:
                    setFullView();
                    break;
                case EModoVentana.ADD:
                    setAgregable();
                    break;
                case EModoVentana.GESTION:
                    setGestionable();
                    break;
                default:
                    setReadOnly();
                    break;
            }
        }

        /// <summary>
        /// Este método oculta los botones de acción de la toolbar para
        /// </summary>
        protected override void setReadOnly() {
            base.setReadOnly();

            toolStrip1.Items["btnGestion"].Visible = false;

            // Luego de establecer el modo de vista verifica permisos
            aplicarListPermisos(toolStrip1, "CUENTA");
        }

        /// <summary>
        /// Este método muestra los botones de edicion de la toolbar para
        /// dejar al listado en un modo de full edición (con add y remove).
        /// </summary>
        protected override void setFullView() {
            base.setFullView();

            toolStrip1.Items["btnGestion"].Visible = false;

            // Luego de establecer el modo de vista verifica permisos
            aplicarListPermisos(toolStrip1, "CUENTA");
        }

        /// <summary>
        /// Este método muestra solo el botón de agregar de la toolbar para
        /// dejar al listado en un modo de Agregable (solamente con add).
        /// </summary>
        protected override void setAgregable() {
            base.setAgregable();

            toolStrip1.Items["btnGestion"].Visible = false;

            // Luego de establecer el modo de vista verifica permisos
            aplicarListPermisos(toolStrip1, "CUENTA");
        }

        /// <summary>
        /// Este método muestra solo el botón de agregar de la toolbar para
        /// dejar al listado en un modo de Agregable (solamente con add).
        /// </summary>
        protected void setGestionable() {
            base.setReadOnly();

            toolStrip1.Items["btnGestion"].Visible = true;

            // Luego de establecer el modo de vista verifica permisos
            aplicarListPermisos(toolStrip1, "CUENTA");
        }
        #endregion panellist

        #region interfase
        /// <summary>
        /// Este método es llamado cuando se presiona enter sobre el listado.
        /// Fue creado para reaccionar de una forma estándar, y por defecto es
        /// como si fuera un doble click, pero el método puede ser sobrepasado.
        /// </summary>
        protected override void alPresionarEnter() {
            btnGestion.PerformClick();
        }

        /// <summary>
        /// Este método responde al botón Gestion. Debería 'mostrar' cualquier
        /// error que pudiese ocurrir y no propagar ninguna excepción.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        protected void btnGestion_Click(object sender, EventArgs e) {
            if (dgvListado.CurrentRow == null)
                Sistema.Controlador.mostrar("ROW-MUST", ENivelMensaje.ERROR, null, false);

            try {
                CUCaller.CallCU("cuGestionar", this, new object[] {getObjetoActual()});
            } catch (Exception ex) {
                Sistema.Controlador.mostrar("ACTION-GESTION-NOK", ENivelMensaje.ERROR, ex.ToString(), true);
            } finally {
                postAccion();
            }
        }

        /// <summary>
        /// Este método actual al redibujarse una fila y lo que intenta es
        /// marcar de manera distinta la fila que corresponda con una cuenta
        /// fuera de vigencia.
        /// </summary>
        /// <param name="sender">
        /// El componente que lanza el evento (envía el mensaje).
        /// </param>
        /// <param name="e">
        /// Los argumentos del evento lanzado por el componente.
        /// </param>
        private void dgvListado_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) {
            _mirow = ((DataRowView)dgvListado.Rows[e.RowIndex].DataBoundItem).Row;
            _vigencia = _mirow["Estado"].ToString();

            dgvListado.Rows[e.RowIndex].DefaultCellStyle.ForeColor = _vigencia.Equals(_CANCELADA) 
                ? Color.Red 
                : Color.Black;
        }
        #endregion interface
    }
}