
namespace Barcode_QRCode
{
    partial class CokluEtiket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CokluEtiket));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tekliEtiketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çokluEtiketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radBar = new System.Windows.Forms.RadioButton();
            this.radQR = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radAlanlar = new System.Windows.Forms.RadioButton();
            this.radRaflar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintCoklu = new System.Windows.Forms.Button();
            this.cmbAlanRaf = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblListe = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.menuStrip1.TabIndex = 19;
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
            this.çokluEtiketToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.çokluEtiketToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.çokluEtiketToolStripMenuItem.Name = "çokluEtiketToolStripMenuItem";
            this.çokluEtiketToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.çokluEtiketToolStripMenuItem.Text = "Çoklu Etiket";
            // 
            // bilgiToolStripMenuItem
            // 
            this.bilgiToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bilgiToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            this.bilgiToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.bilgiToolStripMenuItem.Text = "Bilgi";
            this.bilgiToolStripMenuItem.Click += new System.EventHandler(this.bilgiToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrintPreview);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPrintCoklu);
            this.groupBox1.Controls.Add(this.cmbAlanRaf);
            this.groupBox1.Location = new System.Drawing.Point(30, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 369);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etiketini çıkartmak istediğiniz bölümü seçiniz.";
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintPreview.Location = new System.Drawing.Point(393, 283);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(166, 47);
            this.btnPrintPreview.TabIndex = 22;
            this.btnPrintPreview.Text = "Önizleme";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radBar);
            this.groupBox4.Controls.Add(this.radQR);
            this.groupBox4.Location = new System.Drawing.Point(63, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 84);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // radBar
            // 
            this.radBar.AutoSize = true;
            this.radBar.Location = new System.Drawing.Point(19, 21);
            this.radBar.Name = "radBar";
            this.radBar.Size = new System.Drawing.Size(74, 21);
            this.radBar.TabIndex = 0;
            this.radBar.TabStop = true;
            this.radBar.Text = "Barkod";
            this.radBar.UseVisualStyleBackColor = true;
            // 
            // radQR
            // 
            this.radQR.AutoSize = true;
            this.radQR.Location = new System.Drawing.Point(19, 48);
            this.radQR.Name = "radQR";
            this.radQR.Size = new System.Drawing.Size(79, 21);
            this.radQR.TabIndex = 1;
            this.radQR.TabStop = true;
            this.radQR.Text = "QR Kod";
            this.radQR.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radAlanlar);
            this.groupBox3.Controls.Add(this.radRaflar);
            this.groupBox3.Location = new System.Drawing.Point(63, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 84);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // radAlanlar
            // 
            this.radAlanlar.AutoSize = true;
            this.radAlanlar.Location = new System.Drawing.Point(19, 21);
            this.radAlanlar.Name = "radAlanlar";
            this.radAlanlar.Size = new System.Drawing.Size(73, 21);
            this.radAlanlar.TabIndex = 0;
            this.radAlanlar.TabStop = true;
            this.radAlanlar.Text = "Alanlar";
            this.radAlanlar.UseVisualStyleBackColor = true;
            this.radAlanlar.CheckedChanged += new System.EventHandler(this.radAlanlar_CheckedChanged);
            // 
            // radRaflar
            // 
            this.radRaflar.AutoSize = true;
            this.radRaflar.Location = new System.Drawing.Point(19, 48);
            this.radRaflar.Name = "radRaflar";
            this.radRaflar.Size = new System.Drawing.Size(67, 21);
            this.radRaflar.TabIndex = 1;
            this.radRaflar.TabStop = true;
            this.radRaflar.Text = "Raflar";
            this.radRaflar.UseVisualStyleBackColor = true;
            this.radRaflar.CheckedChanged += new System.EventHandler(this.radRaflar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(60, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 99);
            this.label1.TabIndex = 19;
            this.label1.Text = "*Not: Alan seçeneği ile seçilen deponun içindeki alanların numaralarını çıkartır." +
    " Raflar seçeneği seçilen rafa ait gözlerin numaralarını çıkartır.";
            // 
            // btnPrintCoklu
            // 
            this.btnPrintCoklu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintCoklu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintCoklu.Location = new System.Drawing.Point(393, 196);
            this.btnPrintCoklu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintCoklu.Name = "btnPrintCoklu";
            this.btnPrintCoklu.Size = new System.Drawing.Size(167, 82);
            this.btnPrintCoklu.TabIndex = 18;
            this.btnPrintCoklu.Text = "Yazdır...";
            this.btnPrintCoklu.UseVisualStyleBackColor = true;
            this.btnPrintCoklu.Click += new System.EventHandler(this.btnPrintCoklu_Click);
            // 
            // cmbAlanRaf
            // 
            this.cmbAlanRaf.FormattingEnabled = true;
            this.cmbAlanRaf.ItemHeight = 16;
            this.cmbAlanRaf.Location = new System.Drawing.Point(297, 38);
            this.cmbAlanRaf.Name = "cmbAlanRaf";
            this.cmbAlanRaf.Size = new System.Drawing.Size(263, 24);
            this.cmbAlanRaf.TabIndex = 2;
            this.cmbAlanRaf.SelectedValueChanged += new System.EventHandler(this.cmbAlanRaf_SelectedValueChanged);
            this.cmbAlanRaf.Click += new System.EventHandler(this.cmbAlanRaf_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblListe);
            this.groupBox2.Location = new System.Drawing.Point(660, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 369);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alan - Raf Listesi";
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.Location = new System.Drawing.Point(6, 61);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(46, 17);
            this.lblListe.TabIndex = 0;
            this.lblListe.Text = "label2";
            // 
            // CokluEtiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(994, 555);
            this.MinimumSize = new System.Drawing.Size(994, 555);
            this.Name = "CokluEtiket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode-QRCode Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CokluEtiket_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tekliEtiketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çokluEtiketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRaflar;
        private System.Windows.Forms.RadioButton radAlanlar;
        private System.Windows.Forms.ComboBox cmbAlanRaf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintCoklu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radBar;
        private System.Windows.Forms.RadioButton radQR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrintPreview;
    }
}