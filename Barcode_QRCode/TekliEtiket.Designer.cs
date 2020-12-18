
namespace Barcode_QRCode
{
    partial class TekliEtiket
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TekliEtiket));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAlanlar = new System.Windows.Forms.ComboBox();
            this.mlzDepoAlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSatir = new System.Windows.Forms.ComboBox();
            this.cmbSutun = new System.Windows.Forms.ComboBox();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRaflar = new System.Windows.Forms.ComboBox();
            this.mlzDepoRafBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMetin3 = new System.Windows.Forms.TextBox();
            this.txtMetin2 = new System.Windows.Forms.TextBox();
            this.radBar = new System.Windows.Forms.RadioButton();
            this.radQR = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picCode = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.qrText1 = new System.Windows.Forms.PictureBox();
            this.qrText2 = new System.Windows.Forms.PictureBox();
            this.picCode5 = new System.Windows.Forms.PictureBox();
            this.picCode4 = new System.Windows.Forms.PictureBox();
            this.picCode3 = new System.Windows.Forms.PictureBox();
            this.picCode2 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tekliEtiketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çokluEtiketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mlzDepoAlanBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mlzDepoRafBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCode)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCode5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCode4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCode3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCode2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alan";
            // 
            // cmbAlanlar
            // 
            this.cmbAlanlar.DataSource = this.mlzDepoAlanBindingSource;
            this.cmbAlanlar.DisplayMember = "alan_adi";
            this.cmbAlanlar.FormattingEnabled = true;
            this.cmbAlanlar.Location = new System.Drawing.Point(85, 38);
            this.cmbAlanlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAlanlar.Name = "cmbAlanlar";
            this.cmbAlanlar.Size = new System.Drawing.Size(215, 24);
            this.cmbAlanlar.TabIndex = 0;
            this.cmbAlanlar.ValueMember = "alan_id";
            this.cmbAlanlar.SelectedValueChanged += new System.EventHandler(this.cmbAlanlar_SelectedValueChanged);
            // 
            // mlzDepoAlanBindingSource
            // 
            this.mlzDepoAlanBindingSource.DataSource = typeof(Barcode_QRCode.Mlz_Depo_Alan);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Satır";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sütun";
            // 
            // cmbSatir
            // 
            this.cmbSatir.FormattingEnabled = true;
            this.cmbSatir.Location = new System.Drawing.Point(85, 133);
            this.cmbSatir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSatir.Name = "cmbSatir";
            this.cmbSatir.Size = new System.Drawing.Size(127, 24);
            this.cmbSatir.TabIndex = 4;
            this.cmbSatir.SelectedValueChanged += new System.EventHandler(this.cmbSatir_SelectedValueChanged);
            // 
            // cmbSutun
            // 
            this.cmbSutun.FormattingEnabled = true;
            this.cmbSutun.Location = new System.Drawing.Point(85, 181);
            this.cmbSutun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSutun.Name = "cmbSutun";
            this.cmbSutun.Size = new System.Drawing.Size(127, 24);
            this.cmbSutun.TabIndex = 5;
            this.cmbSutun.SelectedValueChanged += new System.EventHandler(this.cmbSutun_SelectedValueChanged);
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(21, 36);
            this.txtMetin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMetin.MaxLength = 50;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(279, 22);
            this.txtMetin.TabIndex = 6;
            this.txtMetin.TextChanged += new System.EventHandler(this.txtMetin_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbRaflar);
            this.groupBox1.Controls.Add(this.cmbSatir);
            this.groupBox1.Controls.Add(this.cmbSutun);
            this.groupBox1.Controls.Add(this.cmbAlanlar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(309, 215);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fabrika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Raf";
            // 
            // cmbRaflar
            // 
            this.cmbRaflar.DataSource = this.mlzDepoRafBindingSource;
            this.cmbRaflar.DisplayMember = "raf_adi";
            this.cmbRaflar.FormattingEnabled = true;
            this.cmbRaflar.Location = new System.Drawing.Point(85, 86);
            this.cmbRaflar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRaflar.Name = "cmbRaflar";
            this.cmbRaflar.Size = new System.Drawing.Size(215, 24);
            this.cmbRaflar.TabIndex = 6;
            this.cmbRaflar.ValueMember = "raf_id";
            this.cmbRaflar.SelectedValueChanged += new System.EventHandler(this.cmbRaflar_SelectedValueChanged);
            // 
            // mlzDepoRafBindingSource
            // 
            this.mlzDepoRafBindingSource.DataSource = typeof(Barcode_QRCode.Mlz_Depo_Raf);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMetin3);
            this.groupBox2.Controls.Add(this.txtMetin2);
            this.groupBox2.Controls.Add(this.txtMetin);
            this.groupBox2.Location = new System.Drawing.Point(15, 274);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(309, 209);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serbest Metin";
            // 
            // txtMetin3
            // 
            this.txtMetin3.Location = new System.Drawing.Point(21, 129);
            this.txtMetin3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMetin3.MaxLength = 50;
            this.txtMetin3.Name = "txtMetin3";
            this.txtMetin3.Size = new System.Drawing.Size(279, 22);
            this.txtMetin3.TabIndex = 8;
            this.txtMetin3.TextChanged += new System.EventHandler(this.txtMetin3_TextChanged);
            // 
            // txtMetin2
            // 
            this.txtMetin2.Location = new System.Drawing.Point(21, 82);
            this.txtMetin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMetin2.MaxLength = 50;
            this.txtMetin2.Name = "txtMetin2";
            this.txtMetin2.Size = new System.Drawing.Size(279, 22);
            this.txtMetin2.TabIndex = 7;
            this.txtMetin2.TextChanged += new System.EventHandler(this.txtMetin2_TextChanged);
            // 
            // radBar
            // 
            this.radBar.AutoSize = true;
            this.radBar.Location = new System.Drawing.Point(29, 41);
            this.radBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radBar.Name = "radBar";
            this.radBar.Size = new System.Drawing.Size(74, 21);
            this.radBar.TabIndex = 12;
            this.radBar.TabStop = true;
            this.radBar.Text = "Barkod";
            this.radBar.UseVisualStyleBackColor = true;
            this.radBar.CheckedChanged += new System.EventHandler(this.radBar_CheckedChanged);
            // 
            // radQR
            // 
            this.radQR.AutoSize = true;
            this.radQR.Location = new System.Drawing.Point(29, 89);
            this.radQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radQR.Name = "radQR";
            this.radQR.Size = new System.Drawing.Size(83, 21);
            this.radQR.TabIndex = 13;
            this.radQR.TabStop = true;
            this.radQR.Text = "QRCode";
            this.radQR.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radBar);
            this.groupBox3.Controls.Add(this.radQR);
            this.groupBox3.Location = new System.Drawing.Point(343, 55);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(167, 160);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tür";
            // 
            // picCode
            // 
            this.picCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCode.Location = new System.Drawing.Point(9, 21);
            this.picCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCode.Name = "picCode";
            this.picCode.Size = new System.Drawing.Size(413, 98);
            this.picCode.TabIndex = 15;
            this.picCode.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.qrText1);
            this.groupBox4.Controls.Add(this.qrText2);
            this.groupBox4.Controls.Add(this.picCode5);
            this.groupBox4.Controls.Add(this.picCode4);
            this.groupBox4.Controls.Add(this.picCode3);
            this.groupBox4.Controls.Add(this.picCode2);
            this.groupBox4.Controls.Add(this.picCode);
            this.groupBox4.Location = new System.Drawing.Point(525, 55);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(431, 428);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // qrText1
            // 
            this.qrText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrText1.Location = new System.Drawing.Point(223, 22);
            this.qrText1.Margin = new System.Windows.Forms.Padding(0);
            this.qrText1.Name = "qrText1";
            this.qrText1.Size = new System.Drawing.Size(199, 184);
            this.qrText1.TabIndex = 20;
            this.qrText1.TabStop = false;
            // 
            // qrText2
            // 
            this.qrText2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrText2.Location = new System.Drawing.Point(223, 234);
            this.qrText2.Margin = new System.Windows.Forms.Padding(0);
            this.qrText2.Name = "qrText2";
            this.qrText2.Size = new System.Drawing.Size(199, 184);
            this.qrText2.TabIndex = 19;
            this.qrText2.TabStop = false;
            // 
            // picCode5
            // 
            this.picCode5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCode5.Location = new System.Drawing.Point(9, 234);
            this.picCode5.Margin = new System.Windows.Forms.Padding(0);
            this.picCode5.Name = "picCode5";
            this.picCode5.Size = new System.Drawing.Size(199, 184);
            this.picCode5.TabIndex = 18;
            this.picCode5.TabStop = false;
            // 
            // picCode4
            // 
            this.picCode4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCode4.Location = new System.Drawing.Point(9, 22);
            this.picCode4.Margin = new System.Windows.Forms.Padding(0);
            this.picCode4.Name = "picCode4";
            this.picCode4.Size = new System.Drawing.Size(199, 184);
            this.picCode4.TabIndex = 18;
            this.picCode4.TabStop = false;
            // 
            // picCode3
            // 
            this.picCode3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCode3.Location = new System.Drawing.Point(9, 320);
            this.picCode3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCode3.Name = "picCode3";
            this.picCode3.Size = new System.Drawing.Size(413, 98);
            this.picCode3.TabIndex = 17;
            this.picCode3.TabStop = false;
            // 
            // picCode2
            // 
            this.picCode2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCode2.Location = new System.Drawing.Point(9, 176);
            this.picCode2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCode2.Name = "picCode2";
            this.picCode2.Size = new System.Drawing.Size(413, 98);
            this.picCode2.TabIndex = 16;
            this.picCode2.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Location = new System.Drawing.Point(343, 400);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(167, 82);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Çıkart...";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tekliEtiketToolStripMenuItem
            // 
            this.tekliEtiketToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tekliEtiketToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tekliEtiketToolStripMenuItem.Name = "tekliEtiketToolStripMenuItem";
            this.tekliEtiketToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.tekliEtiketToolStripMenuItem.Text = "Tekli Etiket";
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
            this.bilgiToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bilgiToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            this.bilgiToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.bilgiToolStripMenuItem.Text = "Bilgi";
            this.bilgiToolStripMenuItem.Click += new System.EventHandler(this.bilgiToolStripMenuItem_Click);
            // 
            // TekliEtiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(994, 555);
            this.MinimumSize = new System.Drawing.Size(994, 555);
            this.Name = "TekliEtiket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode-QRCode Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TekliEtiket_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mlzDepoAlanBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mlzDepoRafBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCode)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qrText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCode5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCode4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCode3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCode2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlanlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSatir;
        private System.Windows.Forms.ComboBox cmbSutun;
        private System.Windows.Forms.TextBox txtMetin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBar;
        private System.Windows.Forms.RadioButton radQR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picCode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtMetin3;
        private System.Windows.Forms.TextBox txtMetin2;
        private System.Windows.Forms.PictureBox picCode3;
        private System.Windows.Forms.PictureBox picCode2;
        private System.Windows.Forms.PictureBox picCode5;
        private System.Windows.Forms.PictureBox picCode4;
        private System.Windows.Forms.BindingSource mlzDepoAlanBindingSource;
        private System.Windows.Forms.ComboBox cmbRaflar;
        private System.Windows.Forms.BindingSource mlzDepoRafBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tekliEtiketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çokluEtiketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem;
        private System.Windows.Forms.PictureBox qrText1;
        private System.Windows.Forms.PictureBox qrText2;
    }
}

