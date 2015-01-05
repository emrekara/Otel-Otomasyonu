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

namespace Otel_Otomasyonu
{
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void BosOdalarDoldur()
        {
            DoluOdalar.View = View.Details;
            DoluOdalar.Columns.Clear();
            DoluOdalar.Columns.Add("Oda ID", 50, HorizontalAlignment.Left);
            DoluOdalar.Columns.Add("Oda No", 60, HorizontalAlignment.Left);
            DoluOdalar.Columns.Add("Giriş Tarihi", 140, HorizontalAlignment.Left);
            DoluOdalar.Columns.Add("Çıkış Tarihi", 140, HorizontalAlignment.Left);
            try
            {
                Ayarlar.BaglantiAc();
                DataTable veriler = new DataTable();
                SqlCommand komut = new SqlCommand("select o.ID,o.Isim,ho.GirisTarihi,ho.CikisTarihi,ho.OdaID from Odalar as o left join HangiOdada as ho on o.ID=ho.OdaID where ho.GirisTarihi< convert(varchar, getdate(), 102)  or ho.CikisTarihi> convert(varchar, getdate(), 102)", Ayarlar.baglanti);

                SqlDataAdapter tablo = new SqlDataAdapter(komut);

                tablo.Fill(veriler);

                DoluOdalar.Items.Clear();

                for (int i = 0; i < veriler.Rows.Count; i++)
                {
                    DataRow satir = veriler.Rows[i];

                    if (satir.RowState != DataRowState.Deleted)
                    {
                        ListViewItem item = new ListViewItem(satir["ID"].ToString());
                        item.SubItems.Add(satir["Isim"].ToString());
                        item.SubItems.Add(satir["GirisTarihi"].ToString());
                        item.SubItems.Add(satir["CikisTarihi"].ToString());

                        DoluOdalar.Items.Add(item);
                    }
                }

                Ayarlar.BaglantiKapat();

            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }

            
        }
        public void DoluOdalarDoldur()
        {
            DoluOdalar.View = View.Details;
            DoluOdalar.Columns.Clear();
            DoluOdalar.Columns.Add("Oda ID", 50, HorizontalAlignment.Left);
            DoluOdalar.Columns.Add("Oda No", 60, HorizontalAlignment.Left);
            DoluOdalar.Columns.Add("Giriş Tarihi", 140, HorizontalAlignment.Left);
            DoluOdalar.Columns.Add("Çıkış Tarihi", 140, HorizontalAlignment.Left);
            try
            {
                Ayarlar.BaglantiAc();
                DataTable veriler = new DataTable();
                SqlCommand komut = new SqlCommand("select o.ID,o.Isim,ho.GirisTarihi,ho.CikisTarihi,ho.OdaID from Odalar as o left join HangiOdada as ho on o.ID=ho.OdaID where ho.GirisTarihi between convert(varchar, getdate(), 102)  and convert(varchar, getdate(), 102) or ho.CikisTarihi between convert(varchar, getdate(), 102) and convert(varchar, getdate(), 102)", Ayarlar.baglanti);
         
                SqlDataAdapter tablo = new SqlDataAdapter(komut);

                tablo.Fill(veriler);

                DoluOdalar.Items.Clear();

                for (int i = 0; i < veriler.Rows.Count; i++)
                {
                    DataRow satir = veriler.Rows[i];

                    if (satir.RowState != DataRowState.Deleted)
                    {
                        ListViewItem item = new ListViewItem(satir["ID"].ToString());
                        item.SubItems.Add(satir["Isim"].ToString());
                        item.SubItems.Add(satir["GirisTarihi"].ToString());
                        item.SubItems.Add(satir["CikisTarihi"].ToString());

                        DoluOdalar.Items.Add(item);
                    }
                }

                Ayarlar.BaglantiKapat();

            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message);
            }

            
        }
        private void Odalar_Load(object sender, EventArgs e)
        {
            BosOdalarDoldur();
            DoluOdalarDoldur();

        }
    }
}
