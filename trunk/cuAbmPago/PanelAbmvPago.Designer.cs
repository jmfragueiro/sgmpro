using scioThirdPartLibrary;

namespace cuAbmPago {
    partial class PanelAbmvPago {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing) {
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.ctrlTxtComboFormaPago = new scioThirdPartLibrary.ReadOnlyComboBox();
            this.ctrlTxtComboTipoPago = new scioThirdPartLibrary.ReadOnlyComboBox();
            this.txtFechaUMod = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDeudas = new System.Windows.Forms.TabPage();
            this.tabRecibos = new System.Windows.Forms.TabPage();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.grpImportes = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPagar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPagar = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtGastos = new System.Windows.Forms.TextBox();
            this.txtHonor = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPagosAHoy = new System.Windows.Forms.TextBox();
            this.chkAjustar = new System.Windows.Forms.CheckBox();
            this.txtFechaBaja = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGenerarRecibo = new System.Windows.Forms.Button();
            this.findCuenta = new System.Windows.Forms.Button();
            this.btnVerConvenio = new System.Windows.Forms.Button();
            this.btnVerCuenta = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.grpImportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cuenta Origen";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(93, 12);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.ReadOnly = true;
            this.txtCuenta.Size = new System.Drawing.Size(345, 20);
            this.txtCuenta.TabIndex = 14;
            this.txtCuenta.TabStop = false;
            // 
            // ctrlTxtComboFormaPago
            // 
            this.ctrlTxtComboFormaPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctrlTxtComboFormaPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctrlTxtComboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtComboFormaPago.FormattingEnabled = true;
            this.ctrlTxtComboFormaPago.Location = new System.Drawing.Point(461, 64);
            this.ctrlTxtComboFormaPago.Name = "ctrlTxtComboFormaPago";
            this.ctrlTxtComboFormaPago.Size = new System.Drawing.Size(253, 21);
            this.ctrlTxtComboFormaPago.TabIndex = 4;
            this.ctrlTxtComboFormaPago.SelectedIndexChanged += new System.EventHandler(this.ctrlTxtComboFormaPago_SelectedIndexChanged);
            // 
            // ctrlTxtComboTipoPago
            // 
            this.ctrlTxtComboTipoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctrlTxtComboTipoPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctrlTxtComboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtComboTipoPago.FormattingEnabled = true;
            this.ctrlTxtComboTipoPago.Location = new System.Drawing.Point(93, 64);
            this.ctrlTxtComboTipoPago.Name = "ctrlTxtComboTipoPago";
            this.ctrlTxtComboTipoPago.Size = new System.Drawing.Size(279, 21);
            this.ctrlTxtComboTipoPago.TabIndex = 3;
            this.ctrlTxtComboTipoPago.SelectedIndexChanged += new System.EventHandler(this.ctrlTxtComboTipoPago_SelectedIndexChanged);
            // 
            // txtFechaUMod
            // 
            this.txtFechaUMod.Location = new System.Drawing.Point(323, 474);
            this.txtFechaUMod.Name = "txtFechaUMod";
            this.txtFechaUMod.ReadOnly = true;
            this.txtFechaUMod.Size = new System.Drawing.Size(134, 20);
            this.txtFechaUMod.TabIndex = 12;
            this.txtFechaUMod.TabStop = false;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(93, 474);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(128, 20);
            this.txtFecha.TabIndex = 11;
            this.txtFecha.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Fecha de Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Fecha de Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Forma de Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Tipo de Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Descripción";
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(93, 448);
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ReadOnly = true;
            this.ctrlTxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(364, 20);
            this.ctrlTxtDescripcion.TabIndex = 9;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDeudas);
            this.tabControl.Controls.Add(this.tabRecibos);
            this.tabControl.Location = new System.Drawing.Point(6, 104);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(713, 255);
            this.tabControl.TabIndex = 7;
            // 
            // tabDeudas
            // 
            this.tabDeudas.Location = new System.Drawing.Point(4, 22);
            this.tabDeudas.Name = "tabDeudas";
            this.tabDeudas.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeudas.Size = new System.Drawing.Size(705, 229);
            this.tabDeudas.TabIndex = 0;
            this.tabDeudas.Text = "Deuda Seleccionable";
            this.tabDeudas.UseVisualStyleBackColor = true;
            // 
            // tabRecibos
            // 
            this.tabRecibos.Location = new System.Drawing.Point(4, 22);
            this.tabRecibos.Name = "tabRecibos";
            this.tabRecibos.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecibos.Size = new System.Drawing.Size(705, 229);
            this.tabRecibos.TabIndex = 1;
            this.tabRecibos.Text = "Recibos Asociados";
            this.tabRecibos.UseVisualStyleBackColor = true;
            // 
            // txtConvenio
            // 
            this.txtConvenio.Location = new System.Drawing.Point(93, 38);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.ReadOnly = true;
            this.txtConvenio.Size = new System.Drawing.Size(590, 20);
            this.txtConvenio.TabIndex = 15;
            this.txtConvenio.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(37, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 73;
            this.label20.Text = "Convenio";
            // 
            // grpImportes
            // 
            this.grpImportes.Controls.Add(this.btnGenerarRecibo);
            this.grpImportes.Controls.Add(this.label15);
            this.grpImportes.Controls.Add(this.lblPagar);
            this.grpImportes.Controls.Add(this.label11);
            this.grpImportes.Controls.Add(this.label10);
            this.grpImportes.Controls.Add(this.label9);
            this.grpImportes.Controls.Add(this.label1);
            this.grpImportes.Controls.Add(this.label17);
            this.grpImportes.Controls.Add(this.label7);
            this.grpImportes.Controls.Add(this.txtPagar);
            this.grpImportes.Controls.Add(this.txtTotal);
            this.grpImportes.Controls.Add(this.txtGastos);
            this.grpImportes.Controls.Add(this.txtHonor);
            this.grpImportes.Controls.Add(this.txtInteres);
            this.grpImportes.Controls.Add(this.txtCapital);
            this.grpImportes.Location = new System.Drawing.Point(6, 365);
            this.grpImportes.Name = "grpImportes";
            this.grpImportes.Size = new System.Drawing.Size(709, 77);
            this.grpImportes.TabIndex = 8;
            this.grpImportes.TabStop = false;
            this.grpImportes.Text = "Importes Globales (calculados en base al saldo actual de las deudas seleccionadas" +
                ")";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(187, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 24);
            this.label15.TabIndex = 63;
            this.label15.Text = "=";
            // 
            // lblPagar
            // 
            this.lblPagar.AutoSize = true;
            this.lblPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagar.Location = new System.Drawing.Point(9, 50);
            this.lblPagar.Name = "lblPagar";
            this.lblPagar.Size = new System.Drawing.Size(72, 13);
            this.lblPagar.TabIndex = 61;
            this.lblPagar.Text = "A PAGAR $";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "TOTAL $";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(574, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Gastos $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Honor. $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Interes $";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(169, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 13);
            this.label17.TabIndex = 61;
            this.label17.Text = "(valor final IVA Honorarios incluido)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Capital $";
            // 
            // txtPagar
            // 
            this.txtPagar.Location = new System.Drawing.Point(87, 47);
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.ReadOnly = true;
            this.txtPagar.Size = new System.Drawing.Size(79, 20);
            this.txtPagar.TabIndex = 0;
            this.txtPagar.TabStop = false;
            this.txtPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagar.LostFocus += new System.EventHandler(this.ctrlTxtTotal_KeyDown);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(87, 21);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(79, 20);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.LostFocus += new System.EventHandler(this.ctrlTxtTotal_KeyDown);
            // 
            // txtGastos
            // 
            this.txtGastos.Location = new System.Drawing.Point(627, 21);
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.ReadOnly = true;
            this.txtGastos.Size = new System.Drawing.Size(60, 20);
            this.txtGastos.TabIndex = 4;
            this.txtGastos.TabStop = false;
            this.txtGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGastos.TextChanged += new System.EventHandler(this.ctrlTxtTotal_KeyDown);
            // 
            // txtHonor
            // 
            this.txtHonor.Location = new System.Drawing.Point(510, 21);
            this.txtHonor.Name = "txtHonor";
            this.txtHonor.ReadOnly = true;
            this.txtHonor.Size = new System.Drawing.Size(60, 20);
            this.txtHonor.TabIndex = 3;
            this.txtHonor.TabStop = false;
            this.txtHonor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHonor.TextChanged += new System.EventHandler(this.ctrlTxtTotal_KeyDown);
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(393, 21);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.ReadOnly = true;
            this.txtInteres.Size = new System.Drawing.Size(60, 20);
            this.txtInteres.TabIndex = 2;
            this.txtInteres.TabStop = false;
            this.txtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInteres.TextChanged += new System.EventHandler(this.ctrlTxtTotal_KeyDown);
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(276, 21);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.ReadOnly = true;
            this.txtCapital.Size = new System.Drawing.Size(60, 20);
            this.txtCapital.TabIndex = 1;
            this.txtCapital.TabStop = false;
            this.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCapital.TextChanged += new System.EventHandler(this.ctrlTxtTotal_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(463, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = "Estado Actual";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(540, 448);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(174, 20);
            this.txtEstado.TabIndex = 10;
            this.txtEstado.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(523, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "Total Pagos a hoy $";
            // 
            // txtPagosAHoy
            // 
            this.txtPagosAHoy.Location = new System.Drawing.Point(628, 12);
            this.txtPagosAHoy.Name = "txtPagosAHoy";
            this.txtPagosAHoy.ReadOnly = true;
            this.txtPagosAHoy.Size = new System.Drawing.Size(86, 20);
            this.txtPagosAHoy.TabIndex = 74;
            this.txtPagosAHoy.TabStop = false;
            this.txtPagosAHoy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkAjustar
            // 
            this.chkAjustar.AutoSize = true;
            this.chkAjustar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAjustar.Checked = true;
            this.chkAjustar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAjustar.Location = new System.Drawing.Point(622, 104);
            this.chkAjustar.Name = "chkAjustar";
            this.chkAjustar.Size = new System.Drawing.Size(91, 17);
            this.chkAjustar.TabIndex = 5;
            this.chkAjustar.Text = "Distribuir Auto";
            this.chkAjustar.UseVisualStyleBackColor = true;
            this.chkAjustar.CheckedChanged += new System.EventHandler(this.chkAjustar_CheckedChanged);
            // 
            // txtFechaBaja
            // 
            this.txtFechaBaja.Location = new System.Drawing.Point(540, 474);
            this.txtFechaBaja.Name = "txtFechaBaja";
            this.txtFechaBaja.ReadOnly = true;
            this.txtFechaBaja.Size = new System.Drawing.Size(174, 20);
            this.txtFechaBaja.TabIndex = 13;
            this.txtFechaBaja.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(475, 477);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 78;
            this.label13.Text = "Fecha Baja";
            // 
            // btnGenerarRecibo
            // 
            this.btnGenerarRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRecibo.Image = global::cuAbmPago.Properties.Resources.movimiento;
            this.btnGenerarRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarRecibo.Location = new System.Drawing.Point(577, 45);
            this.btnGenerarRecibo.Name = "btnGenerarRecibo";
            this.btnGenerarRecibo.Size = new System.Drawing.Size(110, 27);
            this.btnGenerarRecibo.TabIndex = 64;
            this.btnGenerarRecibo.Tag = "BOTON.RECIBO.GENERAR";
            this.btnGenerarRecibo.Text = "Generar &Recibo";
            this.btnGenerarRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarRecibo.Visible = true;
            this.btnGenerarRecibo.Click += new System.EventHandler(this.btnGenerarRecibo_Click);
            // 
            // findCuenta
            // 
            this.findCuenta.Image = global::cuAbmPago.Properties.Resources.seleccionar;
            this.findCuenta.Location = new System.Drawing.Point(442, 10);
            this.findCuenta.Name = "findCuenta";
            this.findCuenta.Size = new System.Drawing.Size(26, 23);
            this.findCuenta.TabIndex = 0;
            this.findCuenta.TabStop = false;
            this.findCuenta.UseVisualStyleBackColor = true;
            this.findCuenta.Click += new System.EventHandler(this.ctrlFindCuenta_Click);
            // 
            // btnVerConvenio
            // 
            this.btnVerConvenio.Image = global::cuAbmPago.Properties.Resources.convenio;
            this.btnVerConvenio.Location = new System.Drawing.Point(689, 36);
            this.btnVerConvenio.Name = "btnVerConvenio";
            this.btnVerConvenio.Size = new System.Drawing.Size(26, 23);
            this.btnVerConvenio.TabIndex = 2;
            this.btnVerConvenio.TabStop = false;
            this.btnVerConvenio.UseVisualStyleBackColor = true;
            this.btnVerConvenio.Click += new System.EventHandler(this.btnVerConvenio_Click);
            // 
            // btnVerCuenta
            // 
            this.btnVerCuenta.Image = global::cuAbmPago.Properties.Resources.cuenta1;
            this.btnVerCuenta.Location = new System.Drawing.Point(471, 10);
            this.btnVerCuenta.Name = "btnVerCuenta";
            this.btnVerCuenta.Size = new System.Drawing.Size(26, 23);
            this.btnVerCuenta.TabIndex = 1;
            this.btnVerCuenta.TabStop = false;
            this.btnVerCuenta.UseVisualStyleBackColor = true;
            this.btnVerCuenta.Click += new System.EventHandler(this.btnVerCuenta_Click);
            // 
            // UserControl1
            // 
            this.Controls.Add(this.txtFechaBaja);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chkAjustar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPagosAHoy);
            this.Controls.Add(this.grpImportes);
            this.Controls.Add(this.findCuenta);
            this.Controls.Add(this.txtConvenio);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnVerConvenio);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ctrlTxtComboFormaPago);
            this.Controls.Add(this.ctrlTxtComboTipoPago);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtFechaUMod);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlTxtDescripcion);
            this.Controls.Add(this.btnVerCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCuenta);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(722, 500);
            this.tabControl.ResumeLayout(false);
            this.grpImportes.ResumeLayout(false);
            this.grpImportes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Button btnVerCuenta;
        private ReadOnlyComboBox ctrlTxtComboFormaPago;
        private ReadOnlyComboBox ctrlTxtComboTipoPago;
        private System.Windows.Forms.TextBox txtFechaUMod;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDeudas;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnVerConvenio;
        private System.Windows.Forms.Button findCuenta;
        private System.Windows.Forms.TabPage tabRecibos;
        private System.Windows.Forms.GroupBox grpImportes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtGastos;
        private System.Windows.Forms.TextBox txtHonor;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPagosAHoy;
        private System.Windows.Forms.CheckBox chkAjustar;
        private System.Windows.Forms.TextBox txtFechaBaja;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPagar;
        private System.Windows.Forms.TextBox txtPagar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnGenerarRecibo;
    }
}