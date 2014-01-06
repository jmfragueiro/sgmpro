namespace cuGenerarInformes
{
    partial class PanelSeleccionTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelSeleccionTemplate));
            this.txtCmbNombre = new System.Windows.Forms.ComboBox();
            this.txtDescTemplate = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.txtDescTemplate.Location = new System.Drawing.Point(264, 28);
            this.txtDescTemplate.Name = "txtDescTemplate";
            this.txtDescTemplate.ReadOnly = true;
            this.txtDescTemplate.Size = new System.Drawing.Size(264, 20);
            this.txtDescTemplate.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(429, 69);
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
            this.btnAceptar.Location = new System.Drawing.Point(315, 69);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 27);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "&Imprimir";
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
            this.groupBox1.Location = new System.Drawing.Point(-3, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 56);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // PanelSeleccionTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescTemplate);
            this.Controls.Add(this.txtCmbNombre);
            this.Controls.Add(this.groupBox1);
            this.Name = "PanelSeleccionTemplate";
            this.Size = new System.Drawing.Size(537, 102);
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
    }
}
