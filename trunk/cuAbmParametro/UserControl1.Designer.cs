using scioThirdPartLibrary;

namespace cuAbmParametro
{
    partial class UserControl1
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
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlTxtOrden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlTxtComboClase = new ReadOnlyComboBox();
            this.ctrlTxtNombre = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlTxtClave = new System.Windows.Forms.TextBox();
            this.ctrlTxtComboTipo = new ReadOnlyComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpValores = new System.Windows.Forms.GroupBox();
            this.ctrlTxtValorChar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctrlChkValorBool = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlTxtValorDouble = new System.Windows.Forms.TextBox();
            this.ctrlTxtValorLong = new System.Windows.Forms.TextBox();
            this.ctrlTxtValorString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlValorFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorFecha = new System.Windows.Forms.TextBox();
            this.grpValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Clase";
            // 
            // ctrlTxtOrden
            // 
            this.ctrlTxtOrden.Location = new System.Drawing.Point(82, 63);
            this.ctrlTxtOrden.Name = "ctrlTxtOrden";
            this.ctrlTxtOrden.ReadOnly = true;
            this.ctrlTxtOrden.Size = new System.Drawing.Size(73, 20);
            this.ctrlTxtOrden.TabIndex = 0;
            this.ctrlTxtOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Orden";
            // 
            // ctrlTxtComboClase
            // 
            this.ctrlTxtComboClase.FormattingEnabled = true;
            this.ctrlTxtComboClase.Location = new System.Drawing.Point(82, 88);
            this.ctrlTxtComboClase.Name = "ctrlTxtComboClase";
            this.ctrlTxtComboClase.Size = new System.Drawing.Size(184, 21);
            this.ctrlTxtComboClase.TabIndex = 1;
            // 
            // ctrlTxtNombre
            // 
            this.ctrlTxtNombre.Location = new System.Drawing.Point(82, 38);
            this.ctrlTxtNombre.Name = "ctrlTxtNombre";
            this.ctrlTxtNombre.ReadOnly = true;
            this.ctrlTxtNombre.Size = new System.Drawing.Size(438, 20);
            this.ctrlTxtNombre.TabIndex = 78;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 79;
            this.label20.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Clave";
            // 
            // ctrlTxtClave
            // 
            this.ctrlTxtClave.Location = new System.Drawing.Point(82, 13);
            this.ctrlTxtClave.Name = "ctrlTxtClave";
            this.ctrlTxtClave.ReadOnly = true;
            this.ctrlTxtClave.Size = new System.Drawing.Size(438, 20);
            this.ctrlTxtClave.TabIndex = 76;
            // 
            // ctrlTxtComboTipo
            // 
            this.ctrlTxtComboTipo.FormattingEnabled = true;
            this.ctrlTxtComboTipo.Location = new System.Drawing.Point(82, 114);
            this.ctrlTxtComboTipo.Name = "ctrlTxtComboTipo";
            this.ctrlTxtComboTipo.Size = new System.Drawing.Size(185, 21);
            this.ctrlTxtComboTipo.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "Tipo";
            // 
            // grpValores
            // 
            this.grpValores.Controls.Add(this.ctrlTxtValorChar);
            this.grpValores.Controls.Add(this.label8);
            this.grpValores.Controls.Add(this.ctrlChkValorBool);
            this.grpValores.Controls.Add(this.label9);
            this.grpValores.Controls.Add(this.label5);
            this.grpValores.Controls.Add(this.ctrlTxtValorDouble);
            this.grpValores.Controls.Add(this.ctrlTxtValorLong);
            this.grpValores.Controls.Add(this.ctrlTxtValorString);
            this.grpValores.Controls.Add(this.label3);
            this.grpValores.Controls.Add(this.ctrlValorFecha);
            this.grpValores.Controls.Add(this.label6);
            this.grpValores.Controls.Add(this.txtValorFecha);
            this.grpValores.Location = new System.Drawing.Point(4, 150);
            this.grpValores.Name = "grpValores";
            this.grpValores.Size = new System.Drawing.Size(523, 189);
            this.grpValores.TabIndex = 87;
            this.grpValores.TabStop = false;
            this.grpValores.Text = "Valores del Parámetro";
            // 
            // ctrlTxtValorChar
            // 
            this.ctrlTxtValorChar.Location = new System.Drawing.Point(79, 165);
            this.ctrlTxtValorChar.Name = "ctrlTxtValorChar";
            this.ctrlTxtValorChar.ReadOnly = true;
            this.ctrlTxtValorChar.Size = new System.Drawing.Size(25, 20);
            this.ctrlTxtValorChar.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "Valor Char";
            // 
            // ctrlChkValorBool
            // 
            this.ctrlChkValorBool.AutoSize = true;
            this.ctrlChkValorBool.Location = new System.Drawing.Point(13, 144);
            this.ctrlChkValorBool.Name = "ctrlChkValorBool";
            this.ctrlChkValorBool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlChkValorBool.Size = new System.Drawing.Size(80, 17);
            this.ctrlChkValorBool.TabIndex = 99;
            this.ctrlChkValorBool.Text = "Valor Bool  ";
            this.ctrlChkValorBool.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 98;
            this.label9.Text = "Valor Double";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "Valor Long";
            // 
            // ctrlTxtValorDouble
            // 
            this.ctrlTxtValorDouble.Location = new System.Drawing.Point(79, 117);
            this.ctrlTxtValorDouble.Name = "ctrlTxtValorDouble";
            this.ctrlTxtValorDouble.ReadOnly = true;
            this.ctrlTxtValorDouble.Size = new System.Drawing.Size(185, 20);
            this.ctrlTxtValorDouble.TabIndex = 97;
            this.ctrlTxtValorDouble.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ctrlTxtValorLong
            // 
            this.ctrlTxtValorLong.Location = new System.Drawing.Point(79, 91);
            this.ctrlTxtValorLong.Name = "ctrlTxtValorLong";
            this.ctrlTxtValorLong.ReadOnly = true;
            this.ctrlTxtValorLong.Size = new System.Drawing.Size(185, 20);
            this.ctrlTxtValorLong.TabIndex = 97;
            this.ctrlTxtValorLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ctrlTxtValorString
            // 
            this.ctrlTxtValorString.Location = new System.Drawing.Point(79, 24);
            this.ctrlTxtValorString.Multiline = true;
            this.ctrlTxtValorString.Name = "ctrlTxtValorString";
            this.ctrlTxtValorString.ReadOnly = true;
            this.ctrlTxtValorString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtValorString.Size = new System.Drawing.Size(437, 35);
            this.ctrlTxtValorString.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "Valor String";
            // 
            // ctrlValorFecha
            // 
            this.ctrlValorFecha.CustomFormat = "dd/MM/yyyy  hh:mm:ss";
            this.ctrlValorFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctrlValorFecha.Location = new System.Drawing.Point(244, 65);
            this.ctrlValorFecha.Name = "ctrlValorFecha";
            this.ctrlValorFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ctrlValorFecha.Size = new System.Drawing.Size(20, 20);
            this.ctrlValorFecha.TabIndex = 92;
            this.ctrlValorFecha.ValueChanged += new System.EventHandler(this.ctrlValorFecha_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Valor Fecha";
            // 
            // txtValorFecha
            // 
            this.txtValorFecha.Location = new System.Drawing.Point(79, 65);
            this.txtValorFecha.Name = "txtValorFecha";
            this.txtValorFecha.ReadOnly = true;
            this.txtValorFecha.Size = new System.Drawing.Size(159, 20);
            this.txtValorFecha.TabIndex = 93;
            // 
            // UserControl1
            // 
            this.Controls.Add(this.ctrlTxtComboTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ctrlTxtNombre);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlTxtClave);
            this.Controls.Add(this.ctrlTxtComboClase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlTxtOrden);
            this.Controls.Add(this.grpValores);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(530, 345);
            this.grpValores.ResumeLayout(false);
            this.grpValores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctrlTxtOrden;
        private System.Windows.Forms.Label label2;
        private ReadOnlyComboBox ctrlTxtComboClase;
        private System.Windows.Forms.TextBox ctrlTxtNombre;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctrlTxtClave;
        private ReadOnlyComboBox ctrlTxtComboTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpValores;
        private System.Windows.Forms.TextBox ctrlTxtValorChar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ctrlChkValorBool;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctrlTxtValorLong;
        private System.Windows.Forms.TextBox ctrlTxtValorString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ctrlValorFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ctrlTxtValorDouble;
    }
}
