namespace cuGenerarInformes
{
    partial class PanelImprimirFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAcept = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHCuit = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHRemito = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkHCtaCte = new System.Windows.Forms.CheckBox();
            this.chkHContado = new System.Windows.Forms.CheckBox();
            this.chkHResponsable = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHDomicilio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHNro = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHFecha = new System.Windows.Forms.MaskedTextBox();
            this.cmbHFecha = new System.Windows.Forms.DateTimePicker();
            this.txtHCliente = new System.Windows.Forms.TextBox();
            this.cmbHEntidad = new System.Windows.Forms.ComboBox();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbEntidad = new System.Windows.Forms.RadioButton();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.txtUnitario = new System.Windows.Forms.MaskedTextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(765, 411);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnSave,
            this.toolBtnPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(765, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnSave
            // 
            this.toolBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSave.Image = global::cuGenerarInformes.Properties.Resources.Save_24x24;
            this.toolBtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSave.Name = "toolBtnSave";
            this.toolBtnSave.Size = new System.Drawing.Size(28, 28);
            this.toolBtnSave.Text = "toolStripButton1";
            this.toolBtnSave.Click += new System.EventHandler(this.toolBtnSave_Click);
            // 
            // toolBtnPrint
            // 
            this.toolBtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnPrint.Image = global::cuGenerarInformes.Properties.Resources.Print_24x24;
            this.toolBtnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnPrint.Name = "toolBtnPrint";
            this.toolBtnPrint.Size = new System.Drawing.Size(28, 28);
            this.toolBtnPrint.Text = "toolStripButton2";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(765, 377);
            this.splitContainer2.SplitterDistance = 289;
            this.splitContainer2.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.cmbHTipo);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.txtHNro);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.txtHFecha);
            this.splitContainer3.Panel1.Controls.Add(this.cmbHFecha);
            this.splitContainer3.Panel1.Controls.Add(this.txtHCliente);
            this.splitContainer3.Panel1.Controls.Add(this.cmbHEntidad);
            this.splitContainer3.Panel1.Controls.Add(this.rbCliente);
            this.splitContainer3.Panel1.Controls.Add(this.rbEntidad);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvListado);
            this.splitContainer3.Size = new System.Drawing.Size(765, 289);
            this.splitContainer3.SplitterDistance = 234;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUnitario);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnAcept);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtDescri);
            this.groupBox2.Location = new System.Drawing.Point(3, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 48);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Línea";
            // 
            // btnDel
            // 
            this.btnDel.Image = global::cuGenerarInformes.Properties.Resources.delete;
            this.btnDel.Location = new System.Drawing.Point(713, 19);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(31, 24);
            this.btnDel.TabIndex = 5;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAcept
            // 
            this.btnAcept.Image = global::cuGenerarInformes.Properties.Resources.accept;
            this.btnAcept.Location = new System.Drawing.Point(676, 19);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(31, 24);
            this.btnAcept.TabIndex = 4;
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::cuGenerarInformes.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(639, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 24);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescri
            // 
            this.txtDescri.Enabled = false;
            this.txtDescri.Location = new System.Drawing.Point(120, 22);
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(407, 20);
            this.txtDescri.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHCuit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHRemito);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkHCtaCte);
            this.groupBox1.Controls.Add(this.chkHContado);
            this.groupBox1.Controls.Add(this.chkHResponsable);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHDomicilio);
            this.groupBox1.Location = new System.Drawing.Point(3, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 96);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // txtHCuit
            // 
            this.txtHCuit.Location = new System.Drawing.Point(588, 19);
            this.txtHCuit.Mask = "00-00000000-0";
            this.txtHCuit.Name = "txtHCuit";
            this.txtHCuit.Size = new System.Drawing.Size(161, 20);
            this.txtHCuit.TabIndex = 21;
            this.txtHCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cuit";
            // 
            // txtHRemito
            // 
            this.txtHRemito.Location = new System.Drawing.Point(587, 54);
            this.txtHRemito.Mask = "0000-00000000";
            this.txtHRemito.Name = "txtHRemito";
            this.txtHRemito.Size = new System.Drawing.Size(161, 20);
            this.txtHRemito.TabIndex = 12;
            this.txtHRemito.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Remito";
            // 
            // chkHCtaCte
            // 
            this.chkHCtaCte.AutoSize = true;
            this.chkHCtaCte.Location = new System.Drawing.Point(357, 57);
            this.chkHCtaCte.Name = "chkHCtaCte";
            this.chkHCtaCte.Size = new System.Drawing.Size(64, 17);
            this.chkHCtaCte.TabIndex = 16;
            this.chkHCtaCte.Text = "Cta.Cte.";
            this.chkHCtaCte.UseVisualStyleBackColor = true;
            // 
            // chkHContado
            // 
            this.chkHContado.AutoSize = true;
            this.chkHContado.Location = new System.Drawing.Point(285, 57);
            this.chkHContado.Name = "chkHContado";
            this.chkHContado.Size = new System.Drawing.Size(66, 17);
            this.chkHContado.TabIndex = 15;
            this.chkHContado.Text = "Contado";
            this.chkHContado.UseVisualStyleBackColor = true;
            // 
            // chkHResponsable
            // 
            this.chkHResponsable.AutoSize = true;
            this.chkHResponsable.Location = new System.Drawing.Point(81, 57);
            this.chkHResponsable.Name = "chkHResponsable";
            this.chkHResponsable.Size = new System.Drawing.Size(131, 17);
            this.chkHResponsable.TabIndex = 14;
            this.chkHResponsable.Text = "Responsable Inscripto";
            this.chkHResponsable.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Domicilio";
            // 
            // txtHDomicilio
            // 
            this.txtHDomicilio.Location = new System.Drawing.Point(81, 19);
            this.txtHDomicilio.Name = "txtHDomicilio";
            this.txtHDomicilio.Size = new System.Drawing.Size(458, 20);
            this.txtHDomicilio.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo";
            // 
            // cmbHTipo
            // 
            this.cmbHTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHTipo.FormattingEnabled = true;
            this.cmbHTipo.Location = new System.Drawing.Point(452, 43);
            this.cmbHTipo.Name = "cmbHTipo";
            this.cmbHTipo.Size = new System.Drawing.Size(116, 21);
            this.cmbHTipo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nro.";
            // 
            // txtHNro
            // 
            this.txtHNro.Location = new System.Drawing.Point(620, 16);
            this.txtHNro.Mask = "0000-00000000";
            this.txtHNro.Name = "txtHNro";
            this.txtHNro.Size = new System.Drawing.Size(137, 20);
            this.txtHNro.TabIndex = 7;
            this.txtHNro.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha";
            // 
            // txtHFecha
            // 
            this.txtHFecha.Location = new System.Drawing.Point(452, 16);
            this.txtHFecha.Mask = "00/00/0000";
            this.txtHFecha.Name = "txtHFecha";
            this.txtHFecha.ReadOnly = true;
            this.txtHFecha.Size = new System.Drawing.Size(90, 20);
            this.txtHFecha.TabIndex = 4;
            this.txtHFecha.ValidatingType = typeof(System.DateTime);
            // 
            // cmbHFecha
            // 
            this.cmbHFecha.CustomFormat = "dd/MM/yyyy  hh:mm:ss";
            this.cmbHFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmbHFecha.Location = new System.Drawing.Point(548, 16);
            this.cmbHFecha.Name = "cmbHFecha";
            this.cmbHFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbHFecha.Size = new System.Drawing.Size(20, 20);
            this.cmbHFecha.TabIndex = 5;
            this.cmbHFecha.ValueChanged += new System.EventHandler(this.cmbHFecha_ValueChanged);
            // 
            // txtHCliente
            // 
            this.txtHCliente.Location = new System.Drawing.Point(84, 42);
            this.txtHCliente.Name = "txtHCliente";
            this.txtHCliente.Size = new System.Drawing.Size(243, 20);
            this.txtHCliente.TabIndex = 3;
            // 
            // cmbHEntidad
            // 
            this.cmbHEntidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHEntidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHEntidad.FormattingEnabled = true;
            this.cmbHEntidad.Location = new System.Drawing.Point(84, 15);
            this.cmbHEntidad.Name = "cmbHEntidad";
            this.cmbHEntidad.Size = new System.Drawing.Size(243, 21);
            this.cmbHEntidad.TabIndex = 2;
            this.cmbHEntidad.SelectedIndexChanged += new System.EventHandler(this.ctrlCmbEntidad_SelectedIndexChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(17, 43);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbEntidad
            // 
            this.rbEntidad.AutoSize = true;
            this.rbEntidad.Location = new System.Drawing.Point(17, 16);
            this.rbEntidad.Name = "rbEntidad";
            this.rbEntidad.Size = new System.Drawing.Size(61, 17);
            this.rbEntidad.TabIndex = 0;
            this.rbEntidad.TabStop = true;
            this.rbEntidad.Text = "Entidad";
            this.rbEntidad.UseVisualStyleBackColor = true;
            this.rbEntidad.CheckedChanged += new System.EventHandler(this.rbEntidad_CheckedChanged);
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListado.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListado.EnableHeadersVisualStyles = false;
            this.dgvListado.Location = new System.Drawing.Point(0, 0);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(765, 51);
            this.dgvListado.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(6, 22);
            this.txtCantidad.Mask = "99999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(108, 20);
            this.txtCantidad.TabIndex = 22;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCantidad.ValidatingType = typeof(int);
            // 
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(533, 22);
            this.txtUnitario.Mask = "00000";
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtUnitario.TabIndex = 13;
            this.txtUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnitario.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // PanelImprimirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "PanelImprimirFactura";
            this.Size = new System.Drawing.Size(765, 411);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDescri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtHRemito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkHCtaCte;
        private System.Windows.Forms.CheckBox chkHContado;
        private System.Windows.Forms.CheckBox chkHResponsable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHDomicilio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtHNro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtHFecha;
        private System.Windows.Forms.DateTimePicker cmbHFecha;
        private System.Windows.Forms.TextBox txtHCliente;
        private System.Windows.Forms.ComboBox cmbHEntidad;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbEntidad;
        protected System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBtnSave;
        private System.Windows.Forms.ToolStripButton toolBtnPrint;
        private System.Windows.Forms.MaskedTextBox txtHCuit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtUnitario;
        private System.Windows.Forms.MaskedTextBox txtCantidad;

    }
}
