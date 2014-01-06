
using scioThirdPartLibrary;

namespace cuGenerarInformes
{
    partial class PanelFiltroHistoricoEstadosCuentas
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
            if(disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            this.label32 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.chkListaUsuarios = new System.Windows.Forms.CheckedListBox();
            this.chkTodosUsuarios = new System.Windows.Forms.CheckBox();
            this.dtpFechaHasta = new scioThirdPartLibrary.NullableDateTimePicker();
            this.dtpFechaDesde = new scioThirdPartLibrary.NullableDateTimePicker();
            this.tipFchDesde = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtDniTitular = new System.Windows.Forms.MaskedTextBox();
            this.chkTodoEntidades = new System.Windows.Forms.CheckBox();
            this.chkListaEntidades = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 12);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(38, 13);
            this.label32.TabIndex = 56;
            this.label32.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Hasta";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = global::cuGenerarInformes.Properties.Resources.Refresh_24x24;
            this.btnFiltrar.Location = new System.Drawing.Point(649, 65);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(87, 82);
            this.btnFiltrar.TabIndex = 59;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkListaUsuarios
            // 
            this.chkListaUsuarios.FormattingEnabled = true;
            this.chkListaUsuarios.HorizontalScrollbar = true;
            this.chkListaUsuarios.Location = new System.Drawing.Point(10, 65);
            this.chkListaUsuarios.Name = "chkListaUsuarios";
            this.chkListaUsuarios.Size = new System.Drawing.Size(225, 79);
            this.chkListaUsuarios.TabIndex = 60;
            // 
            // chkTodosUsuarios
            // 
            this.chkTodosUsuarios.AutoSize = true;
            this.chkTodosUsuarios.Location = new System.Drawing.Point(10, 46);
            this.chkTodosUsuarios.Name = "chkTodosUsuarios";
            this.chkTodosUsuarios.Size = new System.Drawing.Size(116, 17);
            this.chkTodosUsuarios.TabIndex = 65;
            this.chkTodosUsuarios.Text = "Todos los Usuarios";
            this.chkTodosUsuarios.UseVisualStyleBackColor = true;
            this.chkTodosUsuarios.CheckedChanged += new System.EventHandler(this.chkTodosUsuarios_CheckedChanged);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(209, 8);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaHasta.TabIndex = 1;
            this.dtpFechaHasta.Value = new System.DateTime(2010, 4, 22, 18, 27, 51, 859);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(50, 8);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaDesde.TabIndex = 0;
            this.dtpFechaDesde.Value = new System.DateTime(2010, 4, 22, 18, 27, 51, 859);
            // 
            // tipFchDesde
            // 
            this.tipFchDesde.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipFchDesde.ToolTipTitle = "Fecha desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "DNI Titular";
            // 
            // txtDniTitular
            // 
            this.txtDniTitular.Location = new System.Drawing.Point(532, 68);
            this.txtDniTitular.Mask = "99999999";
            this.txtDniTitular.Name = "txtDniTitular";
            this.txtDniTitular.Size = new System.Drawing.Size(100, 20);
            this.txtDniTitular.TabIndex = 73;
            // 
            // chkTodoEntidades
            // 
            this.chkTodoEntidades.AutoSize = true;
            this.chkTodoEntidades.Location = new System.Drawing.Point(241, 46);
            this.chkTodoEntidades.Name = "chkTodoEntidades";
            this.chkTodoEntidades.Size = new System.Drawing.Size(122, 17);
            this.chkTodoEntidades.TabIndex = 66;
            this.chkTodoEntidades.Text = "Todas las Entidades";
            this.chkTodoEntidades.UseVisualStyleBackColor = true;
            this.chkTodoEntidades.CheckedChanged += new System.EventHandler(this.chkTodosEntidades_CheckedChanged);
            // 
            // chkListaEntidades
            // 
            this.chkListaEntidades.FormattingEnabled = true;
            this.chkListaEntidades.HorizontalScrollbar = true;
            this.chkListaEntidades.Location = new System.Drawing.Point(241, 65);
            this.chkListaEntidades.Name = "chkListaEntidades";
            this.chkListaEntidades.Size = new System.Drawing.Size(221, 79);
            this.chkListaEntidades.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Cod Cuenta";
            // 
            // txtCodCta
            // 
            this.txtCodCta.Location = new System.Drawing.Point(532, 97);
            this.txtCodCta.Name = "txtCodCta";
            this.txtCodCta.Size = new System.Drawing.Size(100, 20);
            this.txtCodCta.TabIndex = 75;
            // 
            // PanelFiltroHistoricoEstadosCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCodCta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDniTitular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkTodoEntidades);
            this.Controls.Add(this.chkTodosUsuarios);
            this.Controls.Add(this.chkListaEntidades);
            this.Controls.Add(this.chkListaUsuarios);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "PanelFiltroHistoricoEstadosCuentas";
            this.Size = new System.Drawing.Size(739, 156);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NullableDateTimePicker dtpFechaDesde;
        private NullableDateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckedListBox chkListaUsuarios;
        private System.Windows.Forms.CheckBox chkTodosUsuarios;
        private System.Windows.Forms.ToolTip tipFchDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDniTitular;
        private System.Windows.Forms.CheckBox chkTodoEntidades;
        private System.Windows.Forms.CheckedListBox chkListaEntidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodCta;
    }
}
