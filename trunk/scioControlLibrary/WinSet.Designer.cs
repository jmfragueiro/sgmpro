namespace scioControlLibrary
{
    partial class WinSet<T>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnListo = new System.Windows.Forms.Button();
            this.listDisponibles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAgregarTodo = new System.Windows.Forms.Button();
            this.btnQuitarTodo = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCloser = new System.Windows.Forms.Button();
            this.listConfigurados = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReiniciar);
            this.groupBox1.Controls.Add(this.btnListo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(-5, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Image = global::scioControlLibrary.Properties.Resources.reiniciar;
            this.btnReiniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReiniciar.Location = new System.Drawing.Point(452, 19);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(99, 27);
            this.btnReiniciar.TabIndex = 0;
            this.btnReiniciar.Text = "&Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnListo
            // 
            this.btnListo.Image = global::scioControlLibrary.Properties.Resources.ok;
            this.btnListo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListo.Location = new System.Drawing.Point(568, 19);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(99, 27);
            this.btnListo.TabIndex = 0;
            this.btnListo.Text = "&Guardar";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // listDisponibles
            // 
            this.listDisponibles.FormattingEnabled = true;
            this.listDisponibles.Location = new System.Drawing.Point(12, 56);
            this.listDisponibles.Name = "listDisponibles";
            this.listDisponibles.ScrollAlwaysVisible = true;
            this.listDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listDisponibles.Size = new System.Drawing.Size(300, 329);
            this.listDisponibles.TabIndex = 4;
            this.listDisponibles.TabStop = false;
            this.listDisponibles.DoubleClick += new System.EventHandler(this.listDisponibles_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione los elementos que desea y utilice los botones para agregar o quitar de" +
                " la configuración actual...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Elementos disponibles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Elementos configurados:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::scioControlLibrary.Properties.Resources.Next_16x16;
            this.btnAgregar.Location = new System.Drawing.Point(322, 118);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(31, 29);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAgregarTodo
            // 
            this.btnAgregarTodo.Image = global::scioControlLibrary.Properties.Resources.allup;
            this.btnAgregarTodo.Location = new System.Drawing.Point(322, 170);
            this.btnAgregarTodo.Name = "btnAgregarTodo";
            this.btnAgregarTodo.Size = new System.Drawing.Size(31, 29);
            this.btnAgregarTodo.TabIndex = 1;
            this.btnAgregarTodo.UseVisualStyleBackColor = true;
            this.btnAgregarTodo.Click += new System.EventHandler(this.btnAgregarTodo_Click);
            // 
            // btnQuitarTodo
            // 
            this.btnQuitarTodo.Image = global::scioControlLibrary.Properties.Resources.allback;
            this.btnQuitarTodo.Location = new System.Drawing.Point(322, 274);
            this.btnQuitarTodo.Name = "btnQuitarTodo";
            this.btnQuitarTodo.Size = new System.Drawing.Size(31, 29);
            this.btnQuitarTodo.TabIndex = 3;
            this.btnQuitarTodo.UseVisualStyleBackColor = true;
            this.btnQuitarTodo.Click += new System.EventHandler(this.btnQuitarTodo_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::scioControlLibrary.Properties.Resources.Previous_16x16;
            this.btnQuitar.Location = new System.Drawing.Point(322, 222);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(31, 29);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCloser
            // 
            this.btnCloser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloser.Location = new System.Drawing.Point(206, 17);
            this.btnCloser.Name = "btnCloser";
            this.btnCloser.Size = new System.Drawing.Size(10, 10);
            this.btnCloser.TabIndex = 9;
            this.btnCloser.UseVisualStyleBackColor = true;
            this.btnCloser.Click += new System.EventHandler(this.btnCloser_Click);
            // 
            // listConfigurados
            // 
            this.listConfigurados.FormattingEnabled = true;
            this.listConfigurados.Location = new System.Drawing.Point(362, 56);
            this.listConfigurados.Name = "listConfigurados";
            this.listConfigurados.ScrollAlwaysVisible = true;
            this.listConfigurados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listConfigurados.Size = new System.Drawing.Size(300, 329);
            this.listConfigurados.TabIndex = 5;
            this.listConfigurados.TabStop = false;
            this.listConfigurados.DoubleClick += new System.EventHandler(this.listConfigurados_DoubleClick);
            // 
            // WinSet
            // 
            this.AcceptButton = this.btnListo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCloser;
            this.ClientSize = new System.Drawing.Size(674, 444);
            this.Controls.Add(this.btnQuitarTodo);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregarTodo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listConfigurados);
            this.Controls.Add(this.listDisponibles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCloser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::scioControlLibrary.Properties.Resources._12494;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinSet";
            this.Text = "Setear Valores de Gestión";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WinSetParametro_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.ListBox listDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAgregarTodo;
        private System.Windows.Forms.Button btnQuitarTodo;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnCloser;
        private System.Windows.Forms.ListBox listConfigurados;
    }
}