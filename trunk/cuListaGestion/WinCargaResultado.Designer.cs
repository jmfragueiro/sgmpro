using scioThirdPartLibrary;

namespace cuListaGestion
{
    partial class WinCargaResultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinCargaResultado));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctrlTxtComboResultado = new ReadOnlyComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ctrlTxtResFecha = new System.Windows.Forms.MaskedTextBox();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.ctrlFechaRes = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctrlTxtComboResultado);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ctrlTxtResFecha);
            this.groupBox2.Controls.Add(this.ctrlTxtDescripcion);
            this.groupBox2.Controls.Add(this.ctrlFechaRes);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12,14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535,144);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado de Gestión";
            // 
            // ctrlTxtComboResultado
            // 
            this.ctrlTxtComboResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtComboResultado.FormattingEnabled = true;
            this.ctrlTxtComboResultado.Location = new System.Drawing.Point(111,22);
            this.ctrlTxtComboResultado.Name = "ctrlTxtComboResultado";
            this.ctrlTxtComboResultado.Size = new System.Drawing.Size(184,21);
            this.ctrlTxtComboResultado.TabIndex = 0;
            this.ctrlTxtComboResultado.SelectedIndexChanged += new System.EventHandler(this.ctrlTxtComboResultado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13,25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94,13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Tipo de Resultado\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44,52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63,13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Descripción";
            // 
            // ctrlTxtResFecha
            // 
            this.ctrlTxtResFecha.Location = new System.Drawing.Point(111,118);
            this.ctrlTxtResFecha.Mask = "00/00/0000";
            this.ctrlTxtResFecha.Name = "ctrlTxtResFecha";
            this.ctrlTxtResFecha.Size = new System.Drawing.Size(90,20);
            this.ctrlTxtResFecha.TabIndex = 2;
            this.ctrlTxtResFecha.ValidatingType = typeof(System.DateTime);
            this.ctrlTxtResFecha.Validated += new System.EventHandler(this.ctrlTxtResFecha_Validated);
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(111,49);
            this.ctrlTxtDescripcion.Multiline = true;
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(416,63);
            this.ctrlTxtDescripcion.TabIndex = 1;
            // 
            // ctrlFechaRes
            // 
            this.ctrlFechaRes.CustomFormat = "dd/MM/yyyy  hh:mm:ss";
            this.ctrlFechaRes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctrlFechaRes.Location = new System.Drawing.Point(207,118);
            this.ctrlFechaRes.Name = "ctrlFechaRes";
            this.ctrlFechaRes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlFechaRes.Size = new System.Drawing.Size(20,20);
            this.ctrlFechaRes.TabIndex = 3;
            this.ctrlFechaRes.ValueChanged += new System.EventHandler(this.ctrlFechaRes_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20,122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57,13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Fecha Rta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Location = new System.Drawing.Point(-8,164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577,56);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(456,16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99,27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(345,16);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99,27);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // WinCargaResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F,13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(559,214);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinCargaResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SGMPro - Cargar Resultado de Gestión";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private ReadOnlyComboBox ctrlTxtComboResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox ctrlTxtResFecha;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.DateTimePicker ctrlFechaRes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
    }
}