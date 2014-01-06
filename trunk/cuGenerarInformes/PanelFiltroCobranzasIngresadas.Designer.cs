using scioThirdPartLibrary;

namespace cuGenerarInformes
{
    partial class PanelFiltroCobranzasIngresadas
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
            this.label32 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.chkTipoPago = new System.Windows.Forms.CheckedListBox();
            this.chkFormaPago = new System.Windows.Forms.CheckedListBox();
            this.chkTodosEntidades = new System.Windows.Forms.CheckBox();
            this.chkTodosTipoPago = new System.Windows.Forms.CheckBox();
            this.chkTodoFormaPago = new System.Windows.Forms.CheckBox();
            this.chkEstado = new System.Windows.Forms.CheckedListBox();
            this.chkTodoEstado = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.cmbFiltroRend = new System.Windows.Forms.ComboBox();
            this.dtpFechaHasta = new scioThirdPartLibrary.NullableDateTimePicker();
            this.dtpFechaDesde = new scioThirdPartLibrary.NullableDateTimePicker();
            this.groupBox1.SuspendLayout();
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
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 12);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(38, 13);
            this.label32.TabIndex = 56;
            this.label32.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Hasta";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = global::cuGenerarInformes.Properties.Resources.Refresh_24x24;
            this.btnFiltrar.Location = new System.Drawing.Point(797, 66);
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
            this.chkTipoPago.Location = new System.Drawing.Point(254, 66);
            this.chkTipoPago.Name = "chkTipoPago";
            this.chkTipoPago.Size = new System.Drawing.Size(175, 79);
            this.chkTipoPago.TabIndex = 60;
            // 
            // chkFormaPago
            // 
            this.chkFormaPago.FormattingEnabled = true;
            this.chkFormaPago.HorizontalScrollbar = true;
            this.chkFormaPago.Location = new System.Drawing.Point(435, 66);
            this.chkFormaPago.Name = "chkFormaPago";
            this.chkFormaPago.Size = new System.Drawing.Size(175, 79);
            this.chkFormaPago.TabIndex = 61;
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
            this.chkTodosTipoPago.Location = new System.Drawing.Point(254, 47);
            this.chkTodosTipoPago.Name = "chkTodosTipoPago";
            this.chkTodosTipoPago.Size = new System.Drawing.Size(101, 17);
            this.chkTodosTipoPago.TabIndex = 65;
            this.chkTodosTipoPago.Text = "Todos los Tipos";
            this.chkTodosTipoPago.UseVisualStyleBackColor = true;
            this.chkTodosTipoPago.CheckedChanged += new System.EventHandler(this.chkTodosTipoPago_CheckedChanged);
            // 
            // chkTodoFormaPago
            // 
            this.chkTodoFormaPago.AutoSize = true;
            this.chkTodoFormaPago.Location = new System.Drawing.Point(435, 47);
            this.chkTodoFormaPago.Name = "chkTodoFormaPago";
            this.chkTodoFormaPago.Size = new System.Drawing.Size(109, 17);
            this.chkTodoFormaPago.TabIndex = 66;
            this.chkTodoFormaPago.Text = "Todas las Formas";
            this.chkTodoFormaPago.UseVisualStyleBackColor = true;
            this.chkTodoFormaPago.CheckedChanged += new System.EventHandler(this.chkTodoFormaPago_CheckedChanged);
            // 
            // chkEstado
            // 
            this.chkEstado.FormattingEnabled = true;
            this.chkEstado.HorizontalScrollbar = true;
            this.chkEstado.Location = new System.Drawing.Point(616, 66);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(175, 79);
            this.chkEstado.TabIndex = 61;
            // 
            // chkTodoEstado
            // 
            this.chkTodoEstado.AutoSize = true;
            this.chkTodoEstado.Location = new System.Drawing.Point(616, 47);
            this.chkTodoEstado.Name = "chkTodoEstado";
            this.chkTodoEstado.Size = new System.Drawing.Size(113, 17);
            this.chkTodoEstado.TabIndex = 66;
            this.chkTodoEstado.Text = "Todos los Estados";
            this.chkTodoEstado.UseVisualStyleBackColor = true;
            this.chkTodoEstado.CheckedChanged += new System.EventHandler(this.chkTodoEstado_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDesmarcar);
            this.groupBox1.Controls.Add(this.btnMarcar);
            this.groupBox1.Location = new System.Drawing.Point(697, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 38);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Location = new System.Drawing.Point(93, 10);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(75, 23);
            this.btnDesmarcar.TabIndex = 70;
            this.btnDesmarcar.Text = "No Rendido";
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(12, 10);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(75, 23);
            this.btnMarcar.TabIndex = 69;
            this.btnMarcar.Text = "Rendido";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // cmbFiltroRend
            // 
            this.cmbFiltroRend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroRend.FormattingEnabled = true;
            this.cmbFiltroRend.Items.AddRange(new object[] {
            "Todos",
            "Rendidos",
            "No Rendidos"});
            this.cmbFiltroRend.Location = new System.Drawing.Point(790, 42);
            this.cmbFiltroRend.Name = "cmbFiltroRend";
            this.cmbFiltroRend.Size = new System.Drawing.Size(90, 21);
            this.cmbFiltroRend.TabIndex = 69;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(209, 8);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaHasta.TabIndex = 1;
            this.dtpFechaHasta.Value = new System.DateTime(2010, 4, 22, 18, 27, 51, 859);
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
            // PanelFiltroCobranzasIngresadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbFiltroRend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkTodoEstado);
            this.Controls.Add(this.chkTodoFormaPago);
            this.Controls.Add(this.chkTodosTipoPago);
            this.Controls.Add(this.chkTodosEntidades);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.chkFormaPago);
            this.Controls.Add(this.chkTipoPago);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.chkListaEntidades);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "PanelFiltroCobranzasIngresadas";
            this.Size = new System.Drawing.Size(892, 150);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NullableDateTimePicker dtpFechaDesde;
        private NullableDateTimePicker dtpFechaHasta;
        private System.Windows.Forms.CheckedListBox chkListaEntidades;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckedListBox chkTipoPago;
        private System.Windows.Forms.CheckedListBox chkFormaPago;
        private System.Windows.Forms.CheckBox chkTodosEntidades;
        private System.Windows.Forms.CheckBox chkTodosTipoPago;
        private System.Windows.Forms.CheckBox chkTodoFormaPago;
        private System.Windows.Forms.CheckedListBox chkEstado;
        private System.Windows.Forms.CheckBox chkTodoEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.ComboBox cmbFiltroRend;
    }
}
