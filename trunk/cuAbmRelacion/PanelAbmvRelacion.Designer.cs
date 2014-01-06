using scioThirdPartLibrary;

namespace cuAbmRelacion
{
    partial class PanelAbmvRelacion
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
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.ctrlTxtComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.fechaUMod = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnVerOrigen = new System.Windows.Forms.Button();
            this.ctrlFindOrigen = new System.Windows.Forms.Button();
            this.btnVerDestino = new System.Windows.Forms.Button();
            this.ctrlFindDestino = new System.Windows.Forms.Button();
            this.ctrlTxtComboTipo = new ReadOnlyComboBox();
            this.SuspendLayout();
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(115, 69);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(333, 20);
            this.txtDestino.TabIndex = 5;
            // 
            // ctrlTxtComentario
            // 
            this.ctrlTxtComentario.Location = new System.Drawing.Point(115, 98);
            this.ctrlTxtComentario.Multiline = true;
            this.ctrlTxtComentario.Name = "ctrlTxtComentario";
            this.ctrlTxtComentario.ReadOnly = true;
            this.ctrlTxtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtComentario.Size = new System.Drawing.Size(402, 60);
            this.ctrlTxtComentario.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de Relación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Persona Relacionada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Comentarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Persona Origen";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(115, 41);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(333, 20);
            this.txtOrigen.TabIndex = 2;
            // 
            // fechaUMod
            // 
            this.fechaUMod.Location = new System.Drawing.Point(370, 13);
            this.fechaUMod.Name = "fechaUMod";
            this.fechaUMod.ReadOnly = true;
            this.fechaUMod.Size = new System.Drawing.Size(147, 20);
            this.fechaUMod.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(295, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Fecha de Act.";
            // 
            // btnVerOrigen
            // 
            this.btnVerOrigen.Image = global::cuAbmRelacion.Properties.Resources.persona2;
            this.btnVerOrigen.Location = new System.Drawing.Point(491, 39);
            this.btnVerOrigen.Name = "btnVerOrigen";
            this.btnVerOrigen.Size = new System.Drawing.Size(26, 23);
            this.btnVerOrigen.TabIndex = 4;
            this.btnVerOrigen.UseVisualStyleBackColor = true;
            this.btnVerOrigen.Click += new System.EventHandler(this.btnVerOrigen_Click);
            // 
            // ctrlFindOrigen
            // 
            this.ctrlFindOrigen.Image = global::cuAbmRelacion.Properties.Resources.seleccionar;
            this.ctrlFindOrigen.Location = new System.Drawing.Point(459, 39);
            this.ctrlFindOrigen.Name = "ctrlFindOrigen";
            this.ctrlFindOrigen.Size = new System.Drawing.Size(26, 23);
            this.ctrlFindOrigen.TabIndex = 3;
            this.ctrlFindOrigen.UseVisualStyleBackColor = true;
            this.ctrlFindOrigen.Click += new System.EventHandler(this.ctrlFindOrigen_Click);
            // 
            // btnVerDestino
            // 
            this.btnVerDestino.Image = global::cuAbmRelacion.Properties.Resources.persona2;
            this.btnVerDestino.Location = new System.Drawing.Point(491, 67);
            this.btnVerDestino.Name = "btnVerDestino";
            this.btnVerDestino.Size = new System.Drawing.Size(26, 23);
            this.btnVerDestino.TabIndex = 7;
            this.btnVerDestino.UseVisualStyleBackColor = true;
            this.btnVerDestino.Click += new System.EventHandler(this.ctrlVerDestino_Click);
            // 
            // ctrlFindDestino
            // 
            this.ctrlFindDestino.Image = global::cuAbmRelacion.Properties.Resources.seleccionar;
            this.ctrlFindDestino.Location = new System.Drawing.Point(459, 67);
            this.ctrlFindDestino.Name = "ctrlFindDestino";
            this.ctrlFindDestino.Size = new System.Drawing.Size(26, 23);
            this.ctrlFindDestino.TabIndex = 6;
            this.ctrlFindDestino.UseVisualStyleBackColor = true;
            this.ctrlFindDestino.Click += new System.EventHandler(this.ctrlFindDestino_Click);
            // 
            // ctrlTxtComboTipo
            // 
            this.ctrlTxtComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtComboTipo.FormattingEnabled = true;
            this.ctrlTxtComboTipo.Location = new System.Drawing.Point(115, 12);
            this.ctrlTxtComboTipo.Name = "ctrlTxtComboTipo";
            this.ctrlTxtComboTipo.Size = new System.Drawing.Size(174, 21);
            this.ctrlTxtComboTipo.TabIndex = 0;
            // 
            // PanelAbmvRelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.ctrlTxtComboTipo);
            this.Controls.Add(this.fechaUMod);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnVerOrigen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlFindOrigen);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.btnVerDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlFindDestino);
            this.Controls.Add(this.ctrlTxtComentario);
            this.Controls.Add(this.txtDestino);
            this.Name = "PanelAbmvRelacion";
            this.Size = new System.Drawing.Size(530, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctrlTxtComentario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button ctrlFindDestino;
        private System.Windows.Forms.Button btnVerDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Button ctrlFindOrigen;
        private System.Windows.Forms.Button btnVerOrigen;
        private System.Windows.Forms.TextBox fechaUMod;
        private System.Windows.Forms.Label label14;
        private ReadOnlyComboBox ctrlTxtComboTipo;
    }
}
