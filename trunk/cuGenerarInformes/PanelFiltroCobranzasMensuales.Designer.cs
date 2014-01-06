namespace cuGenerarInformes
{
    partial class PanelFiltroCobranzasMensuales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelFiltroCobranzasMensuales));
            this.chkListaEntidades = new System.Windows.Forms.CheckedListBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.chkTipoPago = new System.Windows.Forms.CheckedListBox();
            this.chkTodosEntidades = new System.Windows.Forms.CheckBox();
            this.chkTodosTipoPago = new System.Windows.Forms.CheckBox();
            this.txtPeriodo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // chkListaEntidades
            // 
            this.chkListaEntidades.FormattingEnabled = true;
            this.chkListaEntidades.HorizontalScrollbar = true;
            this.chkListaEntidades.Location = new System.Drawing.Point(8, 66);
            this.chkListaEntidades.Name = "chkListaEntidades";
            this.chkListaEntidades.Size = new System.Drawing.Size(297, 79);
            this.chkListaEntidades.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 12);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 13);
            this.label32.TabIndex = 56;
            this.label32.Text = "Período";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "(Ej. 2009)";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(658, 66);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(83, 79);
            this.btnFiltrar.TabIndex = 59;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkTipoPago
            // 
            this.chkTipoPago.FormattingEnabled = true;
            this.chkTipoPago.HorizontalScrollbar = true;
            this.chkTipoPago.Location = new System.Drawing.Point(311, 66);
            this.chkTipoPago.Name = "chkTipoPago";
            this.chkTipoPago.Size = new System.Drawing.Size(341, 79);
            this.chkTipoPago.TabIndex = 60;
            // 
            // chkTodosEntidades
            // 
            this.chkTodosEntidades.AutoSize = true;
            this.chkTodosEntidades.Location = new System.Drawing.Point(8, 47);
            this.chkTodosEntidades.Name = "chkTodosEntidades";
            this.chkTodosEntidades.Size = new System.Drawing.Size(112, 17);
            this.chkTodosEntidades.TabIndex = 64;
            this.chkTodosEntidades.Text = "Todos los Clientes";
            this.chkTodosEntidades.UseVisualStyleBackColor = true;
            this.chkTodosEntidades.CheckedChanged += new System.EventHandler(this.chkTodosEntidades_CheckedChanged);
            // 
            // chkTodosTipoPago
            // 
            this.chkTodosTipoPago.AutoSize = true;
            this.chkTodosTipoPago.Location = new System.Drawing.Point(311, 47);
            this.chkTodosTipoPago.Name = "chkTodosTipoPago";
            this.chkTodosTipoPago.Size = new System.Drawing.Size(101, 17);
            this.chkTodosTipoPago.TabIndex = 65;
            this.chkTodosTipoPago.Text = "Todos los Tipos";
            this.chkTodosTipoPago.UseVisualStyleBackColor = true;
            this.chkTodosTipoPago.CheckedChanged += new System.EventHandler(this.chkTodosTipoPago_CheckedChanged);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(50, 9);
            this.txtPeriodo.Mask = "9999";
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(45, 20);
            this.txtPeriodo.TabIndex = 66;
            // 
            // PanelFiltroCobranzasMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.chkTodosTipoPago);
            this.Controls.Add(this.chkTodosEntidades);
            this.Controls.Add(this.chkTipoPago);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.chkListaEntidades);
            this.Name = "PanelFiltroCobranzasMensuales";
            this.Size = new System.Drawing.Size(750, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListaEntidades;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckedListBox chkTipoPago;
        private System.Windows.Forms.CheckBox chkTodosEntidades;
        private System.Windows.Forms.CheckBox chkTodosTipoPago;
        private System.Windows.Forms.MaskedTextBox txtPeriodo;
    }
}
