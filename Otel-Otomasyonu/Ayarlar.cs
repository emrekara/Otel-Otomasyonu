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

        public static void BaglantiKapat()
        {
            baglanti.Close();
        }

    }
}
