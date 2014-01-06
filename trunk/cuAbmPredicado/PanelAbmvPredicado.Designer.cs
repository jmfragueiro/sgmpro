using System.Windows.Forms;
using scioThirdPartLibrary;

namespace cuAbmPredicado
{
    partial class PanelAbmvPredicado
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
            this.ctrlTxtNroOrden = new System.Windows.Forms.MaskedTextBox();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.grpDatosPredicado = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Selector = new System.Windows.Forms.Label();
            this.cmbConector = new scioThirdPartLibrary.ReadOnlyComboBox();
            this.cmbVariable = new scioThirdPartLibrary.ReadOnlyComboBox();
            this.cmbCriterio = new scioThirdPartLibrary.ReadOnlyComboBox();
            this.cmbVocablo = new scioThirdPartLibrary.ReadOnlyComboBox();
            this.cmbSelector = new scioThirdPartLibrary.ReadOnlyComboBox();
            this.ctrlRdbVariable = new System.Windows.Forms.RadioButton();
            this.ctrlRdbValor = new System.Windows.Forms.RadioButton();
            this.ctrlTxtValor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescVocablo = new System.Windows.Forms.TextBox();
            this.grpDatosPredicado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.ctrlTxtNroOrden.Location = new System.Drawing.Point(124, 17);
            this.ctrlTxtNroOrden.Mask = "9";
            this.ctrlTxtNroOrden.Name = "ctrlTxtNroOrden";
            this.ctrlTxtNroOrden.Size = new System.Drawing.Size(20, 20);
            this.ctrlTxtNroOrden.TabIndex = 95;
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ctrlTxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(124, 43);
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
            this.grpDatosPredicado.Size = new System.Drawing.Size(642, 93);
            this.grpDatosPredicado.TabIndex = 112;
            this.grpDatosPredicado.TabStop = false;
            this.grpDatosPredicado.Text = "Datos del Predicado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Conector";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 121;
            this.label4.Text = "Valor / Variable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Criterio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Vocablo";
            // 
            // Selector
            // 
            this.Selector.AutoSize = true;
            this.Selector.Location = new System.Drawing.Point(7, 24);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(46, 13);
            this.Selector.TabIndex = 121;
            this.Selector.Text = "Selector";
            // 
            // cmbConector
            // 
            this.cmbConector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConector.FormattingEnabled = true;
            this.cmbConector.Location = new System.Drawing.Point(578, 43);
            this.cmbConector.Name = "cmbConector";
            this.cmbConector.Size = new System.Drawing.Size(58, 21);
            this.cmbConector.TabIndex = 117;
            // 
            // cmbVariable
            // 
            this.cmbVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariable.FormattingEnabled = true;
            this.cmbVariable.Location = new System.Drawing.Point(392, 43);
            this.cmbVariable.Name = "cmbVariable";
            this.cmbVariable.Size = new System.Drawing.Size(183, 21);
            this.cmbVariable.TabIndex = 116;
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Location = new System.Drawing.Point(338, 43);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(52, 21);
            this.cmbCriterio.TabIndex = 115;
            // 
            // cmbVocablo
            // 
            this.cmbVocablo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVocablo.FormattingEnabled = true;
            this.cmbVocablo.Location = new System.Drawing.Point(60, 43);
            this.cmbVocablo.Name = "cmbVocablo";
            this.cmbVocablo.Size = new System.Drawing.Size(276, 21);
            this.cmbVocablo.TabIndex = 112;
            this.cmbVocablo.SelectedIndexChanged += new System.EventHandler(this.cmbVocablo_SelectedIndexChanged);
            // 
            // cmbSelector
            // 
            this.cmbSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelector.FormattingEnabled = true;
            this.cmbSelector.Location = new System.Drawing.Point(7, 43);
            this.cmbSelector.Name = "cmbSelector";
            this.cmbSelector.Size = new System.Drawing.Size(52, 21);
            this.cmbSelector.TabIndex = 110;
            // 
            // ctrlRdbVariable
            // 
            this.ctrlRdbVariable.AutoSize = true;
            this.ctrlRdbVariable.Location = new System.Drawing.Point(449, 67);
            this.ctrlRdbVariable.Name = "ctrlRdbVariable";
            this.ctrlRdbVariable.Size = new System.Drawing.Size(63, 17);
            this.ctrlRdbVariable.TabIndex = 120;
            this.ctrlRdbVariable.TabStop = true;
            this.ctrlRdbVariable.Text = "Variable";
            this.ctrlRdbVariable.UseVisualStyleBackColor = true;
            this.ctrlRdbVariable.CheckedChanged += new System.EventHandler(this.ctrlRdbVariable_CheckedChanged);
            // 
            // ctrlRdbValor
            // 
            this.ctrlRdbValor.AutoSize = true;
            this.ctrlRdbValor.Location = new System.Drawing.Point(394, 67);
            this.ctrlRdbValor.Name = "ctrlRdbValor";
            this.ctrlRdbValor.Size = new System.Drawing.Size(49, 17);
            this.ctrlRdbValor.TabIndex = 118;
            this.ctrlRdbValor.TabStop = true;
            this.ctrlRdbValor.Text = "Valor";
            this.ctrlRdbValor.UseVisualStyleBackColor = true;
            this.ctrlRdbValor.CheckedChanged += new System.EventHandler(this.ctrlRdbValor_CheckedChanged);
            // 
            // ctrlTxtValor
            // 
            this.ctrlTxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtValor.Location = new System.Drawing.Point(393, 43);
            this.ctrlTxtValor.Name = "ctrlTxtValor";
            this.ctrlTxtValor.Size = new System.Drawing.Size(183, 20);
            this.ctrlTxtValor.TabIndex = 119;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(648, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 239);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variables del Sistema";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 124;
            this.label9.Text = "$$_MANA_$$ = Fecha Act.+1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 123;
            this.label8.Text = "$$_AYER_$$ = Fecha Act.-1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 122;
            this.label3.Text = "$$_HOY_$$ = Fecha Actual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescVocablo);
            this.groupBox2.Location = new System.Drawing.Point(4, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 67);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción del Vocablo Seleccionado";
            // 
            // txtDescVocablo
            // 
            this.txtDescVocablo.Location = new System.Drawing.Point(10, 20);
            this.txtDescVocablo.Multiline = true;
            this.txtDescVocablo.Name = "txtDescVocablo";
            this.txtDescVocablo.ReadOnly = true;
            this.txtDescVocablo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescVocablo.Size = new System.Drawing.Size(626, 41);
            this.txtDescVocablo.TabIndex = 0;
            this.txtDescVocablo.TabStop = false;
            this.txtDescVocablo.Text = "Seleccione un Vocablo para ver su descripción...";
            // 
            // PanelGUIPredicado
            // 
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctrlTxtNroOrden);
            this.Controls.Add(this.ctrlTxtDescripcion);
            this.Controls.Add(this.grpDatosPredicado);
            this.Name = "PanelGUIPredicado";
            this.Size = new System.Drawing.Size(799, 245);
            this.grpDatosPredicado.ResumeLayout(false);
            this.grpDatosPredicado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
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
        private MaskedTextBox ctrlTxtNroOrden;
        private GroupBox groupBox1;
        private Label label3;
        private Label label8;
        private Label label9;
        private GroupBox groupBox2;
        private TextBox txtDescVocablo;
    }
}