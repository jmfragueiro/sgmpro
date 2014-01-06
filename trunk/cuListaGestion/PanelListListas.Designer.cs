namespace cuListaGestion {
    partial class PanelListListas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected System.Windows.Forms.ToolStripButton btnGestion;
        protected System.Windows.Forms.ToolStripButton btnCartas;
        protected System.Windows.Forms.ToolStripButton btnListado;

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
            this.btnCartas = new System.Windows.Forms.ToolStripButton();
            this.btnListado = new System.Windows.Forms.ToolStripButton();

            // 
            // btnGestion
            //             
            this.toolStrip1.SuspendLayout();
            this.toolStrip1.Items.Add(btnGestion);
            this.btnGestion.Image = global::cuListaGestion.Properties.Resources.masiva;
            this.btnGestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(23, 22);
            this.btnGestion.Text = "Gestionar";
            this.btnGestion.ToolTipText = "Gestionar (F10)";
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            // 
            // btnCartas
            //             
            this.toolStrip1.SuspendLayout();
            this.toolStrip1.Items.Add(btnCartas);
            this.btnCartas.Image = global::cuListaGestion.Properties.Resources.param;
            this.btnCartas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCartas.Name = "btnCartas";
            this.btnCartas.Size = new System.Drawing.Size(23, 22);
            this.btnCartas.Text = "Postal/Terreno";
            this.btnCartas.ToolTipText = "Generar Documentos Postal/Terreno (F11)";
            this.btnCartas.Click += new System.EventHandler(this.btnCartas_Click);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();

            // 
            // btnListado
            //             
            this.toolStrip1.SuspendLayout();
            this.toolStrip1.Items.Add(btnListado);
            this.btnListado.Image = global::cuListaGestion.Properties.Resources.param;
            this.btnListado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(23, 22);
            this.btnListado.Text = "&Generar Listado";
            this.btnListado.ToolTipText = "Generar Listado de Gestiones de la Lista (F12)";
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
        }

        #endregion
    }
}