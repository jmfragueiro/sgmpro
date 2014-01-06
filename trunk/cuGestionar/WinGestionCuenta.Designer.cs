namespace cuGestionar {
    partial class WinGestionCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinGestionCuenta));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCuenta = new cuGestionar.PanelGestionCuenta();
            this.panelPersonas = new cuGestionar.PanelGestionPersonas();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConvenio = new System.Windows.Forms.Button();
            this.btnRegistrarDeuda = new System.Windows.Forms.Button();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnGestionBOffice = new System.Windows.Forms.Button();
            this.btnGestionTerreno = new System.Windows.Forms.Button();
            this.btnGestionPostal = new System.Windows.Forms.Button();
            this.btnGestionTelef = new System.Windows.Forms.Button();
            this.btnEditGestion = new System.Windows.Forms.Button();
            this.btnCargarGestion = new System.Windows.Forms.Button();
            this.btnCloser = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGestiones = new System.Windows.Forms.TabPage();
            this.tabCuotas = new System.Windows.Forms.TabPage();
            this.tabPagos = new System.Windows.Forms.TabPage();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.tabHistEstados = new System.Windows.Forms.TabPage();
            this.tabHistConvenios = new System.Windows.Forms.TabPage();
            this.tabOCTitular = new System.Windows.Forms.TabPage();
            this.tabOCGarante = new System.Windows.Forms.TabPage();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::cuGestionar.Properties.Resources.imgheaderlinea;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCloser);
            this.splitContainer1.Panel1MinSize = 32;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelCuenta);
            this.splitContainer1.Panel2.Controls.Add(this.panelPersonas);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(994, 672);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label6.Location = new System.Drawing.Point(834, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sistema de Gestión de Mora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::cuGestionar.Properties.Resources.logoText;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelCuenta
            // 
            this.panelCuenta.Location = new System.Drawing.Point(5, 12);
            this.panelCuenta.Name = "panelCuenta";
            this.panelCuenta.Size = new System.Drawing.Size(508, 280);
            this.panelCuenta.TabIndex = 0;
            // 
            // panelPersonas
            // 
            this.panelPersonas.Location = new System.Drawing.Point(522, 8);
            this.panelPersonas.Name = "panelPersonas";
            this.panelPersonas.Size = new System.Drawing.Size(466, 280);
            this.panelPersonas.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConvenio);
            this.groupBox1.Controls.Add(this.btnRegistrarDeuda);
            this.groupBox1.Controls.Add(this.btnRegistrarPago);
            this.groupBox1.Controls.Add(this.btnGestionBOffice);
            this.groupBox1.Controls.Add(this.btnGestionTerreno);
            this.groupBox1.Controls.Add(this.btnGestionPostal);
            this.groupBox1.Controls.Add(this.btnGestionTelef);
            this.groupBox1.Controls.Add(this.btnEditGestion);
            this.groupBox1.Controls.Add(this.btnCargarGestion);
            this.groupBox1.Location = new System.Drawing.Point(-4, 585);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 63);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnConvenio
            // 
            this.btnConvenio.Image = global::cuGestionar.Properties.Resources.convenio;
            this.btnConvenio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvenio.Location = new System.Drawing.Point(700, 19);
            this.btnConvenio.Name = "btnConvenio";
            this.btnConvenio.Size = new System.Drawing.Size(92, 27);
            this.btnConvenio.TabIndex = 1;
            this.btnConvenio.Tag = "BOTON.GESTIONAR.ALTACONVENIO";
            this.btnConvenio.Text = "Alta &Conven.";
            this.btnConvenio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvenio.UseVisualStyleBackColor = true;
            this.btnConvenio.Click += new System.EventHandler(this.btnConvenio_Click);
            // 
            // btnRegistrarDeuda
            // 
            this.btnRegistrarDeuda.Image = global::cuGestionar.Properties.Resources.deudas;
            this.btnRegistrarDeuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarDeuda.Location = new System.Drawing.Point(900, 19);
            this.btnRegistrarDeuda.Name = "btnRegistrarDeuda";
            this.btnRegistrarDeuda.Size = new System.Drawing.Size(92, 27);
            this.btnRegistrarDeuda.TabIndex = 1;
            this.btnRegistrarDeuda.Tag = "BOTON.GESTIONAR.ALTADEUDA";
            this.btnRegistrarDeuda.Text = "Alta &Deuda";
            this.btnRegistrarDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarDeuda.UseVisualStyleBackColor = true;
            this.btnRegistrarDeuda.Click += new System.EventHandler(this.btnRegistrarDeuda_Click);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Image = global::cuGestionar.Properties.Resources.cuGestionPago;
            this.btnRegistrarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPago.Location = new System.Drawing.Point(799, 19);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(92, 27);
            this.btnRegistrarPago.TabIndex = 1;
            this.btnRegistrarPago.Tag = "BOTON.GESTIONAR.ALTAPAGO";
            this.btnRegistrarPago.Text = "Alta Pa&go";
            this.btnRegistrarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // btnGestionBOffice
            // 
            this.btnGestionBOffice.Image = global::cuGestionar.Properties.Resources.verificar;
            this.btnGestionBOffice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionBOffice.Location = new System.Drawing.Point(576, 19);
            this.btnGestionBOffice.Name = "btnGestionBOffice";
            this.btnGestionBOffice.Size = new System.Drawing.Size(103, 27);
            this.btnGestionBOffice.TabIndex = 1;
            this.btnGestionBOffice.Tag = "BOTON.GESTIONAR.BACKOFFICE";
            this.btnGestionBOffice.Text = "Gestión &Back.";
            this.btnGestionBOffice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionBOffice.UseVisualStyleBackColor = true;
            this.btnGestionBOffice.Click += new System.EventHandler(this.btnGestionBOffice_Click);
            // 
            // btnGestionTerreno
            // 
            this.btnGestionTerreno.Image = global::cuGestionar.Properties.Resources.terreno;
            this.btnGestionTerreno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionTerreno.Location = new System.Drawing.Point(465, 19);
            this.btnGestionTerreno.Name = "btnGestionTerreno";
            this.btnGestionTerreno.Size = new System.Drawing.Size(103, 27);
            this.btnGestionTerreno.TabIndex = 1;
            this.btnGestionTerreno.Tag = "BOTON.GESTIONAR.TERRENO";
            this.btnGestionTerreno.Text = "Gestión Te&rr.";
            this.btnGestionTerreno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionTerreno.UseVisualStyleBackColor = true;
            this.btnGestionTerreno.Click += new System.EventHandler(this.btnGestionTerreno_Click);
            // 
            // btnGestionPostal
            // 
            this.btnGestionPostal.Image = global::cuGestionar.Properties.Resources.postal;
            this.btnGestionPostal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPostal.Location = new System.Drawing.Point(354, 19);
            this.btnGestionPostal.Name = "btnGestionPostal";
            this.btnGestionPostal.Size = new System.Drawing.Size(103, 27);
            this.btnGestionPostal.TabIndex = 1;
            this.btnGestionPostal.Tag = "BOTON.GESTIONAR.POSTAL";
            this.btnGestionPostal.Text = "Gestión &Postal";
            this.btnGestionPostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionPostal.UseVisualStyleBackColor = true;
            this.btnGestionPostal.Click += new System.EventHandler(this.btnGestionPostal_Click);
            // 
            // btnGestionTelef
            // 
            this.btnGestionTelef.Image = global::cuGestionar.Properties.Resources.telefono;
            this.btnGestionTelef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionTelef.Location = new System.Drawing.Point(243, 19);
            this.btnGestionTelef.Name = "btnGestionTelef";
            this.btnGestionTelef.Size = new System.Drawing.Size(103, 27);
            this.btnGestionTelef.TabIndex = 1;
            this.btnGestionTelef.Tag = "BOTON.GESTIONAR.TELEFONICA";
            this.btnGestionTelef.Text = "Gestión &Telef.";
            this.btnGestionTelef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionTelef.UseVisualStyleBackColor = true;
            this.btnGestionTelef.Click += new System.EventHandler(this.btnGestionTelef_Click);
            // 
            // btnEditGestion
            // 
            this.btnEditGestion.Image = global::cuGestionar.Properties.Resources.editgestion;
            this.btnEditGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditGestion.Location = new System.Drawing.Point(9, 19);
            this.btnEditGestion.Name = "btnEditGestion";
            this.btnEditGestion.Size = new System.Drawing.Size(103, 27);
            this.btnEditGestion.TabIndex = 1;
            this.btnEditGestion.Tag = "BOTON.GESTIONAR.SELECCION";
            this.btnEditGestion.Text = "&Actualizar Sel.";
            this.btnEditGestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditGestion.UseVisualStyleBackColor = true;
            this.btnEditGestion.Click += new System.EventHandler(this.btnEditGestion_Click);
            // 
            // btnCloser
            // 
            this.btnCloser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloser.Location = new System.Drawing.Point(963, 12);
            this.btnCloser.Name = "btnCloser";
            this.btnCloser.Size = new System.Drawing.Size(10, 10);
            this.btnCloser.TabIndex = 11;
            this.btnCloser.UseVisualStyleBackColor = true;
            this.btnCloser.Click += new System.EventHandler(this.btnCloser_Click);
            // 
            // btnCargarGestion
            // 
            this.btnCargarGestion.Image = global::cuGestionar.Properties.Resources.gestionar;
            this.btnCargarGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarGestion.Location = new System.Drawing.Point(132, 19);
            this.btnCargarGestion.Name = "btnCargarGestion";
            this.btnCargarGestion.Size = new System.Drawing.Size(103, 27);
            this.btnCargarGestion.TabIndex = 1;
            this.btnCargarGestion.Tag = "BOTON.GESTIONAR.ACTUAL";
            this.btnCargarGestion.Text = "&Gestión Actual";
            this.btnCargarGestion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarGestion.UseVisualStyleBackColor = true;
            this.btnCargarGestion.Click += new System.EventHandler(this.btnCargarGestion_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGestiones);
            this.tabControl.Controls.Add(this.tabCuotas);
            this.tabControl.Controls.Add(this.tabPagos);
            this.tabControl.Controls.Add(this.tabHistorial);
            this.tabControl.Controls.Add(this.tabHistConvenios);            
            this.tabControl.Controls.Add(this.tabOCTitular);
            this.tabControl.Controls.Add(this.tabOCGarante);
            this.tabControl.Controls.Add(this.tabHistEstados);
            this.tabControl.Location = new System.Drawing.Point(5, 298);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(983, 288);
            this.tabControl.TabIndex = 2;
            // 
            // tabGestiones
            // 
            this.tabGestiones.Location = new System.Drawing.Point(4, 22);
            this.tabGestiones.Name = "tabGestiones";
            this.tabGestiones.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestiones.Size = new System.Drawing.Size(975, 262);
            this.tabGestiones.TabIndex = 0;
            this.tabGestiones.Text = "Gestiones";
            this.tabGestiones.UseVisualStyleBackColor = true;
            // 
            // tabCuotas
            // 
            this.tabCuotas.Location = new System.Drawing.Point(4, 22);
            this.tabCuotas.Name = "tabCuotas";
            this.tabCuotas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuotas.Size = new System.Drawing.Size(975, 262);
            this.tabCuotas.TabIndex = 1;
            this.tabCuotas.Text = "Convenio Activo";
            this.tabCuotas.UseVisualStyleBackColor = true;
            // 
            // tabPagos
            // 
            this.tabPagos.Location = new System.Drawing.Point(4, 22);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.Size = new System.Drawing.Size(975, 262);
            this.tabPagos.TabIndex = 5;
            this.tabPagos.Text = "Pagos";
            this.tabPagos.UseVisualStyleBackColor = true;
            // 
            // tabHistorial
            // 
            this.tabHistorial.Location = new System.Drawing.Point(4, 22);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Size = new System.Drawing.Size(975, 262);
            this.tabHistorial.TabIndex = 6;
            this.tabHistorial.Text = "Historial Deudas";
            this.tabHistorial.UseVisualStyleBackColor = true;
            // 
            // tabHistConvenios
            // 
            this.tabHistConvenios.Location = new System.Drawing.Point(4, 22);
            this.tabHistConvenios.Name = "tabHistConvenios";
            this.tabHistConvenios.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistConvenios.Size = new System.Drawing.Size(975, 262);
            this.tabHistConvenios.TabIndex = 2;
            this.tabHistConvenios.Text = "Historial Convenios";
            this.tabHistConvenios.UseVisualStyleBackColor = true;
            // 
            // tabHistEstados
            // 
            this.tabHistConvenios.Location = new System.Drawing.Point(4, 22);
            this.tabHistConvenios.Name = "tabHistEstados";
            this.tabHistConvenios.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistConvenios.Size = new System.Drawing.Size(975, 262);
            this.tabHistConvenios.TabIndex = 7;
            this.tabHistConvenios.Text = "Historial Estados";
            this.tabHistConvenios.UseVisualStyleBackColor = true;
            // 
            // tabOCTitular
            // 
            this.tabOCTitular.Location = new System.Drawing.Point(4, 22);
            this.tabOCTitular.Name = "tabOCTitular";
            this.tabOCTitular.Padding = new System.Windows.Forms.Padding(3);
            this.tabOCTitular.Size = new System.Drawing.Size(975, 262);
            this.tabOCTitular.TabIndex = 3;
            this.tabOCTitular.Text = "Otras Cuentas del Titular";
            this.tabOCTitular.UseVisualStyleBackColor = true;
            // 
            // tabOCGarante
            // 
            this.tabOCGarante.Location = new System.Drawing.Point(4, 22);
            this.tabOCGarante.Name = "tabOCGarante";
            this.tabOCGarante.Padding = new System.Windows.Forms.Padding(3);
            this.tabOCGarante.Size = new System.Drawing.Size(975, 262);
            this.tabOCGarante.TabIndex = 4;
            this.tabOCGarante.Text = "Otras Cuentas del Garante";
            this.tabOCGarante.UseVisualStyleBackColor = true;
            // 
            // WinGestionCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 672);
            this.CancelButton = this.btnCloser;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinGestionCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Mora";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WinGestionCuenta_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private PanelGestionPersonas panelPersonas;
        private PanelGestionCuenta panelCuenta;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGestiones;
        private System.Windows.Forms.TabPage tabCuotas;
        private System.Windows.Forms.TabPage tabHistConvenios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCargarGestion;
        private System.Windows.Forms.Button btnGestionTelef;
        private System.Windows.Forms.Button btnGestionPostal;
        private System.Windows.Forms.Button btnGestionTerreno;
        private System.Windows.Forms.Button btnGestionBOffice;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnConvenio;
        private System.Windows.Forms.Button btnEditGestion;
        private System.Windows.Forms.TabPage tabOCTitular;
        private System.Windows.Forms.TabPage tabOCGarante;
        private System.Windows.Forms.TabPage tabPagos;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.TabPage tabHistEstados;
        private System.Windows.Forms.Button btnRegistrarDeuda;
        private System.Windows.Forms.Button btnCloser;
    }
}