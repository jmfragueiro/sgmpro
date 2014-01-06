namespace cuGenerarInformes
{
    partial class PanelFiltroListaCuentas
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
            this.chkListaEntidades = new System.Windows.Forms.CheckedListBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.chkEstadosGestion = new System.Windows.Forms.CheckedListBox();
            this.chkTodasEntidades = new System.Windows.Forms.CheckBox();
            this.chkTodosEstado = new System.Windows.Forms.CheckBox();
            this.rbResumen = new System.Windows.Forms.RadioButton();
            this.rbDetalle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkListaEntidades
            // 
            this.chkListaEntidades.FormattingEnabled = true;
            this.chkListaEntidades.HorizontalScrollbar = true;
            this.chkListaEntidades.Location = new System.Drawing.Point(12, 32);
            this.chkListaEntidades.Name = "chkListaEntidades";
            this.chkListaEntidades.Size = new System.Drawing.Size(268, 94);
            this.chkListaEntidades.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = global::cuGenerarInformes.Properties.Resources.Refresh_24x24;
            this.btnFiltrar.Location = new System.Drawing.Point(659, 32);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(90, 94);
            this.btnFiltrar.TabIndex = 59;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkEstadosGestion
            // 
            this.chkEstadosGestion.FormattingEnabled = true;
            this.chkEstadosGestion.HorizontalScrollbar = true;
            this.chkEstadosGestion.Location = new System.Drawing.Point(286, 32);
            this.chkEstadosGestion.Name = "chkEstadosGestion";
            this.chkEstadosGestion.Size = new System.Drawing.Size(266, 94);
            this.chkEstadosGestion.TabIndex = 60;
            // 
            // chkTodasEntidades
            // 
            this.chkTodasEntidades.AutoSize = true;
            this.chkTodasEntidades.Location = new System.Drawing.Point(12, 13);
            this.chkTodasEntidades.Name = "chkTodasEntidades";
            this.chkTodasEntidades.Size = new System.Drawing.Size(122, 17);
            this.chkTodasEntidades.TabIndex = 64;
            this.chkTodasEntidades.Text = "Todos las Entidades";
            this.chkTodasEntidades.UseVisualStyleBackColor = true;
            this.chkTodasEntidades.CheckedChanged += new System.EventHandler(this.chkTodosEntidades_CheckedChanged);
            // 
            // chkTodosEstado
            // 
            this.chkTodosEstado.AutoSize = true;
            this.chkTodosEstado.Location = new System.Drawing.Point(286, 13);
            this.chkTodosEstado.Name = "chkTodosEstado";
            this.chkTodosEstado.Size = new System.Drawing.Size(113, 17);
            this.chkTodosEstado.TabIndex = 65;
            this.chkTodosEstado.Text = "Todos los Estados";
            this.chkTodosEstado.UseVisualStyleBackColor = true;
            this.chkTodosEstado.CheckedChanged += new System.EventHandler(this.chkTodosTipoPago_CheckedChanged);
            // 
            // rbResumen
            // 
            this.rbResumen.AutoSize = true;
            this.rbResumen.Location = new System.Drawing.Point(15, 54);
            this.rbResumen.Name = "rbResumen";
            this.rbResumen.Size = new System.Drawing.Size(70, 17);
            this.rbResumen.TabIndex = 67;
            this.rbResumen.TabStop = true;
            this.rbResumen.Text = "Resumen";
            this.rbResumen.UseVisualStyleBackColor = true;
            // 
            // rbDetalle
            // 
            this.rbDetalle.AutoSize = true;
            this.rbDetalle.Location = new System.Drawing.Point(15, 20);
            this.rbDetalle.Name = "rbDetalle";
            this.rbDetalle.Size = new System.Drawing.Size(58, 17);
            this.rbDetalle.TabIndex = 68;
            this.rbDetalle.TabStop = true;
            this.rbDetalle.Text = "Detalle";
            this.rbDetalle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDetalle);
            this.groupBox1.Controls.Add(this.rbResumen);
            this.groupBox1.Location = new System.Drawing.Point(558, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 99);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // PanelFiltroListaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkTodosEstado);
            this.Controls.Add(this.chkTodasEntidades);
            this.Controls.Add(this.chkEstadosGestion);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.chkListaEntidades);
            this.Name = "PanelFiltroListaCuentas";
            this.Size = new System.Drawing.Size(752, 134);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListaEntidades;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckedListBox chkEstadosGestion;
        private System.Windows.Forms.CheckBox chkTodasEntidades;
        private System.Windows.Forms.CheckBox chkTodosEstado;
        private System.Windows.Forms.RadioButton rbResumen;
        private System.Windows.Forms.RadioButton rbDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
