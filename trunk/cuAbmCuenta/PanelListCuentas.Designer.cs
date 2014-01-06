namespace cuAbmCuenta {
    partial class PanelListCuentas {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        protected System.Windows.Forms.ToolStripButton btnGestion;

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
            // 
            // btnGestion
            //             
            this.toolStrip1.SuspendLayout();
            this.toolStrip1.Items.Add(btnGestion);
            this.btnGestion.Image = global::cuAbmCuenta.Properties.Resources.gestionar_tb;
            this.btnGestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(23, 22);
            this.btnGestion.Text = "Gestionar";
            this.btnGestion.Tag = "BOTON.GESTION.GESTIONAR";
            this.btnGestion.ToolTipText = "Gestionar (Enter)";
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvListado_RowPrePaint);
            this.dgvListado.AllowUserToResizeColumns = true;
        }
        #endregion
    }
}
