using scioThirdPartLibrary;

namespace cuAbmPredicado
{
    partial class PanelPreviewPredicado
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ctrlTxtNroOrden = new System.Windows.Forms.TextBox();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.grpDatosPredicado = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Selector = new System.Windows.Forms.Label();
            this.cmbConector = new ReadOnlyComboBox();
            this.cmbVariable = new ReadOnlyComboBox();
            this.cmbCriterio = new ReadOnlyComboBox();
            this.cmbVocablo = new ReadOnlyComboBox();
            this.cmbSelector = new ReadOnlyComboBox();
            this.ctrlRdbVariable = new System.Windows.Forms.RadioButton();
            this.ctrlRdbValor = new System.Windows.Forms.RadioButton();
            this.ctrlTxtValor = new System.Windows.Forms.TextBox();
            this.grpDatosPredicado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 111;
            this.label7.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Número de Orden";
            // 
            // ctrlTxtNroOrden
            // 
            this.ctrlTxtNroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtNroOrden.Location = new System.Drawing.Point(121, 17);
            this.ctrlTxtNroOrden.Name = "ctrlTxtNroOrden";
            this.ctrlTxtNroOrden.Size = new System.Drawing.Size(129, 20);
            this.ctrlTxtNroOrden.TabIndex = 95;
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(120, 43);
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(399, 20);
            this.ctrlTxtDescripcion.TabIndex = 96;
            // 
            // grpDatosPredicado
            // 
            this.grpDatosPredicado.Controls.Add(this.label5);
            this.grpDatosPredicado.Controls.Add(this.label4);
            this.grpDatosPredicado.Controls.Add(this.label2);
            this.grpDatosPredicado.Controls.Add(this.label1);
            this.grpDatosPredicado.Controls.Add(this.Selector);
            this.grpDatosPredicado.Controls.Add(this.cmbConector);
            this.grpDatosPredicado.Controls.Add(this.cmbVariable);
            this.grpDatosPredicado.Controls.Add(this.cmbCriterio);
            this.grpDatosPredicado.Controls.Add(this.cmbVocablo);
            this.grpDatosPredicado.Controls.Add(this.cmbSelector);
            this.grpDatosPredicado.Controls.Add(this.ctrlRdbVariable);
            this.grpDatosPredicado.Controls.Add(this.ctrlRdbValor);
            this.grpDatosPredicado.Controls.Add(this.ctrlTxtValor);
            this.grpDatosPredicado.Location = new System.Drawing.Point(4, 76);
            this.grpDatosPredicado.Name = "grpDatosPredicado";
            this.grpDatosPredicado.Size = new System.Drawing.Size(567, 100);
            this.grpDatosPredicado.TabIndex = 112;
            this.grpDatosPredicado.TabStop = false;
            this.grpDatosPredicado.Text = "Datos del Predicado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Conector";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 121;
            this.label4.Text = "Valor / Variable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Criterio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Vocablo";
            // 
            // Selector
            // 
            this.Selector.AutoSize = true;
            this.Selector.Location = new System.Drawing.Point(12, 24);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(46, 13);
            this.Selector.TabIndex = 121;
            this.Selector.Text = "Selector";
            // 
            // cmbConector
            // 
            this.cmbConector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConector.FormattingEnabled = true;
            this.cmbConector.Location = new System.Drawing.Point(492, 43);
            this.cmbConector.Name = "cmbConector";
            this.cmbConector.Size = new System.Drawing.Size(58, 21);
            this.cmbConector.TabIndex = 117;
            // 
            // cmbVariable
            // 
            this.cmbVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariable.FormattingEnabled = true;
            this.cmbVariable.Location = new System.Drawing.Point(306, 43);
            this.cmbVariable.Name = "cmbVariable";
            this.cmbVariable.Size = new System.Drawing.Size(183, 21);
            this.cmbVariable.TabIndex = 116;
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Location = new System.Drawing.Point(251, 43);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(52, 21);
            this.cmbCriterio.TabIndex = 115;
            // 
            // cmbVocablo
            // 
            this.cmbVocablo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVocablo.FormattingEnabled = true;
            this.cmbVocablo.Location = new System.Drawing.Point(67, 43);
            this.cmbVocablo.Name = "cmbVocablo";
            this.cmbVocablo.Size = new System.Drawing.Size(181, 21);
            this.cmbVocablo.TabIndex = 112;
            // 
            // cmbSelector
            // 
            this.cmbSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelector.FormattingEnabled = true;
            this.cmbSelector.Location = new System.Drawing.Point(12, 43);
            this.cmbSelector.Name = "cmbSelector";
            this.cmbSelector.Size = new System.Drawing.Size(52, 21);
            this.cmbSelector.TabIndex = 110;
            // 
            // ctrlRdbVariable
            // 
            this.ctrlRdbVariable.AutoSize = true;
            this.ctrlRdbVariable.Location = new System.Drawing.Point(370, 70);
            this.ctrlRdbVariable.Name = "ctrlRdbVariable";
            this.ctrlRdbVariable.Size = new System.Drawing.Size(63, 17);
            this.ctrlRdbVariable.TabIndex = 120;
            this.ctrlRdbVariable.TabStop = true;
            this.ctrlRdbVariable.Text = "Variable";
            this.ctrlRdbVariable.UseVisualStyleBackColor = true;
            // 
            // ctrlRdbValor
            // 
            this.ctrlRdbValor.AutoSize = true;
            this.ctrlRdbValor.Location = new System.Drawing.Point(315, 70);
            this.ctrlRdbValor.Name = "ctrlRdbValor";
            this.ctrlRdbValor.Size = new System.Drawing.Size(49, 17);
            this.ctrlRdbValor.TabIndex = 118;
            this.ctrlRdbValor.TabStop = true;
            this.ctrlRdbValor.Text = "Valor";
            this.ctrlRdbValor.UseVisualStyleBackColor = true;
            // 
            // ctrlTxtValor
            // 
            this.ctrlTxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtValor.Location = new System.Drawing.Point(305, 43);
            this.ctrlTxtValor.Name = "ctrlTxtValor";
            this.ctrlTxtValor.Size = new System.Drawing.Size(183, 20);
            this.ctrlTxtValor.TabIndex = 119;
            // 
            // PanelAbmvPredicado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctrlTxtNroOrden);
            this.Controls.Add(this.ctrlTxtDescripcion);
            this.Controls.Add(this.grpDatosPredicado);
            this.Name = "PanelAbmvPredicado";
            this.Size = new System.Drawing.Size(576, 180);
            this.grpDatosPredicado.ResumeLayout(false);
            this.grpDatosPredicado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ctrlTxtNroOrden;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.GroupBox grpDatosPredicado;
        private System.Windows.Forms.TextBox ctrlTxtValor;
        private ReadOnlyComboBox cmbConector;
        private ReadOnlyComboBox cmbVariable;
        private ReadOnlyComboBox cmbCriterio;
        private ReadOnlyComboBox cmbVocablo;
        private ReadOnlyComboBox cmbSelector;
        private System.Windows.Forms.RadioButton ctrlRdbVariable;
        private System.Windows.Forms.RadioButton ctrlRdbValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Selector;
    }
}