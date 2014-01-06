using System.Windows.Forms;
using scioThirdPartLibrary;
using sgmpro.dominio.gestion;

namespace cuAbmGestion
{
    partial class PanelAbmvGestion
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersona = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrlTxtComboResultado = new ReadOnlyComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctrlTxtResFecha = new System.Windows.Forms.MaskedTextBox();
            this.ctrlFechaRes = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.btnReimprimir = new System.Windows.Forms.Button();
            this.btnVerCuenta = new System.Windows.Forms.Button();
            this.btnVerContacto = new System.Windows.Forms.Button();
            this.ctrlFindContacto = new System.Windows.Forms.Button();
            this.btnVerPersona = new System.Windows.Forms.Button();
            this.ctrlFindPersona = new System.Windows.Forms.Button();
            this.btnAddContacto = new System.Windows.Forms.Button();
            this.ctrlTxtComboTipo = new ReadOnlyComboBox();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtFechaCierre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(118, 370);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(227, 20);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Asignada / Ejecutada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Persona Contactada";
            // 
            // txtPersona
            // 
            this.txtPersona.Location = new System.Drawing.Point(117, 61);
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.ReadOnly = true;
            this.txtPersona.Size = new System.Drawing.Size(542, 20);
            this.txtPersona.TabIndex = 9;
            this.txtPersona.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha Cierre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Descripción";
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(111, 49);
            this.ctrlTxtDescripcion.Multiline = true;
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ReadOnly = true;
            this.ctrlTxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(600, 118);
            this.ctrlTxtDescripcion.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrlTxtComboResultado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ctrlTxtResFecha);
            this.groupBox1.Controls.Add(this.ctrlTxtDescripcion);
            this.groupBox1.Controls.Add(this.ctrlFechaRes);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(6, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 199);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado de Gestión";
            // 
            // ctrlTxtComboResultado
            // 
            this.ctrlTxtComboResultado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctrlTxtComboResultado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctrlTxtComboResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtComboResultado.FormattingEnabled = true;
            this.ctrlTxtComboResultado.Location = new System.Drawing.Point(111, 22);
            this.ctrlTxtComboResultado.Name = "ctrlTxtComboResultado";
            this.ctrlTxtComboResultado.Size = new System.Drawing.Size(280, 21);
            this.ctrlTxtComboResultado.TabIndex = 0;
            this.ctrlTxtComboResultado.SelectedIndexChanged += new System.EventHandler(this.ctrlTxtComboResultado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Tipo de Resultado\r\n";
            // 
            // ctrlTxtResFecha
            // 
            this.ctrlTxtResFecha.Location = new System.Drawing.Point(111, 173);
            this.ctrlTxtResFecha.Mask = "00/00/0000";
            this.ctrlTxtResFecha.Name = "ctrlTxtResFecha";
            this.ctrlTxtResFecha.ReadOnly = true;
            this.ctrlTxtResFecha.Size = new System.Drawing.Size(90, 20);
            this.ctrlTxtResFecha.TabIndex = 2;
            this.ctrlTxtResFecha.ValidatingType = typeof(System.DateTime);
            this.ctrlTxtResFecha.Validated += new System.EventHandler(this.ctrlTxtResFecha_Validated);
            // 
            // ctrlFechaRes
            // 
            this.ctrlFechaRes.CustomFormat = "dd/MM/yyyy  hh:mm:ss";
            this.ctrlFechaRes.Enabled = false;
            this.ctrlFechaRes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctrlFechaRes.Location = new System.Drawing.Point(207, 173);
            this.ctrlFechaRes.Name = "ctrlFechaRes";
            this.ctrlFechaRes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlFechaRes.Size = new System.Drawing.Size(20, 20);
            this.ctrlFechaRes.TabIndex = 3;
            this.ctrlFechaRes.ValueChanged += new System.EventHandler(this.ctrlFechaRes_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Fecha Rta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Contacto Utilizado";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(117, 87);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.ReadOnly = true;
            this.txtContacto.Size = new System.Drawing.Size(509, 20);
            this.txtContacto.TabIndex = 10;
            this.txtContacto.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tipo de Gestión";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "desde la Lista de Gestión";
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(496, 370);
            this.txtLista.Name = "txtLista";
            this.txtLista.ReadOnly = true;
            this.txtLista.Size = new System.Drawing.Size(227, 20);
            this.txtLista.TabIndex = 15;
            this.txtLista.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Estado de Gestión";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(117, 113);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(280, 20);
            this.txtEstado.TabIndex = 11;
            this.txtEstado.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Cuenta";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(117, 36);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.ReadOnly = true;
            this.txtCuenta.Size = new System.Drawing.Size(542, 20);
            this.txtCuenta.TabIndex = 8;
            this.txtCuenta.TabStop = false;
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.Image = global::cuAbmGestion.Properties.Resources.imprimir1;
            this.btnReimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReimprimir.Location = new System.Drawing.Point(583, 7);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(140, 23);
            this.btnReimprimir.TabIndex = 48;
            this.btnReimprimir.Text = "Imprimir Documento";
            this.btnReimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReimprimir.UseVisualStyleBackColor = true;
            this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);
            // 
            // btnVerCuenta
            // 
            this.btnVerCuenta.Image = global::cuAbmGestion.Properties.Resources.cuenta1;
            this.btnVerCuenta.Location = new System.Drawing.Point(665, 34);
            this.btnVerCuenta.Name = "btnVerCuenta";
            this.btnVerCuenta.Size = new System.Drawing.Size(26, 23);
            this.btnVerCuenta.TabIndex = 1;
            this.btnVerCuenta.UseVisualStyleBackColor = true;
            this.btnVerCuenta.Click += new System.EventHandler(this.btnVerCuenta_Click);
            // 
            // btnVerContacto
            // 
            this.btnVerContacto.Image = global::cuAbmGestion.Properties.Resources.contacto;
            this.btnVerContacto.Location = new System.Drawing.Point(697, 86);
            this.btnVerContacto.Name = "btnVerContacto";
            this.btnVerContacto.Size = new System.Drawing.Size(26, 23);
            this.btnVerContacto.TabIndex = 6;
            this.btnVerContacto.UseVisualStyleBackColor = true;
            this.btnVerContacto.Click += new System.EventHandler(this.btnVerContacto_Click);
            // 
            // ctrlFindContacto
            // 
            this.ctrlFindContacto.Image = global::cuAbmGestion.Properties.Resources.seleccionar;
            this.ctrlFindContacto.Location = new System.Drawing.Point(665, 86);
            this.ctrlFindContacto.Name = "ctrlFindContacto";
            this.ctrlFindContacto.Size = new System.Drawing.Size(26, 23);
            this.ctrlFindContacto.TabIndex = 5;
            this.ctrlFindContacto.UseVisualStyleBackColor = true;
            this.ctrlFindContacto.Click += new System.EventHandler(this.ctrlFindContacto_Click);
            // 
            // btnVerPersona
            // 
            this.btnVerPersona.Image = global::cuAbmGestion.Properties.Resources.persona2;
            this.btnVerPersona.Location = new System.Drawing.Point(697, 60);
            this.btnVerPersona.Name = "btnVerPersona";
            this.btnVerPersona.Size = new System.Drawing.Size(26, 23);
            this.btnVerPersona.TabIndex = 3;
            this.btnVerPersona.UseVisualStyleBackColor = true;
            this.btnVerPersona.Click += new System.EventHandler(this.btnVerPersona_Click);
            // 
            // ctrlFindPersona
            // 
            this.ctrlFindPersona.Image = global::cuAbmGestion.Properties.Resources.seleccionar;
            this.ctrlFindPersona.Location = new System.Drawing.Point(665, 60);
            this.ctrlFindPersona.Name = "ctrlFindPersona";
            this.ctrlFindPersona.Size = new System.Drawing.Size(26, 23);
            this.ctrlFindPersona.TabIndex = 2;
            this.ctrlFindPersona.UseVisualStyleBackColor = true;
            this.ctrlFindPersona.Click += new System.EventHandler(this.ctrlFindPersona_Click);
            // 
            // btnAddContacto
            // 
            this.btnAddContacto.Image = global::cuAbmGestion.Properties.Resources.nuevo;
            this.btnAddContacto.Location = new System.Drawing.Point(633, 86);
            this.btnAddContacto.Name = "btnAddContacto";
            this.btnAddContacto.Size = new System.Drawing.Size(26, 23);
            this.btnAddContacto.TabIndex = 4;
            this.btnAddContacto.Tag = "BOTON.CONTACTO.CREAR";
            this.btnAddContacto.UseVisualStyleBackColor = true;
            this.btnAddContacto.Click += new System.EventHandler(this.ctrlAddContacto_Click);
            // 
            // ctrlTxtComboTipo
            // 
            this.ctrlTxtComboTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctrlTxtComboTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctrlTxtComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtComboTipo.FormattingEnabled = true;
            this.ctrlTxtComboTipo.Location = new System.Drawing.Point(118, 9);
            this.ctrlTxtComboTipo.Name = "ctrlTxtComboTipo";
            this.ctrlTxtComboTipo.Size = new System.Drawing.Size(279, 21);
            this.ctrlTxtComboTipo.TabIndex = 0;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(118, 344);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = true;
            this.txtFechaInicio.Size = new System.Drawing.Size(227, 20);
            this.txtFechaInicio.TabIndex = 12;
            this.txtFechaInicio.TabStop = false;
            // 
            // txtFechaCierre
            // 
            this.txtFechaCierre.Location = new System.Drawing.Point(496, 344);
            this.txtFechaCierre.Name = "txtFechaCierre";
            this.txtFechaCierre.ReadOnly = true;
            this.txtFechaCierre.Size = new System.Drawing.Size(227, 20);
            this.txtFechaCierre.TabIndex = 13;
            this.txtFechaCierre.TabStop = false;
            // 
            // PanelGUIAbmvGestion
            // 
            this.Controls.Add(this.ctrlTxtComboTipo);
            this.Controls.Add(this.btnVerCuenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFechaCierre);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReimprimir);
            this.Controls.Add(this.btnVerContacto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddContacto);
            this.Controls.Add(this.ctrlFindContacto);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerPersona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlFindPersona);
            this.Controls.Add(this.txtPersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.groupBox1);
            this.Name = "PanelGUIAbmvGestion";
            this.Size = new System.Drawing.Size(726, 398);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerPersona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ctrlFindPersona;
        private System.Windows.Forms.TextBox txtPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerContacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ctrlFindContacto;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnVerCuenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Button btnAddContacto;
        private ReadOnlyComboBox ctrlTxtComboTipo;
        private System.Windows.Forms.MaskedTextBox ctrlTxtResFecha;
        private System.Windows.Forms.DateTimePicker ctrlFechaRes;
        private System.Windows.Forms.Label label12;
        private ReadOnlyComboBox ctrlTxtComboResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtFechaCierre;
        private System.Windows.Forms.Button btnReimprimir;
    }
}
