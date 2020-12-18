using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using ZXing;

namespace Barcode_QRCode
{
    public partial class CokluEtiket : Form
    {
        public CokluEtiket()
        {
            InitializeComponent();

            lblListe.Text = "";
            radAlanlar.Enabled = false;
            radBar.Checked = true;

        }

        private int numberOfItemsPerPage = 0;
        private int numberOfPrintedItems = 0;

        BarcodeWriter barcodeWriter = new BarcodeWriter()
        {
            Options = new ZXing.Common.EncodingOptions
            {
                PureBarcode = false,
                Margin = 1
            }
        };

        public class Depo
        {
            public int DepoId { get; set; }
            public string DepoAdi { get; set; }
            public int SatirSayisi { get; set; }
            public int SutunSayisi { get; set; }
            public int UstDepoId { get; set; }
            public int AlanId { get; set; }
            public string DepoKodu { get; set; }
            public string AlanKodu { get; set; }

        }
        List<Depo> depos = new List<Depo>();

        private void tekliEtiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TekliEtiket tekli = new TekliEtiket();
            tekli.Show();
        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BilgiSayfasi bilgi = new BilgiSayfasi();
            bilgi.Show();
        }

        private void CokluEtiket_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmbAlanRaf_Click(object sender, EventArgs e)
        {
        }

        private void PrintListe(int iRafAlanId)
        {
            if (radAlanlar.Checked)
            {
                lblListe.Text = "";
            }
            else if (radRaflar.Checked)
            {
                using (MidPortal_DBEntities1 mid = new MidPortal_DBEntities1())
                {
                    depos = (from m in mid.Mlz_Depo_Raf
                             where m.raf_id == iRafAlanId
                             select new Depo { DepoId = m.raf_id, DepoAdi = m.raf_adi, SatirSayisi = m.satir_sayisi, SutunSayisi = m.sutun_sayisi }).ToList();

                    var toplam = depos[0].SatirSayisi * depos[0].SutunSayisi;

                    if (radBar.Checked)
                    {
                        if (toplam % 3 == 0)
                        {
                            lblListe.Text = depos[0].DepoAdi + " adlı depoda \n"
                                + toplam + " adet raf gözü bulunmakta. \n\n"
                                + (toplam / 3) + " adet etiket bastırılacak.";
                        }
                        else
                        {
                            lblListe.Text = depos[0].DepoAdi + " adlı depoda \n"
                                + toplam + " adet raf gözü bulunmakta. \n\n"
                                + (Math.Ceiling(Convert.ToDouble(toplam / 3)) + 1)
                                + " adet etiket bastırılacak.";
                        }
                    }
                    else if (radQR.Checked)
                    {
                        if (toplam % 2 == 0)
                        {
                            lblListe.Text = depos[0].DepoAdi + " adlı depoda \n"
                                + toplam + " adet raf gözü bulunmakta. \n\n"
                                + (toplam / 2) + " adet etiket bastırılacak.";
                        }
                        else
                        {
                            lblListe.Text = depos[0].DepoAdi + " adlı depoda \n"
                                + toplam + " adet raf gözü bulunmakta. \n\n"
                                + (Math.Ceiling(Convert.ToDouble(toplam / 2)) + 1)
                                + " adet etiket bastırılacak.";
                        }
                    }
                    else
                    {
                    }
                }
            }
            else
            {
            }
        }

        private void cmbAlanRaf_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int sVal = Convert.ToInt32(cmbAlanRaf.SelectedValue.ToString());
                PrintListe(sVal);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void radAlanlar_CheckedChanged(object sender, EventArgs e)
        {
            using (MidPortal_DBEntities1 mid = new MidPortal_DBEntities1())
            {
                depos = (from s in mid.Mlz_Depo_Alan
                         select new Depo { DepoAdi = s.alan_adi, DepoId = s.alan_id, DepoKodu = s.alan_kodu }).ToList();

                cmbAlanRaf.DataSource = depos;
                cmbAlanRaf.DisplayMember = "DepoAdi";
                cmbAlanRaf.ValueMember = "DepoId";
            }
        }

        private void radRaflar_CheckedChanged(object sender, EventArgs e)
        {
            using (MidPortal_DBEntities1 mid = new MidPortal_DBEntities1())
            {
                depos = (from s in mid.Mlz_Depo_Raf
                         select new Depo { DepoAdi = s.raf_adi, DepoId = s.raf_id }).ToList();

                cmbAlanRaf.DataSource = depos;
                cmbAlanRaf.DisplayMember = "DepoAdi";
                cmbAlanRaf.ValueMember = "DepoId";
            }
        }

