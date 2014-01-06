namespace cuGenerarInformes
{
    partial class PanelFiltroAccionesRealizadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelFiltroAccionesRealizadas));
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkTodosEntidades = new System.Windows.Forms.CheckBox();
            this.chkListaEntidades = new System.Windows.Forms.CheckedListBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtFiltroDni = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(53, 6);
            this.txtDesde.Mask = "00/00/0000";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(83, 20);
            this.txtDesde.TabIndex = 5;
            this.txtDesde.ValidatingType = typeof(System.DateTime);
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
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(183, 6);
            this.txtHasta.Mask = "00/00/0000";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(83, 20);
            this.txtHasta.TabIndex = 10;
            this.txtHasta.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Hasta";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(56, 42);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(201, 20);
            this.txtFiltroNombre.TabIndex = 20;
            this.txtFiltroNombre.Enter += new System.EventHandler(this.txtFiltroNombre_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiltroDni);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFiltroNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 109);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda Deudor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "(Sin ptos)";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::cuGenerarInformes.Properties.Resources.magnifier;
            this.btnBuscar.Location = new System.Drawing.Point(56, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(42, 35);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Dni";
            // 
            // chkTodosEntidades
            // 
            this.chkTodosEntidades.AutoSize = true;
            this.chkTodosEntidades.Location = new System.Drawing.Point(285, 9);
            this.chkTodosEntidades.Name = "chkTodosEntidades";
            this.chkTodosEntidades.Size = new System.Drawing.Size(121, 17);
            this.chkTodosEntidades.TabIndex = 30;
            this.chkTodosEntidades.TabStop = false;
            this.chkTodosEntidades.Text = "Todos los Deudores";
            this.chkTodosEntidades.UseVisualStyleBackColor = true;
            this.chkTodosEntidades.CheckedChanged += new System.EventHandler(this.chkTodosEntidades_CheckedChanged);
            // 
            // chkListaEntidades
            // 
            this.chkListaEntidades.FormattingEnabled = true;
            this.chkListaEntidades.HorizontalScrollbar = true;
            this.chkListaEntidades.Location = new System.Drawing.Point(285, 32);
            this.chkListaEntidades.Name = "chkListaEntidades";
            this.chkListaEntidades.Size = new System.Drawing.Size(240, 109);
            this.chkListaEntidades.TabIndex = 35;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(531, 62);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(83, 79);
            this.btnFiltrar.TabIndex = 40;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtFiltroDni
            // 
            this.txtFiltroDni.Location = new System.Drawing.Point(56, 16);
            this.txtFiltroDni.Name = "txtFiltroDni";
            this.txtFiltroDni.Size = new System.Drawing.Size(83, 20);
            this.txtFiltroDni.TabIndex = 81;
            this.txtFiltroDni.Enter += new System.EventHandler(this.txtFiltroDni_Enter);
            // 
            // PanelFiltroAccionesRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkTodosEntidades);
            this.Controls.Add(this.chkListaEntidades);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.btnFiltrar);
            this.Name = "PanelFiltroAccionesRealizadas";
            this.Size = new System.Drawing.Size(621, 150);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTodosEntidades;
        private System.Windows.Forms.CheckedListBox chkListaEntidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiltroDni;
    }
}
