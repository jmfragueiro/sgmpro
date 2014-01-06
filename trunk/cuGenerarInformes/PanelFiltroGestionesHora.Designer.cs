using scioThirdPartLibrary;

namespace cuGenerarInformes
{
    partial class PanelFiltroGestionesHora
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkListaUsuarios = new System.Windows.Forms.CheckedListBox();
            this.label32 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.chkTodosUsuarios = new System.Windows.Forms.CheckBox();
            this.dtpFechaDesde = new NullableDateTimePicker();
            this.SuspendLayout();
            // 
            // chkListaUsuarios
            // 
            this.chkListaUsuarios.FormattingEnabled = true;
            this.chkListaUsuarios.HorizontalScrollbar = true;
            this.chkListaUsuarios.Location = new System.Drawing.Point(8, 66);
            this.chkListaUsuarios.Name = "chkListaUsuarios";
            this.chkListaUsuarios.Size = new System.Drawing.Size(240, 79);
            this.chkListaUsuarios.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 12);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 13);
            this.label32.TabIndex = 56;
            this.label32.Text = "Fecha";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = global::cuGenerarInformes.Properties.Resources.Refresh_24x24;
            this.btnFiltrar.Location = new System.Drawing.Point(254, 63);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(87, 82);
            this.btnFiltrar.TabIndex = 59;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkTodosUsuarios
            // 
            this.chkTodosUsuarios.AutoSize = true;
            this.chkTodosUsuarios.Location = new System.Drawing.Point(8, 47);
            this.chkTodosUsuarios.Name = "chkTodosUsuarios";
            this.chkTodosUsuarios.Size = new System.Drawing.Size(116, 17);
            this.chkTodosUsuarios.TabIndex = 64;
            this.chkTodosUsuarios.Text = "Todos los Usuarios";
            this.chkTodosUsuarios.UseVisualStyleBackColor = true;
            this.chkTodosUsuarios.CheckedChanged += new System.EventHandler(this.chkTodosEntidades_CheckedChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(50, 8);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaDesde.TabIndex = 0;
            this.dtpFechaDesde.Value = new System.DateTime(2010, 4, 22, 18, 27, 51, 859);
            // 
            // PanelFiltroGestionesHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkTodosUsuarios);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.chkListaUsuarios);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "PanelFiltroGestionesHora";
            this.Size = new System.Drawing.Size(350, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NullableDateTimePicker dtpFechaDesde;
        private System.Windows.Forms.CheckedListBox chkListaUsuarios;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckBox chkTodosUsuarios;
    }
}
