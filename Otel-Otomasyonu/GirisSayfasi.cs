using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonu 
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        private void GirisSayfasi_Load(object sender, EventArgs e)
        {
            Sifre.Enabled = false;
            Giris.Enabled = false;
            KullaniciAdi.Focus();
        }

        private void KullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (KullaniciAdi.Text.Length>=11)
            {
                Sifre.Enabled = true;
                Giris.Enabled = true;

            }
            else
            {
                Sifre.Enabled = false;
                Giris.Enabled = false;
            }
        }

        private void Giris_Click(object sender, EventArgs e)
        {
            Ayarlar.KullaniciGiris(KullaniciAdi.Text, Sifre.Text);   
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
