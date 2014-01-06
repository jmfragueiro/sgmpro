namespace cuGenerarJobs {
    partial class PanelListJobs {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        protected System.Windows.Forms.ToolStripButton btnRun;
                
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

        #region Código generado por el Diseñador de componentes
        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        protected override void InitializeComponent() {
            base.InitializeComponent();

            this.components = new System.ComponentModel.Container();
            this.btnRun = new System.Windows.Forms.ToolStripButton();

            // 
            // btnRun
            // 
            this.toolStrip1.SuspendLayout();
            //this.toolStrip1.Items.Add(btnRun);
            this.toolStrip1.Items.Insert(0,btnRun);
            this.btnRun.Image = global::cuGenerarJobs.Properties.Resources.clock_play;
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(23, 22);
            this.btnRun.Text = "Ejecutar";
            this.btnRun.ToolTipText = "Ejecutar (F10)";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();   
        }
        #endregion
    }
}
