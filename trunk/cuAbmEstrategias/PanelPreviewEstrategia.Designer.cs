namespace cuAbmEstrategia
{
    partial class PanelPreviewEstrategia
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlTxtNombre = new System.Windows.Forms.TextBox();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidadPredicados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54,26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44,13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35,49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63,13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Descripción";
            // 
            // ctrlTxtNombre
            // 
            this.ctrlTxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif",8.25F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
            this.ctrlTxtNombre.Location = new System.Drawing.Point(106,23);
            this.ctrlTxtNombre.Name = "ctrlTxtNombre";
            this.ctrlTxtNombre.ReadOnly = true;
            this.ctrlTxtNombre.Size = new System.Drawing.Size(275,20);
            this.ctrlTxtNombre.TabIndex = 70;
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif",8.25F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(106,49);
            this.ctrlTxtDescripcion.Multiline = true;
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ReadOnly = true;
            this.ctrlTxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(390,41);
            this.ctrlTxtDescripcion.TabIndex = 72;
            // 
            // txtCantidadPredicados
            // 
            this.txtCantidadPredicados.Font = new System.Drawing.Font("Microsoft Sans Serif",8.25F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
            this.txtCantidadPredicados.Location = new System.Drawing.Point(106,96);
            this.txtCantidadPredicados.Name = "txtCantidadPredicados";
            this.txtCantidadPredicados.ReadOnly = true;
            this.txtCantidadPredicados.Size = new System.Drawing.Size(79,20);
            this.txtCantidadPredicados.TabIndex = 70;
            this.txtCantidadPredicados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21,90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77,30);
            this.label2.TabIndex = 74;
            this.label2.Text = "Cantidad de Predicados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelPreviewEstrategia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlTxtDescripcion);
            this.Controls.Add(this.txtCantidadPredicados);
            this.Controls.Add(this.ctrlTxtNombre);
            this.Name = "PanelPreviewEstrategia";
            this.Size = new System.Drawing.Size(532, 137);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctrlTxtNombre;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadPredicados;
        private System.Windows.Forms.Label label2;


    }
}