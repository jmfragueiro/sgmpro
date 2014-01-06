namespace cuConfigurarUsuarios {
    partial class PanelPreviewUsuario
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
            this.txtFechaUMod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ctrlTxtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlTxtEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlTxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlTxtLegajo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGestion = new System.Windows.Forms.GroupBox();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.grpGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlChkActivo
            // 
            this.ctrlChkActivo.AutoSize = true;
            this.ctrlChkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlChkActivo.Enabled = false;
            this.ctrlChkActivo.Location = new System.Drawing.Point(430, 18);
            this.ctrlChkActivo.Name = "ctrlChkActivo";
            this.ctrlChkActivo.Size = new System.Drawing.Size(95, 17);
            this.ctrlChkActivo.TabIndex = 38;
            this.ctrlChkActivo.Text = "Usuario Activo";
            this.ctrlChkActivo.UseVisualStyleBackColor = true;
            // 
            // txtFechaUMod
            // 
            this.txtFechaUMod.Location = new System.Drawing.Point(97, 156);
            this.txtFechaUMod.Name = "txtFechaUMod";
            this.txtFechaUMod.ReadOnly = true;
            this.txtFechaUMod.Size = new System.Drawing.Size(180, 20);
            this.txtFechaUMod.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Fecha de Act.";
            // 
            // ctrlTxtPassword
            // 
            this.ctrlTxtPassword.Location = new System.Drawing.Point(97, 121);
            this.ctrlTxtPassword.Name = "ctrlTxtPassword";
            this.ctrlTxtPassword.PasswordChar = '*';
            this.ctrlTxtPassword.ReadOnly = true;
            this.ctrlTxtPassword.Size = new System.Drawing.Size(180, 20);
            this.ctrlTxtPassword.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Password";
            // 
            // ctrlTxtEmpleado
            // 
            this.ctrlTxtEmpleado.Location = new System.Drawing.Point(97, 86);
            this.ctrlTxtEmpleado.Name = "ctrlTxtEmpleado";
            this.ctrlTxtEmpleado.ReadOnly = true;
            this.ctrlTxtEmpleado.Size = new System.Drawing.Size(428, 20);
            this.ctrlTxtEmpleado.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Empleado";
            // 
            // ctrlTxtNombre
            // 
            this.ctrlTxtNombre.Location = new System.Drawing.Point(97, 51);
            this.ctrlTxtNombre.Name = "ctrlTxtNombre";
            this.ctrlTxtNombre.ReadOnly = true;
            this.ctrlTxtNombre.Size = new System.Drawing.Size(180, 20);
            this.ctrlTxtNombre.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre";
            // 
            // ctrlTxtLegajo
            // 
            this.ctrlTxtLegajo.Location = new System.Drawing.Point(97, 16);
            this.ctrlTxtLegajo.Name = "ctrlTxtLegajo";
            this.ctrlTxtLegajo.ReadOnly = true;
            this.ctrlTxtLegajo.Size = new System.Drawing.Size(180, 20);
            this.ctrlTxtLegajo.TabIndex = 37;
            this.ctrlTxtLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Legajo";
            // 
            // grpGestion
            // 
            this.grpGestion.Controls.Add(this.lblCuentas);
            this.grpGestion.Location = new System.Drawing.Point(290, 114);
            this.grpGestion.Name = "grpGestion";
            this.grpGestion.Size = new System.Drawing.Size(235, 62);
            this.grpGestion.TabIndex = 48;
            this.grpGestion.TabStop = false;
            this.grpGestion.Text = "Datos de Gestión";
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Location = new System.Drawing.Point(27, 30);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(191, 13);
            this.lblCuentas.TabIndex = 46;
            this.lblCuentas.Text = "El Usuario posee 0 cuentas asignadas.";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpGestion);
            this.Controls.Add(this.ctrlChkActivo);
            this.Controls.Add(this.txtFechaUMod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ctrlTxtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctrlTxtEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlTxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlTxtLegajo);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(555, 194);
            this.grpGestion.ResumeLayout(false);
            this.grpGestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ctrlChkActivo;
        private System.Windows.Forms.TextBox txtFechaUMod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ctrlTxtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctrlTxtEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctrlTxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctrlTxtLegajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpGestion;
        private System.Windows.Forms.Label lblCuentas;
    }
}