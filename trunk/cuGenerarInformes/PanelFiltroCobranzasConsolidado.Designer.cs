using scioThirdPartLibrary;

namespace cuGenerarInformes
{
    partial class PanelFiltroCobranzasConsolidado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelFiltroCobranzasConsolidado));
            this.chkListaEntidades = new System.Windows.Forms.CheckedListBox();
            this.chkTodosEntidades = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTodosTipoPago = new System.Windows.Forms.CheckBox();
            this.chkTipoPago = new System.Windows.Forms.CheckedListBox();
            this.dtpFechaHasta = new scioThirdPartLibrary.NullableDateTimePicker();
            this.dtpFechaDesde = new scioThirdPartLibrary.NullableDateTimePicker();
            this.SuspendLayout();
            // 
            // chkListaEntidades
            // 
            this.chkListaEntidades.FormattingEnabled = true;
            this.chkListaEntidades.HorizontalScrollbar = true;
            this.chkListaEntidades.Location = new System.Drawing.Point(8, 66);
            this.chkListaEntidades.Name = "chkListaEntidades";
            this.chkListaEntidades.Size = new System.Drawing.Size(240, 79);
            this.chkListaEntidades.TabIndex = 2;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Desde";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(435, 66);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(83, 79);
            this.btnFiltrar.TabIndex = 59;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Hasta";
            // 
            // chkTodosTipoPago
            // 
            this.chkTodosTipoPago.AutoSize = true;
            this.chkTodosTipoPago.Location = new System.Drawing.Point(254, 47);
            this.chkTodosTipoPago.Name = "chkTodosTipoPago";
            this.chkTodosTipoPago.Size = new System.Drawing.Size(101, 17);
            this.chkTodosTipoPago.TabIndex = 73;
            this.chkTodosTipoPago.Text = "Todos los Tipos";
            this.chkTodosTipoPago.UseVisualStyleBackColor = true;
            this.chkTodosTipoPago.Visible = false;
            // 
            // chkTipoPago
            // 
            this.chkTipoPago.FormattingEnabled = true;
            this.chkTipoPago.HorizontalScrollbar = true;
            this.chkTipoPago.Location = new System.Drawing.Point(254, 66);
            this.chkTipoPago.Name = "chkTipoPago";
            this.chkTipoPago.Size = new System.Drawing.Size(175, 79);
            this.chkTipoPago.TabIndex = 72;
            this.chkTipoPago.Visible = false;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(207, 5);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaHasta.TabIndex = 75;
            this.dtpFechaHasta.Value = new System.DateTime(2010, 4, 22, 18, 27, 51, 859);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(48, 5);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaDesde.TabIndex = 74;
            this.dtpFechaDesde.Value = new System.DateTime(2010, 4, 22, 18, 27, 51, 859);
            // 
            // PanelFiltroCobranzasConsolidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.chkTodosTipoPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkTodosEntidades);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.chkListaEntidades);
            this.Controls.Add(this.chkTipoPago);
            this.Name = "PanelFiltroCobranzasConsolidado";
            this.Size = new System.Drawing.Size(526, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListaEntidades;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckBox chkTodosEntidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTodosTipoPago;
        private System.Windows.Forms.CheckedListBox chkTipoPago;
        private NullableDateTimePicker dtpFechaHasta;
        private NullableDateTimePicker dtpFechaDesde;
    }
}
