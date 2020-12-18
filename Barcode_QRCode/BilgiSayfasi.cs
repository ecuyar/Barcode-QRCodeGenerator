using System;
using System.Windows.Forms;

namespace Barcode_QRCode
{
    public partial class BilgiSayfasi : Form
    {
        public BilgiSayfasi()
        {
            InitializeComponent();
        }

        private void cokluEtiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CokluEtiket coklu = new CokluEtiket();
            coklu.Show();
        }

        private void tekliEtiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TekliEtiket tekli = new TekliEtiket();
            tekli.Show();
        }

        private void picMidsoft_MouseDown(object sender, MouseEventArgs e)
        {
            picMidsoft.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picMidsoft_MouseUp(object sender, MouseEventArgs e)
        {
            picMidsoft.BorderStyle = BorderStyle.None;
        }
    }
}
