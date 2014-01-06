namespace scioBaseLibrary.vista {
    partial class WinPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinPrincipal));
            this._statusBar = new System.Windows.Forms.StatusStrip();
            this._stAyuda = new System.Windows.Forms.ToolStripStatusLabel();
            this._stExtra1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._stExtra2 = new System.Windows.Forms.ToolStripStatusLabel();
            this._mainMenu = new System.Windows.Forms.MenuStrip();
            this._toolBar = new System.Windows.Forms.ToolStrip();
            this._statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _statusBar
            // 
            this._statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._stAyuda,
            this._stExtra1,
            this._stExtra2});
            this._statusBar.Location = new System.Drawing.Point(0, 226);
            this._statusBar.Name = "_statusBar";
            this._statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this._statusBar.ShowItemToolTips = true;
            this._statusBar.Size = new System.Drawing.Size(586, 38);
            this._statusBar.TabIndex = 0;
            this._statusBar.Text = "statusStrip1";
            // 
            // _stAyuda
            // 
            this._stAyuda.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this._stAyuda.Name = "_stAyuda";
            this._stAyuda.Size = new System.Drawing.Size(271, 33);
            this._stAyuda.Spring = true;
            this._stAyuda.Text = "Listo...";
            this._stAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _stExtra1
            // 
            this._stExtra1.AutoSize = false;
            this._stExtra1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this._stExtra1.Image = global::scioBaseLibrary.Properties.Resources.extra1;
            this._stExtra1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._stExtra1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._stExtra1.Name = "_stExtra1";
            this._stExtra1.Size = new System.Drawing.Size(150, 33);
            this._stExtra1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _stExtra2
            // 
            this._stExtra2.AutoSize = false;
            this._stExtra2.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this._stExtra2.Image = global::scioBaseLibrary.Properties.Resources.extra2;
            this._stExtra2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._stExtra2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._stExtra2.Name = "_stExtra2";
            this._stExtra2.Size = new System.Drawing.Size(150, 33);
            this._stExtra2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _mainMenu
            // 
            this._mainMenu.Location = new System.Drawing.Point(0, 0);
            this._mainMenu.Name = "_mainMenu";
            this._mainMenu.Size = new System.Drawing.Size(586, 24);
            this._mainMenu.TabIndex = 4;
            this._mainMenu.Text = "Menu Principal";
            // 
            // _toolBar
            // 
            this._toolBar.Font = new System.Drawing.Font("Segoe UI", 7F);
            this._toolBar.Location = new System.Drawing.Point(0, 24);
            this._toolBar.Name = "_toolBar";
            this._toolBar.Size = new System.Drawing.Size(586, 25);
            this._toolBar.TabIndex = 6;
            this._toolBar.Text = "Barra de Herramientas";
            // 
            // WinPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::scioBaseLibrary.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 264);
            this.Controls.Add(this._toolBar);
            this.Controls.Add(this._statusBar);
            this.Controls.Add(this._mainMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this._mainMenu;
            this.Name = "WinPrincipal";
            this.Text = "SCIO Desarrollo Profesional";
            this.Shown += new System.EventHandler(this.WinPrincipal_Shown);
            this._statusBar.ResumeLayout(false);
            this._statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip _statusBar;
        private System.Windows.Forms.ToolStripStatusLabel _stAyuda;
        private System.Windows.Forms.ToolStripStatusLabel _stExtra1;
        private System.Windows.Forms.ToolStripStatusLabel _stExtra2;
        private System.Windows.Forms.MenuStrip _mainMenu;
        private System.Windows.Forms.ToolStrip _toolBar;
    }
}