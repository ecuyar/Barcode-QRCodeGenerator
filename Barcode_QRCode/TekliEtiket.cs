using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using ZXing;

namespace Barcode_QRCode
{
    public partial class TekliEtiket : Form
    {
        BarcodeWriter barcodeWriter = new BarcodeWriter()
        {
            Options = new ZXing.Common.EncodingOptions
            {
                PureBarcode = false,
                Margin = 1
            }
        };

        private void cokluEtiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CokluEtiket coklu = new CokluEtiket();
            coklu.Show();
        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BilgiSayfasi bilgi = new BilgiSayfasi();
            bilgi.Show();
        }

        private void TekliEtiket_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        public TekliEtiket()
        {
            InitializeComponent();

            radBar.Checked = true;

            try
            {
                using (MidPortal_DBEntities1 mid = new MidPortal_DBEntities1())
                {
                    cmbAlanlar.DataSource = mid.Mlz_Depo_Alan.ToList();
                    cmbAlanlar.ValueMember = "alan_id";
                    cmbAlanlar.DisplayMember = "alan_adi";

                    cmbAlanlar.SelectedValue = -1;

                    cmbRaflar.DataSource = mid.Mlz_Depo_Raf.ToList();
                    cmbRaflar.ValueMember = "raf_id";
                    cmbRaflar.DisplayMember = "raf_adi";

                    cmbRaflar.SelectedValue = -1;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.ToString());
            }

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();

            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (radQR.Checked)
            {
                e.Graphics.DrawImage(picCode4.Image, 30, 30);
                e.Graphics.DrawImage(picCode5.Image, 30, picCode4.Height + 70);

                e.Graphics.DrawImage(qrText1.Image, picCode4.Width + 40, 20);
                e.Graphics.DrawImage(qrText2.Image, picCode4.Width + 40, picCode4.Height + 50);

            }
            else if (radBar.Checked)
            {
                e.Graphics.DrawImage(picCode.Image, 30, 30);
                e.Graphics.DrawImage(picCode2.Image, 30, 30 + picCode.Height + 70);
                e.Graphics.DrawImage(picCode3.Image, 30, 30 + (picCode.Height * 2) + 70 * 2);
            }
            else
            {
            }
        }

        private void hideBarcode()
        {
            picCode.Visible = false;
            picCode2.Visible = false;
            picCode3.Visible = false;

            picCode4.Visible = true;
            picCode5.Visible = true;
            qrText1.Visible = true;
            qrText2.Visible = true;

            txtMetin3.Enabled = false;
        }

        private void hideQR()
        {
            picCode.Visible = true;
            picCode2.Visible = true;
            picCode3.Visible = true;

            picCode4.Visible = false;
            picCode5.Visible = false;
            qrText1.Visible = false;
            qrText2.Visible = false;

            txtMetin3.Enabled = true;
        }

        private void radBar_CheckedChanged(object sender, EventArgs e)
        {
            string userText;
            Bitmap pixelData;

            try
            {
                if (radQR.Checked)
                {
                    barcodeWriter.Format = BarcodeFormat.QR_CODE;
                    barcodeWriter.Options.Height = 155;
                    barcodeWriter.Options.Width = 155;

                    hideBarcode();

                    userText = txtMetin.Text;
                    pixelData = barcodeWriter.Write(userText);
                    picCode4.Image = pixelData;

                    userText = txtMetin2.Text;
                    pixelData = barcodeWriter.Write(userText);
                    picCode5.Image = pixelData;
                }
                else if (radBar.Checked)
                {
                    barcodeWriter.Format = BarcodeFormat.CODE_128;
                    barcodeWriter.Options.Height = 75;
                    barcodeWriter.Options.Width = 305;

                    hideQR();

                    userText = txtMetin.Text;
                    pixelData = barcodeWriter.Write(userText);

                    picCode.Image = pixelData;

                    userText = txtMetin2.Text;
                    pixelData = barcodeWriter.Write(userText);
                    picCode2.Image = pixelData;

                    userText = txtMetin3.Text;
                    pixelData = barcodeWriter.Write(userText);
                    picCode3.Image = pixelData;
                }
                else
                {
                    //MessageBox.Show("Error.");
                }
            }
            catch (Exception)
            {

            }

        }

