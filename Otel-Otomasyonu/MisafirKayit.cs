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

        public void OdaDoldur()
        {
            Ayarlar.BaglantiAc();
            SqlCommand komut = new SqlCommand("Select OdaID from Odalar", Ayarlar.baglanti);
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
            OdaLimiti.Enabled = false;
            BirAdiSoyadi.Enabled = false;
            BirTelefon.Enabled = false;
            BirEmail.Enabled = false;
            IkiAdiSoyadi.Enabled = false;
            IkiTelefon.Enabled = false;
            IkiEmail.Enabled = false;
            UcAdiSoyadi.Enabled = false;
            UcTelefon.Enabled = false;
            UcEmail.Enabled = false;
            DortAdiSoyadi.Enabled = false;
            DortTelefon.Enabled = false;
            DortEmail.Enabled = false;
            BesAdiSoyadi.Enabled = false;
            BesTelefon.Enabled = false;
            BesEmail.Enabled = false;
            OdaDoldur();
        }

        private void KisiAdedi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(KisiAdedi.Text) > 0 && int.Parse(KisiAdedi.Text) < 6)
            {
                GirisTarihi.Enabled = true;
                CikisTarihi.Enabled = true;
                groupBox2.Visible = true;
                TabKontrol();
            }
            else
            {
                KisiAdedi.Text = "1";
                MessageBox.Show("Lütfen Listeden Seçim Yapınız!");
            }
        }

        private void KisiAdedi_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(KisiAdedi.Text) > 0 && int.Parse(KisiAdedi.Text) < 6)
            {
                GirisTarihi.Enabled = true;
                CikisTarihi.Enabled = true;
                groupBox2.Visible = true;
                TabKontrol();
            }
            else
            {
                KisiAdedi.Text = "1";
                MessageBox.Show("Lütfen Listeden Seçim Yapınız!");
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
            if (CikisTarihi.Value < GirisTarihi.Value)
            {
                TarihKontrol();
                MessageBox.Show("Çıkış Tarihi Giriş Tarihinden Önce Olamaz.");
            }
        }

        double deger, deger2, deger3, deger4, deger5;

        private void BirTCNo_TextChanged(object sender, EventArgs e)
        {
            if (BirTCNo.Text != "")
            {
                if (!double.TryParse(BirTCNo.Text, out deger))
                {
                    MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                    BirTCNo.Text = "";
                }
            } 
            if (BirTCNo.Text.Length == 11)
            {

                BirAdiSoyadi.Enabled = true;
                BirTelefon.Enabled = true;
                BirEmail.Enabled = true;
                Ayarlar.BaglantiAc();
                DataTable tablo = new DataTable();
                SqlCommand komut = new SqlCommand("Select TOP 1 * from MisafirKayit where TCKimlikNo='"+BirTCNo.Text+"'", Ayarlar.baglanti);
                SqlDataAdapter adp = new SqlDataAdapter(komut);
                adp.Fill(tablo);
                if (tablo.Rows.Count>0)
                {

                    
                        BirAdiSoyadi.Text = tablo.Rows[0]["AdSoyad"].ToString();
                        BirTelefon.Text = tablo.Rows[0]["Telefon"].ToString();
                        BirEmail.Text = tablo.Rows[0]["Email"].ToString();

                }
                else
                {
                    BirAdiSoyadi.Clear();
                    BirTelefon.Clear();
                    BirEmail.Clear();
                }
                
                Ayarlar.BaglantiKapat();
            }
            else
            {
                BirAdiSoyadi.Clear();
                BirTelefon.Clear();
                BirEmail.Clear();
            }


        }

        private void IkiTCNo_TextChanged(object sender, EventArgs e)
        {
            if (IkiTCNo.Text != "")
            {
                if (!double.TryParse(IkiTCNo.Text, out deger2))
                {
                    MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                    IkiTCNo.Clear();
                }
            }
            if (IkiTCNo.Text.Length == 11)
            {
                if (IkiTCNo==BirTCNo)
                {
                    MessageBox.Show("Aynı Kişiyi Girdiniz!");
                }
                else
                {
                    IkiAdiSoyadi.Enabled = true;
                    IkiTelefon.Enabled = true;
                    IkiEmail.Enabled = true;
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    SqlCommand komut = new SqlCommand("Select TOP 1 * from MisafirKayit where TCKimlikNo='" + IkiTCNo.Text + "'", Ayarlar.baglanti);
                    SqlDataAdapter adp = new SqlDataAdapter(komut);
                    adp.Fill(tablo);
                    if (tablo.Rows.Count > 0)
                    {
                        IkiAdiSoyadi.Text = tablo.Rows[0]["AdSoyad"].ToString();
                        IkiTelefon.Text = tablo.Rows[0]["Telefon"].ToString();
                        IkiEmail.Text = tablo.Rows[0]["Email"].ToString();
                    }
                    else
                    {
                        IkiAdiSoyadi.Clear();
                        IkiTelefon.Clear();
                        IkiEmail.Clear();
                    }

                    Ayarlar.BaglantiKapat();
                }
            }
            else
            {
                IkiAdiSoyadi.Clear();
                IkiTelefon.Clear();
                IkiEmail.Clear();
            }
        }

        private void UcTCNo_TextChanged(object sender, EventArgs e)
        {
            if (UcTCNo.Text != "")
            {
                if (!double.TryParse(UcTCNo.Text, out deger2))
                {
                    MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                    UcTCNo.Clear();
                }
            }
            if (UcTCNo.Text.Length == 11)
            {
                UcAdiSoyadi.Enabled = true;
                UcTelefon.Enabled = true;
                UcEmail.Enabled = true;
                Ayarlar.BaglantiAc();
                DataTable tablo = new DataTable();
                SqlCommand komut = new SqlCommand("Select TOP 1 * from MisafirKayit where TCKimlikNo='" + UcTCNo.Text + "'", Ayarlar.baglanti);
                SqlDataAdapter adp = new SqlDataAdapter(komut);
                adp.Fill(tablo);
                if (tablo.Rows.Count > 0)
                {
                    UcAdiSoyadi.Text = tablo.Rows[0]["AdSoyad"].ToString();
                    UcTelefon.Text = tablo.Rows[0]["Telefon"].ToString();
                    UcEmail.Text = tablo.Rows[0]["Email"].ToString();
                }
                else
                {
                    UcAdiSoyadi.Clear();
                    UcTelefon.Clear();
                    UcEmail.Clear();
                }

                Ayarlar.BaglantiKapat();
            }
            else
            {
                UcAdiSoyadi.Clear();
                UcTelefon.Clear();
                UcEmail.Clear();
            }
        }

        private void DortTCNo_TextChanged(object sender, EventArgs e)
        {
            if (DortTCNo.Text != "")
            {
                if (!double.TryParse(DortTCNo.Text, out deger2))
                {
                    MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                    DortTCNo.Clear();
                }
            }
            if (DortTCNo.Text.Length == 11)
            {
                DortAdiSoyadi.Enabled = true;
                DortTelefon.Enabled = true;
                DortEmail.Enabled = true;
                Ayarlar.BaglantiAc();
                DataTable tablo = new DataTable();
                SqlCommand komut = new SqlCommand("Select TOP 1 * from MisafirKayit where TCKimlikNo='" + DortTCNo.Text + "'", Ayarlar.baglanti);
                SqlDataAdapter adp = new SqlDataAdapter(komut);
                adp.Fill(tablo);
                if (tablo.Rows.Count > 0)
                {
                    DortAdiSoyadi.Text = tablo.Rows[0]["AdSoyad"].ToString();
                    DortTelefon.Text = tablo.Rows[0]["Telefon"].ToString();
                    DortEmail.Text = tablo.Rows[0]["Email"].ToString();
                }
                else
                {
                    DortAdiSoyadi.Clear();
                    DortTelefon.Clear();
                    DortEmail.Clear();
                }

                Ayarlar.BaglantiKapat();
            }
            else
            {
                DortAdiSoyadi.Clear();
                DortTelefon.Clear();
                DortEmail.Clear();
            }
        }

        private void BesTCNo_TextChanged(object sender, EventArgs e)
        {
            if (BesTCNo.Text != "")
            {
                if (!double.TryParse(BesTCNo.Text, out deger2))
                {
                    MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                    BesTCNo.Clear();
                }
            }
            if (BesTCNo.Text.Length == 11)
            {
                BesAdiSoyadi.Enabled = true;
                BesTelefon.Enabled = true;
                BesEmail.Enabled = true;
                Ayarlar.BaglantiAc();
                DataTable tablo = new DataTable();
                SqlCommand komut = new SqlCommand("Select TOP 1 * from MisafirKayit where TCKimlikNo='" + BesTCNo.Text + "'", Ayarlar.baglanti);
                SqlDataAdapter adp = new SqlDataAdapter(komut);
                adp.Fill(tablo);
                if (tablo.Rows.Count > 0)
                {
                    BesAdiSoyadi.Text = tablo.Rows[0]["AdSoyad"].ToString();
                    BesTelefon.Text = tablo.Rows[0]["Telefon"].ToString();
                    BesEmail.Text = tablo.Rows[0]["Email"].ToString();
                }
                else
                {
                    BesAdiSoyadi.Clear();
                    BesTelefon.Clear();
                    BesEmail.Clear();
                }

                Ayarlar.BaglantiKapat();
            }
            else
            {
                BesAdiSoyadi.Clear();
                BesTelefon.Clear();
                BesEmail.Clear();
            }
            if (BesTCNo.Text.Length == 11)
            {
                BesAdiSoyadi.Enabled = true;
                BesTelefon.Enabled = true;
                BesEmail.Enabled = true;
            }
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {

        }

        private void OdaNumarasi_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void OdaNumarasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OdaNumarasi.Text == "203" ||
                OdaNumarasi.Text == "204" ||
                OdaNumarasi.Text == "302" ||
                OdaNumarasi.Text == "501" ||
                OdaNumarasi.Text == "601" ||
                OdaNumarasi.Text == "602" ||
                OdaNumarasi.Text == "603")
            {
                OdaLimiti.Text = "2";
            }
            else if (OdaNumarasi.Text == "102" ||
                    OdaNumarasi.Text == "105" ||
                    OdaNumarasi.Text == "202" ||
                    OdaNumarasi.Text == "205" ||
                    OdaNumarasi.Text == "303" ||
                    OdaNumarasi.Text == "304" ||
                    OdaNumarasi.Text == "502" ||
                    OdaNumarasi.Text == "604" ||
                    OdaNumarasi.Text == "605" ||
                    OdaNumarasi.Text == "606")
            {
                OdaLimiti.Text = "3";
            }
            else if (OdaNumarasi.Text == "103" ||
                   OdaNumarasi.Text == "206" ||
                   OdaNumarasi.Text == "305" ||
                   OdaNumarasi.Text == "403" ||
                   OdaNumarasi.Text == "404" ||
                   OdaNumarasi.Text == "503")
            {
                OdaLimiti.Text = "4";
            }
            else if (OdaNumarasi.Text == "104" ||
                   OdaNumarasi.Text == "106" ||
                   OdaNumarasi.Text == "306" ||
                   OdaNumarasi.Text == "405" ||
                   OdaNumarasi.Text == "406" ||
                   OdaNumarasi.Text == "504" ||
                   OdaNumarasi.Text == "505" ||
                   OdaNumarasi.Text == "506")
            {
                OdaLimiti.Text = "5";
            }
            else if (
                OdaNumarasi.Text == "101" ||
                OdaNumarasi.Text == "201" ||
                OdaNumarasi.Text == "301" ||
                OdaNumarasi.Text == "401" ||
                OdaNumarasi.Text == "402")
            {
                OdaLimiti.Text = "1";
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Seçim Yapınız.");
                OdaNumarasi.ResetText();
            }
        }
    }
}
