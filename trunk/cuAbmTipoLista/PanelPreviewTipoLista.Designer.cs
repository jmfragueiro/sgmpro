using System.Windows.Forms;
using scioControlLibrary;
using sgmpro.dominio.configuracion;

namespace cuAbmTipoLista
{
    partial class PanelPreviewTipoLista
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ctrlTxtPerfil = new System.Windows.Forms.TextBox();
            this.ctrlTxtNombre = new System.Windows.Forms.TextBox();
            this.ctrlTxtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoGestion = new System.Windows.Forms.TextBox();
            this.txtCtdadEstrategias = new System.Windows.Forms.TextBox();
            this.txtCtdadEntidades = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxCuentas = new System.Windows.Forms.TextBox();
            this.txtPrioridad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaAlta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpVerifica = new System.Windows.Forms.GroupBox();
            this.chkEstados = new System.Windows.Forms.CheckBox();
            this.chkPendientes = new System.Windows.Forms.CheckBox();
            this.chkElegibilidad = new System.Windows.Forms.CheckBox();
            this.grpVerifica.SuspendLayout();
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
            // ctrlTxtPerfil
            // 
            this.ctrlTxtPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtPerfil.Location = new System.Drawing.Point(187, 161);
            this.ctrlTxtPerfil.Name = "ctrlTxtPerfil";
            this.ctrlTxtPerfil.ReadOnly = true;
            this.ctrlTxtPerfil.Size = new System.Drawing.Size(225, 20);
            this.ctrlTxtPerfil.TabIndex = 9;
            // 
            // ctrlTxtNombre
            // 
            this.ctrlTxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtNombre.Location = new System.Drawing.Point(187, 11);
            this.ctrlTxtNombre.Name = "ctrlTxtNombre";
            this.ctrlTxtNombre.ReadOnly = true;
            this.ctrlTxtNombre.Size = new System.Drawing.Size(397, 20);
            this.ctrlTxtNombre.TabIndex = 6;
            // 
            // ctrlTxtDescripcion
            // 
            this.ctrlTxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTxtDescripcion.Location = new System.Drawing.Point(187, 36);
            this.ctrlTxtDescripcion.Multiline = true;
            this.ctrlTxtDescripcion.Name = "ctrlTxtDescripcion";
            this.ctrlTxtDescripcion.ReadOnly = true;
            this.ctrlTxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctrlTxtDescripcion.Size = new System.Drawing.Size(397, 41);
            this.ctrlTxtDescripcion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Crear Gestiones para el Perfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Genera Gestiones del Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nombre";
            // 
            // txtTipoGestion
            // 
            this.txtTipoGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoGestion.Location = new System.Drawing.Point(187, 135);
            this.txtTipoGestion.Name = "txtTipoGestion";
            this.txtTipoGestion.ReadOnly = true;
            this.txtTipoGestion.Size = new System.Drawing.Size(225, 20);
            this.txtTipoGestion.TabIndex = 9;
            // 
            // txtCtdadEstrategias
            // 
            this.txtCtdadEstrategias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtdadEstrategias.Location = new System.Drawing.Point(187, 109);
            this.txtCtdadEstrategias.Name = "txtCtdadEstrategias";
            this.txtCtdadEstrategias.ReadOnly = true;
            this.txtCtdadEstrategias.Size = new System.Drawing.Size(100, 20);
            this.txtCtdadEstrategias.TabIndex = 9;
            // 
            // txtCtdadEntidades
            // 
            this.txtCtdadEntidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtdadEntidades.Location = new System.Drawing.Point(187, 83);
            this.txtCtdadEntidades.Name = "txtCtdadEntidades";
            this.txtCtdadEntidades.ReadOnly = true;
            this.txtCtdadEntidades.Size = new System.Drawing.Size(100, 20);
            this.txtCtdadEntidades.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Cantidad de Entidades de Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Cantidad de Estrategias Utilizadas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Máxima Cantidad de Cuentas Aceptable";
            // 
            // txtMaxCuentas
            // 
            this.txtMaxCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxCuentas.Location = new System.Drawing.Point(526, 82);
            this.txtMaxCuentas.Name = "txtMaxCuentas";
            this.txtMaxCuentas.ReadOnly = true;
            this.txtMaxCuentas.Size = new System.Drawing.Size(58, 20);
            this.txtMaxCuentas.TabIndex = 64;
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrioridad.Location = new System.Drawing.Point(526, 108);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.ReadOnly = true;
            this.txtPrioridad.Size = new System.Drawing.Size(58, 20);
            this.txtPrioridad.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Prioridad";
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaAlta.Location = new System.Drawing.Point(507, 160);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.ReadOnly = true;
            this.txtFechaAlta.Size = new System.Drawing.Size(77, 20);
            this.txtFechaAlta.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Fecha U. Mod.";
            // 
            // grpVerifica
            // 
            this.grpVerifica.Controls.Add(this.chkEstados);
            this.grpVerifica.Controls.Add(this.chkPendientes);
            this.grpVerifica.Controls.Add(this.chkElegibilidad);
            this.grpVerifica.Location = new System.Drawing.Point(12, 190);
            this.grpVerifica.Name = "grpVerifica";
            this.grpVerifica.Size = new System.Drawing.Size(574, 43);
            this.grpVerifica.TabIndex = 66;
            this.grpVerifica.TabStop = false;
            this.grpVerifica.Text = "Verifica de cada Cuenta antes de incluirla al Generar Lista";
            // 
            // checkBox1
            // 
            this.chkEstados.AutoSize = true;
            this.chkEstados.Enabled = false;
            this.chkEstados.Location = new System.Drawing.Point(325, 20);
            this.chkEstados.Name = "checkBox1";
            this.chkEstados.Size = new System.Drawing.Size(175, 17);
            this.chkEstados.TabIndex = 0;
            this.chkEstados.Text = "Estados de Cuenta Controlados";
            this.chkEstados.UseVisualStyleBackColor = true;
            // 
            // chkPendientes
            // 
            this.chkPendientes.AutoSize = true;
            this.chkPendientes.Enabled = false;
            this.chkPendientes.Location = new System.Drawing.Point(175, 20);
            this.chkPendientes.Name = "chkPendientes";
            this.chkPendientes.Size = new System.Drawing.Size(129, 17);
            this.chkPendientes.TabIndex = 0;
            this.chkPendientes.Text = "Gestiones Pendientes";
            this.chkPendientes.UseVisualStyleBackColor = true;
            // 
            // chkElegibilidad
            // 
            this.chkElegibilidad.AutoSize = true;
            this.chkElegibilidad.Enabled = false;
            this.chkElegibilidad.Location = new System.Drawing.Point(24, 20);
            this.chkElegibilidad.Name = "chkElegibilidad";
            this.chkElegibilidad.Size = new System.Drawing.Size(127, 17);
            this.chkElegibilidad.TabIndex = 0;
            this.chkElegibilidad.Text = "Fecha de Elegibilidad";
            this.chkElegibilidad.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpVerifica);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFechaAlta);
            this.Controls.Add(this.txtPrioridad);
            this.Controls.Add(this.txtMaxCuentas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCtdadEntidades);
            this.Controls.Add(this.txtCtdadEstrategias);
            this.Controls.Add(this.txtTipoGestion);
            this.Controls.Add(this.ctrlTxtPerfil);
            this.Controls.Add(this.ctrlTxtNombre);
            this.Controls.Add(this.ctrlTxtDescripcion);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(589, 236);
            this.grpVerifica.ResumeLayout(false);
            this.grpVerifica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ctrlTxtPerfil;
        private System.Windows.Forms.TextBox ctrlTxtNombre;
        private System.Windows.Forms.TextBox ctrlTxtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipoGestion;
        private System.Windows.Forms.TextBox txtCtdadEstrategias;
        private System.Windows.Forms.TextBox txtCtdadEntidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaxCuentas;
        private TextBox txtPrioridad;
        private Label label8;
        private TextBox txtFechaAlta;
        private Label label9;
        private GroupBox grpVerifica;
        private CheckBox chkElegibilidad;
        private CheckBox chkEstados;
        private CheckBox chkPendientes;
    }
}
