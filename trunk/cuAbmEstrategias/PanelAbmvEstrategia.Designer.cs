using System.Windows.Forms;

namespace cuAbmEstrategia
{
    partial class PanelAbmvEstrategia
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
            this.ctrlGrpEstrategia = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlTxtNombre = new System.Windows.Forms.TextBox();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPredicados = new System.Windows.Forms.TabPage();
            this.ctrlGrpEstrategia.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlGrpEstrategia
            // 
            this.ctrlGrpEstrategia.Controls.Add(this.label3);
            this.ctrlGrpEstrategia.Controls.Add(this.label1);
            this.ctrlGrpEstrategia.Controls.Add(this.ctrlTxtNombre);
            this.ctrlGrpEstrategia.Controls.Add(this.ctrlTxtDescripcion);
            this.ctrlGrpEstrategia.Location = new System.Drawing.Point(4, 3);
            this.ctrlGrpEstrategia.Name = "ctrlGrpEstrategia";
            this.ctrlGrpEstrategia.Size = new System.Drawing.Size(859, 96);
            this.ctrlGrpEstrategia.TabIndex = 87;
            this.ctrlGrpEstrategia.TabStop = false;
            this.ctrlGrpEstrategia.Text = "Estrategia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Descripción";
            // 
            // ctrlTxtNombre
            // 
            this.ctrlTxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ctrlTxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtNombre.Location = new System.Drawing.Point(115, 21);
            this.ctrlTxtNombre.Name = "ctrlTxtNombre";
            this.ctrlTxtNombre.Size = new System.Drawing.Size(683, 20);
            this.ctrlTxtNombre.TabIndex = 70;
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ctrlTxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(115, 47);
            this.ctrlTxtDescripcion.Multiline = true;
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(683, 41);
            this.ctrlTxtDescripcion.TabIndex = 72;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPredicados);
            this.tabControl.Location = new System.Drawing.Point(3, 105);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(864, 236);
            this.tabControl.TabIndex = 88;
            // 
            // tabPredicados
            // 
            this.tabPredicados.Location = new System.Drawing.Point(4, 22);
            this.tabPredicados.Name = "tabPredicados";
            this.tabPredicados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPredicados.Size = new System.Drawing.Size(856, 210);
            this.tabPredicados.TabIndex = 0;
            this.tabPredicados.Text = "Predicados";
            this.tabPredicados.UseVisualStyleBackColor = true;
            // 
            // PanelGUIEstrategia
            // 
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ctrlGrpEstrategia);
            this.Name = "PanelAbmvEstrategia";
            this.Size = new System.Drawing.Size(870, 344);
            this.ctrlGrpEstrategia.ResumeLayout(false);
            this.ctrlGrpEstrategia.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox ctrlGrpEstrategia;
        private System.Windows.Forms.TextBox ctrlTxtNombre;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPredicados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}