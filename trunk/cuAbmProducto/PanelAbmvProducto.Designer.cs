namespace cuAbmProducto {
    partial class PanelAbmvProducto
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ctrlTxtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlTxtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctrlChkActivada = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTramos = new System.Windows.Forms.TabPage();
            this.tabCuentas = new System.Windows.Forms.TabPage();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.ctrlChkActualizar = new System.Windows.Forms.CheckBox();
            this.ctrlChkTemporal = new System.Windows.Forms.CheckBox();
            this.ctrlChkDeudaCuotas = new System.Windows.Forms.CheckBox();
            this.ctrlChkUnificar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlTxtImputacion = new System.Windows.Forms.TextBox();
            this.grpPagos = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.grpPagos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(83, 110);
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ReadOnly = true;
            this.ctrlTxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(541, 20);
            this.ctrlTxtDescripcion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descripción";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Entidad";
            // 
            // ctrlTxtCodigo
            // 
            this.ctrlTxtCodigo.Location = new System.Drawing.Point(83, 58);
            this.ctrlTxtCodigo.Name = "ctrlTxtCodigo";
            this.ctrlTxtCodigo.ReadOnly = true;
            this.ctrlTxtCodigo.Size = new System.Drawing.Size(402, 20);
            this.ctrlTxtCodigo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Código";
            // 
            // ctrlTxtNombre
            // 
            this.ctrlTxtNombre.Location = new System.Drawing.Point(83, 84);
            this.ctrlTxtNombre.Name = "ctrlTxtNombre";
            this.ctrlTxtNombre.ReadOnly = true;
            this.ctrlTxtNombre.Size = new System.Drawing.Size(402, 20);
            this.ctrlTxtNombre.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre";
            // 
            // ctrlChkActivada
            // 
            this.ctrlChkActivada.AutoSize = true;
            this.ctrlChkActivada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlChkActivada.Location = new System.Drawing.Point(42, 35);
            this.ctrlChkActivada.Name = "ctrlChkActivada";
            this.ctrlChkActivada.Size = new System.Drawing.Size(56, 17);
            this.ctrlChkActivada.TabIndex = 0;
            this.ctrlChkActivada.Text = "Activo";
            this.ctrlChkActivada.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTramos);
            this.tabControl.Controls.Add(this.tabCuentas);
            this.tabControl.Location = new System.Drawing.Point(3, 228);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(621, 271);
            this.tabControl.TabIndex = 8;
            this.tabControl.TabStop = false;
            // 
            // tabTramos
            // 
            this.tabTramos.Location = new System.Drawing.Point(4, 22);
            this.tabTramos.Name = "tabTramos";
            this.tabTramos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTramos.Size = new System.Drawing.Size(613, 245);
            this.tabTramos.TabIndex = 11;
            this.tabTramos.Text = "Tramos";
            this.tabTramos.UseVisualStyleBackColor = true;
            // 
            // tabCuentas
            // 
            this.tabCuentas.Location = new System.Drawing.Point(4, 22);
            this.tabCuentas.Name = "tabCuentas";
            this.tabCuentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuentas.Size = new System.Drawing.Size(613, 245);
            this.tabCuentas.TabIndex = 10;
            this.tabCuentas.Text = "Cuentas Asociadas";
            this.tabCuentas.UseVisualStyleBackColor = true;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(83, 9);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.ReadOnly = true;
            this.txtEntidad.Size = new System.Drawing.Size(402, 20);
            this.txtEntidad.TabIndex = 7;
            this.txtEntidad.TabStop = false;
            // 
            // ctrlChkActualizar
            // 
            this.ctrlChkActualizar.AutoSize = true;
            this.ctrlChkActualizar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlChkActualizar.Enabled = false;
            this.ctrlChkActualizar.Location = new System.Drawing.Point(19, 200);
            this.ctrlChkActualizar.Name = "ctrlChkActualizar";
            this.ctrlChkActualizar.Size = new System.Drawing.Size(174, 17);
            this.ctrlChkActualizar.TabIndex = 5;
            this.ctrlChkActualizar.Text = "Aplicar Actualización de Saldos";
            this.ctrlChkActualizar.UseVisualStyleBackColor = true;
            // 
            // ctrlChkTemporal
            // 
            this.ctrlChkTemporal.AutoSize = true;
            this.ctrlChkTemporal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlChkTemporal.Location = new System.Drawing.Point(228, 200);
            this.ctrlChkTemporal.Name = "ctrlChkTemporal";
            this.ctrlChkTemporal.Size = new System.Drawing.Size(144, 17);
            this.ctrlChkTemporal.TabIndex = 6;
            this.ctrlChkTemporal.Text = "Tramos en Días de Mora";
            this.ctrlChkTemporal.UseVisualStyleBackColor = true;
            // 
            // ctrlChkDeudaCuotas
            // 
            this.ctrlChkDeudaCuotas.AutoSize = true;
            this.ctrlChkDeudaCuotas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlChkDeudaCuotas.Location = new System.Drawing.Point(407, 200);
            this.ctrlChkDeudaCuotas.Name = "ctrlChkDeudaCuotas";
            this.ctrlChkDeudaCuotas.Size = new System.Drawing.Size(199, 17);
            this.ctrlChkDeudaCuotas.TabIndex = 7;
            this.ctrlChkDeudaCuotas.Text = "Permitir Múltiples Deudas Informadas";
            this.ctrlChkDeudaCuotas.UseVisualStyleBackColor = true;
            // 
            // ctrlChkUnificar
            // 
            this.ctrlChkUnificar.AutoSize = true;
            this.ctrlChkUnificar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlChkUnificar.Location = new System.Drawing.Point(348, 26);
            this.ctrlChkUnificar.Name = "ctrlChkUnificar";
            this.ctrlChkUnificar.Size = new System.Drawing.Size(251, 17);
            this.ctrlChkUnificar.TabIndex = 1;
            this.ctrlChkUnificar.Text = "Unificar Gastos y Capital en Deudas Informadas";
            this.ctrlChkUnificar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Forma de Imputación";
            // 
            // ctrlTxtImputacion
            // 
            this.ctrlTxtImputacion.Location = new System.Drawing.Point(125, 23);
            this.ctrlTxtImputacion.Name = "ctrlTxtImputacion";
            this.ctrlTxtImputacion.ReadOnly = true;
            this.ctrlTxtImputacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtImputacion.Size = new System.Drawing.Size(217, 20);
            this.ctrlTxtImputacion.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.grpPagos.Controls.Add(this.ctrlChkUnificar);
            this.grpPagos.Controls.Add(this.label1);
            this.grpPagos.Controls.Add(this.ctrlTxtImputacion);
            this.grpPagos.Location = new System.Drawing.Point(7, 136);
            this.grpPagos.Name = "grpPagos";
            this.grpPagos.Size = new System.Drawing.Size(617, 58);
            this.grpPagos.TabIndex = 4;
            this.grpPagos.TabStop = false;
            this.grpPagos.Text = "Aplicación de Pagos";
            // 
            // UserControl1
            // 
            this.Controls.Add(this.grpPagos);
            this.Controls.Add(this.ctrlChkDeudaCuotas);
            this.Controls.Add(this.ctrlChkTemporal);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ctrlChkActivada);
            this.Controls.Add(this.ctrlChkActualizar);
            this.Controls.Add(this.ctrlTxtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctrlTxtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctrlTxtDescripcion);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(627, 501);
            this.tabControl.ResumeLayout(false);
            this.grpPagos.ResumeLayout(false);
            this.grpPagos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ctrlTxtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctrlTxtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ctrlChkActivada;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCuentas;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.CheckBox ctrlChkActualizar;
        private System.Windows.Forms.TabPage tabTramos;
        private System.Windows.Forms.CheckBox ctrlChkTemporal;
        private System.Windows.Forms.CheckBox ctrlChkDeudaCuotas;
        private System.Windows.Forms.CheckBox ctrlChkUnificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctrlTxtImputacion;
        private System.Windows.Forms.GroupBox grpPagos;
    }
}