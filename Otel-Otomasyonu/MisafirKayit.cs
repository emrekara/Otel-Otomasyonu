using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Otel_Otomasyonu
{
    public partial class MisafirKayit : Form
    {
        public MisafirKayit()
        {
            InitializeComponent();
        }
        public void KisiKontrol()
        {
            if (int.Parse(KisiAdedi.Text) >5)  
            {
                KisiAdedi.Text = "";
                MessageBox.Show("Lütfen Listeden Seçim Yapınız!");
            }
        }
        public void OdaDoldur() {
            Ayarlar.BaglantiAc();
            SqlCommand komut = new SqlCommand("Select OdaID from Odalar",Ayarlar.baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                OdaNumarasi.Items.Add(oku[0]);
            }
            Ayarlar.BaglantiKapat();
        }
        public void TarihKontrol()
        {
            TimeSpan tarih = new TimeSpan(1, 0, 0, 0);
            DateTime yenitarih = GirisTarihi.Value + tarih;
            CikisTarihi.Value = yenitarih;
        }
        public void TabKontrol()
        {
            tabControl1.Show();
            this.tabControl1.TabPages.Remove(BirinciMisafir);
            this.tabControl1.TabPages.Remove(IkinciMisafir);
            this.tabControl1.TabPages.Remove(UcuncuMisafir);
            this.tabControl1.TabPages.Remove(DorduncuMisafir);
            this.tabControl1.TabPages.Remove(BesinciMisafir);
            string b;
            b = KisiAdedi.Text;
            if (b == "1")
            {
                this.tabControl1.TabPages.Add(BirinciMisafir);
                this.tabControl1.TabPages.Remove(IkinciMisafir);
                this.tabControl1.TabPages.Remove(UcuncuMisafir);
                this.tabControl1.TabPages.Remove(DorduncuMisafir);
                this.tabControl1.TabPages.Remove(BesinciMisafir);
            }
            else if (b == "2")
            {
                this.tabControl1.TabPages.Add(BirinciMisafir);
                this.tabControl1.TabPages.Add(IkinciMisafir);
                this.tabControl1.TabPages.Remove(UcuncuMisafir);
                this.tabControl1.TabPages.Remove(DorduncuMisafir);
                this.tabControl1.TabPages.Remove(BesinciMisafir);

            }
            else if (b == "3")
            {
                this.tabControl1.TabPages.Add(BirinciMisafir);
                this.tabControl1.TabPages.Add(IkinciMisafir);
                this.tabControl1.TabPages.Add(UcuncuMisafir);
                this.tabControl1.TabPages.Remove(DorduncuMisafir);
                this.tabControl1.TabPages.Remove(BesinciMisafir);
            }
            else if (b == "4")
            {
                this.tabControl1.TabPages.Add(BirinciMisafir);
                this.tabControl1.TabPages.Add(IkinciMisafir);
                this.tabControl1.TabPages.Add(UcuncuMisafir);
                this.tabControl1.TabPages.Add(DorduncuMisafir);
                this.tabControl1.TabPages.Remove(BesinciMisafir);
            }
            else if (b == "5")
            {
                this.tabControl1.TabPages.Add(BirinciMisafir);
                this.tabControl1.TabPages.Add(IkinciMisafir);
                this.tabControl1.TabPages.Add(UcuncuMisafir);
                this.tabControl1.TabPages.Add(DorduncuMisafir);
                this.tabControl1.TabPages.Add(BesinciMisafir);
            }
        }
        
        private void MisafirGiris_Load(object sender, EventArgs e)
        {
            KisiAdedi.Focus();
            GirisTarihi.Enabled = false;
            CikisTarihi.Enabled = false;
            OdaNumarasi.Enabled = false;
            groupBox2.Visible = false;
            OdaDoldur();
        }

        private void KisiAdedi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void KisiAdedi_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(KisiAdedi.Text) > 0)
            {
                GirisTarihi.Enabled = true;
                CikisTarihi.Enabled = true;
                groupBox2.Visible = true;
                TabKontrol();
            }
        }

        private void GirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            TarihKontrol();
            OdaNumarasi.Enabled = true;
        }

        private void CikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            OdaNumarasi.Enabled = true;
            if (CikisTarihi.Value<GirisTarihi.Value)
            {
                TarihKontrol();
                MessageBox.Show("Çıkış Tarihi Giriş Tarihinden Önce Olamaz.");
            }
        }

        int deger,deger2,deger3,deger4,deger5;

        private void BirTCNo_TextChanged(object sender, EventArgs e)
        {
            
            if (!int.TryParse(BirTCNo.Text,out deger))
            {
                MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                BirTCNo.Clear();
            }
        }

        private void IkiTCNo_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(BirTCNo.Text, out deger2))
            {
                MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                BirTCNo.Clear();
            }
        }

        private void UcTCNo_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(BirTCNo.Text, out deger3))
            {
                MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                BirTCNo.Clear();
            }
        }

        private void DortTCNo_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(BirTCNo.Text, out deger4))
            {
                MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                BirTCNo.Clear();
            }
        }

        private void BesTCNo_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(BirTCNo.Text, out deger5))
            {
                MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                BirTCNo.Clear();
            }
        }
    }
}
