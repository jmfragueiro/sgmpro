using scioThirdPartLibrary;

namespace cuAbmRecibo {
    partial class PanelAbmvRecibo {
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
            this.panelAbmvContacto1 = new cuAbmContacto.PanelAbmvContacto(new cuAbmContacto.CUAbmContacto());
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.ctrlTxtComboTipoRecibo = new scioThirdPartLibrary.ReadOnlyComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.ctrlTxtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.grpDestinatario = new System.Windows.Forms.GroupBox();
            this.btnImprimirCopia = new System.Windows.Forms.Button();
            this.btnReimprimirRecibo = new System.Windows.Forms.Button();
            this.grpPago.SuspendLayout();
            this.grpDestinatario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAbmvContacto1
            // 
            this.panelAbmvContacto1.Location = new System.Drawing.Point(44, 19);
            this.panelAbmvContacto1.Name = "panelAbmvContacto1";
            this.panelAbmvContacto1.Size = new System.Drawing.Size(547, 246);
            this.panelAbmvContacto1.TabIndex = 0;
            // 
            // grpPago
            // 
            this.grpPago.Controls.Add(this.ctrlTxtComboTipoRecibo);
            this.grpPago.Controls.Add(this.txtFecha);
            this.grpPago.Controls.Add(this.btnImprimirCopia);
            this.grpPago.Controls.Add(this.btnReimprimirRecibo);
            this.grpPago.Controls.Add(this.label8);
            this.grpPago.Controls.Add(this.label4);
            this.grpPago.Controls.Add(this.label3);
            this.grpPago.Controls.Add(this.label10);
            this.grpPago.Controls.Add(this.label1);
            this.grpPago.Controls.Add(this.txtConcepto);
            this.grpPago.Controls.Add(this.ctrlTxtDescripcion);
            this.grpPago.Controls.Add(this.ctrlTxtNumero);
            this.grpPago.Controls.Add(this.label7);
            this.grpPago.Controls.Add(this.txtImporte);
            this.grpPago.Controls.Add(this.label2);
            this.grpPago.Controls.Add(this.txtPago);
            this.grpPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPago.Location = new System.Drawing.Point(6, 0);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(625, 133);
            this.grpPago.TabIndex = 0;
            this.grpPago.TabStop = false;
            this.grpPago.Text = "Datos del pago";
            // 
            // ctrlTxtComboTipoRecibo
            // 
            this.ctrlTxtComboTipoRecibo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtComboTipoRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtComboTipoRecibo.FormattingEnabled = true;
            this.ctrlTxtComboTipoRecibo.Location = new System.Drawing.Point(79, 23);
            this.ctrlTxtComboTipoRecibo.Name = "ctrlTxtComboTipoRecibo";
            this.ctrlTxtComboTipoRecibo.Size = new System.Drawing.Size(168, 21);
            this.ctrlTxtComboTipoRecibo.TabIndex = 0;
            this.ctrlTxtComboTipoRecibo.SelectedIndexChanged += new System.EventHandler(this.ctrlTxtComboTipoRecibo_SelectedIndexChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(502, 23);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(107, 20);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(441, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Concepto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Descripción";
            this.label3.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(253, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Tipo";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(79, 77);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.ReadOnly = true;
            this.txtConcepto.Size = new System.Drawing.Size(349, 20);
            this.txtConcepto.TabIndex = 70;
            this.txtConcepto.TabStop = false;
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(79, 103);
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ReadOnly = true;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(349, 20);
            this.ctrlTxtDescripcion.TabIndex = 2;
            this.ctrlTxtDescripcion.Visible = false;
            // 
            // ctrlTxtNumero
            // 
            this.ctrlTxtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtNumero.Location = new System.Drawing.Point(303, 23);
            this.ctrlTxtNumero.Name = "ctrlTxtNumero";
            this.ctrlTxtNumero.Size = new System.Drawing.Size(125, 20);
            this.ctrlTxtNumero.TabIndex = 1;
            this.ctrlTxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Importe =  $";
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(502, 50);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(107, 20);
            this.txtImporte.TabIndex = 67;
            this.txtImporte.TabStop = false;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Pago";
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(79, 50);
            this.txtPago.Name = "txtPago";
            this.txtPago.ReadOnly = true;
            this.txtPago.Size = new System.Drawing.Size(349, 20);
            this.txtPago.TabIndex = 3;
            this.txtPago.TabStop = false;
            // 
            // grpDestinatario
            // 
            this.grpDestinatario.Controls.Add(this.panelAbmvContacto1);
            this.grpDestinatario.Location = new System.Drawing.Point(6, 142);
            this.grpDestinatario.Name = "grpDestinatario";
            this.grpDestinatario.Size = new System.Drawing.Size(625, 272);
            this.grpDestinatario.TabIndex = 1;
            this.grpDestinatario.TabStop = false;
            this.grpDestinatario.Text = "Destinatario";
            // 
            // btnImprimirCopia
            // 
            this.btnImprimirCopia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirCopia.Image = global::cuAbmRecibo.Properties.Resources.imprimir;
            this.btnImprimirCopia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirCopia.Location = new System.Drawing.Point(525, 77);
            this.btnImprimirCopia.Name = "btnImprimirCopia";
            this.btnImprimirCopia.Size = new System.Drawing.Size(84, 46);
            this.btnImprimirCopia.TabIndex = 3;
            this.btnImprimirCopia.Tag = "BOTON.RECIBO.COPIAFIEL";
            this.btnImprimirCopia.Text = "Copia &Fiel";
            this.btnImprimirCopia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirCopia.Visible = false;
            this.btnImprimirCopia.Click += new System.EventHandler(this.btnImprimirCopia_Click);
            // 
            // btnReimprimirRecibo
            // 
            this.btnReimprimirRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimprimirRecibo.Image = global::cuAbmRecibo.Properties.Resources.imprimir;
            this.btnReimprimirRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReimprimirRecibo.Location = new System.Drawing.Point(436, 77);
            this.btnReimprimirRecibo.Name = "btnReimprimirRecibo";
            this.btnReimprimirRecibo.Size = new System.Drawing.Size(83, 46);
            this.btnReimprimirRecibo.TabIndex = 3;
            this.btnReimprimirRecibo.Tag = "BOTON.RECIBO.REIMPRIMIR";
            this.btnReimprimirRecibo.Text = "&Reimprimir";
            this.btnReimprimirRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReimprimirRecibo.Visible = false;
            this.btnReimprimirRecibo.Click += new System.EventHandler(this.btnReimprimirRecibo_Click);
            // 
            // UserControl1
            // 
            this.Controls.Add(this.grpDestinatario);
            this.Controls.Add(this.grpPago);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(636, 417);
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            this.grpDestinatario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReimprimirRecibo;
        private System.Windows.Forms.GroupBox grpPago;
        private ReadOnlyComboBox ctrlTxtComboTipoRecibo;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.TextBox ctrlTxtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.GroupBox grpDestinatario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private cuAbmContacto.PanelAbmvContacto panelAbmvContacto1;
        private System.Windows.Forms.Button btnImprimirCopia;
    }
}