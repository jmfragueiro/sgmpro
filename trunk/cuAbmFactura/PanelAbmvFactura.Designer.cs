using System.Windows.Forms;
using scioThirdPartLibrary;

namespace cuAbmFactura
{
    public partial class PanelAbmvFactura
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
            this.ctrlGrpCabecera = new System.Windows.Forms.GroupBox();
            this.ctrlChkContado = new System.Windows.Forms.CheckBox();
            this.ctrlTxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.ctrlFecha = new System.Windows.Forms.DateTimePicker();
            this.ctrlCmbTipo = new ReadOnlyComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlTxtNumero = new System.Windows.Forms.TextBox();
            this.ctrlCmbCliente = new ReadOnlyComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.ctrlGrpItem = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlTxtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlTxtConcepto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlTxtItem = new System.Windows.Forms.TextBox();
            this.GrpTotales = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.ctrlTxtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReimprimirRecibo = new System.Windows.Forms.Button();
            this.ctrlGrpCabecera.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.ctrlGrpItem.SuspendLayout();
            this.GrpTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlGrpCabecera
            // 
            this.ctrlGrpCabecera.Controls.Add(this.ctrlChkContado);
            this.ctrlGrpCabecera.Controls.Add(this.ctrlTxtFecha);
            this.ctrlGrpCabecera.Controls.Add(this.ctrlFecha);
            this.ctrlGrpCabecera.Controls.Add(this.ctrlCmbTipo);
            this.ctrlGrpCabecera.Controls.Add(this.label1);
            this.ctrlGrpCabecera.Controls.Add(this.label10);
            this.ctrlGrpCabecera.Controls.Add(this.label2);
            this.ctrlGrpCabecera.Controls.Add(this.ctrlTxtNumero);
            this.ctrlGrpCabecera.Controls.Add(this.ctrlCmbCliente);
            this.ctrlGrpCabecera.Controls.Add(this.label8);
            this.ctrlGrpCabecera.Location = new System.Drawing.Point(4, 3);
            this.ctrlGrpCabecera.Name = "ctrlGrpCabecera";
            this.ctrlGrpCabecera.Size = new System.Drawing.Size(745, 149);
            this.ctrlGrpCabecera.TabIndex = 0;
            this.ctrlGrpCabecera.TabStop = false;
            this.ctrlGrpCabecera.Text = "Cabecera";
            // 
            // ctrlChkContado
            // 
            this.ctrlChkContado.AutoSize = true;
            this.ctrlChkContado.Checked = true;
            this.ctrlChkContado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctrlChkContado.Location = new System.Drawing.Point(77, 126);
            this.ctrlChkContado.Name = "ctrlChkContado";
            this.ctrlChkContado.Size = new System.Drawing.Size(66, 17);
            this.ctrlChkContado.TabIndex = 5;
            this.ctrlChkContado.Text = "Contado";
            this.ctrlChkContado.UseVisualStyleBackColor = true;
            // 
            // ctrlTxtFecha
            // 
            this.ctrlTxtFecha.Location = new System.Drawing.Point(77, 99);
            this.ctrlTxtFecha.Mask = "00/00/0000";
            this.ctrlTxtFecha.Name = "ctrlTxtFecha";
            this.ctrlTxtFecha.Size = new System.Drawing.Size(99, 20);
            this.ctrlTxtFecha.TabIndex = 3;
            this.ctrlTxtFecha.ValidatingType = typeof(System.DateTime);
            this.ctrlTxtFecha.Validated += new System.EventHandler(this.ctrlTxtFecha_Validated);
            // 
            // ctrlFecha
            // 
            this.ctrlFecha.CustomFormat = "dd/MM/yyyy  hh:mm:ss";
            this.ctrlFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctrlFecha.Location = new System.Drawing.Point(182, 99);
            this.ctrlFecha.Name = "ctrlFecha";
            this.ctrlFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlFecha.Size = new System.Drawing.Size(20, 20);
            this.ctrlFecha.TabIndex = 4;
            this.ctrlFecha.ValueChanged += new System.EventHandler(this.ctrlFecha_ValueChanged);
            // 
            // ctrlCmbTipo
            // 
            this.ctrlCmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlCmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCmbTipo.FormattingEnabled = true;
            this.ctrlCmbTipo.Location = new System.Drawing.Point(77, 46);
            this.ctrlCmbTipo.Name = "ctrlCmbTipo";
            this.ctrlCmbTipo.Size = new System.Drawing.Size(125, 21);
            this.ctrlCmbTipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Tipo";
            // 
            // ctrlTxtNumero
            // 
            this.ctrlTxtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtNumero.Location = new System.Drawing.Point(77, 73);
            this.ctrlTxtNumero.Name = "ctrlTxtNumero";
            this.ctrlTxtNumero.Size = new System.Drawing.Size(125, 20);
            this.ctrlTxtNumero.TabIndex = 2;
            this.ctrlTxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrlTxtNumero.Enter += new System.EventHandler(this.ctrlTxtNumero_Enter);
            // 
            // ctrlCmbCliente
            // 
            this.ctrlCmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctrlCmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctrlCmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlCmbCliente.FormattingEnabled = true;
            this.ctrlCmbCliente.Location = new System.Drawing.Point(77, 19);
            this.ctrlCmbCliente.Name = "ctrlCmbCliente";
            this.ctrlCmbCliente.Size = new System.Drawing.Size(354, 21);
            this.ctrlCmbCliente.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Cliente";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabItems);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(3, 209);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(746, 218);
            this.tabControl.TabIndex = 2;
            // 
            // tabItems
            // 
            this.tabItems.Location = new System.Drawing.Point(4, 22);
            this.tabItems.Name = "tabItems";
            this.tabItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabItems.Size = new System.Drawing.Size(738, 192);
            this.tabItems.TabIndex = 0;
            this.tabItems.Text = "Items";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // ctrlGrpItem
            // 
            this.ctrlGrpItem.Controls.Add(this.label5);
            this.ctrlGrpItem.Controls.Add(this.ctrlTxtPrecio);
            this.ctrlGrpItem.Controls.Add(this.label4);
            this.ctrlGrpItem.Controls.Add(this.ctrlTxtConcepto);
            this.ctrlGrpItem.Controls.Add(this.label3);
            this.ctrlGrpItem.Controls.Add(this.ctrlTxtItem);
            this.ctrlGrpItem.Location = new System.Drawing.Point(4, 152);
            this.ctrlGrpItem.Name = "ctrlGrpItem";
            this.ctrlGrpItem.Size = new System.Drawing.Size(745, 79);
            this.ctrlGrpItem.TabIndex = 1;
            this.ctrlGrpItem.TabStop = false;
            this.ctrlGrpItem.Text = "Items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(701, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "Precio";
            // 
            // ctrlTxtPrecio
            // 
            this.ctrlTxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtPrecio.Location = new System.Drawing.Point(652, 31);
            this.ctrlTxtPrecio.Name = "ctrlTxtPrecio";
            this.ctrlTxtPrecio.Size = new System.Drawing.Size(86, 20);
            this.ctrlTxtPrecio.TabIndex = 2;
            this.ctrlTxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrlTxtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrlTxtPrecio_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Concepto";
            // 
            // ctrlTxtConcepto
            // 
            this.ctrlTxtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtConcepto.Location = new System.Drawing.Point(34, 31);
            this.ctrlTxtConcepto.Multiline = true;
            this.ctrlTxtConcepto.Name = "ctrlTxtConcepto";
            this.ctrlTxtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtConcepto.Size = new System.Drawing.Size(617, 42);
            this.ctrlTxtConcepto.TabIndex = 1;
            this.ctrlTxtConcepto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrlTxtConcepto_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Cant.";
            // 
            // ctrlTxtItem
            // 
            this.ctrlTxtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtItem.Location = new System.Drawing.Point(7, 31);
            this.ctrlTxtItem.Name = "ctrlTxtItem";
            this.ctrlTxtItem.Size = new System.Drawing.Size(26, 20);
            this.ctrlTxtItem.TabIndex = 0;
            this.ctrlTxtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrlTxtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrlTxtItem_KeyDown);
            // 
            // GrpTotales
            // 
            this.GrpTotales.Controls.Add(this.label6);
            this.GrpTotales.Controls.Add(this.label11);
            this.GrpTotales.Controls.Add(this.txtSubtotal);
            this.GrpTotales.Location = new System.Drawing.Point(296, 425);
            this.GrpTotales.Name = "GrpTotales";
            this.GrpTotales.Size = new System.Drawing.Size(452, 41);
            this.GrpTotales.TabIndex = 92;
            this.GrpTotales.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "SUBTOTAL $";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(198, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 89;
            this.label11.Text = "IVA";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(84, 15);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(86, 20);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ctrlTxtIVA
            // 
            this.ctrlTxtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtIVA.Location = new System.Drawing.Point(524, 440);
            this.ctrlTxtIVA.Name = "ctrlTxtIVA";
            this.ctrlTxtIVA.Size = new System.Drawing.Size(48, 20);
            this.ctrlTxtIVA.TabIndex = 2;
            this.ctrlTxtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrlTxtIVA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrlTxtIVA_KeyDown);
            this.ctrlTxtIVA.Leave += new System.EventHandler(this.ctrlTxtIVA_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(653, 440);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(85, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(572, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(602, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "TOTAL $";
            // 
            // btnReimprimirRecibo
            // 
            this.btnReimprimirRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimprimirRecibo.Image = global::cuAbmFactura.Properties.Resources.imprimir;
            this.btnReimprimirRecibo.Location = new System.Drawing.Point(4, 433);
            this.btnReimprimirRecibo.Name = "btnReimprimirRecibo";
            this.btnReimprimirRecibo.Size = new System.Drawing.Size(105, 27);
            this.btnReimprimirRecibo.TabIndex = 5;
            this.btnReimprimirRecibo.Tag = "BOTON.RECIBO.REIMPRIMIR";
            this.btnReimprimirRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReimprimirRecibo.Click += new System.EventHandler(this.btnReimprimirRecibo_Click);
            // 
            // PanelAbmvFactura
            // 
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ctrlGrpItem);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnReimprimirRecibo);
            this.Controls.Add(this.ctrlTxtIVA);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ctrlGrpCabecera);
            this.Controls.Add(this.GrpTotales);
            this.Name = "PanelAbmvFactura";
            this.Size = new System.Drawing.Size(752, 468);
            this.ctrlGrpCabecera.ResumeLayout(false);
            this.ctrlGrpCabecera.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ctrlGrpItem.ResumeLayout(false);
            this.ctrlGrpItem.PerformLayout();
            this.GrpTotales.ResumeLayout(false);
            this.GrpTotales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.GroupBox ctrlGrpCabecera;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabItems;
        private ReadOnlyComboBox ctrlCmbCliente;
        private Label label8;
        private ReadOnlyComboBox ctrlCmbTipo;
        private Button btnReimprimirRecibo;
        private Label label1;
        private Label label10;
        private Label label2;
        private TextBox ctrlTxtNumero;
        private MaskedTextBox ctrlTxtFecha;
        private DateTimePicker ctrlFecha;
        private CheckBox ctrlChkContado;
        private GroupBox ctrlGrpItem;
        private Label label3;
        private TextBox ctrlTxtItem;
        private Label label5;
        private TextBox ctrlTxtPrecio;
        private Label label4;
        private TextBox ctrlTxtConcepto;
        private GroupBox GrpTotales;
        private Label label6;
        private TextBox txtSubtotal;
        private TextBox ctrlTxtIVA;
        private TextBox txtTotal;
        private Label label7;
        private Label label11;
        private Label label9;
    }
}