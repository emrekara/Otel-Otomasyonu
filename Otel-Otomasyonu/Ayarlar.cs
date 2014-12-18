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
    class Ayarlar
    {

        public static SqlConnection baglanti;

        public static void BaglantiAc()
        {
            baglanti = new SqlConnection("SERVER=EmreKara\\EMRE; Database=Otel; Integrated Security=true;");
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

        }

        public static void KullaniciGiris(string k_adi, string sifre)
        {
            DataTable veriler = new DataTable();
            string kullanici_adi = k_adi, kullanici_sifre = sifre;
            BaglantiAc();
            string GirisKontrol="select PersonelTCNo from PersonelBilgi where PersonelTCNo = '"+kullanici_adi+"'";
            SqlCommand kullanici_adi_sorgu = new SqlCommand(GirisKontrol, baglanti);
            

            if (kullanici_adi.Length>=11)
            {
                MessageBox.Show(kullanici_adi_sorgu.ToString());
            }
            else
            {
                MessageBox.Show("sads");
            }
        }

        public static void BaglantiKapat()
        {
            baglanti.Close();
        }

    }
}
