using System.Drawing;

namespace cuAbmConvenio {
    partial class PanelPreviewConvenio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMontoFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeudaConQuita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaAlta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCuotasPagas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.txtQuita = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaBaja = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGastoA = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.grpEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(73, 113);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(565, 21);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtMontoFinal
            // 
            this.txtMontoFinal.Location = new System.Drawing.Point(364, 44);
            this.txtMontoFinal.Name = "txtMontoFinal";
            this.txtMontoFinal.ReadOnly = true;
            this.txtMontoFinal.Size = new System.Drawing.Size(67, 20);
            this.txtMontoFinal.TabIndex = 5;
            this.txtMontoFinal.TabStop = false;
            this.txtMontoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Monto Final $";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Cuenta";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(73, 8);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.ReadOnly = true;
            this.txtCuenta.Size = new System.Drawing.Size(565, 20);
            this.txtCuenta.TabIndex = 14;
            this.txtCuenta.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Fecha Inicio";
            // 
            // txtDeudaConQuita
            // 
            this.txtDeudaConQuita.Location = new System.Drawing.Point(555, 61);
            this.txtDeudaConQuita.Name = "txtDeudaConQuita";
            this.txtDeudaConQuita.ReadOnly = true;
            this.txtDeudaConQuita.Size = new System.Drawing.Size(83, 20);
            this.txtDeudaConQuita.TabIndex = 2;
            this.txtDeudaConQuita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Deuda Origen $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Fecha de Alta";
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Location = new System.Drawing.Point(553, 19);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.ReadOnly = true;
            this.txtFechaAlta.Size = new System.Drawing.Size(82, 20);
            this.txtFechaAlta.TabIndex = 53;
            this.txtFechaAlta.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cuotas Pagas";
            // 
            // txtCuotasPagas
            // 
            this.txtCuotasPagas.Location = new System.Drawing.Point(185, 19);
            this.txtCuotasPagas.Name = "txtCuotasPagas";
            this.txtCuotasPagas.ReadOnly = true;
            this.txtCuotasPagas.Size = new System.Drawing.Size(67, 20);
            this.txtCuotasPagas.TabIndex = 5;
            this.txtCuotasPagas.TabStop = false;
            this.txtCuotasPagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Saldo Actual $";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(364, 19);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(67, 20);
            this.txtSaldo.TabIndex = 5;
            this.txtSaldo.TabStop = false;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.chkActivo);
            this.grpEstado.Controls.Add(this.txtCuotasPagas);
            this.grpEstado.Controls.Add(this.label7);
            this.grpEstado.Controls.Add(this.label9);
            this.grpEstado.Controls.Add(this.txtMontoPago);
            this.grpEstado.Controls.Add(this.txtSaldo);
            this.grpEstado.Controls.Add(this.label8);
            this.grpEstado.Controls.Add(this.txtMontoFinal);
            this.grpEstado.Controls.Add(this.label6);
            this.grpEstado.Controls.Add(this.txtFechaAlta);
            this.grpEstado.Controls.Add(this.label5);
            this.grpEstado.Controls.Add(this.txtFechaBaja);
            this.grpEstado.Controls.Add(this.label10);
            this.grpEstado.Location = new System.Drawing.Point(3, 144);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(647, 71);
            this.grpEstado.TabIndex = 14;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Estado del Convenio";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkActivo.Enabled = false;
            this.chkActivo.Location = new System.Drawing.Point(12, 25);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(89, 31);
            this.chkActivo.TabIndex = 0;
            this.chkActivo.Text = "Convenio Activo";
            this.chkActivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Monto Pago $";
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(185, 44);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.ReadOnly = true;
            this.txtMontoPago.Size = new System.Drawing.Size(67, 20);
            this.txtMontoPago.TabIndex = 5;
            this.txtMontoPago.TabStop = false;
            this.txtMontoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQuita
            // 
            this.txtQuita.Location = new System.Drawing.Point(73, 61);
            this.txtQuita.Name = "txtQuita";
            this.txtQuita.ReadOnly = true;
            this.txtQuita.Size = new System.Drawing.Size(68, 20);
            this.txtQuita.TabIndex = 2;
            this.txtQuita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Quita $";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Anticipo $";
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Location = new System.Drawing.Point(73, 87);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.ReadOnly = true;
            this.txtAnticipo.Size = new System.Drawing.Size(68, 20);
            this.txtAnticipo.TabIndex = 3;
            this.txtAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(369, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "Cuotas";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Enabled = false;
            this.txtFechaInicio.Location = new System.Drawing.Point(555, 87);
            this.txtFechaInicio.Mask = "00/00/0000";
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(83, 20);
            this.txtFechaInicio.TabIndex = 6;
            this.txtFechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Fecha de Baja";
            // 
            // txtFechaBaja
            // 
            this.txtFechaBaja.Location = new System.Drawing.Point(553, 44);
            this.txtFechaBaja.Name = "txtFechaBaja";
            this.txtFechaBaja.ReadOnly = true;
            this.txtFechaBaja.Size = new System.Drawing.Size(82, 20);
            this.txtFechaBaja.TabIndex = 53;
            this.txtFechaBaja.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(252, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 59;
            this.label16.Text = "Gastos Ant.$";
            // 
            // txtGastoA
            // 
            this.txtGastoA.Location = new System.Drawing.Point(323, 87);
            this.txtGastoA.Name = "txtGastoA";
            this.txtGastoA.ReadOnly = true;
            this.txtGastoA.Size = new System.Drawing.Size(40, 20);
            this.txtGastoA.TabIndex = 4;
            this.txtGastoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(555, 34);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(83, 20);
            this.txtOrigen.TabIndex = 63;
            this.txtOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(466, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 64;
            this.label17.Text = "Deuda c/Quita $";
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(74, 34);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(289, 20);
            this.txtTipo.TabIndex = 66;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCuotas
            // 
            this.txtCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotas.Location = new System.Drawing.Point(410, 34);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.ReadOnly = true;
            this.txtCuotas.Size = new System.Drawing.Size(45, 20);
            this.txtCuotas.TabIndex = 67;
            this.txtCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UserControl1
            // 
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtGastoA);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAnticipo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtQuita);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDeudaConQuita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpEstado);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(656, 222);
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMontoFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeudaConQuita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFechaAlta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCuotasPagas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtQuita;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtFechaInicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFechaBaja;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtGastoA;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCuotas;
    }
}