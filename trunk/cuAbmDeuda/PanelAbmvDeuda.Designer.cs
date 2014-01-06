using scioThirdPartLibrary;

namespace cuAbmDeuda
{
    partial class PanelAbmvDeuda
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
            this.label7 = new System.Windows.Forms.Label();
            this.ctrlTxtInteres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.tabPagos = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.label9 = new System.Windows.Forms.Label();
            this.ctrlTxtCapital = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ctrlTxtGastos = new System.Windows.Forms.TextBox();
            this.grpImportes = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ctrlTxtHonorarios = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.ctrlTxtComboConcepto = new scioThirdPartLibrary.ReadOnlyComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlTxtComboDetalle = new scioThirdPartLibrary.ReadOnlyComboBox();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlChkInformada = new System.Windows.Forms.CheckBox();
            this.grpOriginales = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHonorO = new System.Windows.Forms.TextBox();
            this.txtCapitalO = new System.Windows.Forms.TextBox();
            this.txtGastosO = new System.Windows.Forms.TextBox();
            this.txtTotalO = new System.Windows.Forms.TextBox();
            this.txtInteresO = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFechaBaja = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFechaAlta = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.ctrlFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelarDeuda = new System.Windows.Forms.Button();
            this.findCuenta = new System.Windows.Forms.Button();
            this.btnVerCuenta = new System.Windows.Forms.Button();
            this.btnVerConvenio = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.grpImportes.SuspendLayout();
            this.grpOriginales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Capital ($)";
            // 
            // ctrlTxtInteres
            // 
            this.ctrlTxtInteres.Location = new System.Drawing.Point(191, 19);
            this.ctrlTxtInteres.Name = "ctrlTxtInteres";
            this.ctrlTxtInteres.ReadOnly = true;
            this.ctrlTxtInteres.Size = new System.Drawing.Size(61, 20);
            this.ctrlTxtInteres.TabIndex = 1;
            this.ctrlTxtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrlTxtInteres.TextChanged += new System.EventHandler(this.ctrlTxtCapital_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Concepto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cuenta Origen";
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(83, 82);
            this.ctrlTxtDescripcion.Multiline = true;
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ReadOnly = true;
            this.ctrlTxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(298, 46);
            this.ctrlTxtDescripcion.TabIndex = 7;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(83, 3);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.ReadOnly = true;
            this.txtCuenta.Size = new System.Drawing.Size(454, 20);
            this.txtCuenta.TabIndex = 10;
            this.txtCuenta.TabStop = false;
            // 
            // tabPagos
            // 
            this.tabPagos.Location = new System.Drawing.Point(4, 22);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagos.Size = new System.Drawing.Size(665, 220);
            this.tabPagos.TabIndex = 0;
            this.tabPagos.Text = "Imputaciones Realizadas";
            this.tabPagos.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagos);
            this.tabControl.Location = new System.Drawing.Point(4, 263);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(673, 246);
            this.tabControl.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Interés ($)";
            // 
            // ctrlTxtCapital
            // 
            this.ctrlTxtCapital.ForeColor = System.Drawing.Color.Black;
            this.ctrlTxtCapital.Location = new System.Drawing.Point(67, 19);
            this.ctrlTxtCapital.Name = "ctrlTxtCapital";
            this.ctrlTxtCapital.ReadOnly = true;
            this.ctrlTxtCapital.Size = new System.Drawing.Size(61, 20);
            this.ctrlTxtCapital.TabIndex = 0;
            this.ctrlTxtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrlTxtCapital.TextChanged += new System.EventHandler(this.ctrlTxtCapital_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Gastos ($)";
            // 
            // ctrlTxtGastos
            // 
            this.ctrlTxtGastos.Location = new System.Drawing.Point(459, 19);
            this.ctrlTxtGastos.Name = "ctrlTxtGastos";
            this.ctrlTxtGastos.ReadOnly = true;
            this.ctrlTxtGastos.Size = new System.Drawing.Size(61, 20);
            this.ctrlTxtGastos.TabIndex = 3;
            this.ctrlTxtGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrlTxtGastos.TextChanged += new System.EventHandler(this.ctrlTxtCapital_TextChanged);
            // 
            // grpImportes
            // 
            this.grpImportes.Controls.Add(this.label14);
            this.grpImportes.Controls.Add(this.label11);
            this.grpImportes.Controls.Add(this.ctrlTxtHonorarios);
            this.grpImportes.Controls.Add(this.ctrlTxtCapital);
            this.grpImportes.Controls.Add(this.ctrlTxtGastos);
            this.grpImportes.Controls.Add(this.txtTotal);
            this.grpImportes.Controls.Add(this.ctrlTxtInteres);
            this.grpImportes.Controls.Add(this.label12);
            this.grpImportes.Controls.Add(this.label9);
            this.grpImportes.Controls.Add(this.label7);
            this.grpImportes.Location = new System.Drawing.Point(4, 211);
            this.grpImportes.Name = "grpImportes";
            this.grpImportes.Size = new System.Drawing.Size(673, 46);
            this.grpImportes.TabIndex = 9;
            this.grpImportes.TabStop = false;
            this.grpImportes.Text = "Importes Actuales (saldos)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(527, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "TOTAL ($)";
            // 
            // ctrlTxtHonorarios
            // 
            this.ctrlTxtHonorarios.ForeColor = System.Drawing.Color.Black;
            this.ctrlTxtHonorarios.Location = new System.Drawing.Point(334, 19);
            this.ctrlTxtHonorarios.Name = "ctrlTxtHonorarios";
            this.ctrlTxtHonorarios.ReadOnly = true;
            this.ctrlTxtHonorarios.Size = new System.Drawing.Size(61, 20);
            this.ctrlTxtHonorarios.TabIndex = 2;
            this.ctrlTxtHonorarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrlTxtHonorarios.TextChanged += new System.EventHandler(this.ctrlTxtCapital_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(596, 19);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(69, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Honorarios ($)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Convenio";
            // 
            // txtConvenio
            // 
            this.txtConvenio.Location = new System.Drawing.Point(83, 29);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.ReadOnly = true;
            this.txtConvenio.Size = new System.Drawing.Size(484, 20);
            this.txtConvenio.TabIndex = 3;
            this.txtConvenio.TabStop = false;
            // 
            // ctrlTxtComboConcepto
            // 
            this.ctrlTxtComboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtComboConcepto.FormattingEnabled = true;
            this.ctrlTxtComboConcepto.Location = new System.Drawing.Point(83, 55);
            this.ctrlTxtComboConcepto.Name = "ctrlTxtComboConcepto";
            this.ctrlTxtComboConcepto.Size = new System.Drawing.Size(298, 21);
            this.ctrlTxtComboConcepto.TabIndex = 5;
            this.ctrlTxtComboConcepto.SelectedIndexChanged += new System.EventHandler(this.ctrlTxtComboConcepto_SelectedIndexChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(480, 82);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(197, 20);
            this.txtEstado.TabIndex = 9;
            this.txtEstado.TabStop = false;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(385, 85);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(90, 13);
            this.Estado.TabIndex = 24;
            this.Estado.Text = "Estado de Deuda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Detalle de Deuda";
            // 
            // ctrlTxtComboDetalle
            // 
            this.ctrlTxtComboDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtComboDetalle.FormattingEnabled = true;
            this.ctrlTxtComboDetalle.Location = new System.Drawing.Point(480, 55);
            this.ctrlTxtComboDetalle.Name = "ctrlTxtComboDetalle";
            this.ctrlTxtComboDetalle.Size = new System.Drawing.Size(197, 21);
            this.ctrlTxtComboDetalle.TabIndex = 6;
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(645, 29);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.ReadOnly = true;
            this.txtCuota.Size = new System.Drawing.Size(32, 20);
            this.txtCuota.TabIndex = 4;
            this.txtCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cuota";
            // 
            // ctrlChkInformada
            // 
            this.ctrlChkInformada.AutoSize = true;
            this.ctrlChkInformada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlChkInformada.Enabled = false;
            this.ctrlChkInformada.Location = new System.Drawing.Point(604, 5);
            this.ctrlChkInformada.Name = "ctrlChkInformada";
            this.ctrlChkInformada.Size = new System.Drawing.Size(73, 17);
            this.ctrlChkInformada.TabIndex = 2;
            this.ctrlChkInformada.Text = "Informada";
            this.ctrlChkInformada.UseVisualStyleBackColor = true;
            // 
            // grpOriginales
            // 
            this.grpOriginales.Controls.Add(this.label10);
            this.grpOriginales.Controls.Add(this.label16);
            this.grpOriginales.Controls.Add(this.txtHonorO);
            this.grpOriginales.Controls.Add(this.txtCapitalO);
            this.grpOriginales.Controls.Add(this.txtGastosO);
            this.grpOriginales.Controls.Add(this.txtTotalO);
            this.grpOriginales.Controls.Add(this.txtInteresO);
            this.grpOriginales.Controls.Add(this.label18);
            this.grpOriginales.Controls.Add(this.label19);
            this.grpOriginales.Controls.Add(this.label20);
            this.grpOriginales.Location = new System.Drawing.Point(6, 160);
            this.grpOriginales.Name = "grpOriginales";
            this.grpOriginales.Size = new System.Drawing.Size(671, 47);
            this.grpOriginales.TabIndex = 50;
            this.grpOriginales.TabStop = false;
            this.grpOriginales.Text = "Importes Originales";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(525, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "TOTAL ($)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(400, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Gastos ($)";
            // 
            // txtHonorO
            // 
            this.txtHonorO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHonorO.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtHonorO.Location = new System.Drawing.Point(332, 20);
            this.txtHonorO.Name = "txtHonorO";
            this.txtHonorO.ReadOnly = true;
            this.txtHonorO.Size = new System.Drawing.Size(61, 20);
            this.txtHonorO.TabIndex = 3;
            this.txtHonorO.TabStop = false;
            this.txtHonorO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCapitalO
            // 
            this.txtCapitalO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapitalO.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCapitalO.Location = new System.Drawing.Point(65, 20);
            this.txtCapitalO.Name = "txtCapitalO";
            this.txtCapitalO.ReadOnly = true;
            this.txtCapitalO.Size = new System.Drawing.Size(61, 20);
            this.txtCapitalO.TabIndex = 0;
            this.txtCapitalO.TabStop = false;
            this.txtCapitalO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGastosO
            // 
            this.txtGastosO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGastosO.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtGastosO.Location = new System.Drawing.Point(457, 20);
            this.txtGastosO.Name = "txtGastosO";
            this.txtGastosO.ReadOnly = true;
            this.txtGastosO.Size = new System.Drawing.Size(61, 20);
            this.txtGastosO.TabIndex = 2;
            this.txtGastosO.TabStop = false;
            this.txtGastosO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalO
            // 
            this.txtTotalO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalO.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTotalO.Location = new System.Drawing.Point(594, 20);
            this.txtTotalO.Name = "txtTotalO";
            this.txtTotalO.ReadOnly = true;
            this.txtTotalO.Size = new System.Drawing.Size(69, 20);
            this.txtTotalO.TabIndex = 5;
            this.txtTotalO.TabStop = false;
            this.txtTotalO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInteresO
            // 
            this.txtInteresO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteresO.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtInteresO.Location = new System.Drawing.Point(189, 20);
            this.txtInteresO.Name = "txtInteresO";
            this.txtInteresO.ReadOnly = true;
            this.txtInteresO.Size = new System.Drawing.Size(61, 20);
            this.txtInteresO.TabIndex = 1;
            this.txtInteresO.TabStop = false;
            this.txtInteresO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(256, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Honorarios ($)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(132, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "Interés ($)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Capital ($)";
            // 
            // txtFechaBaja
            // 
            this.txtFechaBaja.Location = new System.Drawing.Point(565, 134);
            this.txtFechaBaja.Name = "txtFechaBaja";
            this.txtFechaBaja.ReadOnly = true;
            this.txtFechaBaja.Size = new System.Drawing.Size(112, 20);
            this.txtFechaBaja.TabIndex = 59;
            this.txtFechaBaja.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(483, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Fecha de Baja";
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Location = new System.Drawing.Point(565, 108);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.ReadOnly = true;
            this.txtFechaAlta.Size = new System.Drawing.Size(112, 20);
            this.txtFechaAlta.TabIndex = 57;
            this.txtFechaAlta.TabStop = false;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(83, 134);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(173, 20);
            this.txtFecha.TabIndex = 53;
            // 
            // ctrlFecha
            // 
            this.ctrlFecha.CustomFormat = "dd/MM/yyyy  hh:mm:ss";
            this.ctrlFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctrlFecha.Location = new System.Drawing.Point(258, 134);
            this.ctrlFecha.Name = "ctrlFecha";
            this.ctrlFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlFecha.Size = new System.Drawing.Size(20, 20);
            this.ctrlFecha.TabIndex = 8;
            this.ctrlFecha.ValueChanged += new System.EventHandler(this.ctrlFecha_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(503, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Fecha Alta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Vencimiento";
            // 
            // btnCancelarDeuda
            // 
            this.btnCancelarDeuda.Image = global::cuAbmDeuda.Properties.Resources.verificar;
            this.btnCancelarDeuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarDeuda.Location = new System.Drawing.Point(303, 132);
            this.btnCancelarDeuda.Name = "btnCancelarDeuda";
            this.btnCancelarDeuda.Size = new System.Drawing.Size(78, 23);
            this.btnCancelarDeuda.TabIndex = 60;
            this.btnCancelarDeuda.Tag = "BOTON.DEUDA.CANCELAR";
            this.btnCancelarDeuda.Text = "&Cancelar";
            this.btnCancelarDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarDeuda.UseVisualStyleBackColor = true;
            this.btnCancelarDeuda.Click += new System.EventHandler(this.btnCancelarDeuda_Click);
            // 
            // findCuenta
            // 
            this.findCuenta.Image = global::cuAbmDeuda.Properties.Resources.seleccionar;
            this.findCuenta.Location = new System.Drawing.Point(541, 2);
            this.findCuenta.Name = "findCuenta";
            this.findCuenta.Size = new System.Drawing.Size(26, 23);
            this.findCuenta.TabIndex = 0;
            this.findCuenta.UseVisualStyleBackColor = true;
            this.findCuenta.Click += new System.EventHandler(this.ctrlFindCuenta_Click);
            // 
            // btnVerCuenta
            // 
            this.btnVerCuenta.Image = global::cuAbmDeuda.Properties.Resources.cuenta1;
            this.btnVerCuenta.Location = new System.Drawing.Point(573, 2);
            this.btnVerCuenta.Name = "btnVerCuenta";
            this.btnVerCuenta.Size = new System.Drawing.Size(26, 23);
            this.btnVerCuenta.TabIndex = 1;
            this.btnVerCuenta.UseVisualStyleBackColor = true;
            this.btnVerCuenta.Click += new System.EventHandler(this.btnVerCuenta_Click);
            // 
            // btnVerConvenio
            // 
            this.btnVerConvenio.Image = global::cuAbmDeuda.Properties.Resources.convenio;
            this.btnVerConvenio.Location = new System.Drawing.Point(573, 27);
            this.btnVerConvenio.Name = "btnVerConvenio";
            this.btnVerConvenio.Size = new System.Drawing.Size(26, 23);
            this.btnVerConvenio.TabIndex = 3;
            this.btnVerConvenio.UseVisualStyleBackColor = true;
            this.btnVerConvenio.Click += new System.EventHandler(this.btnVerConvenio_Click);
            // 
            // UserControl1
            // 
            this.Controls.Add(this.btnCancelarDeuda);
            this.Controls.Add(this.txtFechaBaja);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFechaAlta);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.ctrlFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpOriginales);
            this.Controls.Add(this.ctrlChkInformada);
            this.Controls.Add(this.ctrlTxtComboDetalle);
            this.Controls.Add(this.ctrlTxtComboConcepto);
            this.Controls.Add(this.findCuenta);
            this.Controls.Add(this.btnVerCuenta);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlTxtDescripcion);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.grpImportes);
            this.Controls.Add(this.txtConvenio);
            this.Controls.Add(this.btnVerConvenio);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(680, 509);
            this.tabControl.ResumeLayout(false);
            this.grpImportes.ResumeLayout(false);
            this.grpImportes.PerformLayout();
            this.grpOriginales.ResumeLayout(false);
            this.grpOriginales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ctrlTxtInteres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TabPage tabPagos;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ctrlTxtCapital;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ctrlTxtGastos;
        private System.Windows.Forms.GroupBox grpImportes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ctrlTxtHonorarios;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.Button btnVerConvenio;
        private System.Windows.Forms.Button btnVerCuenta;
        private ReadOnlyComboBox ctrlTxtComboConcepto;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label label5;
        private ReadOnlyComboBox ctrlTxtComboDetalle;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ctrlChkInformada;
        private System.Windows.Forms.Button findCuenta;
        private System.Windows.Forms.GroupBox grpOriginales;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHonorO;
        private System.Windows.Forms.TextBox txtCapitalO;
        private System.Windows.Forms.TextBox txtGastosO;
        private System.Windows.Forms.TextBox txtTotalO;
        private System.Windows.Forms.TextBox txtInteresO;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFechaBaja;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFechaAlta;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.DateTimePicker ctrlFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelarDeuda;
    }
}
