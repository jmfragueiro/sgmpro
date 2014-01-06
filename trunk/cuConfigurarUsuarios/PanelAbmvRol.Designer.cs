namespace cuConfigurarUsuarios {
    partial class PanelAbmvRol
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
            this.ctrlTxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPermisos = new System.Windows.Forms.TabPage();
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.ctrlChkActivo = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlTxtNombre
            // 
            this.ctrlTxtNombre.Location = new System.Drawing.Point(82, 18);
            this.ctrlTxtNombre.Name = "ctrlTxtNombre";
            this.ctrlTxtNombre.ReadOnly = true;
            this.ctrlTxtNombre.Size = new System.Drawing.Size(204, 20);
            this.ctrlTxtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(82, 44);
            this.ctrlTxtDescripcion.Multiline = true;
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ReadOnly = true;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(458, 43);
            this.ctrlTxtDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Descripción";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPermisos);
            this.tabControl.Controls.Add(this.tabRoles);
            this.tabControl.Controls.Add(this.tabUsuarios);
            this.tabControl.Location = new System.Drawing.Point(5, 101);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(539, 249);
            this.tabControl.TabIndex = 11;
            // 
            // tabPermisos
            // 
            this.tabPermisos.Location = new System.Drawing.Point(4, 22);
            this.tabPermisos.Name = "tabPermisos";
            this.tabPermisos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPermisos.Size = new System.Drawing.Size(531, 223);
            this.tabPermisos.TabIndex = 4;
            this.tabPermisos.Text = "Permisos (0)";
            this.tabPermisos.UseVisualStyleBackColor = true;
            // 
            // tabRoles
            // 
            this.tabRoles.Location = new System.Drawing.Point(4, 22);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoles.Size = new System.Drawing.Size(531, 223);
            this.tabRoles.TabIndex = 5;
            this.tabRoles.Text = "Roles (0)";
            this.tabRoles.UseVisualStyleBackColor = true;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(531, 223);
            this.tabUsuarios.TabIndex = 6;
            this.tabUsuarios.Text = "Usuarios (0)";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // ctrlChkActivo
            // 
            this.ctrlChkActivo.AutoSize = true;
            this.ctrlChkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlChkActivo.Location = new System.Drawing.Point(465, 20);
            this.ctrlChkActivo.Name = "ctrlChkActivo";
            this.ctrlChkActivo.Size = new System.Drawing.Size(75, 17);
            this.ctrlChkActivo.TabIndex = 2;
            this.ctrlChkActivo.Text = "Rol Activo";
            this.ctrlChkActivo.UseVisualStyleBackColor = true;
            // 
            // PanelAbmvRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlChkActivo);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ctrlTxtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlTxtNombre);
            this.Controls.Add(this.label2);
            this.Name = "PanelAbmvRol";
            this.Size = new System.Drawing.Size(549, 354);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctrlTxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPermisos;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.CheckBox ctrlChkActivo;
    }
}