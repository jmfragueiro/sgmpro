using scioThirdPartLibrary;

namespace cuAbmPersona
{
    partial class PanelAbmvPersona
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
            this.ctrlTxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlTxtDNI = new System.Windows.Forms.TextBox();
            this.ctrlTxtCuit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlTxtComentario = new System.Windows.Forms.TextBox();
            this.ctrlTxtTrabajo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCuentas = new System.Windows.Forms.TabPage();
            this.tabGestiones = new System.Windows.Forms.TabPage();
            this.tabContactos = new System.Windows.Forms.TabPage();
            this.tabRelaciones = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaUMod = new System.Windows.Forms.TextBox();
            this.ctrlTxtComboSexo = new ReadOnlyComboBox();
            this.ctrlTxtTipoIVA = new ReadOnlyComboBox();
            this.ctrlTxtEstadoCivil = new ReadOnlyComboBox();
            this.ctrlTxtEstadoEconomico = new ReadOnlyComboBox();
            this.txtTotalPagado = new System.Windows.Forms.TextBox();
            this.txtMaxDiasDeudor = new System.Windows.Forms.TextBox();
            this.txtUltGestion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSaldoTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grpGestion = new System.Windows.Forms.GroupBox();
            this.convenio = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPagadoHonor = new System.Windows.Forms.TextBox();
            this.ctrlTxtProfesion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.grpGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlTxtNombre
            // 
            this.ctrlTxtNombre.Location = new System.Drawing.Point(107, 14);
            this.ctrlTxtNombre.Name = "ctrlTxtNombre";
            this.ctrlTxtNombre.ReadOnly = true;
            this.ctrlTxtNombre.Size = new System.Drawing.Size(601, 20);
            this.ctrlTxtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre (Razón)";
            // 
            // ctrlTxtDNI
            // 
            this.ctrlTxtDNI.Location = new System.Drawing.Point(259, 39);
            this.ctrlTxtDNI.Name = "ctrlTxtDNI";
            this.ctrlTxtDNI.ReadOnly = true;
            this.ctrlTxtDNI.Size = new System.Drawing.Size(103, 20);
            this.ctrlTxtDNI.TabIndex = 2;
            // 
            // ctrlTxtCuit
            // 
            this.ctrlTxtCuit.Location = new System.Drawing.Point(107, 40);
            this.ctrlTxtCuit.Name = "ctrlTxtCuit";
            this.ctrlTxtCuit.ReadOnly = true;
            this.ctrlTxtCuit.Size = new System.Drawing.Size(107, 20);
            this.ctrlTxtCuit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "CUIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo IVA";
            // 
            // ctrlTxtComentario
            // 
            this.ctrlTxtComentario.Location = new System.Drawing.Point(443, 120);
            this.ctrlTxtComentario.Multiline = true;
            this.ctrlTxtComentario.Name = "ctrlTxtComentario";
            this.ctrlTxtComentario.ReadOnly = true;
            this.ctrlTxtComentario.Size = new System.Drawing.Size(541, 21);
            this.ctrlTxtComentario.TabIndex = 9;
            // 
            // ctrlTxtTrabajo
            // 
            this.ctrlTxtTrabajo.Location = new System.Drawing.Point(443, 94);
            this.ctrlTxtTrabajo.Name = "ctrlTxtTrabajo";
            this.ctrlTxtTrabajo.ReadOnly = true;
            this.ctrlTxtTrabajo.Size = new System.Drawing.Size(541, 20);
            this.ctrlTxtTrabajo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Estado Civil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Comentario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Trabajo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Estado Económico";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCuentas);
            this.tabControl.Controls.Add(this.tabGestiones);
            this.tabControl.Controls.Add(this.tabContactos);
            this.tabControl.Controls.Add(this.tabRelaciones);
            this.tabControl.Location = new System.Drawing.Point(6, 227);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(991, 346);
            this.tabControl.TabIndex = 11;
            // 
            // tabCuentas
            // 
            this.tabCuentas.Location = new System.Drawing.Point(4, 22);
            this.tabCuentas.Name = "tabCuentas";
            this.tabCuentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuentas.Size = new System.Drawing.Size(983, 320);
            this.tabCuentas.TabIndex = 2;
            this.tabCuentas.Text = "Cuentas";
            this.tabCuentas.UseVisualStyleBackColor = true;
            // 
            // tabGestiones
            // 
            this.tabGestiones.Location = new System.Drawing.Point(4, 22);
            this.tabGestiones.Name = "tabGestiones";
            this.tabGestiones.Size = new System.Drawing.Size(876, 242);
            this.tabGestiones.TabIndex = 3;
            this.tabGestiones.Text = "Gestiones";
            this.tabGestiones.UseVisualStyleBackColor = true;
            // 
            // tabContactos
            // 
            this.tabContactos.Location = new System.Drawing.Point(4, 22);
            this.tabContactos.Name = "tabContactos";
            this.tabContactos.Padding = new System.Windows.Forms.Padding(3);
            this.tabContactos.Size = new System.Drawing.Size(876, 242);
            this.tabContactos.TabIndex = 0;
            this.tabContactos.Text = "Contactos";
            this.tabContactos.UseVisualStyleBackColor = true;
            // 
            // tabRelaciones
            // 
            this.tabRelaciones.Location = new System.Drawing.Point(4, 22);
            this.tabRelaciones.Name = "tabRelaciones";
            this.tabRelaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelaciones.Size = new System.Drawing.Size(876, 242);
            this.tabRelaciones.TabIndex = 1;
            this.tabRelaciones.Text = "Relaciones";
            this.tabRelaciones.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sexo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(725, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fecha de Act.";
            // 
            // txtFechaUMod
            // 
            this.txtFechaUMod.Location = new System.Drawing.Point(803, 14);
            this.txtFechaUMod.Name = "txtFechaUMod";
            this.txtFechaUMod.ReadOnly = true;
            this.txtFechaUMod.Size = new System.Drawing.Size(181, 20);
            this.txtFechaUMod.TabIndex = 9;
            this.txtFechaUMod.TabStop = false;
            // 
            // ctrlTxtComboSexo
            // 
            this.ctrlTxtComboSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctrlTxtComboSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctrlTxtComboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtComboSexo.FormattingEnabled = true;
            this.ctrlTxtComboSexo.Location = new System.Drawing.Point(443, 67);
            this.ctrlTxtComboSexo.Name = "ctrlTxtComboSexo";
            this.ctrlTxtComboSexo.Size = new System.Drawing.Size(184, 21);
            this.ctrlTxtComboSexo.TabIndex = 4;
            // 
            // ctrlTxtTipoIVA
            // 
            this.ctrlTxtTipoIVA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctrlTxtTipoIVA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctrlTxtTipoIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtTipoIVA.FormattingEnabled = true;
            this.ctrlTxtTipoIVA.Location = new System.Drawing.Point(706, 66);
            this.ctrlTxtTipoIVA.Name = "ctrlTxtTipoIVA";
            this.ctrlTxtTipoIVA.Size = new System.Drawing.Size(278, 21);
            this.ctrlTxtTipoIVA.TabIndex = 5;
            // 
            // ctrlTxtEstadoCivil
            // 
            this.ctrlTxtEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctrlTxtEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctrlTxtEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtEstadoCivil.FormattingEnabled = true;
            this.ctrlTxtEstadoCivil.Location = new System.Drawing.Point(107, 67);
            this.ctrlTxtEstadoCivil.Name = "ctrlTxtEstadoCivil";
            this.ctrlTxtEstadoCivil.Size = new System.Drawing.Size(255, 21);
            this.ctrlTxtEstadoCivil.TabIndex = 3;
            // 
            // ctrlTxtEstadoEconomico
            // 
            this.ctrlTxtEstadoEconomico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctrlTxtEstadoEconomico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctrlTxtEstadoEconomico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrlTxtEstadoEconomico.FormattingEnabled = true;
            this.ctrlTxtEstadoEconomico.Location = new System.Drawing.Point(107, 120);
            this.ctrlTxtEstadoEconomico.Name = "ctrlTxtEstadoEconomico";
            this.ctrlTxtEstadoEconomico.Size = new System.Drawing.Size(255, 21);
            this.ctrlTxtEstadoEconomico.TabIndex = 8;
            // 
            // txtTotalPagado
            // 
            this.txtTotalPagado.Location = new System.Drawing.Point(121, 38);
            this.txtTotalPagado.Name = "txtTotalPagado";
            this.txtTotalPagado.ReadOnly = true;
            this.txtTotalPagado.Size = new System.Drawing.Size(83, 20);
            this.txtTotalPagado.TabIndex = 1;
            this.txtTotalPagado.TabStop = false;
            this.txtTotalPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaxDiasDeudor
            // 
            this.txtMaxDiasDeudor.Location = new System.Drawing.Point(299, 38);
            this.txtMaxDiasDeudor.Name = "txtMaxDiasDeudor";
            this.txtMaxDiasDeudor.ReadOnly = true;
            this.txtMaxDiasDeudor.Size = new System.Drawing.Size(100, 20);
            this.txtMaxDiasDeudor.TabIndex = 2;
            this.txtMaxDiasDeudor.TabStop = false;
            this.txtMaxDiasDeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUltGestion
            // 
            this.txtUltGestion.Location = new System.Drawing.Point(405, 38);
            this.txtUltGestion.Name = "txtUltGestion";
            this.txtUltGestion.ReadOnly = true;
            this.txtUltGestion.Size = new System.Drawing.Size(82, 20);
            this.txtUltGestion.TabIndex = 3;
            this.txtUltGestion.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Ultima Gestión";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(127, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Total Pagado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(304, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Máx. días deudor";
            // 
            // txtSaldoTotal
            // 
            this.txtSaldoTotal.Location = new System.Drawing.Point(15, 38);
            this.txtSaldoTotal.Name = "txtSaldoTotal";
            this.txtSaldoTotal.ReadOnly = true;
            this.txtSaldoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoTotal.TabIndex = 0;
            this.txtSaldoTotal.TabStop = false;
            this.txtSaldoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Saldo Total Actual";
            // 
            // grpGestion
            // 
            this.grpGestion.Controls.Add(this.convenio);
            this.grpGestion.Controls.Add(this.label14);
            this.grpGestion.Controls.Add(this.txtSaldoTotal);
            this.grpGestion.Controls.Add(this.label13);
            this.grpGestion.Controls.Add(this.label16);
            this.grpGestion.Controls.Add(this.label12);
            this.grpGestion.Controls.Add(this.label11);
            this.grpGestion.Controls.Add(this.txtUltGestion);
            this.grpGestion.Controls.Add(this.txtMaxDiasDeudor);
            this.grpGestion.Controls.Add(this.txtPagadoHonor);
            this.grpGestion.Controls.Add(this.txtTotalPagado);
            this.grpGestion.Location = new System.Drawing.Point(214, 156);
            this.grpGestion.Name = "grpGestion";
            this.grpGestion.Size = new System.Drawing.Size(585, 65);
            this.grpGestion.TabIndex = 10;
            this.grpGestion.TabStop = false;
            this.grpGestion.Text = "Datos de Gestión";
            // 
            // convenio
            // 
            this.convenio.AutoSize = true;
            this.convenio.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.convenio.Enabled = false;
            this.convenio.Location = new System.Drawing.Point(489, 21);
            this.convenio.Name = "convenio";
            this.convenio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.convenio.Size = new System.Drawing.Size(89, 31);
            this.convenio.TabIndex = 4;
            this.convenio.TabStop = false;
            this.convenio.Text = "Convenio Activo";
            this.convenio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.convenio.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(212, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Pagado Honor.";
            // 
            // txtPagadoHonor
            // 
            this.txtPagadoHonor.Location = new System.Drawing.Point(210, 38);
            this.txtPagadoHonor.Name = "txtPagadoHonor";
            this.txtPagadoHonor.ReadOnly = true;
            this.txtPagadoHonor.Size = new System.Drawing.Size(83, 20);
            this.txtPagadoHonor.TabIndex = 1;
            this.txtPagadoHonor.TabStop = false;
            this.txtPagadoHonor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ctrlTxtProfesion
            // 
            this.ctrlTxtProfesion.Location = new System.Drawing.Point(106, 94);
            this.ctrlTxtProfesion.Name = "ctrlTxtProfesion";
            this.ctrlTxtProfesion.ReadOnly = true;
            this.ctrlTxtProfesion.Size = new System.Drawing.Size(256, 20);
            this.ctrlTxtProfesion.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(51, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Profesion";
            // 
            // PanelGUIPersona
            // 
            this.Controls.Add(this.ctrlTxtEstadoEconomico);
            this.Controls.Add(this.ctrlTxtEstadoCivil);
            this.Controls.Add(this.ctrlTxtTipoIVA);
            this.Controls.Add(this.ctrlTxtComboSexo);
            this.Controls.Add(this.grpGestion);
            this.Controls.Add(this.txtFechaUMod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctrlTxtProfesion);
            this.Controls.Add(this.ctrlTxtTrabajo);
            this.Controls.Add(this.ctrlTxtComentario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlTxtCuit);
            this.Controls.Add(this.ctrlTxtDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlTxtNombre);
            this.Name = "PanelGUIPersona";
            this.Size = new System.Drawing.Size(1000, 576);
            this.tabControl.ResumeLayout(false);
            this.grpGestion.ResumeLayout(false);
            this.grpGestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctrlTxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctrlTxtDNI;
        private System.Windows.Forms.TextBox ctrlTxtCuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctrlTxtComentario;
        private System.Windows.Forms.TextBox ctrlTxtTrabajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabContactos;
        private System.Windows.Forms.TabPage tabRelaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFechaUMod;
        private System.Windows.Forms.TabPage tabCuentas;
        private System.Windows.Forms.TabPage tabGestiones;
        private ReadOnlyComboBox ctrlTxtComboSexo;
        private ReadOnlyComboBox ctrlTxtTipoIVA;
        private ReadOnlyComboBox ctrlTxtEstadoCivil;
        private ReadOnlyComboBox ctrlTxtEstadoEconomico;
        private System.Windows.Forms.TextBox txtTotalPagado;
        private System.Windows.Forms.TextBox txtMaxDiasDeudor;
        private System.Windows.Forms.TextBox txtUltGestion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSaldoTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grpGestion;
        private System.Windows.Forms.CheckBox convenio;
        private System.Windows.Forms.TextBox ctrlTxtProfesion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPagadoHonor;
    }
}
