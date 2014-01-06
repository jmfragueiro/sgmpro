
using scioThirdPartLibrary;

namespace cuGenerarInformes
{
    partial class PanelFiltroListaGestiones
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
            this.chkResultados = new System.Windows.Forms.CheckedListBox();
            this.chkTodosUsuarios = new System.Windows.Forms.CheckBox();
            this.chkTodosEstado = new System.Windows.Forms.CheckBox();
            this.chkTodoResultados = new System.Windows.Forms.CheckBox();
            this.rbResumen = new System.Windows.Forms.RadioButton();
            this.rbDetalle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoGestion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new NullableDateTimePicker();
            this.dtpFechaDesde = new NullableDateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkListaUsuarios
            // 
            this.chkListaUsuarios.FormattingEnabled = true;
            this.chkListaUsuarios.HorizontalScrollbar = true;
            this.chkListaUsuarios.Location = new System.Drawing.Point(8, 66);
            this.chkListaUsuarios.Name = "chkListaUsuarios";
            this.chkListaUsuarios.Size = new System.Drawing.Size(240, 79);
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
            this.btnFiltrar.Location = new System.Drawing.Point(717, 65);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(87, 82);
            this.btnFiltrar.TabIndex = 59;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkEstadosGestion
            // 
            this.chkEstadosGestion.FormattingEnabled = true;
            this.chkEstadosGestion.HorizontalScrollbar = true;
            this.chkEstadosGestion.Location = new System.Drawing.Point(254, 66);
            this.chkEstadosGestion.Name = "chkEstadosGestion";
            this.chkEstadosGestion.Size = new System.Drawing.Size(175, 79);
            this.chkEstadosGestion.TabIndex = 60;
            // 
            // chkResultados
            // 
            this.chkResultados.FormattingEnabled = true;
            this.chkResultados.HorizontalScrollbar = true;
            this.chkResultados.Location = new System.Drawing.Point(435, 66);
            this.chkResultados.Name = "chkResultados";
            this.chkResultados.Size = new System.Drawing.Size(175, 79);
            this.chkResultados.TabIndex = 61;
            // 
            // chkTodosUsuarios
            // 
            this.chkTodosUsuarios.AutoSize = true;
            this.chkTodosUsuarios.Location = new System.Drawing.Point(8, 47);
            this.chkTodosUsuarios.Name = "chkTodosUsuarios";
            this.chkTodosUsuarios.Size = new System.Drawing.Size(116, 17);
            this.chkTodosUsuarios.TabIndex = 64;
            this.chkTodosUsuarios.Text = "Todos los Usuarios";
            this.chkTodosUsuarios.UseVisualStyleBackColor = true;
            this.chkTodosUsuarios.CheckedChanged += new System.EventHandler(this.chkTodosEntidades_CheckedChanged);
            // 
            // chkTodosEstado
            // 
            this.chkTodosEstado.AutoSize = true;
            this.chkTodosEstado.Location = new System.Drawing.Point(254, 47);
            this.chkTodosEstado.Name = "chkTodosEstado";
            this.chkTodosEstado.Size = new System.Drawing.Size(113, 17);
            this.chkTodosEstado.TabIndex = 65;
            this.chkTodosEstado.Text = "Todos los Estados";
            this.chkTodosEstado.UseVisualStyleBackColor = true;
            this.chkTodosEstado.CheckedChanged += new System.EventHandler(this.chkTodosTipoPago_CheckedChanged);
            // 
            // chkTodoResultados
            // 
            this.chkTodoResultados.AutoSize = true;
            this.chkTodoResultados.Location = new System.Drawing.Point(435, 47);
            this.chkTodoResultados.Name = "chkTodoResultados";
            this.chkTodoResultados.Size = new System.Drawing.Size(331, 17);
            this.chkTodoResultados.TabIndex = 66;
            this.chkTodoResultados.Text = "Todos los Resultados (dejar en blanco obtiene las sin resultados)";
            this.chkTodoResultados.UseVisualStyleBackColor = true;
            this.chkTodoResultados.CheckedChanged += new System.EventHandler(this.chkTodoFormaPago_CheckedChanged);
            // 
            // rbResumen
            // 
            this.rbResumen.AutoSize = true;
            this.rbResumen.Location = new System.Drawing.Point(12, 54);
            this.rbResumen.Name = "rbResumen";
            this.rbResumen.Size = new System.Drawing.Size(70, 17);
            this.rbResumen.TabIndex = 67;
            this.rbResumen.TabStop = true;
            this.rbResumen.Text = "Resumen";
            this.rbResumen.UseVisualStyleBackColor = true;
            // 
            // rbDetalle
            // 
            this.rbDetalle.AutoSize = true;
            this.rbDetalle.Location = new System.Drawing.Point(12, 22);
            this.rbDetalle.Name = "rbDetalle";
            this.rbDetalle.Size = new System.Drawing.Size(58, 17);
            this.rbDetalle.TabIndex = 68;
            this.rbDetalle.TabStop = true;
            this.rbDetalle.Text = "Detalle";
            this.rbDetalle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDetalle);
            this.groupBox1.Controls.Add(this.rbResumen);
            this.groupBox1.Location = new System.Drawing.Point(616, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 88);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // cmbTipoGestion
            // 
            this.cmbTipoGestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoGestion.FormattingEnabled = true;
            this.cmbTipoGestion.Location = new System.Drawing.Point(379, 8);
            this.cmbTipoGestion.Name = "cmbTipoGestion";
            this.cmbTipoGestion.Size = new System.Drawing.Size(231, 21);
            this.cmbTipoGestion.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Tipo";
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
            // PanelFiltroListaGestiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoGestion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkTodoResultados);
            this.Controls.Add(this.chkTodosEstado);
            this.Controls.Add(this.chkTodosUsuarios);
            this.Controls.Add(this.chkResultados);
            this.Controls.Add(this.chkEstadosGestion);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.chkListaUsuarios);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "PanelFiltroListaGestiones";
            this.Size = new System.Drawing.Size(815, 150);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.CheckedListBox chkResultados;
        private System.Windows.Forms.CheckBox chkTodosUsuarios;
        private System.Windows.Forms.CheckBox chkTodosEstado;
        private System.Windows.Forms.CheckBox chkTodoResultados;
        private System.Windows.Forms.RadioButton rbResumen;
        private System.Windows.Forms.RadioButton rbDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoGestion;
        private System.Windows.Forms.Label label2;
    }
}