        private void txtMetin_TextChanged(object sender, EventArgs e)
        {
            string userText;
            Bitmap pixelData;
            Bitmap qrText = new Bitmap(150, 150);

            if (radQR.Checked && txtMetin.Text.Length != 0)
            {
                barcodeWriter.Format = BarcodeFormat.QR_CODE;

                userText = txtMetin.Text.Trim();
                pixelData = barcodeWriter.Write(userText);
                picCode4.Image = pixelData;


                //add new text to bitmap qr code

                RectangleF newText = new RectangleF(30, 75, 120, 75);
                Graphics g = Graphics.FromImage(qrText);

                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawString(userText, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, newText);

                qrText1.Image = qrText;

                g.Flush();

            }
            else if (radBar.Checked && txtMetin.Text.Length != 0)
            {
                barcodeWriter.Format = BarcodeFormat.CODE_128;

                userText = txtMetin.Text.Trim();
                pixelData = barcodeWriter.Write(userText);
                picCode.Image = pixelData;
            }
            else if (txtMetin.Text.Length == 0)
            {
                picCode.Image = null;
                picCode4.Image = null;
                qrText1.Image = null;
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }

        private void txtMetin2_TextChanged(object sender, EventArgs e)
        {
            string userText;
            Bitmap pixelData;
            Bitmap qrText = new Bitmap(150, 150);

            if (radQR.Checked && txtMetin2.Text.Length != 0)
            {
                barcodeWriter.Format = BarcodeFormat.QR_CODE;

                userText = txtMetin2.Text.Trim();
                pixelData = barcodeWriter.Write(userText);
                picCode5.Image = pixelData;

                RectangleF newText = new RectangleF(30, 75, 120, 75);
                Graphics g = Graphics.FromImage(qrText);

                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawString(userText, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, newText);

                qrText2.Image = qrText;

                g.Flush();
            }
            else if (radBar.Checked && txtMetin2.Text.Length != 0)
            {
                barcodeWriter.Format = BarcodeFormat.CODE_128;

                userText = txtMetin2.Text.Trim();
                pixelData = barcodeWriter.Write(userText);
                picCode2.Image = pixelData;
            }
            else if (txtMetin2.Text.Length == 0)
            {
                picCode2.Image = null;
                picCode5.Image = null;
                qrText2.Image = null;
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }

        private void txtMetin3_TextChanged(object sender, EventArgs e)
        {
            string userText;
            Bitmap pixelData;

            if (radQR.Checked && txtMetin3.Text.Length != 0)
            {
                barcodeWriter.Format = BarcodeFormat.QR_CODE;

                userText = txtMetin3.Text.Trim();
                pixelData = barcodeWriter.Write(userText);
                picCode3.Image = pixelData;
            }
            else if (radBar.Checked && txtMetin3.Text.Length != 0)
            {
                barcodeWriter.Format = BarcodeFormat.CODE_128;

                userText = txtMetin3.Text.Trim();
                pixelData = barcodeWriter.Write(userText);
                picCode3.Image = pixelData;
            }
            else if (txtMetin3.Text.Length == 0)
            {
                picCode3.Image = null;
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }

        private void cmbAlanlar_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbSatir.Text = "";
            cmbSutun.Text = "";
            cmbRaflar.Text = "";

            cmbSatir.Enabled = false;
            cmbSutun.Enabled = false;

            int AlanId = Convert.ToInt32(cmbAlanlar.SelectedValue);
            DrawId(AlanId);
        }

        private void cmbRaflar_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbSatir.Enabled = true;
            cmbSutun.Enabled = true;

            cmbAlanlar.Text = "";

            int rafId = Convert.ToInt32(cmbRaflar.SelectedValue);

            //clear items when raf changed
            cmbSatir.Items.Clear();
            cmbSutun.Items.Clear();

            try
            {
                if (rafId != -1)
                {
                    using (MidPortal_DBEntities1 mid = new MidPortal_DBEntities1())
                    {
                        int satirSayisi = (from s in mid.Mlz_Depo_Raf
                                           where s.raf_id == rafId
                                           select s.satir_sayisi).FirstOrDefault();

                        for (int i = 0; i < satirSayisi; i++)
                        {
                            cmbSatir.Items.Add(i + 1);
                        }
                        cmbSatir.SelectedValue = -1;//auto select on start

                        int sutunSayisi = (from s in mid.Mlz_Depo_Raf
                                           where s.raf_id == rafId
                                           select s.sutun_sayisi).FirstOrDefault();

                        for (int i = 0; i < sutunSayisi; i++)
                        {
                            cmbSutun.Items.Add(i + 1);
                        }
                        cmbSutun.SelectedValue = -1;//auto select on start
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        int raf = -1;
        int col = -1;
        int row = -1;

        private void cmbSatir_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                raf = Convert.ToInt32(cmbRaflar.SelectedValue.ToString());
                row = Convert.ToInt32(cmbSatir.SelectedItem.ToString());

                FindRafUrunIdWithColRow(raf, row, col);
            }
            catch (Exception)
            {
            }
        }

        private void cmbSutun_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                raf = Convert.ToInt32(cmbRaflar.SelectedValue.ToString());
                col = Convert.ToInt32(cmbSutun.SelectedItem.ToString());

                FindRafUrunIdWithColRow(raf, row, col);
            }
            catch (Exception)
            {
            }
        }

        public void FindRafUrunIdWithColRow(int iRaf, int iSat, int iSut)
        {
            int RafUrunId = -1;

            try
            {
                using (MidPortal_DBEntities1 e = new MidPortal_DBEntities1())
                {
                    RafUrunId = (from s in e.Mlz_Depo_Raf_Urun where s.raf_id == iRaf && s.i == iSat - 1 && s.j == iSut - 1 select s.raf_urun_id).FirstOrDefault();
                }

                DrawId(RafUrunId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DrawId(int rafUrunId)
        {/*
            if (radQR.Checked)
            {*/
            Bitmap pixelData;
            Bitmap qrText = new Bitmap(155, 155);

            try
            {
                //create both qr and barcode and show one of them by selecting the option
                //create QRCode
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                barcodeWriter.Options.Height = 155;
                barcodeWriter.Options.Width = 155;

                picCode5.Image = null; //only one barcode enough

                pixelData = barcodeWriter.Write(rafUrunId.ToString());
                picCode4.Image = pixelData;

                RectangleF newText = new RectangleF(30, 75, 120, 75);
                Graphics g = Graphics.FromImage(qrText);
                g.DrawString(rafUrunId.ToString(), new Font("Times New Roman", 20), Brushes.Black, newText);
                qrText1.Image = qrText;
                g.Flush();

                //create Barcode
                barcodeWriter.Format = BarcodeFormat.CODE_128;
                barcodeWriter.Options.Height = 75;
                barcodeWriter.Options.Width = 305;

                picCode2.Image = null;
                picCode3.Image = null;

                pixelData = barcodeWriter.Write(rafUrunId.ToString());
                picCode.Image = pixelData;

                if (radBar.Checked)
                {
                    hideQR();
                }
                else if (radQR.Checked)
                {
                    hideBarcode();
                }
                else { }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            /*}
            else if (radBar.Checked)
            {
                Bitmap pixelData;

                try
                {
                    barcodeWriter.Format = BarcodeFormat.CODE_128;
                    barcodeWriter.Options.Height = 75;
                    barcodeWriter.Options.Width = 305;

                    pixelData = barcodeWriter.Write(rafUrunId.ToString());
                    picCode.Image = pixelData;

                    picCode4.Image = null;
                    picCode5.Image = null;

                   hideQR();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }*/
        }
    }
}
