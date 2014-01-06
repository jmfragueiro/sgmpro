namespace cuConfigurarUsuarios {
    partial class PanelPreviewPerfil
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
            if (disposing && (components != null))
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
            this.ctrlChkActivo = new System.Windows.Forms.CheckBox();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlTxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ctrlChkActivo
            // 
            this.ctrlChkActivo.AutoSize = true;
            this.ctrlChkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlChkActivo.Enabled = false;
            this.ctrlChkActivo.Location = new System.Drawing.Point(477, 17);
            this.ctrlChkActivo.Name = "ctrlChkActivo";
            this.ctrlChkActivo.Size = new System.Drawing.Size(82, 17);
            this.ctrlChkActivo.TabIndex = 25;
            this.ctrlChkActivo.Text = "Perfil Activo";
            this.ctrlChkActivo.UseVisualStyleBackColor = true;
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(178, 40);
            this.ctrlTxtDescripcion.Multiline = true;
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ReadOnly = true;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(374, 43);
            this.ctrlTxtDescripcion.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Descripción";
            // 
            // ctrlTxtNombre
            // 
            this.ctrlTxtNombre.Location = new System.Drawing.Point(178, 14);
            this.ctrlTxtNombre.Name = "ctrlTxtNombre";
            this.ctrlTxtNombre.ReadOnly = true;
            this.ctrlTxtNombre.Size = new System.Drawing.Size(204, 20);
            this.ctrlTxtNombre.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cantidad de Usuarios Asociados";
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Location = new System.Drawing.Point(178, 89);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.ReadOnly = true;
            this.txtUsuarios.Size = new System.Drawing.Size(90, 20);
            this.txtUsuarios.TabIndex = 26;
            // 
            // PanelPreviewPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlChkActivo);
            this.Controls.Add(this.ctrlTxtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctrlTxtNombre);
            this.Controls.Add(this.label2);
            this.Name = "PanelPreviewPerfil";
            this.Size = new System.Drawing.Size(564, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ctrlChkActivo;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctrlTxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuarios;




    }
}