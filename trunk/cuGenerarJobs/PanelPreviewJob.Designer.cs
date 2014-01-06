namespace cuGenerarJobs
{
    partial class PanelPreviewJob
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpEjecuciones = new System.Windows.Forms.GroupBox();
            this.txtSiguiente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUltima = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFrecuencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblCorriendo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grpEjecuciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(311, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(78, 111);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(581, 100);
            this.txtDescripcion.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(89, 21);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.ReadOnly = true;
            this.txtInicio.Size = new System.Drawing.Size(165, 20);
            this.txtInicio.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Inicio";
            // 
            // grpEjecuciones
            // 
            this.grpEjecuciones.Controls.Add(this.txtSiguiente);
            this.grpEjecuciones.Controls.Add(this.label6);
            this.grpEjecuciones.Controls.Add(this.txtUltima);
            this.grpEjecuciones.Controls.Add(this.label5);
            this.grpEjecuciones.Controls.Add(this.txtInicio);
            this.grpEjecuciones.Controls.Add(this.label4);
            this.grpEjecuciones.Location = new System.Drawing.Point(395, 3);
            this.grpEjecuciones.Name = "grpEjecuciones";
            this.grpEjecuciones.Size = new System.Drawing.Size(264, 102);
            this.grpEjecuciones.TabIndex = 2;
            this.grpEjecuciones.TabStop = false;
            this.grpEjecuciones.Text = "Ejecuciones";
            // 
            // txtSiguiente
            // 
            this.txtSiguiente.Location = new System.Drawing.Point(89, 75);
            this.txtSiguiente.Name = "txtSiguiente";
            this.txtSiguiente.ReadOnly = true;
            this.txtSiguiente.Size = new System.Drawing.Size(165, 20);
            this.txtSiguiente.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Siguiente";
            // 
            // txtUltima
            // 
            this.txtUltima.Location = new System.Drawing.Point(89, 48);
            this.txtUltima.Name = "txtUltima";
            this.txtUltima.ReadOnly = true;
            this.txtUltima.Size = new System.Drawing.Size(165, 20);
            this.txtUltima.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Más Reciente";
            // 
            // txtFrecuencia
            // 
            this.txtFrecuencia.Location = new System.Drawing.Point(78, 36);
            this.txtFrecuencia.Name = "txtFrecuencia";
            this.txtFrecuencia.ReadOnly = true;
            this.txtFrecuencia.Size = new System.Drawing.Size(311, 20);
            this.txtFrecuencia.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Frecuencia";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActivo.Enabled = false;
            this.chkActivo.Location = new System.Drawing.Point(37, 62);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblCorriendo
            // 
            this.lblCorriendo.AutoSize = true;
            this.lblCorriendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorriendo.Location = new System.Drawing.Point(78, 218);
            this.lblCorriendo.Name = "lblCorriendo";
            this.lblCorriendo.Size = new System.Drawing.Size(378, 13);
            this.lblCorriendo.TabIndex = 6;
            this.lblCorriendo.Text = "NOTA: El Trabajo se encuentra en ejecución en estos momentos!";
            this.lblCorriendo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Para Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(78, 84);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(311, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCorriendo);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFrecuencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.grpEjecuciones);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(664, 237);
            this.grpEjecuciones.ResumeLayout(false);
            this.grpEjecuciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpEjecuciones;
        private System.Windows.Forms.TextBox txtSiguiente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUltima;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFrecuencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblCorriendo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}
