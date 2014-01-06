namespace cuGenerarJobs
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
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlTxtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctrlChkActivo = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTipos = new System.Windows.Forms.TabPage();
            this.tabExes = new System.Windows.Forms.TabPage();
            this.grpFrecuencia = new System.Windows.Forms.GroupBox();
            this.grupoDiaHora = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ctrlTxtHoraEjec = new System.Windows.Forms.TextBox();
            this.ctrlTxtMinEjec = new System.Windows.Forms.TextBox();
            this.ctrlCmbInicio = new System.Windows.Forms.DateTimePicker();
            this.grupoDiasSemana = new System.Windows.Forms.GroupBox();
            this.pnlSemanal = new System.Windows.Forms.Panel();
            this.ctrlChkSabado = new System.Windows.Forms.CheckBox();
            this.ctrlChkLunes = new System.Windows.Forms.CheckBox();
            this.ctrlChkDomingo = new System.Windows.Forms.CheckBox();
            this.ctrlChkMartes = new System.Windows.Forms.CheckBox();
            this.ctrlChkJueves = new System.Windows.Forms.CheckBox();
            this.ctrlChkMiercoles = new System.Windows.Forms.CheckBox();
            this.ctrlChkViernes = new System.Windows.Forms.CheckBox();
            this.pnlMensual = new System.Windows.Forms.Panel();
            this.ctrlRdbPeriodoMensual = new System.Windows.Forms.RadioButton();
            this.ctrlRdbUltimoDiaMes = new System.Windows.Forms.RadioButton();
            this.ctrlRdbPrimerDiaMes = new System.Windows.Forms.RadioButton();
            this.pnlDiaria = new System.Windows.Forms.Panel();
            this.ctrlTxtDiaDelMes = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.chkIncluirDiasNoLaborables = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrlRdbMensual = new System.Windows.Forms.RadioButton();
            this.ctrlRdbDiaria = new System.Windows.Forms.RadioButton();
            this.ctrlRdbSemanal = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiguiente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUltima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGestor = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ctrlDelGestor = new System.Windows.Forms.Button();
            this.ctrlFindGestor = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.grpFrecuencia.SuspendLayout();
            this.grupoDiaHora.SuspendLayout();
            this.grupoDiasSemana.SuspendLayout();
            this.pnlSemanal.SuspendLayout();
            this.pnlMensual.SuspendLayout();
            this.pnlDiaria.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(74, 32);
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ReadOnly = true;
            this.ctrlTxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(554, 20);
            this.ctrlTxtDescripcion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descripción";
            // 
            // ctrlTxtNombre
            // 
            this.ctrlTxtNombre.Location = new System.Drawing.Point(74, 6);
            this.ctrlTxtNombre.Name = "ctrlTxtNombre";
            this.ctrlTxtNombre.ReadOnly = true;
            this.ctrlTxtNombre.Size = new System.Drawing.Size(402, 20);
            this.ctrlTxtNombre.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre";
            // 
            // ctrlChkActivo
            // 
            this.ctrlChkActivo.AutoSize = true;
            this.ctrlChkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ctrlChkActivo.Location = new System.Drawing.Point(572, 8);
            this.ctrlChkActivo.Name = "ctrlChkActivo";
            this.ctrlChkActivo.Size = new System.Drawing.Size(56, 17);
            this.ctrlChkActivo.TabIndex = 1;
            this.ctrlChkActivo.Text = "Activo";
            this.ctrlChkActivo.UseVisualStyleBackColor = true;
            this.ctrlChkActivo.CheckedChanged += new System.EventHandler(this.ctrlChkActivo_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTipos);
            this.tabControl.Controls.Add(this.tabExes);
            this.tabControl.Location = new System.Drawing.Point(7, 279);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(621, 243);
            this.tabControl.TabIndex = 6;
            this.tabControl.TabStop = false;
            // 
            // tabTipos
            // 
            this.tabTipos.Location = new System.Drawing.Point(4, 22);
            this.tabTipos.Name = "tabTipos";
            this.tabTipos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTipos.Size = new System.Drawing.Size(613, 217);
            this.tabTipos.TabIndex = 11;
            this.tabTipos.Text = "Tipos de Lista";
            this.tabTipos.UseVisualStyleBackColor = true;
            // 
            // tabExes
            // 
            this.tabExes.Location = new System.Drawing.Point(4, 22);
            this.tabExes.Name = "tabExes";
            this.tabExes.Padding = new System.Windows.Forms.Padding(3);
            this.tabExes.Size = new System.Drawing.Size(613, 217);
            this.tabExes.TabIndex = 10;
            this.tabExes.Text = "Ejecuciones";
            this.tabExes.UseVisualStyleBackColor = true;
            // 
            // grpFrecuencia
            // 
            this.grpFrecuencia.Controls.Add(this.grupoDiaHora);
            this.grpFrecuencia.Controls.Add(this.grupoDiasSemana);
            this.grpFrecuencia.Controls.Add(this.ctrlRdbMensual);
            this.grpFrecuencia.Controls.Add(this.ctrlRdbDiaria);
            this.grpFrecuencia.Controls.Add(this.ctrlRdbSemanal);
            this.grpFrecuencia.Controls.Add(this.txtEstado);
            this.grpFrecuencia.Controls.Add(this.label3);
            this.grpFrecuencia.Controls.Add(this.txtSiguiente);
            this.grpFrecuencia.Controls.Add(this.label2);
            this.grpFrecuencia.Controls.Add(this.txtUltima);
            this.grpFrecuencia.Controls.Add(this.label1);
            this.grpFrecuencia.Location = new System.Drawing.Point(7, 58);
            this.grpFrecuencia.Name = "grpFrecuencia";
            this.grpFrecuencia.Size = new System.Drawing.Size(621, 189);
            this.grpFrecuencia.TabIndex = 3;
            this.grpFrecuencia.TabStop = false;
            this.grpFrecuencia.Text = "Inicio, Frecuencia y Estado";
            // 
            // grupoDiaHora
            // 
            this.grupoDiaHora.Controls.Add(this.textBox3);
            this.grupoDiaHora.Controls.Add(this.textBox2);
            this.grupoDiaHora.Controls.Add(this.textBox1);
            this.grupoDiaHora.Controls.Add(this.textBox4);
            this.grupoDiaHora.Controls.Add(this.ctrlTxtHoraEjec);
            this.grupoDiaHora.Controls.Add(this.ctrlTxtMinEjec);
            this.grupoDiaHora.Controls.Add(this.ctrlCmbInicio);
            this.grupoDiaHora.Location = new System.Drawing.Point(104, 19);
            this.grupoDiaHora.Name = "grupoDiaHora";
            this.grupoDiaHora.Size = new System.Drawing.Size(353, 77);
            this.grupoDiaHora.TabIndex = 3;
            this.grupoDiaHora.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightYellow;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(23, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(64, 20);
            this.textBox3.TabIndex = 98;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "A partir del";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightYellow;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(147, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "min.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightYellow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(85, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 96;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "hs.";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightYellow;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(23, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(35, 20);
            this.textBox4.TabIndex = 95;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "A las";
            // 
            // ctrlTxtHoraEjec
            // 
            this.ctrlTxtHoraEjec.Location = new System.Drawing.Point(59, 21);
            this.ctrlTxtHoraEjec.Name = "ctrlTxtHoraEjec";
            this.ctrlTxtHoraEjec.Size = new System.Drawing.Size(25, 20);
            this.ctrlTxtHoraEjec.TabIndex = 0;
            this.ctrlTxtHoraEjec.TextChanged += new System.EventHandler(this.ctrlTxtHoraEjec_TextChanged);
            // 
            // ctrlTxtMinEjec
            // 
            this.ctrlTxtMinEjec.Location = new System.Drawing.Point(121, 21);
            this.ctrlTxtMinEjec.Name = "ctrlTxtMinEjec";
            this.ctrlTxtMinEjec.Size = new System.Drawing.Size(25, 20);
            this.ctrlTxtMinEjec.TabIndex = 1;
            this.ctrlTxtMinEjec.TextChanged += new System.EventHandler(this.ctrlTxtMinEjec_TextChanged);
            // 
            // ctrlCmbInicio
            // 
            this.ctrlCmbInicio.Location = new System.Drawing.Point(88, 42);
            this.ctrlCmbInicio.Name = "ctrlCmbInicio";
            this.ctrlCmbInicio.Size = new System.Drawing.Size(203, 20);
            this.ctrlCmbInicio.TabIndex = 2;
            // 
            // grupoDiasSemana
            // 
            this.grupoDiasSemana.Controls.Add(this.pnlMensual);
            this.grupoDiasSemana.Controls.Add(this.pnlSemanal);
            this.grupoDiasSemana.Location = new System.Drawing.Point(104, 95);
            this.grupoDiasSemana.Name = "grupoDiasSemana";
            this.grupoDiasSemana.Size = new System.Drawing.Size(353, 79);
            this.grupoDiasSemana.TabIndex = 4;
            this.grupoDiasSemana.TabStop = false;
            // 
            // pnlSemanal
            // 
            this.pnlSemanal.Controls.Add(this.ctrlChkSabado);
            this.pnlSemanal.Controls.Add(this.ctrlChkLunes);
            this.pnlSemanal.Controls.Add(this.ctrlChkDomingo);
            this.pnlSemanal.Controls.Add(this.ctrlChkMartes);
            this.pnlSemanal.Controls.Add(this.ctrlChkJueves);
            this.pnlSemanal.Controls.Add(this.ctrlChkMiercoles);
            this.pnlSemanal.Controls.Add(this.ctrlChkViernes);
            this.pnlSemanal.Location = new System.Drawing.Point(22, 16);
            this.pnlSemanal.Name = "pnlSemanal";
            this.pnlSemanal.Size = new System.Drawing.Size(310, 54);
            this.pnlSemanal.TabIndex = 95;
            // 
            // ctrlChkSabado
            // 
            this.ctrlChkSabado.AutoSize = true;
            this.ctrlChkSabado.Location = new System.Drawing.Point(70, 31);
            this.ctrlChkSabado.Name = "ctrlChkSabado";
            this.ctrlChkSabado.Size = new System.Drawing.Size(63, 17);
            this.ctrlChkSabado.TabIndex = 56;
            this.ctrlChkSabado.Text = "Sabado";
            this.ctrlChkSabado.UseVisualStyleBackColor = true;
            // 
            // ctrlChkLunes
            // 
            this.ctrlChkLunes.AutoSize = true;
            this.ctrlChkLunes.Location = new System.Drawing.Point(9, 8);
            this.ctrlChkLunes.Name = "ctrlChkLunes";
            this.ctrlChkLunes.Size = new System.Drawing.Size(55, 17);
            this.ctrlChkLunes.TabIndex = 51;
            this.ctrlChkLunes.Text = "Lunes";
            this.ctrlChkLunes.UseVisualStyleBackColor = true;
            // 
            // ctrlChkDomingo
            // 
            this.ctrlChkDomingo.AutoSize = true;
            this.ctrlChkDomingo.ForeColor = System.Drawing.Color.Maroon;
            this.ctrlChkDomingo.Location = new System.Drawing.Point(134, 31);
            this.ctrlChkDomingo.Name = "ctrlChkDomingo";
            this.ctrlChkDomingo.Size = new System.Drawing.Size(68, 17);
            this.ctrlChkDomingo.TabIndex = 57;
            this.ctrlChkDomingo.Text = "Domingo";
            this.ctrlChkDomingo.UseVisualStyleBackColor = true;
            // 
            // ctrlChkMartes
            // 
            this.ctrlChkMartes.AutoSize = true;
            this.ctrlChkMartes.Location = new System.Drawing.Point(70, 8);
            this.ctrlChkMartes.Name = "ctrlChkMartes";
            this.ctrlChkMartes.Size = new System.Drawing.Size(58, 17);
            this.ctrlChkMartes.TabIndex = 52;
            this.ctrlChkMartes.Text = "Martes";
            this.ctrlChkMartes.UseVisualStyleBackColor = true;
            // 
            // ctrlChkJueves
            // 
            this.ctrlChkJueves.AutoSize = true;
            this.ctrlChkJueves.Location = new System.Drawing.Point(209, 8);
            this.ctrlChkJueves.Name = "ctrlChkJueves";
            this.ctrlChkJueves.Size = new System.Drawing.Size(60, 17);
            this.ctrlChkJueves.TabIndex = 54;
            this.ctrlChkJueves.Text = "Jueves";
            this.ctrlChkJueves.UseVisualStyleBackColor = true;
            // 
            // ctrlChkMiercoles
            // 
            this.ctrlChkMiercoles.AutoSize = true;
            this.ctrlChkMiercoles.Location = new System.Drawing.Point(134, 8);
            this.ctrlChkMiercoles.Name = "ctrlChkMiercoles";
            this.ctrlChkMiercoles.Size = new System.Drawing.Size(71, 17);
            this.ctrlChkMiercoles.TabIndex = 53;
            this.ctrlChkMiercoles.Text = "Miércoles";
            this.ctrlChkMiercoles.UseVisualStyleBackColor = true;
            // 
            // ctrlChkViernes
            // 
            this.ctrlChkViernes.AutoSize = true;
            this.ctrlChkViernes.Location = new System.Drawing.Point(9, 31);
            this.ctrlChkViernes.Name = "ctrlChkViernes";
            this.ctrlChkViernes.Size = new System.Drawing.Size(61, 17);
            this.ctrlChkViernes.TabIndex = 55;
            this.ctrlChkViernes.Text = "Viernes";
            this.ctrlChkViernes.UseVisualStyleBackColor = true;
            // 
            // pnlMensual
            // 
            this.pnlMensual.Controls.Add(this.ctrlRdbPeriodoMensual);
            this.pnlMensual.Controls.Add(this.ctrlRdbUltimoDiaMes);
            this.pnlMensual.Controls.Add(this.ctrlRdbPrimerDiaMes);
            this.pnlMensual.Controls.Add(this.pnlDiaria);
            this.pnlMensual.Location = new System.Drawing.Point(22, 16);
            this.pnlMensual.Name = "pnlMensual";
            this.pnlMensual.Size = new System.Drawing.Size(310, 54);
            this.pnlMensual.TabIndex = 94;
            // 
            // ctrlRdbPeriodoMensual
            // 
            this.ctrlRdbPeriodoMensual.AutoSize = true;
            this.ctrlRdbPeriodoMensual.BackColor = System.Drawing.Color.Transparent;
            this.ctrlRdbPeriodoMensual.Location = new System.Drawing.Point(9, 13);
            this.ctrlRdbPeriodoMensual.Name = "ctrlRdbPeriodoMensual";
            this.ctrlRdbPeriodoMensual.Size = new System.Drawing.Size(66, 17);
            this.ctrlRdbPeriodoMensual.TabIndex = 61;
            this.ctrlRdbPeriodoMensual.TabStop = true;
            this.ctrlRdbPeriodoMensual.Text = "Los días";
            this.ctrlRdbPeriodoMensual.UseVisualStyleBackColor = false;
            this.ctrlRdbPeriodoMensual.CheckedChanged += new System.EventHandler(this.ctrlRdbPeriodoMensual_CheckedChanged);
            // 
            // ctrlRdbUltimoDiaMes
            // 
            this.ctrlRdbUltimoDiaMes.AutoSize = true;
            this.ctrlRdbUltimoDiaMes.BackColor = System.Drawing.Color.Transparent;
            this.ctrlRdbUltimoDiaMes.Location = new System.Drawing.Point(226, 28);
            this.ctrlRdbUltimoDiaMes.Name = "ctrlRdbUltimoDiaMes";
            this.ctrlRdbUltimoDiaMes.Size = new System.Drawing.Size(83, 17);
            this.ctrlRdbUltimoDiaMes.TabIndex = 64;
            this.ctrlRdbUltimoDiaMes.TabStop = true;
            this.ctrlRdbUltimoDiaMes.Text = "El último día";
            this.ctrlRdbUltimoDiaMes.UseVisualStyleBackColor = false;
            this.ctrlRdbUltimoDiaMes.CheckedChanged += new System.EventHandler(this.ctrlRdbUltimoDiaMes_CheckedChanged);
            // 
            // ctrlRdbPrimerDiaMes
            // 
            this.ctrlRdbPrimerDiaMes.AutoSize = true;
            this.ctrlRdbPrimerDiaMes.BackColor = System.Drawing.Color.Transparent;
            this.ctrlRdbPrimerDiaMes.Location = new System.Drawing.Point(226, 6);
            this.ctrlRdbPrimerDiaMes.Name = "ctrlRdbPrimerDiaMes";
            this.ctrlRdbPrimerDiaMes.Size = new System.Drawing.Size(84, 17);
            this.ctrlRdbPrimerDiaMes.TabIndex = 63;
            this.ctrlRdbPrimerDiaMes.TabStop = true;
            this.ctrlRdbPrimerDiaMes.Text = "El primer día";
            this.ctrlRdbPrimerDiaMes.UseVisualStyleBackColor = false;
            this.ctrlRdbPrimerDiaMes.CheckedChanged += new System.EventHandler(this.ctrlRdbPrimerDiaMes_CheckedChanged);
            // 
            // pnlDiaria
            // 
            this.pnlDiaria.Controls.Add(this.ctrlTxtDiaDelMes);
            this.pnlDiaria.Controls.Add(this.textBox5);
            this.pnlDiaria.Controls.Add(this.chkIncluirDiasNoLaborables);
            this.pnlDiaria.Controls.Add(this.label5);
            this.pnlDiaria.Location = new System.Drawing.Point(0, 0);
            this.pnlDiaria.Name = "pnlDiaria";
            this.pnlDiaria.Size = new System.Drawing.Size(310, 54);
            this.pnlDiaria.TabIndex = 36;
            // 
            // ctrlTxtDiaDelMes
            // 
            this.ctrlTxtDiaDelMes.Location = new System.Drawing.Point(73, 11);
            this.ctrlTxtDiaDelMes.Name = "ctrlTxtDiaDelMes";
            this.ctrlTxtDiaDelMes.Size = new System.Drawing.Size(69, 20);
            this.ctrlTxtDiaDelMes.TabIndex = 62;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LightYellow;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(141, 11);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(79, 20);
            this.textBox5.TabIndex = 92;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "de cada mes";
            // 
            // chkIncluirDiasNoLaborables
            // 
            this.chkIncluirDiasNoLaborables.AutoSize = true;
            this.chkIncluirDiasNoLaborables.Location = new System.Drawing.Point(9, 13);
            this.chkIncluirDiasNoLaborables.Name = "chkIncluirDiasNoLaborables";
            this.chkIncluirDiasNoLaborables.Size = new System.Drawing.Size(144, 17);
            this.chkIncluirDiasNoLaborables.TabIndex = 24;
            this.chkIncluirDiasNoLaborables.Text = "Incluir días no laborables";
            this.chkIncluirDiasNoLaborables.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "(Ej: 1;2;3;4-7;9-11)";
            // 
            // ctrlRdbMensual
            // 
            this.ctrlRdbMensual.AutoSize = true;
            this.ctrlRdbMensual.BackColor = System.Drawing.Color.Transparent;
            this.ctrlRdbMensual.Location = new System.Drawing.Point(19, 75);
            this.ctrlRdbMensual.Name = "ctrlRdbMensual";
            this.ctrlRdbMensual.Size = new System.Drawing.Size(80, 17);
            this.ctrlRdbMensual.TabIndex = 2;
            this.ctrlRdbMensual.TabStop = true;
            this.ctrlRdbMensual.Text = "Mensual     ";
            this.ctrlRdbMensual.UseVisualStyleBackColor = false;
            // 
            // ctrlRdbDiaria
            // 
            this.ctrlRdbDiaria.AutoSize = true;
            this.ctrlRdbDiaria.BackColor = System.Drawing.Color.Transparent;
            this.ctrlRdbDiaria.Location = new System.Drawing.Point(19, 29);
            this.ctrlRdbDiaria.Name = "ctrlRdbDiaria";
            this.ctrlRdbDiaria.Size = new System.Drawing.Size(79, 17);
            this.ctrlRdbDiaria.TabIndex = 0;
            this.ctrlRdbDiaria.TabStop = true;
            this.ctrlRdbDiaria.Text = "Diaria         ";
            this.ctrlRdbDiaria.UseVisualStyleBackColor = false;
            // 
            // ctrlRdbSemanal
            // 
            this.ctrlRdbSemanal.AutoSize = true;
            this.ctrlRdbSemanal.BackColor = System.Drawing.Color.Transparent;
            this.ctrlRdbSemanal.Location = new System.Drawing.Point(19, 52);
            this.ctrlRdbSemanal.Name = "ctrlRdbSemanal";
            this.ctrlRdbSemanal.Size = new System.Drawing.Size(81, 17);
            this.ctrlRdbSemanal.TabIndex = 1;
            this.ctrlRdbSemanal.TabStop = true;
            this.ctrlRdbSemanal.Text = "Semanal     ";
            this.ctrlRdbSemanal.UseVisualStyleBackColor = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(471, 153);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEstado.Size = new System.Drawing.Size(136, 20);
            this.txtEstado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estado Actual";
            // 
            // txtSiguiente
            // 
            this.txtSiguiente.Location = new System.Drawing.Point(471, 98);
            this.txtSiguiente.Name = "txtSiguiente";
            this.txtSiguiente.ReadOnly = true;
            this.txtSiguiente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSiguiente.Size = new System.Drawing.Size(136, 20);
            this.txtSiguiente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Siguiente Ejecución";
            // 
            // txtUltima
            // 
            this.txtUltima.Location = new System.Drawing.Point(471, 43);
            this.txtUltima.Name = "txtUltima";
            this.txtUltima.ReadOnly = true;
            this.txtUltima.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUltima.Size = new System.Drawing.Size(136, 20);
            this.txtUltima.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ejecución mas reciente";
            // 
            // txtGestor
            // 
            this.txtGestor.Location = new System.Drawing.Point(254, 253);
            this.txtGestor.Name = "txtGestor";
            this.txtGestor.ReadOnly = true;
            this.txtGestor.Size = new System.Drawing.Size(98, 20);
            this.txtGestor.TabIndex = 71;
            this.txtGestor.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 256);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(232, 13);
            this.label23.TabIndex = 72;
            this.label23.Text = "Asociar Cuenta y Gestiones al siguiente Usuario";
            // 
            // ctrlDelGestor
            // 
            this.ctrlDelGestor.Image = global::cuGenerarJobs.Properties.Resources.borrar;
            this.ctrlDelGestor.Location = new System.Drawing.Point(383, 251);
            this.ctrlDelGestor.Name = "ctrlDelGestor";
            this.ctrlDelGestor.Size = new System.Drawing.Size(26, 23);
            this.ctrlDelGestor.TabIndex = 5;
            this.ctrlDelGestor.Tag = "BOTON.CUENTA.DESASIGNAR";
            this.ctrlDelGestor.UseVisualStyleBackColor = true;
            this.ctrlDelGestor.Click += new System.EventHandler(this.ctrlDelGestor_Click);
            // 
            // ctrlFindGestor
            // 
            this.ctrlFindGestor.Image = global::cuGenerarJobs.Properties.Resources.seleccionar;
            this.ctrlFindGestor.Location = new System.Drawing.Point(355, 251);
            this.ctrlFindGestor.Name = "ctrlFindGestor";
            this.ctrlFindGestor.Size = new System.Drawing.Size(26, 23);
            this.ctrlFindGestor.TabIndex = 4;
            this.ctrlFindGestor.Tag = "BOTON.CUENTA.ASIGNAR";
            this.ctrlFindGestor.UseVisualStyleBackColor = true;
            this.ctrlFindGestor.Click += new System.EventHandler(this.ctrlFindGestor_Click);
            // 
            // UserControl1
            // 
            this.Controls.Add(this.ctrlDelGestor);
            this.Controls.Add(this.ctrlFindGestor);
            this.Controls.Add(this.txtGestor);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.grpFrecuencia);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ctrlChkActivo);
            this.Controls.Add(this.ctrlTxtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctrlTxtDescripcion);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(635, 527);
            this.tabControl.ResumeLayout(false);
            this.grpFrecuencia.ResumeLayout(false);
            this.grpFrecuencia.PerformLayout();
            this.grupoDiaHora.ResumeLayout(false);
            this.grupoDiaHora.PerformLayout();
            this.grupoDiasSemana.ResumeLayout(false);
            this.pnlSemanal.ResumeLayout(false);
            this.pnlSemanal.PerformLayout();
            this.pnlMensual.ResumeLayout(false);
            this.pnlMensual.PerformLayout();
            this.pnlDiaria.ResumeLayout(false);
            this.pnlDiaria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctrlTxtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ctrlChkActivo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabExes;
        private System.Windows.Forms.TabPage tabTipos;
        private System.Windows.Forms.GroupBox grpFrecuencia;
        private System.Windows.Forms.GroupBox grupoDiaHora;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox ctrlTxtHoraEjec;
        private System.Windows.Forms.TextBox ctrlTxtMinEjec;
        private System.Windows.Forms.DateTimePicker ctrlCmbInicio;
        private System.Windows.Forms.GroupBox grupoDiasSemana;
        private System.Windows.Forms.Panel pnlSemanal;
        private System.Windows.Forms.CheckBox ctrlChkSabado;
        private System.Windows.Forms.CheckBox ctrlChkLunes;
        private System.Windows.Forms.CheckBox ctrlChkDomingo;
        private System.Windows.Forms.CheckBox ctrlChkMartes;
        private System.Windows.Forms.CheckBox ctrlChkJueves;
        private System.Windows.Forms.CheckBox ctrlChkMiercoles;
        private System.Windows.Forms.CheckBox ctrlChkViernes;
        private System.Windows.Forms.Panel pnlMensual;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox ctrlTxtDiaDelMes;
        private System.Windows.Forms.RadioButton ctrlRdbPeriodoMensual;
        private System.Windows.Forms.RadioButton ctrlRdbUltimoDiaMes;
        private System.Windows.Forms.RadioButton ctrlRdbPrimerDiaMes;
        private System.Windows.Forms.Panel pnlDiaria;
        private System.Windows.Forms.CheckBox chkIncluirDiasNoLaborables;
        private System.Windows.Forms.RadioButton ctrlRdbMensual;
        private System.Windows.Forms.RadioButton ctrlRdbDiaria;
        private System.Windows.Forms.RadioButton ctrlRdbSemanal;
        private System.Windows.Forms.TextBox txtSiguiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUltima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ctrlDelGestor;
        private System.Windows.Forms.Button ctrlFindGestor;
        private System.Windows.Forms.TextBox txtGestor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
