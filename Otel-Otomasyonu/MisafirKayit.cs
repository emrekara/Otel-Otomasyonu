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
        bool TC1 = false, TC2 = false, TC3 = false, TC4 = false, TC5 = false;
        string[] MisafirEkle = new string[5];
        string[] RezervasyonKayit = new string[5];
        int OdaNumarasiSecimi = 0;
        string SonKayitID1 = "", SonKayitID2 = "", SonKayitID3 = "", SonKayitID4 = "", SonKayitID5 = "";
        string id1 = "", id2 = "", id3 = "", id4 = "", id5 = "";
        public void OdaDoldur(string giris, string cikis, string Limit)
        {
            OdaNumarasi.Items.Clear();
            Ayarlar.BaglantiAc();
            SqlCommand komut = new SqlCommand("select o.Isim from(select o.ID,o.Isim,ho.GirisTarihi,ho.CikisTarihi,ho.OdaID from Odalar as o left join HangiOdada as ho on o.ID=ho.OdaID where ho.GirisTarihi between '" + giris + "' and '" + cikis + "' or ho.CikisTarihi between '" + giris + "' and '" + cikis + "' or ho.GirisTarihi < '" + giris + "' and ho.CikisTarihi > '" + cikis + "')as tt right join Odalar as o on o.ID=tt.OdaID where tt.GirisTarihi is null and o.Limit>=" + Limit + "", Ayarlar.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                OdaNumarasi.Items.Add(dr["Isim"].ToString());
            }
            Ayarlar.BaglantiKapat();
        }
        public void OdaNumarasiSec()
        {
            string OdaSecimi = OdaNumarasi.Text;
            switch (OdaSecimi)
            {
                case "101":
                    OdaNumarasiSecimi = 1;
                    break;
                case "102":
                    OdaNumarasiSecimi = 2;
                    break;
                case "103":
                    OdaNumarasiSecimi = 3;
                    break;
                case "104":
                    OdaNumarasiSecimi = 4;
                    break;
                case "105":
                    OdaNumarasiSecimi = 5;
                    break;
                case "201":
                    OdaNumarasiSecimi = 6;
                    break;
                case "202":
                    OdaNumarasiSecimi = 7;
                    break;
                case "203":
                    OdaNumarasiSecimi = 8;
                    break;
                case "204":
                    OdaNumarasiSecimi = 9;
                    break;
                case "205":
                    OdaNumarasiSecimi = 10;
                    break;
                case "301":
                    OdaNumarasiSecimi = 11;
                    break;
                case "302":
                    OdaNumarasiSecimi = 12;
                    break;
                case "303":
                    OdaNumarasiSecimi = 13;
                    break;
                case "304":
                    OdaNumarasiSecimi = 14;
                    break;
                case "305":
                    OdaNumarasiSecimi = 15;
                    break;
                case "401":
                    OdaNumarasiSecimi = 16;
                    break;
                case "402":
                    OdaNumarasiSecimi = 17;
                    break;
                case "403":
                    OdaNumarasiSecimi = 18;
                    break;
                case "404":
                    OdaNumarasiSecimi = 19;
                    break;
                case "405":
                    OdaNumarasiSecimi = 20;
                    break;
                default:
                    MessageBox.Show("Numarasını Listeden Seçiniz.");
                    break;
            }

        }
        public void TarihKontrol()
        {
            TimeSpan tarih = new TimeSpan(1, 0, 0, 0);
            DateTime yenitarih = GirisTarihi.Value + tarih;
            CikisTarihi.Value = yenitarih;
        }
        public void TabKontrol()
        {
            groupBox2.Visible = true;
            tabControl1.Show();
            this.tabControl1.TabPages.Remove(BirinciMisafir);
            this.tabControl1.TabPages.Remove(IkinciMisafir);
            this.tabControl1.TabPages.Remove(UcuncuMisafir);
            this.tabControl1.TabPages.Remove(DorduncuMisafir);
            this.tabControl1.TabPages.Remove(BesinciMisafir);
            string b;
            b = OdaLimiti.Text;
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
            else
            {
                this.tabControl1.TabPages.Remove(BirinciMisafir);
                this.tabControl1.TabPages.Remove(IkinciMisafir);
                this.tabControl1.TabPages.Remove(UcuncuMisafir);
                this.tabControl1.TabPages.Remove(DorduncuMisafir);
                this.tabControl1.TabPages.Remove(BesinciMisafir);
            }
        }
        public void Kaydet1(string giristarihi, string cikistarihi)
        {
            string cikis = cikistarihi;
            string giris = giristarihi;
            if (TC1 == false)
            {
                if (BirTCNo.Text.Length == 11 && BirAdiSoyadi.Text.Length >= 3 && BirTelefon.Text.Length >= 9 && (BirCinsiyet.Text == "Erkek" || BirCinsiyet.Text == "Kadın"))
                {
                    Ayarlar.BaglantiAc();
                    SqlCommand kmt = new SqlCommand("Insert into  MisafirKayit(TCKimlik, AdSoyad, Telefon, Cinsiyet) VALUES  ('" + BirTCNo.Text + "','" + BirAdiSoyadi.Text + "','" + BirTelefon.Text + "','" + BirCinsiyet.Text + "'); select scope_identity()", Ayarlar.baglanti);
                    SonKayitID1 = kmt.ExecuteScalar().ToString();
                    SqlCommand kmt2 = new SqlCommand("Insert into HangiOdada(OdaID,MusteriID,GirisTarihi,CikisTarihi,Durum) Values('" + OdaNumarasiSecimi + "','" + SonKayitID1 + "','" + giris + "','" + cikis + "','Giriş')", Ayarlar.baglanti);
                    kmt2.ExecuteNonQuery();
                    Ayarlar.BaglantiKapat();
                    MisafirEkle[0] = "1";
                    RezervasyonKayit[0] = "1";
                }
            }
            else
            {
                if (BirTCNo.Text.Length == 11 && BirAdiSoyadi.Text.Length >= 3 && BirTelefon.Text.Length >= 9 && (BirCinsiyet.Text == "Erkek" || BirCinsiyet.Text == "Kadın"))
                {
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    SqlCommand komut = new SqlCommand("Select TOP 1 ID from MisafirKayit where TCKimlik='" + BirTCNo.Text + "'", Ayarlar.baglanti);
                    SqlDataAdapter adp = new SqlDataAdapter(komut);
                    adp.Fill(tablo);
                    if (tablo.Rows.Count > 0)
                    {
                        id1 = tablo.Rows[0]["ID"].ToString();
                        SqlCommand kmt2 = new SqlCommand("Insert into HangiOdada (OdaID,MusteriID,GirisTarihi,CikisTarihi,Durum) Values('" + OdaNumarasiSecimi + "','" + id1 + "','" + giris + "','" + cikis + "','Giriş')", Ayarlar.baglanti);
                        kmt2.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Sırasında Bir Hata Meydana Geldi.");
                    }

                    Ayarlar.BaglantiKapat();
                    RezervasyonKayit[0] = "1";

                }
                else
                {
                    MessageBox.Show("1. Kişi Girilmedi");
                }
            }
        }
        public void Kaydet2(string giristarihi, string cikistarihi)
        {
            string cikis = cikistarihi;
            string giris = giristarihi;
            if (TC2 == false)
            {
                if (IkiTCNo.Text.Length == 11 && IkiAdiSoyadi.Text.Length >= 3 && IkiTelefon.Text.Length >= 9 && (IkiCinsiyet.Text == "Erkek" || IkiCinsiyet.Text == "Kadın"))
                {
                    Ayarlar.BaglantiAc();
                    SqlCommand kmt = new SqlCommand("Insert into  MisafirKayit(TCKimlik, AdSoyad, Telefon, Cinsiyet) VALUES  ('" + IkiTCNo.Text + "','" + IkiAdiSoyadi.Text + "','" + IkiTelefon.Text + "','" + IkiCinsiyet.Text + "'); select scope_identity()", Ayarlar.baglanti);
                    SonKayitID2 = kmt.ExecuteScalar().ToString();
                    SqlCommand kmt2 = new SqlCommand("Insert into HangiOdada(OdaID,MusteriID,GirisTarihi,CikisTarihi,Durum) Values('" + Convert.ToString(OdaNumarasiSecimi) + "','" + SonKayitID2 + "','" + giris + "','" + cikis + "','Giriş')", Ayarlar.baglanti);
                    kmt2.ExecuteNonQuery();
                    Ayarlar.BaglantiKapat();
                    MisafirEkle[1] = "1";
                    RezervasyonKayit[1] = "1";
                }
            }
            else
            {
                if (IkiTCNo.Text.Length == 11 && IkiAdiSoyadi.Text.Length >= 3 && IkiTelefon.Text.Length >= 9 && (IkiCinsiyet.Text == "Erkek" || IkiCinsiyet.Text == "Kadın"))
                {
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    SqlCommand komut = new SqlCommand("Select TOP 1 ID from MisafirKayit where TCKimlik='" + BirTCNo.Text + "'", Ayarlar.baglanti);
                    SqlDataAdapter adp = new SqlDataAdapter(komut);
                    adp.Fill(tablo);
                    if (tablo.Rows.Count > 0)
                    {
                        id2 = tablo.Rows[0]["ID"].ToString();
                        SqlCommand kmt2 = new SqlCommand("Insert into HangiOdada (OdaID,MusteriID,GirisTarihi,CikisTarihi,Durum) Values('" + OdaNumarasiSecimi + "','" + id1 + "','" + giris + "','" + cikis + "','Giriş')", Ayarlar.baglanti);
                        kmt2.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Sırasında Bir Hata Meydana Geldi.");
                    }
                    Ayarlar.BaglantiKapat();
                    RezervasyonKayit[1] = "1";

                }
                else
                {
                    MessageBox.Show("2. Kişi Girilmedi");
                }
            }
        }
        public void Kaydet3(string giristarihi, string cikistarihi)
        {
            string cikis = cikistarihi;
            string giris = giristarihi;
            if (TC3 == false)
            {
                if (UcTCNo.Text.Length == 11 && UcAdiSoyadi.Text.Length >= 3 && UcTelefon.Text.Length >= 9 && (UcCinsiyet.Text == "Erkek" || UcCinsiyet.Text == "Kadın"))
                {
                    Ayarlar.BaglantiAc();
                    SqlCommand kmt = new SqlCommand("Insert into  MisafirKayit(TCKimlik, AdSoyad, Telefon, Cinsiyet) VALUES  ('" + UcTCNo.Text + "','" + UcAdiSoyadi.Text + "','" + UcTelefon.Text + "','" + UcCinsiyet.Text + "'); select scope_identity()", Ayarlar.baglanti);
                    SonKayitID3 = kmt.ExecuteScalar().ToString();
                    SqlCommand kmt2 = new SqlCommand("Insert into HangiOdada(OdaID,MusteriID,GirisTarihi,CikisTarihi,Durum) Values('" + Convert.ToString(OdaNumarasiSecimi) + "','" + SonKayitID3 + "','" + giris + "','" + cikis + "','Giriş')", Ayarlar.baglanti);
                    kmt2.ExecuteNonQuery();
                    Ayarlar.BaglantiKapat();
                    MisafirEkle[2] = "1";
                    RezervasyonKayit[2] = "1";
                }
            }
            else
            {
                if (UcTCNo.Text.Length == 11 && UcAdiSoyadi.Text.Length >= 3 && UcTelefon.Text.Length >= 9 && (UcCinsiyet.Text == "Erkek" || UcCinsiyet.Text == "Kadın"))
                {
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    SqlCommand komut = new SqlCommand("Select TOP 1 ID from MisafirKayit where TCKimlik='" + BirTCNo.Text + "'", Ayarlar.baglanti);
                    SqlDataAdapter adp = new SqlDataAdapter(komut);
                    adp.Fill(tablo);
                    if (tablo.Rows.Count > 0)
                    {
                        id3 = tablo.Rows[0]["ID"].ToString();
                        SqlCommand kmt2 = new SqlCommand("Insert into HangiOdada (OdaID,MusteriID,GirisTarihi,CikisTarihi,Durum) Values('" + OdaNumarasiSecimi + "','" + id1 + "','" + giris + "','" + cikis + "','Giriş')", Ayarlar.baglanti);
                        kmt2.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Sırasında Bir Hata Meydana Geldi.");
                    }
                    Ayarlar.BaglantiKapat();
                    RezervasyonKayit[2] = "1";

                }
                else
                {
                    MessageBox.Show("3. Kişi Girilmedi");
                }
            }
        }
        public void Kaydet4(string giristarihi, string cikistarihi)
        {
            string cikis = cikistarihi;
            string giris = giristarihi;
            if (TC4 == false)
            {
                if (DortTCNo.Text.Length == 11 && DortAdiSoyadi.Text.Length >= 3 && DortTelefon.Text.Length >= 9 && (UcCinsiyet.Text == "Erkek" || UcCinsiyet.Text == "Kadın"))
                {
                    Ayarlar.BaglantiAc();
                    SqlCommand kmt = new SqlCommand("Insert into  MisafirKayit(TCKimlik, AdSoyad, Telefon, Cinsiyet) VALUES  ('" + DortTCNo.Text + "','" + DortAdiSoyadi.Text + "','" + DortTelefon.Text + "','" + DortCinsiyet.Text + "'); select scope_identity()", Ayarlar.baglanti);
                    SonKayitID4 = kmt.ExecuteScalar().ToString();
                    SqlCommand kmt2 = new SqlCommand("Insert into HangiOdada(OdaID,MusteriID,GirisTarihi,CikisTarihi,Durum) Values('" + Convert.ToString(OdaNumarasiSecimi) + "','" + SonKayitID4 + "','" + giris + "','" + cikis + "','Giriş')", Ayarlar.baglanti);
                    kmt2.ExecuteNonQuery();
                    Ayarlar.BaglantiKapat();
                    MisafirEkle[3] = "1";
                    RezervasyonKayit[3] = "1";
                }
            }
            else
            {
                if (DortTCNo.Text.Length == 11 && DortAdiSoyadi.Text.Length >= 3 && DortTelefon.Text.Length >= 9 && (DortCinsiyet.Text == "Erkek" || DortCinsiyet.Text == "Kadın"))
                {
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    SqlCommand komut = new SqlCommand("Select TOP 1 ID from MisafirKayit where TCKimlik='" + BirTCNo.Text + "'", Ayarlar.baglanti);
                    SqlDataAdapter adp = new SqlDataAdapter(komut);
                    adp.Fill(tablo);
                    if (tablo.Rows.Count > 0)
                    {
                        id4 = tablo.Rows[0]["ID"].ToString();
                        SqlCommand kmt2 = new SqlCommand("Insert into HangiOdada (OdaID,MusteriID,GirisTarihi,CikisTarihi,Durum) Values('" + OdaNumarasiSecimi + "','" + id1 + "','" + giris + "','" + cikis + "','Giriş')", Ayarlar.baglanti);
                        kmt2.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Sırasında Bir Hata Meydana Geldi.");
                    }
                    Ayarlar.BaglantiKapat();
                    RezervasyonKayit[3] = "1";

                }
                else
                {
                    MessageBox.Show("4. Kişi Girilmedi");
                }
            }
        }
        public void Kaydet5(string giristarihi, string cikistarihi)
        {
            string cikis = cikistarihi;
            string giris = giristarihi;
            if (TC5 == false)
            {
                if (BesTCNo.Text.Length == 11 && BesAdiSoyadi.Text.Length >= 3 && BesTelefon.Text.Length >= 9 && (BesCinsiyet.Text == "Erkek" || BesCinsiyet.Text == "Kadın"))
                {
                    Ayarlar.BaglantiAc();
                    SqlCommand kmt = new SqlCommand("Insert into  MisafirKayit(TCKimlik, AdSoyad, Telefon, Cinsiyet) VALUES  ('" + BesTCNo.Text + "','" + BesAdiSoyadi.Text + "','" + BesTelefon.Text + "','" + BesCinsiyet.Text + "'); select scope_identity()", Ayarlar.baglanti);
                    SonKayitID5 = kmt.ExecuteScalar().ToString();
                    SqlCommand kmt2 = new SqlCommand("Insert into HangiOdada(OdaID,MusteriID,GirisTarihi,CikisTarihi,Durum) Values('" + Convert.ToString(OdaNumarasiSecimi) + "','" + SonKayitID5 + "','" + giris + "','" + cikis + "','Giriş')", Ayarlar.baglanti);
                    kmt2.ExecuteNonQuery();
                    Ayarlar.BaglantiKapat();
                    MisafirEkle[4] = "1";
                    RezervasyonKayit[4] = "1";
                }
            }
            else
            {
                if (BesTCNo.Text.Length == 11 && BesAdiSoyadi.Text.Length >= 3 && BesTelefon.Text.Length >= 9 && (BesCinsiyet.Text == "Erkek" || BesCinsiyet.Text == "Kadın"))
                {
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    SqlCommand komut = new SqlCommand("Select TOP 1 ID from MisafirKayit where TCKimlik='" + BirTCNo.Text + "'", Ayarlar.baglanti);
                    SqlDataAdapter adp = new SqlDataAdapter(komut);
                    adp.Fill(tablo);
                    if (tablo.Rows.Count > 0)
                    {
                        id5 = tablo.Rows[0]["ID"].ToString();
                        SqlCommand kmt2 = new SqlCommand("Insert into HangiOdada (OdaID,MusteriID,GirisTarihi,CikisTarihi,Durum) Values('" + OdaNumarasiSecimi + "','" + id1 + "','" + giris + "','" + cikis + "','Giriş')", Ayarlar.baglanti);
                        kmt2.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Sırasında Bir Hata Meydana Geldi.");
                    }
                    Ayarlar.BaglantiKapat();
                    RezervasyonKayit[4] = "1";

                }
                else
                {
                    MessageBox.Show("5. Kişi Girilmedi");
                }
            }
        }
        public void MisafirKaydet(string TCKimlik, string AdSoyad, string Telefon, string Cinsiyet)
        {

        }
        private void MisafirGiris_Load(object sender, EventArgs e)
        {
            KisiAdedi.Focus();
            KayitListesiDoldur();
            GirisTarihi.Enabled = false;
            CikisTarihi.Enabled = false;
            OdaNumarasi.Enabled = false;
            groupBox2.Visible = false;
            OdaLimiti.Enabled = false;
            BirAdiSoyadi.Enabled = false;
            BirTelefon.Enabled = false;
            BirCinsiyet.Enabled = false;
            IkiAdiSoyadi.Enabled = false;
            IkiTelefon.Enabled = false;
            IkiCinsiyet.Enabled = false;
            UcAdiSoyadi.Enabled = false;
            UcTelefon.Enabled = false;
            UcCinsiyet.Enabled = false;
            DortAdiSoyadi.Enabled = false;
            DortTelefon.Enabled = false;
            DortCinsiyet.Enabled = false;
            BesAdiSoyadi.Enabled = false;
            BesTelefon.Enabled = false;
            BesCinsiyet.Enabled = false;
        }
        private void Kaydet_Click(object sender, EventArgs e)
        {
            OdaNumarasiSec();
            int sayfasayisi = tabControl1.TabPages.Count;
            if (TC1 == true || TC2 == true || TC3 == true || TC4 == true || TC5 == true)
            {
                string KaydetGiris = String.Format("{0:yyyy-MM-dd}", GirisTarihi.Value);
                string KaydetCikis = String.Format("{0:yyyy-MM-dd}", CikisTarihi.Value);
                switch (sayfasayisi)
                {
                    case 1:
                        Kaydet1(KaydetGiris, KaydetCikis);
                        break;
                    case 2:
                        Kaydet1(KaydetGiris, KaydetCikis);
                        Kaydet2(KaydetGiris, KaydetCikis);
                        break;
                    case 3:
                        Kaydet1(KaydetGiris, KaydetCikis);
                        Kaydet2(KaydetGiris, KaydetCikis);
                        Kaydet3(KaydetGiris, KaydetCikis);
                        break;
                    case 4:
                        Kaydet1(KaydetGiris, KaydetCikis);
                        Kaydet2(KaydetGiris, KaydetCikis);
                        Kaydet3(KaydetGiris, KaydetCikis);
                        Kaydet4(KaydetGiris, KaydetCikis);
                        break;
                    case 5:
                        Kaydet1(KaydetGiris, KaydetCikis);
                        Kaydet2(KaydetGiris, KaydetCikis);
                        Kaydet3(KaydetGiris, KaydetCikis);
                        Kaydet4(KaydetGiris, KaydetCikis);
                        Kaydet5(KaydetGiris, KaydetCikis);
                        break;
                    default:
                        MessageBox.Show("Hata Var Ulann!");
                        break;
                }
            }
            else if (TC1 == false || TC2 == false || TC3 == false || TC4 == false || TC5 == false)
            {
                string KaydetGiris = String.Format("{0:yyyy-MM-dd}", GirisTarihi.Value);
                string KaydetCikis = String.Format("{0:yyyy-MM-dd}", CikisTarihi.Value);

                switch (sayfasayisi)
                {
                    case 1:
                        Kaydet1(KaydetGiris, KaydetCikis);
                        break;
                    case 2:
                        Kaydet1(KaydetGiris, KaydetCikis);
                        Kaydet2(KaydetGiris, KaydetCikis);
                        break;
                    case 3:
                        Kaydet1(KaydetGiris, KaydetCikis);
                        Kaydet2(KaydetGiris, KaydetCikis);
                        Kaydet3(KaydetGiris, KaydetCikis);
                        break;
                    case 4:
                        Kaydet1(KaydetGiris, KaydetCikis);
                        Kaydet2(KaydetGiris, KaydetCikis);
                        Kaydet3(KaydetGiris, KaydetCikis);
                        Kaydet4(KaydetGiris, KaydetCikis);
                        break;
                    case 5:
                        Kaydet1(KaydetGiris, KaydetCikis);
                        Kaydet2(KaydetGiris, KaydetCikis);
                        Kaydet3(KaydetGiris, KaydetCikis);
                        Kaydet4(KaydetGiris, KaydetCikis);
                        Kaydet5(KaydetGiris, KaydetCikis);
                        break;
                    default:
                        MessageBox.Show("Hata Var Ulann!");
                        break;
                }
                MessageBox.Show("Kayıt Gerçekleştirildi");
            }
            else
            {
                MessageBox.Show("Hiç Bir Kayıt Girilmedi.");
            }

        }
        private void KisiAdedi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(KisiAdedi.Text) > 0 && int.Parse(KisiAdedi.Text) < 6)
            {
                GirisTarihi.Enabled = true;
                CikisTarihi.Enabled = true;
                OdaDoldur(String.Format("{0:yyyy-MM-dd}", GirisTarihi.Value), String.Format("{0:yyyy-MM-dd}", CikisTarihi.Value), KisiAdedi.Text);
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
                OdaDoldur(String.Format("{0:yyyy-MM-dd}", GirisTarihi.Value), String.Format("{0:yyyy-MM-dd}", CikisTarihi.Value), KisiAdedi.Text);
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
            OdaDoldur(String.Format("{0:yyyy-MM-dd}", GirisTarihi.Value), String.Format("{0:yyyy-MM-dd}", CikisTarihi.Value), KisiAdedi.Text);
        }
        private void CikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (CikisTarihi.Value < GirisTarihi.Value)
            {
                TarihKontrol();
                MessageBox.Show("Çıkış Tarihi Giriş Tarihinden Önce Olamaz.");
                OdaDoldur(String.Format("{0:yyyy-MM-dd}", GirisTarihi.Value), String.Format("{0:yyyy-MM-dd}", CikisTarihi.Value), KisiAdedi.Text);
            }
            else
            {
                OdaNumarasi.Enabled = true;
                OdaDoldur(String.Format("{0:yyyy-MM-dd}", GirisTarihi.Value), String.Format("{0:yyyy-MM-dd}", CikisTarihi.Value), KisiAdedi.Text);
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
                if (BirTCNo.Text == IkiTCNo.Text ||
                    BirTCNo.Text == UcTCNo.Text ||
                    BirTCNo.Text == DortTCNo.Text ||
                    BirTCNo.Text == BesTCNo.Text)
                {
                    MessageBox.Show("Aynı Kişiyi Girdiniz!");
                    BirTCNo.Text = "";
                }
                else
                {
                    BirAdiSoyadi.Enabled = true;
                    BirTelefon.Enabled = true;
                    BirCinsiyet.Enabled = true;
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    SqlCommand komut = new SqlCommand("Select TOP 1 AdSoyad, Telefon ,Cinsiyet from MisafirKayit where TCKimlik='" + BirTCNo.Text + "'", Ayarlar.baglanti);
                    SqlDataAdapter adp = new SqlDataAdapter(komut);
                    adp.Fill(tablo);
                    if (tablo.Rows.Count > 0)
                    {
                        BirAdiSoyadi.Text = tablo.Rows[0]["AdSoyad"].ToString();
                        BirTelefon.Text = tablo.Rows[0]["Telefon"].ToString();
                        BirCinsiyet.Text = tablo.Rows[0]["Cinsiyet"].ToString();
                        TC1 = true;
                    }
                    else
                    {
                        BirAdiSoyadi.Clear();
                        BirTelefon.Clear();
                        BirCinsiyet.ResetText();
                    }
                    Ayarlar.BaglantiKapat();
                }
            }
            else
            {
                BirAdiSoyadi.Clear();
                BirTelefon.Clear();
                BirCinsiyet.ResetText();
                BirAdiSoyadi.Enabled = false;
                BirTelefon.Enabled = false;
                BirCinsiyet.Enabled = false;
            }
        }
        private void IkiTCNo_TextChanged(object sender, EventArgs e)
        {
            if (IkiTCNo.Text != "")
            {
                if (!double.TryParse(IkiTCNo.Text, out deger2))
                {
                    MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                    IkiTCNo.Text = "";
                }
            }
            if (IkiTCNo.Text.Length == 11)
            {
                if (IkiTCNo.Text == BirTCNo.Text ||
                    IkiTCNo.Text == UcTCNo.Text ||
                    IkiTCNo.Text == DortTCNo.Text ||
                    IkiTCNo.Text == BesTCNo.Text)
                {
                    MessageBox.Show("Aynı Kişiyi Girdiniz!");
                    IkiTCNo.Text = "";
                }
                else
                {
                    IkiAdiSoyadi.Enabled = true;
                    IkiTelefon.Enabled = true;
                    IkiCinsiyet.Enabled = true;
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    SqlCommand komut = new SqlCommand("Select TOP 1 AdSoyad, Telefon ,Cinsiyet from MisafirKayit where TCKimlik='" + IkiTCNo.Text + "'", Ayarlar.baglanti);
                    SqlDataAdapter adp = new SqlDataAdapter(komut);
                    adp.Fill(tablo);

                    if (tablo.Rows.Count > 0)
                    {
                        IkiAdiSoyadi.Text = tablo.Rows[0]["AdSoyad"].ToString();
                        IkiTelefon.Text = tablo.Rows[0]["Telefon"].ToString();
                        IkiCinsiyet.Text = tablo.Rows[0]["Cinsiyet"].ToString();
                        TC2 = true;

                    }
                    else
                    {
                        IkiAdiSoyadi.Clear();
                        IkiTelefon.Clear();
                        IkiCinsiyet.ResetText();
                    }

                    Ayarlar.BaglantiKapat();
                }
            }
            else
            {
                IkiAdiSoyadi.Clear();
                IkiTelefon.Clear();
                IkiCinsiyet.ResetText();
                IkiAdiSoyadi.Enabled = false;
                IkiTelefon.Enabled = false;
                IkiCinsiyet.Enabled = false;
            }
        }
        private void UcTCNo_TextChanged(object sender, EventArgs e)
        {
            if (UcTCNo.Text != "")
            {
                if (!double.TryParse(UcTCNo.Text, out deger3))
                {
                    MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                    UcTCNo.Text = "";
                }
            }
            if (UcTCNo.Text.Length == 11)
            {
                if (UcTCNo.Text == IkiTCNo.Text ||
                    UcTCNo.Text == BirTCNo.Text ||
                    UcTCNo.Text == DortTCNo.Text ||
                    UcTCNo.Text == BesTCNo.Text)
                {
                    MessageBox.Show("Aynı Kişiyi Girdiniz!");
                    UcTCNo.Text = "";
                }
                else
                {
                    UcAdiSoyadi.Enabled = true;
                    UcTelefon.Enabled = true;
                    UcCinsiyet.Enabled = true;
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    SqlCommand komut = new SqlCommand("Select TOP 1 AdSoyad, Telefon ,Cinsiyet from MisafirKayit where TCKimlik='" + UcTCNo.Text + "'", Ayarlar.baglanti);
                    SqlDataAdapter adp = new SqlDataAdapter(komut);
                    adp.Fill(tablo);
                    if (tablo.Rows.Count > 0)
                    {
                        UcAdiSoyadi.Text = tablo.Rows[0]["AdSoyad"].ToString();
                        UcTelefon.Text = tablo.Rows[0]["Telefon"].ToString();
                        UcCinsiyet.Text = tablo.Rows[0]["Cinsiyet"].ToString();
                        TC3 = true;
                    }
                    else
                    {
                        UcAdiSoyadi.Clear();
                        UcTelefon.Clear();
                        UcCinsiyet.ResetText();
                    }

                    Ayarlar.BaglantiKapat();
                }

            }
            else
            {
                UcAdiSoyadi.Clear();
                UcTelefon.Clear();
                UcCinsiyet.ResetText();
                UcAdiSoyadi.Enabled = false;
                UcTelefon.Enabled = false;
                UcCinsiyet.Enabled = false;
            }
        }
        private void DortTCNo_TextChanged(object sender, EventArgs e)
        {
            if (DortTCNo.Text != "")
            {
                if (!double.TryParse(DortTCNo.Text, out deger4))
                {
                    MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                    DortTCNo.Text = "";
                }
            }
            if (DortTCNo.Text.Length == 11)
            {
                if (DortTCNo.Text == IkiTCNo.Text ||
                    DortTCNo.Text == BirTCNo.Text ||
                    DortTCNo.Text == UcTCNo.Text ||
                    DortTCNo.Text == BesTCNo.Text)
                {
                    MessageBox.Show("Aynı Kişiyi Girdiniz!");
                    DortTCNo.Text = "";
                }
                else
                {
                    DortAdiSoyadi.Enabled = true;
                    DortTelefon.Enabled = true;
                    DortCinsiyet.Enabled = true;
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    SqlCommand komut = new SqlCommand("Select TOP 1 AdSoyad, Telefon ,Cinsiyet from MisafirKayit where TCKimlik='" + DortTCNo.Text + "'", Ayarlar.baglanti);
                    SqlDataAdapter adp = new SqlDataAdapter(komut);
                    adp.Fill(tablo);

                    if (tablo.Rows.Count > 0)
                    {
                        DortAdiSoyadi.Text = tablo.Rows[0]["AdSoyad"].ToString();
                        DortTelefon.Text = tablo.Rows[0]["Telefon"].ToString();
                        DortCinsiyet.Text = tablo.Rows[0]["Cinsiyet"].ToString();
                        TC4 = true;

                    }
                    else
                    {
                        DortAdiSoyadi.Clear();
                        DortTelefon.Clear();
                        DortCinsiyet.ResetText();
                    }

                    Ayarlar.BaglantiKapat();
                }

            }
            else
            {
                DortAdiSoyadi.Clear();
                DortTelefon.Clear();
                DortCinsiyet.ResetText();
                DortAdiSoyadi.Enabled = false;
                DortTelefon.Enabled = false;
                DortCinsiyet.Enabled = false;
            }
        }
        private void BesTCNo_TextChanged(object sender, EventArgs e)
        {
            if (BesTCNo.Text != "")
            {
                if (!double.TryParse(BesTCNo.Text, out deger5))
                {
                    MessageBox.Show("Bu alana sadece rakam girişi yapınız.");
                    BesTCNo.Clear();
                }
            }
            if (BesTCNo.Text.Length == 11)
            {
                if (BesTCNo.Text == IkiTCNo.Text ||
                    BesTCNo.Text == BirTCNo.Text ||
                    BesTCNo.Text == UcTCNo.Text ||
                    BesTCNo.Text == DortTCNo.Text)
                {
                    MessageBox.Show("Aynı Kişiyi Girdiniz!");
                    BesTCNo.Text = "";
                }
                else
                {
                    BesAdiSoyadi.Enabled = true;
                    BesTelefon.Enabled = true;
                    BesCinsiyet.Enabled = true;
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    SqlCommand komut = new SqlCommand("Select TOP 1 AdSoyad, Telefon ,Cinsiyet from MisafirKayit where TCKimlik='" + BesTCNo.Text + "'", Ayarlar.baglanti);
                    SqlDataAdapter adp = new SqlDataAdapter(komut);
                    adp.Fill(tablo);

                    if (tablo.Rows.Count > 0)
                    {
                        BesAdiSoyadi.Text = tablo.Rows[0]["AdSoyad"].ToString();
                        BesTelefon.Text = tablo.Rows[0]["Telefon"].ToString();
                        BesCinsiyet.Text = tablo.Rows[0]["Cinsiyet"].ToString();
                        TC5 = true;

                    }
                    else
                    {
                        BesAdiSoyadi.Clear();
                        BesTelefon.Clear();
                        BesCinsiyet.ResetText();
                        BesAdiSoyadi.Enabled = false;
                        BesTelefon.Enabled = false;
                        BesCinsiyet.Enabled = false;
                    }

                    Ayarlar.BaglantiKapat();
                }

            }
            else
            {
                BesAdiSoyadi.Clear();
                BesTelefon.Clear();
                BesCinsiyet.ResetText();
            }
            if (BesTCNo.Text.Length == 11)
            {
                BesAdiSoyadi.Enabled = true;
                BesTelefon.Enabled = true;
                BesCinsiyet.Enabled = true;
            }
        }
        private void OdaNumarasi_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        private void OdaNumarasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odalimit = OdaNumarasi.Text.Substring(0, 1);
            switch (odalimit)
            {
                case "1":
                    OdaLimiti.Text = "2";
                    TabKontrol();
                    break;
                case "2":
                    OdaLimiti.Text = "3";
                    TabKontrol();
                    break;
                case "3":
                    OdaLimiti.Text = "4";
                    TabKontrol();
                    break;
                case "4":
                    OdaLimiti.Text = "5";
                    TabKontrol();
                    break;
                case "5":
                    OdaLimiti.Text = "6";
                    TabKontrol();
                    break;
                default:
                    MessageBox.Show("Neyin Peşindesin :@");
                    break;
            }
        }
        public void KayitListesiDoldur()
        {

            try
            {
                Ayarlar.BaglantiAc();
                DataTable tablo = new DataTable();
                tablo.Clear();
                SqlCommand komut = new SqlCommand("Select HO.ID,MK.TCKimlik,MK.AdSoyad,MK.Telefon,MK.Cinsiyet,HO.GirisTarihi,HO.CikisTarihi,HO.Durum from MisafirKayit as MK inner join HangiOdada as HO on (MK.ID=HO.MusteriID) where HO.Durum='Giriş' or HO.Durum='Çıkış'", Ayarlar.baglanti);
                SqlDataAdapter veriler = new SqlDataAdapter(komut);
                veriler.Fill(tablo);
                KayitListesi.DataSource = tablo;
                this.KayitListesi.Columns[0].Width = 40;
                this.KayitListesi.Columns[1].Width = 80;
                this.KayitListesi.Columns[2].Width = 120;
                this.KayitListesi.Columns[3].Width = 90;
                this.KayitListesi.Columns[4].Width = 60;
                this.KayitListesi.Columns[5].Width = 75;
                this.KayitListesi.Columns[6].Width = 75;
                this.KayitListesi.Columns[7].Width = 54;
                Ayarlar.BaglantiKapat();
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        private void KayıtListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void KayitCikis_Click(object sender, EventArgs e)
        {

            if (KayitListesi.SelectedRows.Count > 0)
            {
                DialogResult kontrol;
                kontrol = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kontrol == DialogResult.Yes)
                {
                    int selectedIndex = KayitListesi.SelectedRows[0].Index;
                    int rowID = int.Parse(KayitListesi[0, selectedIndex].Value.ToString());
                    Ayarlar.BaglantiAc();
                    SqlCommand kmt2 = new SqlCommand("update HangiOdada set Durum='Çıkış' where ID=" + rowID + "", Ayarlar.baglanti);
                    kmt2.ExecuteNonQuery();
                    Ayarlar.BaglantiKapat();
                    KayitListesiDoldur();
                    MessageBox.Show("Çıkış Yapıldı!");
                    KLTCKimlik.Enabled = true;
                    KLAdSoyad.Enabled = true;
                    KLTelefon.Enabled = true;
                    KLCinsiyet.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Çıkış Yapılmadı!");
                }
            }
            else
            {
                MessageBox.Show("Satır Seçmediniz!");
            }
        }
        private void KLTCKimlik_TextChanged(object sender, EventArgs e)
        {
            if (KLTCKimlik.Text.Length > 0)
            {
                try
                {
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    tablo.Clear();
                    SqlCommand komut = new SqlCommand("Select HO.ID,MK.TCKimlik,MK.AdSoyad,MK.Telefon,MK.Cinsiyet,HO.GirisTarihi,HO.CikisTarihi,HO.Durum from MisafirKayit as MK inner join HangiOdada as HO on (MK.ID=HO.MusteriID) where MK.TCKimlik Like '%" + KLTCKimlik.Text + "%' and  MK.AdSoyad Like '%" + KLAdSoyad.Text + "%' and  MK.Telefon Like '%" + KLTelefon.Text + "%' and  MK.Cinsiyet Like '%" + KLCinsiyet.Text + "%' order by HO.ID desc", Ayarlar.baglanti);
                    SqlDataAdapter veriler = new SqlDataAdapter(komut);
                    veriler.Fill(tablo);
                    KayitListesi.DataSource = tablo;
                    this.KayitListesi.Columns[0].Width = 40;
                    this.KayitListesi.Columns[1].Width = 80;
                    this.KayitListesi.Columns[2].Width = 120;
                    this.KayitListesi.Columns[3].Width = 90;
                    this.KayitListesi.Columns[4].Width = 60;
                    this.KayitListesi.Columns[5].Width = 75;
                    this.KayitListesi.Columns[6].Width = 75;
                    this.KayitListesi.Columns[7].Width = 54;
                    Ayarlar.BaglantiKapat();
                }
                catch (SqlException hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }
        private void KLAdSoyad_TextChanged(object sender, EventArgs e)
        {
            if (KLAdSoyad.Text.Length > 0)
            {
                try
                {
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    tablo.Clear();
                    SqlCommand komut = new SqlCommand("Select HO.ID,MK.TCKimlik,MK.AdSoyad,MK.Telefon,MK.Cinsiyet,HO.GirisTarihi,HO.CikisTarihi,HO.Durum from MisafirKayit as MK inner join HangiOdada as HO on (MK.ID=HO.MusteriID) where MK.TCKimlik Like '%" + KLTCKimlik.Text + "%' and  MK.AdSoyad Like '%" + KLAdSoyad.Text + "%' and  MK.Telefon Like '%" + KLTelefon.Text + "%' and  MK.Cinsiyet Like '%" + KLCinsiyet.Text + "%' order by HO.ID desc", Ayarlar.baglanti);
                    SqlDataAdapter veriler = new SqlDataAdapter(komut);
                    veriler.Fill(tablo);
                    KayitListesi.DataSource = tablo;
                    this.KayitListesi.Columns[0].Width = 40;
                    this.KayitListesi.Columns[1].Width = 80;
                    this.KayitListesi.Columns[2].Width = 120;
                    this.KayitListesi.Columns[3].Width = 90;
                    this.KayitListesi.Columns[4].Width = 60;
                    this.KayitListesi.Columns[5].Width = 75;
                    this.KayitListesi.Columns[6].Width = 75;
                    this.KayitListesi.Columns[7].Width = 54;
                    Ayarlar.BaglantiKapat();
                }
                catch (SqlException hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }
        private void KLTelefon_TextChanged(object sender, EventArgs e)
        {
            if (KLTelefon.Text.Length > 0)
            {
                try
                {
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    tablo.Clear();
                    SqlCommand komut = new SqlCommand("Select HO.ID,MK.TCKimlik,MK.AdSoyad,MK.Telefon,MK.Cinsiyet,HO.GirisTarihi,HO.CikisTarihi,HO.Durum from MisafirKayit as MK inner join HangiOdada as HO on (MK.ID=HO.MusteriID) where MK.TCKimlik Like '%" + KLTCKimlik.Text + "%' and  MK.AdSoyad Like '%" + KLAdSoyad.Text + "%' and  MK.Telefon Like '%" + KLTelefon.Text + "%' and  MK.Cinsiyet Like '%" + KLCinsiyet.Text + "%' order by HO.ID desc", Ayarlar.baglanti);
                    SqlDataAdapter veriler = new SqlDataAdapter(komut);
                    veriler.Fill(tablo);
                    KayitListesi.DataSource = tablo;
                    this.KayitListesi.Columns[0].Width = 40;
                    this.KayitListesi.Columns[1].Width = 80;
                    this.KayitListesi.Columns[2].Width = 120;
                    this.KayitListesi.Columns[3].Width = 90;
                    this.KayitListesi.Columns[4].Width = 60;
                    this.KayitListesi.Columns[5].Width = 75;
                    this.KayitListesi.Columns[6].Width = 75;
                    this.KayitListesi.Columns[7].Width = 54;
                    Ayarlar.BaglantiKapat();
                }
                catch (SqlException hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }
        private void KLCinsiyet_TextChanged(object sender, EventArgs e)
        {
            if (KLCinsiyet.Text.Length > 0)
            {
                try
                {
                    Ayarlar.BaglantiAc();
                    DataTable tablo = new DataTable();
                    tablo.Clear();
                    SqlCommand komut = new SqlCommand("Select HO.ID,MK.TCKimlik,MK.AdSoyad,MK.Telefon,MK.Cinsiyet,HO.GirisTarihi,HO.CikisTarihi,HO.Durum from MisafirKayit as MK inner join HangiOdada as HO on (MK.ID=HO.MusteriID) where MK.TCKimlik Like '%" + KLTCKimlik.Text + "%' and  MK.AdSoyad Like '%" + KLAdSoyad.Text + "%' and  MK.Telefon Like '%" + KLTelefon.Text + "%' and  MK.Cinsiyet Like '%" + KLCinsiyet.Text + "%' order by HO.ID desc", Ayarlar.baglanti);
                    SqlDataAdapter veriler = new SqlDataAdapter(komut);
                    veriler.Fill(tablo);
                    KayitListesi.DataSource = tablo;
                    this.KayitListesi.Columns[0].Width = 40;
                    this.KayitListesi.Columns[1].Width = 80;
                    this.KayitListesi.Columns[2].Width = 120;
                    this.KayitListesi.Columns[3].Width = 90;
                    this.KayitListesi.Columns[4].Width = 60;
                    this.KayitListesi.Columns[5].Width = 75;
                    this.KayitListesi.Columns[6].Width = 75;
                    this.KayitListesi.Columns[7].Width = 54;
                    Ayarlar.BaglantiKapat();
                }
                catch (SqlException hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void BosOdalarListele_Click(object sender, EventArgs e)
        {
            KLTCKimlik.Enabled = false;
            KLAdSoyad.Enabled = false;
            KLTelefon.Enabled = false;
            KLCinsiyet.Enabled = false;
            try
            {
                Ayarlar.BaglantiAc();
                DataTable tablo = new DataTable();
                tablo.Clear();
                SqlCommand komut = new SqlCommand("SELECT Odalar.ID, Odalar.Isim, Odalar.Limit from HangiOdada right JOIN Odalar ON HangiOdada.OdaID = Odalar.ID where OdaID is null", Ayarlar.baglanti);
                SqlDataAdapter veriler = new SqlDataAdapter(komut);
                veriler.Fill(tablo);
                KayitListesi.DataSource = tablo;
                this.KayitListesi.Columns[0].Width = 40;
                this.KayitListesi.Columns[1].Width = 80;
                this.KayitListesi.Columns[2].Width = 120;
                Ayarlar.BaglantiKapat();
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }
                

        }

        private void DoluOdalarListele_Click(object sender, EventArgs e)
        {

            KLTCKimlik.Enabled = false;
            KLAdSoyad.Enabled = false;
            KLTelefon.Enabled = false;
            KLCinsiyet.Enabled = false;
            try
            {
                Ayarlar.BaglantiAc();
                DataTable tablo = new DataTable();
                tablo.Clear();
                SqlCommand komut = new SqlCommand("select HO.ID,MK.TCKimlik,MK.Telefon,MK.AdSoyad,MK.Telefon,MK.Cinsiyet,HO.GirisTarihi,HO.CikisTarihi,HO.Durum from (select ID,TCKimlik,Telefon,AdSoyad,Cinsiyet from MisafirKayit) as MK inner join HangiOdada HO on (MK.ID=HO.MusteriID) where HO.Durum like '%Giriş%'", Ayarlar.baglanti);
                SqlDataAdapter veriler = new SqlDataAdapter(komut);
                veriler.Fill(tablo);
                KayitListesi.DataSource = tablo;
                this.KayitListesi.Columns[0].Width = 40;
                this.KayitListesi.Columns[1].Width = 80;
                this.KayitListesi.Columns[2].Width = 120;
                this.KayitListesi.Columns[3].Width = 90;
                this.KayitListesi.Columns[4].Width = 60;
                this.KayitListesi.Columns[5].Width = 75;
                this.KayitListesi.Columns[6].Width = 75;
                this.KayitListesi.Columns[7].Width = 54;
                Ayarlar.BaglantiKapat();
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void BugunCikis_Click(object sender, EventArgs e)
        {

            KLTCKimlik.Enabled = false;
            KLAdSoyad.Enabled = false;
            KLTelefon.Enabled = false;
            KLCinsiyet.Enabled = false;
            try
            {
                Ayarlar.BaglantiAc();
                DataTable tablo = new DataTable();
                tablo.Clear();
                SqlCommand komut = new SqlCommand("select HO.ID,MK.TCKimlik,MK.Telefon,MK.AdSoyad,MK.Cinsiyet,HO.GirisTarihi,HO.CikisTarihi,HO.Durum from (select ID,TCKimlik,Telefon,AdSoyad,Cinsiyet from MisafirKayit) as MK inner join HangiOdada HO on (MK.ID=HO.MusteriID) where HO.Durum like '%Giriş%' and (HO.CikisTarihi like CONVERT(VARCHAR(10), GETDATE(), 102))", Ayarlar.baglanti);
                SqlDataAdapter veriler = new SqlDataAdapter(komut);
                veriler.Fill(tablo);
                KayitListesi.DataSource = tablo;
                this.KayitListesi.Columns[0].Width = 40;
                this.KayitListesi.Columns[1].Width = 80;
                this.KayitListesi.Columns[2].Width = 120;
                this.KayitListesi.Columns[3].Width = 90;
                this.KayitListesi.Columns[4].Width = 60;
                this.KayitListesi.Columns[5].Width = 75;
                this.KayitListesi.Columns[6].Width = 75;
                this.KayitListesi.Columns[7].Width = 54;
                Ayarlar.BaglantiKapat();
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void TumKayitlar_Click(object sender, EventArgs e)
        {
            KayitListesiDoldur();
            KLTCKimlik.Enabled = true;
            KLAdSoyad.Enabled = true;
            KLCinsiyet.Enabled = true;
            KLTelefon.Enabled = true;
        }
    }
}
