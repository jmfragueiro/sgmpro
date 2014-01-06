using System.Windows.Forms;
using scioThirdPartLibrary;

namespace cuAbmTipoLista
{
    partial class PanelAbmvTipoLista
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabEstrategias = new System.Windows.Forms.TabPage();
            this.tabEntidades = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ctrlTxtCmbTipoGestion = new scioThirdPartLibrary.ReadOnlyComboBox();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.ctrlTxtNombre = new System.Windows.Forms.TextBox();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlTxtMaxCuentas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlChkVerFE = new System.Windows.Forms.CheckBox();
            this.ctrlChkVerPendientes = new System.Windows.Forms.CheckBox();
            this.grpVerificar = new System.Windows.Forms.GroupBox();
            this.ctrlChkCancelacion = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctrlTxtPrioridad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaAlta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.ctrlFindPerfil = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.grpVerificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightYellow;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(142, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(373, 20);
            this.textBox3.TabIndex = 88;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Descripción";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightYellow;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(11, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 87;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Nombre";
            // 
            // tabEstrategias
            // 
            this.tabEstrategias.Location = new System.Drawing.Point(4, 22);
            this.tabEstrategias.Name = "tabEstrategias";
            this.tabEstrategias.Size = new System.Drawing.Size(661, 189);
            this.tabEstrategias.TabIndex = 3;
            this.tabEstrategias.Text = "Estrategias";
            this.tabEstrategias.UseVisualStyleBackColor = true;
            // 
            // tabEntidades
            // 
            this.tabEntidades.Location = new System.Drawing.Point(4, 22);
            this.tabEntidades.Name = "tabEntidades";
            this.tabEntidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntidades.Size = new System.Drawing.Size(661, 189);
            this.tabEntidades.TabIndex = 2;
            this.tabEntidades.Text = "Entidades";
            this.tabEntidades.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEntidades);
            this.tabControl.Controls.Add(this.tabEstrategias);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Location = new System.Drawing.Point(0, 227);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(669, 215);
            this.tabControl.TabIndex = 8;
            // 
            // ctrlTxtCmbTipoGestion
            // 
            this.ctrlTxtCmbTipoGestion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctrlTxtCmbTipoGestion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctrlTxtCmbTipoGestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtCmbTipoGestion.FormattingEnabled = true;
            this.ctrlTxtCmbTipoGestion.Location = new System.Drawing.Point(141, 85);
            this.ctrlTxtCmbTipoGestion.Name = "ctrlTxtCmbTipoGestion";
            this.ctrlTxtCmbTipoGestion.Size = new System.Drawing.Size(178, 21);
            this.ctrlTxtCmbTipoGestion.TabIndex = 2;
            // 
            // txtPerfil
            // 
            this.txtPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfil.Location = new System.Drawing.Point(424, 85);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.ReadOnly = true;
            this.txtPerfil.Size = new System.Drawing.Size(183, 20);
            this.txtPerfil.TabIndex = 9;
            // 
            // ctrlTxtNombre
            // 
            this.ctrlTxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtNombre.Location = new System.Drawing.Point(141, 13);
            this.ctrlTxtNombre.Name = "ctrlTxtNombre";
            this.ctrlTxtNombre.Size = new System.Drawing.Size(524, 20);
            this.ctrlTxtNombre.TabIndex = 0;
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(141, 38);
            this.ctrlTxtDescripcion.Multiline = true;
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(524, 41);
            this.ctrlTxtDescripcion.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Crear para el Perfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Tipo de Gestión a Generar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nombre";
            // 
            // ctrlTxtMaxCuentas
            // 
            this.ctrlTxtMaxCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtMaxCuentas.Location = new System.Drawing.Point(611, 112);
            this.ctrlTxtMaxCuentas.Name = "ctrlTxtMaxCuentas";
            this.ctrlTxtMaxCuentas.Size = new System.Drawing.Size(54, 20);
            this.ctrlTxtMaxCuentas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Máx. cantidad de Cuentas a incluir en la Lista generada";
            // 
            // ctrlChkVerFE
            // 
            this.ctrlChkVerFE.AutoSize = true;
            this.ctrlChkVerFE.Location = new System.Drawing.Point(10, 22);
            this.ctrlChkVerFE.Name = "ctrlChkVerFE";
            this.ctrlChkVerFE.Size = new System.Drawing.Size(127, 17);
            this.ctrlChkVerFE.TabIndex = 0;
            this.ctrlChkVerFE.Text = "Fecha de Elegibilidad";
            this.ctrlChkVerFE.UseVisualStyleBackColor = true;
            // 
            // ctrlChkVerPendientes
            // 
            this.ctrlChkVerPendientes.AutoSize = true;
            this.ctrlChkVerPendientes.Location = new System.Drawing.Point(146, 22);
            this.ctrlChkVerPendientes.Name = "ctrlChkVerPendientes";
            this.ctrlChkVerPendientes.Size = new System.Drawing.Size(129, 17);
            this.ctrlChkVerPendientes.TabIndex = 1;
            this.ctrlChkVerPendientes.Text = "Gestiones Pendientes";
            this.ctrlChkVerPendientes.UseVisualStyleBackColor = true;
            // 
            // grpVerificar
            // 
            this.grpVerificar.Controls.Add(this.ctrlChkCancelacion);
            this.grpVerificar.Controls.Add(this.label8);
            this.grpVerificar.Controls.Add(this.ctrlChkVerFE);
            this.grpVerificar.Controls.Add(this.ctrlChkVerPendientes);
            this.grpVerificar.Location = new System.Drawing.Point(5, 145);
            this.grpVerificar.Name = "grpVerificar";
            this.grpVerificar.Size = new System.Drawing.Size(660, 50);
            this.grpVerificar.TabIndex = 7;
            this.grpVerificar.TabStop = false;
            this.grpVerificar.Text = "Verificar para cada Cuenta antes de incluirla al Generar Lista";
            // 
            // ctrlChkCancelacion
            // 
            this.ctrlChkCancelacion.AutoSize = true;
            this.ctrlChkCancelacion.Location = new System.Drawing.Point(285, 22);
            this.ctrlChkCancelacion.Name = "ctrlChkCancelacion";
            this.ctrlChkCancelacion.Size = new System.Drawing.Size(201, 17);
            this.ctrlChkCancelacion.TabIndex = 2;
            this.ctrlChkCancelacion.Text = "Posee Estado de Cuenta Controlado ";
            this.ctrlChkCancelacion.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "(aquéllos con ValorBool=true)";
            // 
            // ctrlTxtPrioridad
            // 
            this.ctrlTxtPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtPrioridad.Location = new System.Drawing.Point(141, 112);
            this.ctrlTxtPrioridad.Name = "ctrlTxtPrioridad";
            this.ctrlTxtPrioridad.Size = new System.Drawing.Size(36, 20);
            this.ctrlTxtPrioridad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Prioridad para Gestión";
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaAlta.Location = new System.Drawing.Point(141, 201);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.ReadOnly = true;
            this.txtFechaAlta.Size = new System.Drawing.Size(178, 20);
            this.txtFechaAlta.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Fecha Ultima Modificación";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Image = global::cuAbmTipoLista.Properties.Resources.perfil;
            this.btnVerPerfil.Location = new System.Drawing.Point(639, 83);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(26, 23);
            this.btnVerPerfil.TabIndex = 4;
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // ctrlFindPerfil
            // 
            this.ctrlFindPerfil.Image = global::cuAbmTipoLista.Properties.Resources.seleccionar;
            this.ctrlFindPerfil.Location = new System.Drawing.Point(611, 83);
            this.ctrlFindPerfil.Name = "ctrlFindPerfil";
            this.ctrlFindPerfil.Size = new System.Drawing.Size(26, 23);
            this.ctrlFindPerfil.TabIndex = 3;
            this.ctrlFindPerfil.UseVisualStyleBackColor = true;
            this.ctrlFindPerfil.Click += new System.EventHandler(this.ctrlFindPerfil_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpVerificar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlTxtCmbTipoGestion);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.ctrlFindPerfil);
            this.Controls.Add(this.txtFechaAlta);
            this.Controls.Add(this.txtPerfil);
            this.Controls.Add(this.ctrlTxtPrioridad);
            this.Controls.Add(this.ctrlTxtMaxCuentas);
            this.Controls.Add(this.ctrlTxtNombre);
            this.Controls.Add(this.ctrlTxtDescripcion);
            this.Controls.Add(this.tabControl);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(669, 442);
            this.tabControl.ResumeLayout(false);
            this.grpVerificar.ResumeLayout(false);
            this.grpVerificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabEstrategias;
        private System.Windows.Forms.TabPage tabEntidades;
        private System.Windows.Forms.TabControl tabControl;
        private ReadOnlyComboBox ctrlTxtCmbTipoGestion;
        private System.Windows.Forms.Button btnVerPerfil;
        private System.Windows.Forms.Button ctrlFindPerfil;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.TextBox ctrlTxtNombre;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctrlTxtMaxCuentas;
        private System.Windows.Forms.Label label3;
        private CheckBox ctrlChkVerFE;
        private CheckBox ctrlChkVerPendientes;
        private GroupBox grpVerificar;
        private CheckBox ctrlChkCancelacion;
        private TextBox ctrlTxtPrioridad;
        private Label label6;
        private TextBox txtFechaAlta;
        private Label label7;
        private Label label8;
    }
}
