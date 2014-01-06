namespace cuAbmGestion
{
    partial class PanelListGestiones
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected System.Windows.Forms.ToolStripButton btnGestion;
        protected System.Windows.Forms.ToolStripButton btnImprimir;
        protected System.Windows.Forms.ToolStripButton btnImprimirTodo;
        protected System.Windows.Forms.ToolStripButton btnCuenta;
        protected System.Windows.Forms.ToolStripButton btnSiguiente;
        protected System.Windows.Forms.ToolStripButton btnBreak;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        protected override void InitializeComponent() {
            base.InitializeComponent();

            this.components = new System.ComponentModel.Container();

            this.btnGestion = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnImprimirTodo = new System.Windows.Forms.ToolStripButton();
            this.btnCuenta = new System.Windows.Forms.ToolStripButton();
            this.btnSiguiente = new System.Windows.Forms.ToolStripButton();
            this.btnBreak = new System.Windows.Forms.ToolStripButton();

            this.toolStrip1.SuspendLayout();

            this.btnGestion.Image = global::cuAbmGestion.Properties.Resources.gestionar_tb;
            this.btnGestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(23, 22);
            this.btnGestion.Text = "Gestionar";
            this.btnGestion.Tag = "BOTON.GESTION.GESTIONAR";
            this.btnGestion.ToolTipText = "Gestionar (Enter)";
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);

            this.btnImprimir.Image = global::cuAbmGestion.Properties.Resources.imprimir;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(23, 22);
            this.btnImprimir.Text = "Documento";
            this.btnImprimir.Tag = "BOTON.GESTION.IMPRIMIR";
            this.btnImprimir.ToolTipText = "Imprime el Documento asociado";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);

            this.btnImprimirTodo.Image = global::cuAbmGestion.Properties.Resources.imprimirtodo;
            this.btnImprimirTodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimirTodo.Name = "btnImprimirTodo";
            this.btnImprimirTodo.Size = new System.Drawing.Size(23, 22);
            this.btnImprimirTodo.Text = "Doc. Todos";
            this.btnImprimirTodo.Tag = "BOTON.GESTION.IMPRIMIR.TODO";
            this.btnImprimirTodo.ToolTipText = "Imprime todos los Documentos asociados";
            this.btnImprimirTodo.Click += new System.EventHandler(this.btnImprimirTodo_Click);

            this.btnCuenta.Image = global::cuAbmGestion.Properties.Resources.cuenta;
            this.btnCuenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(23, 22);
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.ToolTipText = "Ver Cuenta";
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);

            this.btnSiguiente.Image = global::cuAbmGestion.Properties.Resources.siguiente;
            this.btnSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(23, 22);
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.ToolTipText = "Permite gestionar la siguiente Cuenta asignada";
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);

            this.btnBreak.Image = global::cuAbmGestion.Properties.Resources._break;
            this.btnBreak.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(23, 22);
            this.btnBreak.Text = "Break";
            this.btnBreak.ToolTipText = "Permite detener el conteo de asignación automática";
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);

            this.dgvListado.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvListado_RowPrePaint);
            this.dgvListado.AllowUserToResizeColumns = true;

            this.toolStrip1.Items.Add(btnGestion);
            this.toolStrip1.Items.Add(btnImprimir);
            this.toolStrip1.Items.Add(btnImprimirTodo);
            this.toolStrip1.Items.Add(btnCuenta);
            this.toolStrip1.Items.Add(btnSiguiente);
            this.toolStrip1.Items.Add(btnBreak);

            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
        }

        #endregion
    }
}
