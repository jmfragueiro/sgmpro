using System.Windows.Forms;

namespace scioControlLibrary {
    partial class WinListConAccionExtra<T> {
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAccionExtra = new System.Windows.Forms.Button();
            this.btnListo = new System.Windows.Forms.Button();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(563, 316);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAccionExtra);
            this.groupBox2.Controls.Add(this.btnListo);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(-4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 61);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnAccionExtra
            // 
            this.btnAccionExtra.Image = global::scioControlLibrary.Properties.Resources.masiva;
            this.btnAccionExtra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccionExtra.Location = new System.Drawing.Point(339, 17);
            this.btnAccionExtra.Name = "btnAccionExtra";
            this.btnAccionExtra.Size = new System.Drawing.Size(107, 27);
            this.btnAccionExtra.TabIndex = 2;
            this.btnAccionExtra.Text = "Accion";
            this.btnAccionExtra.UseVisualStyleBackColor = true;
            this.btnAccionExtra.Visible = false;
            this.btnAccionExtra.Click += new System.EventHandler(this.btnAccionExtra_Click);
            // 
            // btnListo
            // 
            this.btnListo.Image = global::scioControlLibrary.Properties.Resources.ok;
            this.btnListo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListo.Location = new System.Drawing.Point(452, 17);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(107, 27);
            this.btnListo.TabIndex = 2;
            this.btnListo.Text = "&Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // WinListConAccionExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 316);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::scioControlLibrary.Properties.Resources.select;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinListConAccionExtra";
            this.Text = "Listar Elementos";
            this.Load += new System.EventHandler(this.WinSelect_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private Button btnListo;
        private Button btnAccionExtra;

    }
}