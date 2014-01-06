namespace cuGenerarInformes
{
    partial class PanelSeleccionTemplateLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelSeleccionTemplateLista));
            this.txtCmbNombre = new System.Windows.Forms.ComboBox();
            this.txtDescTemplate = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnOFD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCmbNombre
            // 
            this.txtCmbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtCmbNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCmbNombre.FormattingEnabled = true;
            this.txtCmbNombre.Location = new System.Drawing.Point(9, 27);
            this.txtCmbNombre.Name = "txtCmbNombre";
            this.txtCmbNombre.Size = new System.Drawing.Size(249, 21);
            this.txtCmbNombre.TabIndex = 0;
            this.txtCmbNombre.SelectedIndexChanged += new System.EventHandler(this.txtCmbNombre_SelectedIndexChanged);
            // 
            // txtDescTemplate
            // 
            this.txtDescTemplate.Location = new System.Drawing.Point(264, 27);
            this.txtDescTemplate.Name = "txtDescTemplate";
            this.txtDescTemplate.ReadOnly = true;
            this.txtDescTemplate.Size = new System.Drawing.Size(264, 20);
            this.txtDescTemplate.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(432, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(315, 102);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 27);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "&Generar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Archivo de Plantilla";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Location = new System.Drawing.Point(-3, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 56);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(55, 61);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(437, 20);
            this.txtDestino.TabIndex = 9;
            // 
            // btnOFD
            // 
            this.btnOFD.Image = global::cuGenerarInformes.Properties.Resources.world;
            this.btnOFD.Location = new System.Drawing.Point(496, 59);
            this.btnOFD.Name = "btnOFD";
            this.btnOFD.Size = new System.Drawing.Size(32, 23);
            this.btnOFD.TabIndex = 11;
            this.btnOFD.UseVisualStyleBackColor = true;
            this.btnOFD.Click += new System.EventHandler(this.btnOFD_Click);
            // 
            // PanelSeleccionTemplateLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOFD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescTemplate);
            this.Controls.Add(this.txtCmbNombre);
            this.Controls.Add(this.groupBox1);
            this.Name = "PanelSeleccionTemplateLista";
            this.Size = new System.Drawing.Size(537, 136);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtCmbNombre;
        private System.Windows.Forms.TextBox txtDescTemplate;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnOFD;
    }
}
