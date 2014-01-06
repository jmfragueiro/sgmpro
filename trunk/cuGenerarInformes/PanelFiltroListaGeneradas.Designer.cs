using scioThirdPartLibrary;

namespace cuGenerarInformes
{
    partial class PanelFiltroListaGeneradas
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
            this.chkListaUsuarios = new System.Windows.Forms.CheckedListBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.chkEstadosGestion = new System.Windows.Forms.CheckedListBox();
            this.dtpFechaHasta = new NullableDateTimePicker();
            this.dtpFechaDesde = new NullableDateTimePicker();
            this.chkTodosTipos = new System.Windows.Forms.CheckBox();
            this.chkTodosEstado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkListaUsuarios
            // 
            this.chkListaUsuarios.FormattingEnabled = true;
            this.chkListaUsuarios.HorizontalScrollbar = true;
            this.chkListaUsuarios.Location = new System.Drawing.Point(8, 66);
            this.chkListaUsuarios.Name = "chkListaUsuarios";
            this.chkListaUsuarios.Size = new System.Drawing.Size(291, 79);
            this.chkListaUsuarios.TabIndex = 2;
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
            this.btnFiltrar.Location = new System.Drawing.Point(621, 66);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(83, 79);
            this.btnFiltrar.TabIndex = 59;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkEstadosGestion
            // 
            this.chkEstadosGestion.FormattingEnabled = true;
            this.chkEstadosGestion.HorizontalScrollbar = true;
            this.chkEstadosGestion.Location = new System.Drawing.Point(305, 66);
            this.chkEstadosGestion.Name = "chkEstadosGestion";
            this.chkEstadosGestion.Size = new System.Drawing.Size(310, 79);
            this.chkEstadosGestion.TabIndex = 60;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(204, 8);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaHasta.TabIndex = 1;
            this.dtpFechaHasta.Value = new System.DateTime(2010, 4, 22, 18, 27, 51, 859);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(48, 8);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaDesde.TabIndex = 0;
            this.dtpFechaDesde.Value = new System.DateTime(2010, 4, 22, 18, 27, 51, 859);
            // 
            // chkTodosTipos
            // 
            this.chkTodosTipos.AutoSize = true;
            this.chkTodosTipos.Location = new System.Drawing.Point(8, 47);
            this.chkTodosTipos.Name = "chkTodosTipos";
            this.chkTodosTipos.Size = new System.Drawing.Size(116, 17);
            this.chkTodosTipos.TabIndex = 64;
            this.chkTodosTipos.Text = "Todos los Usuarios";
            this.chkTodosTipos.UseVisualStyleBackColor = true;
            this.chkTodosTipos.CheckedChanged += new System.EventHandler(this.chkTodosEntidades_CheckedChanged);
            // 
            // chkTodosEstado
            // 
            this.chkTodosEstado.AutoSize = true;
            this.chkTodosEstado.Location = new System.Drawing.Point(305, 47);
            this.chkTodosEstado.Name = "chkTodosEstado";
            this.chkTodosEstado.Size = new System.Drawing.Size(113, 17);
            this.chkTodosEstado.TabIndex = 65;
            this.chkTodosEstado.Text = "Todos los Estados";
            this.chkTodosEstado.UseVisualStyleBackColor = true;
            this.chkTodosEstado.CheckedChanged += new System.EventHandler(this.chkTodosTipoPago_CheckedChanged);
            // 
            // PanelFiltroListaGeneradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkTodosEstado);
            this.Controls.Add(this.chkTodosTipos);
            this.Controls.Add(this.chkEstadosGestion);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.chkListaUsuarios);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "PanelFiltroListaGeneradas";
            this.Size = new System.Drawing.Size(709, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NullableDateTimePicker dtpFechaDesde;
        private NullableDateTimePicker dtpFechaHasta;
        private System.Windows.Forms.CheckedListBox chkListaUsuarios;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckedListBox chkEstadosGestion;
        private System.Windows.Forms.CheckBox chkTodosTipos;
        private System.Windows.Forms.CheckBox chkTodosEstado;
    }
}