        private void btnPrintCoklu_Click(object sender, EventArgs e)
        {
            if (radRaflar.Checked == false || cmbAlanRaf.SelectedValue == null)
            {
                MessageBox.Show("Lütfen gerekli alanları seçiniz.");
            }
            else
            {
                PrintDocument printDocument1 = new PrintDocument();
                PrintDialog printDialog1 = new PrintDialog();

                printDocument1.PrintPage += printDocument1_PrintPage;
                printDialog1.Document = printDocument1;

                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (radBar.Checked)
            {
                List<Depo> barList = new List<Depo>();
                int secilenYerId = Convert.ToInt32(cmbAlanRaf.SelectedValue.ToString());

                using (MidPortal_DBEntities1 midd = new MidPortal_DBEntities1())
                {
                    barList = (from s in midd.Mlz_Depo_Raf_Urun
                               where s.raf_id == secilenYerId
                               select new Depo { DepoId = s.raf_urun_id, SatirSayisi = s.i + 1, SutunSayisi = s.j + 1 }).ToList();
                }

                barcodeWriter.Format = BarcodeFormat.CODE_128;
                barcodeWriter.Options.Height = 75;
                barcodeWriter.Options.Width = 305;

                for (int i = numberOfPrintedItems; i < barList.Count; i++)
                {
                    numberOfItemsPerPage++;

                    Bitmap pixelData;
                    pixelData = barcodeWriter.Write(barList[i].DepoId.ToString());

                    PictureBox picCode = new PictureBox()
                    {
                        Image = pixelData,
                        Width = 410,
                        Height = 100
                    };

                    if (numberOfItemsPerPage < 4)
                    {
                        numberOfPrintedItems++;

                        if (numberOfPrintedItems < 4)
                        {
                            //son kısım barkodlar arası uzaklığı ayarlıyor
                            e.Graphics.DrawImage(picCode.Image, 30, 30 + (picCode.Height * (numberOfItemsPerPage - 1)) + (70 * (numberOfItemsPerPage - 1)));
                        }
                        else
                        {
                            e.HasMorePages = false;
                            e.Graphics.DrawImage(picCode.Image, 30, 30 + (picCode.Height * (numberOfItemsPerPage - 1)) + (70 * (numberOfItemsPerPage - 1)));
                        }

                    }
                    else
                    {
                        numberOfItemsPerPage = 0;
                        e.HasMorePages = true;
                        return;
                    }

                }
            }
            else if (radQR.Checked)
            {
                List<Depo> barList = new List<Depo>();
                int secilenYerId = Convert.ToInt32(cmbAlanRaf.SelectedValue.ToString());

                using (MidPortal_DBEntities1 midd = new MidPortal_DBEntities1())
                {
                    barList = (from s in midd.Mlz_Depo_Raf_Urun
                               where s.raf_id == secilenYerId
                               select new Depo { DepoId = s.raf_urun_id, SatirSayisi = s.i + 1, SutunSayisi = s.j + 1 }).ToList();
                }

                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                barcodeWriter.Options.Height = 155;
                barcodeWriter.Options.Width = 155;

                for (int i = numberOfPrintedItems; i < barList.Count; i++)
                {
                    numberOfItemsPerPage++;

                    Font font = new Font("Arial", 20, FontStyle.Regular);
                    SolidBrush brush = new SolidBrush(Color.Black);

                    Bitmap pixelData;
                    string pixelText;

                    pixelData = barcodeWriter.Write(barList[i].DepoId.ToString());
                    pixelText = barList[i].DepoId.ToString();

                    PictureBox picCode = new PictureBox()
                    {
                        Image = pixelData,
                        Width = 410,
                        Height = 200
                    };

                    if (numberOfItemsPerPage < 3)
                    {
                        numberOfPrintedItems++;

                        if (numberOfPrintedItems < 3)
                        {
                            //son kısım barkodlar arası uzaklığı ayarlıyor
                            //qrcode place
                            e.Graphics.DrawImage(picCode.Image,
                                30, 30 + (pixelData.Height * (numberOfItemsPerPage - 1)) + (70 * (numberOfItemsPerPage - 1)));

                            //qrtext
                            e.Graphics.DrawString(pixelText, font, brush,
                                30 + pixelData.Width + 50,
                                100 + (pixelData.Height * (numberOfItemsPerPage - 1)) + (70 * (numberOfItemsPerPage - 1)));
                        }
                        else
                        {
                            e.HasMorePages = false;
                            e.Graphics.DrawImage(picCode.Image,
                                30, 30 + (pixelData.Height * (numberOfItemsPerPage - 1)) + (70 * (numberOfItemsPerPage - 1)));

                            //qrtext
                            e.Graphics.DrawString(pixelText, font, brush,
                                30 + pixelData.Width + 50,
                                100 + (pixelData.Height * (numberOfItemsPerPage - 1)) + (70 * (numberOfItemsPerPage - 1)));
                        }
                    }
                    else
                    {
                        numberOfItemsPerPage = 0;
                        e.HasMorePages = true;
                        return;
                    }

                }
            }
            else
            {
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (radRaflar.Checked == false || cmbAlanRaf.SelectedValue == null)
            {
                MessageBox.Show("Lütfen gerekli alanları seçiniz.");
            }
            else
            {
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                PrintDocument printDocument1 = new PrintDocument();

                printDocument1.PrintPage += printDocument1_PrintPage;
                printPreviewDialog1.FormClosed += PrintPreviewClosed;

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }

        }

        private void PrintPreviewClosed(object sender, FormClosedEventArgs e)
        {
            numberOfItemsPerPage = 0;
            numberOfPrintedItems = 0;
        }


    }
}
