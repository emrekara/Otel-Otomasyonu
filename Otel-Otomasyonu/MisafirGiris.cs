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
    public partial class MisafirGiris : Form
    {
        public MisafirGiris()
        {
            InitializeComponent();
        }
        
        private void MisafirGiris_Load(object sender, EventArgs e)
        {
            DataTable veriler = new DataTable();


            MisafirListesi.View = View.Details;

            MisafirListesi.Columns.Clear();
            MisafirListesi.Columns.Add("TC Kimlik No", 80, HorizontalAlignment.Left);
            MisafirListesi.Columns.Add("Adı Soyadı", 70, HorizontalAlignment.Left);
            MisafirListesi.Columns.Add("Giris Tarihi", 100, HorizontalAlignment.Left);
            MisafirListesi.Columns.Add("Çıkış Tarihi", 100, HorizontalAlignment.Left);
            MisafirListesi.Columns.Add("Oda Numarası", 60, HorizontalAlignment.Left);
            MisafirListesi.Columns.Add("Oda Ücreti", 60, HorizontalAlignment.Left);
            MisafirListesi.Columns.Add("Misafir Durumu", 80, HorizontalAlignment.Left);

            try
            {
                Ayarlar.BaglantiAc();

                SqlCommand komut = new SqlCommand("Select * from MisafirKayit order by ID desc", Ayarlar.baglanti);

                SqlDataAdapter tablo = new SqlDataAdapter(komut);

                tablo.Fill(veriler);

                MisafirListesi.Items.Clear();

                for (int i = 0; i < veriler.Rows.Count; i++)
                {
                    DataRow satir = veriler.Rows[i];

                    if (satir.RowState != DataRowState.Deleted)
                    {
                        ListViewItem item = new ListViewItem(satir["TCKimlikNo"].ToString());
                        item.SubItems.Add(satir["AdSoyad"].ToString());
                        item.SubItems.Add(satir["GirisTarihi"].ToString());
                        item.SubItems.Add(satir["CikisTarihi"].ToString());
                        item.SubItems.Add(satir["OdaNumarasi"].ToString());
                        item.SubItems.Add(satir["OdaUcreti"].ToString());
                        item.SubItems.Add(satir["MisafirDurumu"].ToString());

                        MisafirListesi.Items.Add(item);
                    }
                }

                Ayarlar.BaglantiKapat();

            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }

        }
    }
}
