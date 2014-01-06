namespace cuConfigurarUsuarios {
    partial class PanelAbmvUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlTxtLegajo = new System.Windows.Forms.TextBox();
            this.ctrlTxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlTxtEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlTxtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaUMod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPerfiles = new System.Windows.Forms.TabPage();
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.tabSesiones = new System.Windows.Forms.TabPage();
            this.ctrlChkActivo = new System.Windows.Forms.CheckBox();
            this.grpGestion = new System.Windows.Forms.GroupBox();
            this.txtGestor = new System.Windows.Forms.TextBox();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlDelGestor = new System.Windows.Forms.Button();
            this.ctrlChangeGestor = new System.Windows.Forms.Button();
            this.ctrlListCuentas = new System.Windows.Forms.Button();
            this.ctrlFindGestor = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.grpGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Legajo";
            // 
            // ctrlTxtLegajo
            // 
            this.ctrlTxtLegajo.Location = new System.Drawing.Point(96, 12);
            this.ctrlTxtLegajo.Name = "ctrlTxtLegajo";
            this.ctrlTxtLegajo.ReadOnly = true;
            this.ctrlTxtLegajo.Size = new System.Drawing.Size(142, 20);
            this.ctrlTxtLegajo.TabIndex = 0;
            this.ctrlTxtLegajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ctrlTxtNombre
            // 
            this.ctrlTxtNombre.Location = new System.Drawing.Point(96, 38);
            this.ctrlTxtNombre.Name = "ctrlTxtNombre";
            this.ctrlTxtNombre.ReadOnly = true;
            this.ctrlTxtNombre.Size = new System.Drawing.Size(142, 20);
            this.ctrlTxtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // ctrlTxtEmpleado
            // 
            this.ctrlTxtEmpleado.Location = new System.Drawing.Point(96, 64);
            this.ctrlTxtEmpleado.Name = "ctrlTxtEmpleado";
            this.ctrlTxtEmpleado.ReadOnly = true;
            this.ctrlTxtEmpleado.Size = new System.Drawing.Size(445, 20);
            this.ctrlTxtEmpleado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Empleado";
            // 
            // ctrlTxtPassword
            // 
            this.ctrlTxtPassword.Location = new System.Drawing.Point(96, 90);
            this.ctrlTxtPassword.Name = "ctrlTxtPassword";
            this.ctrlTxtPassword.PasswordChar = '*';
            this.ctrlTxtPassword.ReadOnly = true;
            this.ctrlTxtPassword.Size = new System.Drawing.Size(142, 20);
            this.ctrlTxtPassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // txtFechaUMod
            // 
            this.txtFechaUMod.Location = new System.Drawing.Point(96, 116);
            this.txtFechaUMod.Name = "txtFechaUMod";
            this.txtFechaUMod.ReadOnly = true;
            this.txtFechaUMod.Size = new System.Drawing.Size(142, 20);
            this.txtFechaUMod.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fecha de Act.";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPerfiles);
            this.tabControl.Controls.Add(this.tabRoles);
            this.tabControl.Controls.Add(this.tabSesiones);
            this.tabControl.Location = new System.Drawing.Point(6, 152);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(539, 235);
            this.tabControl.TabIndex = 6;
            // 
            // tabPerfiles
            // 
            this.tabPerfiles.Location = new System.Drawing.Point(4, 22);
            this.tabPerfiles.Name = "tabPerfiles";
            this.tabPerfiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerfiles.Size = new System.Drawing.Size(531, 209);
            this.tabPerfiles.TabIndex = 0;
            this.tabPerfiles.Text = "Perfiles (0)";
            this.tabPerfiles.UseVisualStyleBackColor = true;
            // 
            // tabRoles
            // 
            this.tabRoles.Location = new System.Drawing.Point(4, 22);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoles.Size = new System.Drawing.Size(531, 209);
            this.tabRoles.TabIndex = 1;
            this.tabRoles.Text = "Roles (0)";
            this.tabRoles.UseVisualStyleBackColor = true;
            // 
            // tabSesiones
            // 
            this.tabSesiones.Location = new System.Drawing.Point(4, 22);
            this.tabSesiones.Name = "tabSesiones";
            this.tabSesiones.Padding = new System.Windows.Forms.Padding(3);
            this.tabSesiones.Size = new System.Drawing.Size(531, 209);
            this.tabSesiones.TabIndex = 2;
            this.tabSesiones.Text = "Sesiones (0)";
            this.tabSesiones.UseVisualStyleBackColor = true;
            // 
            // ctrlChkActivo
            // 
            this.ctrlChkActivo.AutoSize = true;
            this.ctrlChkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlChkActivo.Location = new System.Drawing.Point(446, 14);
            this.ctrlChkActivo.Name = "ctrlChkActivo";
            this.ctrlChkActivo.Size = new System.Drawing.Size(95, 17);
            this.ctrlChkActivo.TabIndex = 1;
            this.ctrlChkActivo.Text = "Usuario Activo";
            this.ctrlChkActivo.UseVisualStyleBackColor = true;
            // 
            // grpGestion
            // 
            this.grpGestion.Controls.Add(this.ctrlDelGestor);
            this.grpGestion.Controls.Add(this.ctrlChangeGestor);
            this.grpGestion.Controls.Add(this.ctrlListCuentas);
            this.grpGestion.Controls.Add(this.ctrlFindGestor);
            this.grpGestion.Controls.Add(this.txtGestor);
            this.grpGestion.Controls.Add(this.lblCuentas);
            this.grpGestion.Controls.Add(this.label5);
            this.grpGestion.Location = new System.Drawing.Point(244, 84);
            this.grpGestion.Name = "grpGestion";
            this.grpGestion.Size = new System.Drawing.Size(297, 72);
            this.grpGestion.TabIndex = 5;
            this.grpGestion.TabStop = false;
            this.grpGestion.Text = "Datos de Gestión";
            // 
            // txtGestor
            // 
            this.txtGestor.Location = new System.Drawing.Point(94, 42);
            this.txtGestor.Name = "txtGestor";
            this.txtGestor.ReadOnly = true;
            this.txtGestor.Size = new System.Drawing.Size(109, 20);
            this.txtGestor.TabIndex = 8;
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Location = new System.Drawing.Point(6, 21);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(191, 13);
            this.lblCuentas.TabIndex = 26;
            this.lblCuentas.Text = "El Usuario posee 0 cuentas asignadas.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Pasar cuentas a";
            // 
            // ctrlDelGestor
            // 
            this.ctrlDelGestor.Image = global::cuConfigurarUsuarios.Properties.Resources.borrar;
            this.ctrlDelGestor.Location = new System.Drawing.Point(263, 40);
            this.ctrlDelGestor.Name = "ctrlDelGestor";
            this.ctrlDelGestor.Size = new System.Drawing.Size(27, 23);
            this.ctrlDelGestor.TabIndex = 2;
            this.ctrlDelGestor.Tag = "BOTON.CUENTA.DESASIGNAR";
            this.ctrlDelGestor.UseVisualStyleBackColor = true;
            this.ctrlDelGestor.Click += new System.EventHandler(this.ctrlDelGestor_Click);
            // 
            // ctrlChangeGestor
            // 
            this.ctrlChangeGestor.Image = global::cuConfigurarUsuarios.Properties.Resources.Next_16x16;
            this.ctrlChangeGestor.Location = new System.Drawing.Point(235, 40);
            this.ctrlChangeGestor.Name = "ctrlChangeGestor";
            this.ctrlChangeGestor.Size = new System.Drawing.Size(27, 23);
            this.ctrlChangeGestor.TabIndex = 1;
            this.ctrlChangeGestor.Tag = "BOTON.CUENTA.ASIGNAR";
            this.ctrlChangeGestor.UseVisualStyleBackColor = true;
            this.ctrlChangeGestor.Click += new System.EventHandler(this.ctrlChangeGestor_Click);
            // 
            // ctrlListCuentas
            // 
            this.ctrlListCuentas.Image = global::cuConfigurarUsuarios.Properties.Resources.cuenta;
            this.ctrlListCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctrlListCuentas.Location = new System.Drawing.Point(207, 16);
            this.ctrlListCuentas.Name = "ctrlListCuentas";
            this.ctrlListCuentas.Size = new System.Drawing.Size(83, 23);
            this.ctrlListCuentas.TabIndex = 0;
            this.ctrlListCuentas.Text = "Ver Ctas.";
            this.ctrlListCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlListCuentas.UseVisualStyleBackColor = true;
            this.ctrlListCuentas.Click += new System.EventHandler(this.ctrlListCuentas_Click);
            // 
            // ctrlFindGestor
            // 
            this.ctrlFindGestor.Image = global::cuConfigurarUsuarios.Properties.Resources.seleccionar;
            this.ctrlFindGestor.Location = new System.Drawing.Point(207, 40);
            this.ctrlFindGestor.Name = "ctrlFindGestor";
            this.ctrlFindGestor.Size = new System.Drawing.Size(27, 23);
            this.ctrlFindGestor.TabIndex = 0;
            this.ctrlFindGestor.Tag = "BOTON.CUENTA.ASIGNAR";
            this.ctrlFindGestor.UseVisualStyleBackColor = true;
            this.ctrlFindGestor.Click += new System.EventHandler(this.ctrlFindGestor_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpGestion);
            this.Controls.Add(this.ctrlChkActivo);
            this.Controls.Add(this.tabControl);
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
            this.Size = new System.Drawing.Size(549, 391);
            this.tabControl.ResumeLayout(false);
            this.grpGestion.ResumeLayout(false);
            this.grpGestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctrlTxtLegajo;
        private System.Windows.Forms.TextBox ctrlTxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctrlTxtEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctrlTxtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaUMod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPerfiles;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.TabPage tabSesiones;
        private System.Windows.Forms.CheckBox ctrlChkActivo;
        private System.Windows.Forms.GroupBox grpGestion;
        private System.Windows.Forms.TextBox txtGestor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ctrlChangeGestor;
        private System.Windows.Forms.Button ctrlFindGestor;
        private System.Windows.Forms.Button ctrlDelGestor;
        private System.Windows.Forms.Label lblCuentas;
        private System.Windows.Forms.Button ctrlListCuentas;
    }
}