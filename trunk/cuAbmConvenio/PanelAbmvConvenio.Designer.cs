using scioThirdPartLibrary;

namespace cuAbmConvenio {
    partial class PanelAbmvConvenio
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
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMontoFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDeudaConQuita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCuotas = new System.Windows.Forms.TabPage();
            this.tabPagos = new System.Windows.Forms.TabPage();
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
            this.txtFechaBaja = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTipo = new ReadOnlyComboBox();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnVerCuenta = new System.Windows.Forms.Button();
            this.ctrlTxtQuita = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRefinanciar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ctrlTxtAnticipo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ctrlTxtFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.btnDocumento = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.ctrlTxtGastoA = new System.Windows.Forms.TextBox();
            this.lblMaxQuita = new System.Windows.Forms.Label();
            this.ctrlChkRedondear = new System.Windows.Forms.CheckBox();
            this.cmbCuotas = new ReadOnlyComboBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblMinAnticipo = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
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
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(73, 113);
            this.ctrlTxtDescripcion.Multiline = true;
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ReadOnly = true;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(396, 21);
            this.ctrlTxtDescripcion.TabIndex = 5;
            // 
            // txtMontoFinal
            // 
            this.txtMontoFinal.Location = new System.Drawing.Point(382, 44);
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
            this.label6.Location = new System.Drawing.Point(305, 47);
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
            this.txtCuenta.Size = new System.Drawing.Size(623, 20);
            this.txtCuenta.TabIndex = 14;
            this.txtCuenta.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Fecha Inicio";
            // 
            // ctrlFechaInicio
            // 
            this.ctrlFechaInicio.CustomFormat = "dd/MM/yyyy  hh:mm:ss";
            this.ctrlFechaInicio.Enabled = false;
            this.ctrlFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctrlFechaInicio.Location = new System.Drawing.Point(619, 113);
            this.ctrlFechaInicio.Name = "ctrlFechaInicio";
            this.ctrlFechaInicio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlFechaInicio.Size = new System.Drawing.Size(20, 20);
            this.ctrlFechaInicio.TabIndex = 8;
            this.ctrlFechaInicio.ValueChanged += new System.EventHandler(this.ctrlFechaInicio_ValueChanged);
            // 
            // txtDeudaConQuita
            // 
            this.txtDeudaConQuita.Location = new System.Drawing.Point(651, 61);
            this.txtDeudaConQuita.Name = "txtDeudaConQuita";
            this.txtDeudaConQuita.ReadOnly = true;
            this.txtDeudaConQuita.Size = new System.Drawing.Size(77, 20);
            this.txtDeudaConQuita.TabIndex = 2;
            this.txtDeudaConQuita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeudaConQuita.TextChanged += new System.EventHandler(this.ctrlTxtDeudaOrigen_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Deuda Base $";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCuotas);
            this.tabControl.Controls.Add(this.tabPagos);
            this.tabControl.Location = new System.Drawing.Point(5, 166);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(727, 241);
            this.tabControl.TabIndex = 11;
            // 
            // tabCuotas
            // 
            this.tabCuotas.Location = new System.Drawing.Point(4, 22);
            this.tabCuotas.Name = "tabCuotas";
            this.tabCuotas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuotas.Size = new System.Drawing.Size(719, 215);
            this.tabCuotas.TabIndex = 1;
            this.tabCuotas.Text = "Cuotas";
            this.tabCuotas.UseVisualStyleBackColor = true;
            // 
            // tabPagos
            // 
            this.tabPagos.Location = new System.Drawing.Point(4, 22);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.Size = new System.Drawing.Size(719, 215);
            this.tabPagos.TabIndex = 2;
            this.tabPagos.Text = "Pagos";
            this.tabPagos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Fecha de Alta";
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Location = new System.Drawing.Point(556, 19);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.ReadOnly = true;
            this.txtFechaAlta.Size = new System.Drawing.Size(140, 20);
            this.txtFechaAlta.TabIndex = 53;
            this.txtFechaAlta.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cuotas Pagas";
            // 
            // txtCuotasPagas
            // 
            this.txtCuotasPagas.Location = new System.Drawing.Point(207, 19);
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
            this.label8.Location = new System.Drawing.Point(300, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Saldo Actual $";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(382, 19);
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
            this.grpEstado.Location = new System.Drawing.Point(8, 413);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(720, 71);
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
            this.label9.Location = new System.Drawing.Point(128, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Monto Pago $";
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(207, 44);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.ReadOnly = true;
            this.txtMontoPago.Size = new System.Drawing.Size(67, 20);
            this.txtMontoPago.TabIndex = 5;
            this.txtMontoPago.TabStop = false;
            this.txtMontoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFechaBaja
            // 
            this.txtFechaBaja.Location = new System.Drawing.Point(556, 44);
            this.txtFechaBaja.Name = "txtFechaBaja";
            this.txtFechaBaja.ReadOnly = true;
            this.txtFechaBaja.Size = new System.Drawing.Size(140, 20);
            this.txtFechaBaja.TabIndex = 53;
            this.txtFechaBaja.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(477, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Fecha de Baja";
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(73, 34);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(396, 21);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // btnActivar
            // 
            this.btnActivar.Image = global::cuAbmConvenio.Properties.Resources.activar;
            this.btnActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivar.Location = new System.Drawing.Point(179, 137);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(83, 23);
            this.btnActivar.TabIndex = 10;
            this.btnActivar.Tag = "BOTON.CONVENIO.GENERAR";
            this.btnActivar.Text = "Activar";
            this.btnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = global::cuAbmConvenio.Properties.Resources.generar;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerar.Location = new System.Drawing.Point(92, 137);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(83, 23);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Tag = "BOTON.CONVENIO.GENERAR";
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnVerCuenta
            // 
            this.btnVerCuenta.Image = global::cuAbmConvenio.Properties.Resources.cuenta1;
            this.btnVerCuenta.Location = new System.Drawing.Point(702, 5);
            this.btnVerCuenta.Name = "btnVerCuenta";
            this.btnVerCuenta.Size = new System.Drawing.Size(26, 23);
            this.btnVerCuenta.TabIndex = 15;
            this.btnVerCuenta.TabStop = false;
            this.btnVerCuenta.UseVisualStyleBackColor = true;
            this.btnVerCuenta.Click += new System.EventHandler(this.btnVerCuenta_Click);
            // 
            // ctrlTxtQuita
            // 
            this.ctrlTxtQuita.Location = new System.Drawing.Point(73, 61);
            this.ctrlTxtQuita.Name = "ctrlTxtQuita";
            this.ctrlTxtQuita.ReadOnly = true;
            this.ctrlTxtQuita.Size = new System.Drawing.Size(68, 20);
            this.ctrlTxtQuita.TabIndex = 2;
            this.ctrlTxtQuita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrlTxtQuita.TextChanged += new System.EventHandler(this.ctrlTxtDeudaOrigen_TextChanged);
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
            // txtRefinanciar
            // 
            this.txtRefinanciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefinanciar.Location = new System.Drawing.Point(651, 87);
            this.txtRefinanciar.Name = "txtRefinanciar";
            this.txtRefinanciar.ReadOnly = true;
            this.txtRefinanciar.Size = new System.Drawing.Size(77, 20);
            this.txtRefinanciar.TabIndex = 5;
            this.txtRefinanciar.TabStop = false;
            this.txtRefinanciar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(568, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "A Refinanciar $";
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
            // ctrlTxtAnticipo
            // 
            this.ctrlTxtAnticipo.Location = new System.Drawing.Point(73, 87);
            this.ctrlTxtAnticipo.Name = "ctrlTxtAnticipo";
            this.ctrlTxtAnticipo.ReadOnly = true;
            this.ctrlTxtAnticipo.Size = new System.Drawing.Size(68, 20);
            this.ctrlTxtAnticipo.TabIndex = 3;
            this.ctrlTxtAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrlTxtAnticipo.TextChanged += new System.EventHandler(this.ctrlTxtDeudaOrigen_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(475, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "Cuotas";
            // 
            // ctrlTxtFechaInicio
            // 
            this.ctrlTxtFechaInicio.Enabled = false;
            this.ctrlTxtFechaInicio.Location = new System.Drawing.Point(550, 113);
            this.ctrlTxtFechaInicio.Mask = "00/00/0000";
            this.ctrlTxtFechaInicio.Name = "ctrlTxtFechaInicio";
            this.ctrlTxtFechaInicio.Size = new System.Drawing.Size(68, 20);
            this.ctrlTxtFechaInicio.TabIndex = 6;
            this.ctrlTxtFechaInicio.ValidatingType = typeof(System.DateTime);
            this.ctrlTxtFechaInicio.Validated += new System.EventHandler(this.ctrlTxtFechaInicio_Validated);
            // 
            // btnDocumento
            // 
            this.btnDocumento.Image = global::cuAbmConvenio.Properties.Resources.documento;
            this.btnDocumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumento.Location = new System.Drawing.Point(5, 137);
            this.btnDocumento.Name = "btnDocumento";
            this.btnDocumento.Size = new System.Drawing.Size(83, 23);
            this.btnDocumento.TabIndex = 8;
            this.btnDocumento.Tag = "BOTON.CONVENIO.IMPRIMIR";
            this.btnDocumento.Text = "Documento";
            this.btnDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocumento.UseVisualStyleBackColor = true;
            this.btnDocumento.Click += new System.EventHandler(this.btnDocumento_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(339, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 59;
            this.label16.Text = "Gastos Ant.$";
            // 
            // ctrlTxtGastoA
            // 
            this.ctrlTxtGastoA.Location = new System.Drawing.Point(410, 87);
            this.ctrlTxtGastoA.Name = "ctrlTxtGastoA";
            this.ctrlTxtGastoA.ReadOnly = true;
            this.ctrlTxtGastoA.Size = new System.Drawing.Size(59, 20);
            this.ctrlTxtGastoA.TabIndex = 4;
            this.ctrlTxtGastoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMaxQuita
            // 
            this.lblMaxQuita.AutoSize = true;
            this.lblMaxQuita.Location = new System.Drawing.Point(144, 64);
            this.lblMaxQuita.Name = "lblMaxQuita";
            this.lblMaxQuita.Size = new System.Drawing.Size(155, 13);
            this.lblMaxQuita.TabIndex = 61;
            this.lblMaxQuita.Text = "(Máximo Quita aplicable $ 0.00)";
            // 
            // ctrlChkRedondear
            // 
            this.ctrlChkRedondear.AutoSize = true;
            this.ctrlChkRedondear.Location = new System.Drawing.Point(651, 115);
            this.ctrlChkRedondear.Name = "ctrlChkRedondear";
            this.ctrlChkRedondear.Size = new System.Drawing.Size(79, 17);
            this.ctrlChkRedondear.TabIndex = 7;
            this.ctrlChkRedondear.Text = "Redondear";
            this.ctrlChkRedondear.UseVisualStyleBackColor = true;
            // 
            // cmbCuotas
            // 
            this.cmbCuotas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCuotas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuotas.FormattingEnabled = true;
            this.cmbCuotas.Location = new System.Drawing.Point(518, 34);
            this.cmbCuotas.Name = "cmbCuotas";
            this.cmbCuotas.Size = new System.Drawing.Size(43, 21);
            this.cmbCuotas.TabIndex = 1;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(651, 34);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(77, 20);
            this.txtOrigen.TabIndex = 63;
            this.txtOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(561, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 64;
            this.label17.Text = "Deuda c/Quita $";
            // 
            // lblMinAnticipo
            // 
            this.lblMinAnticipo.AutoSize = true;
            this.lblMinAnticipo.Location = new System.Drawing.Point(144, 90);
            this.lblMinAnticipo.Name = "lblMinAnticipo";
            this.lblMinAnticipo.Size = new System.Drawing.Size(167, 13);
            this.lblMinAnticipo.TabIndex = 65;
            this.lblMinAnticipo.Text = "(Mínimo Anticipo aplicable $ 0.00)";
            // 
            // UserControl1
            // 
            this.Controls.Add(this.lblMinAnticipo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.cmbCuotas);
            this.Controls.Add(this.ctrlChkRedondear);
            this.Controls.Add(this.ctrlTxtFechaInicio);
            this.Controls.Add(this.lblMaxQuita);
            this.Controls.Add(this.txtRefinanciar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ctrlTxtGastoA);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ctrlTxtAnticipo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ctrlTxtQuita);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnDocumento);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtDeudaConQuita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctrlFechaInicio);
            this.Controls.Add(this.btnVerCuenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.ctrlTxtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpEstado);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(735, 488);
            this.tabControl.ResumeLayout(false);
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.TextBox txtMontoFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVerCuenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ctrlFechaInicio;
        private System.Windows.Forms.TextBox txtDeudaConQuita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCuotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFechaAlta;
        private System.Windows.Forms.TabPage tabPagos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCuotasPagas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.CheckBox chkActivo;
        private ReadOnlyComboBox cmbTipo;
        private System.Windows.Forms.TextBox ctrlTxtQuita;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRefinanciar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ctrlTxtAnticipo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox ctrlTxtFechaInicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFechaBaja;
        private System.Windows.Forms.Button btnDocumento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ctrlTxtGastoA;
        private System.Windows.Forms.Label lblMaxQuita;
        private System.Windows.Forms.CheckBox ctrlChkRedondear;
        private ReadOnlyComboBox cmbCuotas;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblMinAnticipo;
    }
}