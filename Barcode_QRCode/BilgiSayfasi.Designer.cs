
namespace Barcode_QRCode
{
    partial class BilgiSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilgiSayfasi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tekliEtiketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çokluEtiketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picMidsoft = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMidsoft)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tekliEtiketToolStripMenuItem,
            this.çokluEtiketToolStripMenuItem,
            this.bilgiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tekliEtiketToolStripMenuItem
            // 
            this.tekliEtiketToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tekliEtiketToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tekliEtiketToolStripMenuItem.Name = "tekliEtiketToolStripMenuItem";
            this.tekliEtiketToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.tekliEtiketToolStripMenuItem.Text = "Tekli Etiket";
            this.tekliEtiketToolStripMenuItem.Click += new System.EventHandler(this.tekliEtiketToolStripMenuItem_Click);
            // 
            // çokluEtiketToolStripMenuItem
            // 
            this.çokluEtiketToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.çokluEtiketToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.çokluEtiketToolStripMenuItem.Name = "çokluEtiketToolStripMenuItem";
            this.çokluEtiketToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.çokluEtiketToolStripMenuItem.Text = "Çoklu Etiket";
            this.çokluEtiketToolStripMenuItem.Click += new System.EventHandler(this.cokluEtiketToolStripMenuItem_Click);
            // 
            // bilgiToolStripMenuItem
            // 
            this.bilgiToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bilgiToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            this.bilgiToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.bilgiToolStripMenuItem.Text = "Bilgi";
            // 
            // picMidsoft
            // 
            this.picMidsoft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picMidsoft.Image = ((System.Drawing.Image)(resources.GetObject("picMidsoft.Image")));
            this.picMidsoft.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMidsoft.InitialImage")));
            this.picMidsoft.Location = new System.Drawing.Point(175, 132);
            this.picMidsoft.Name = "picMidsoft";
            this.picMidsoft.Size = new System.Drawing.Size(588, 223);
            this.picMidsoft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMidsoft.TabIndex = 21;
            this.picMidsoft.TabStop = false;
            this.picMidsoft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMidsoft_MouseDown);
            this.picMidsoft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picMidsoft_MouseUp);
            // 
            // BilgiSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Controls.Add(this.picMidsoft);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(994, 555);
            this.MinimumSize = new System.Drawing.Size(994, 555);
            this.Name = "BilgiSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BilgiSayfasi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMidsoft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tekliEtiketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çokluEtiketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem;
        private System.Windows.Forms.PictureBox picMidsoft;
    }
}