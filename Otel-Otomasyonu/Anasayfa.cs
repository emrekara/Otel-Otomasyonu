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
    public partial class Anasayfa : Form
    {
        MisafirGiris Mgiris;
        MisafirKontrol Mkontrol;
        BosOdalar Bodalar;
        DoluOdalar Dodalar;
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void misafirGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Mgiris == null || Mgiris.IsDisposed)
            {
                Mgiris = new MisafirGiris();
                Mgiris.MdiParent = this;
                Mgiris.Show();
            }
            else
            {
                Mgiris.Focus();
            }
            Mgiris.WindowState = FormWindowState.Maximized;
        }

        private void misafirKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Mkontrol==null || Mkontrol.IsDisposed)
            {
                Mkontrol = new MisafirKontrol();
                Mkontrol.MdiParent = this;
                Mkontrol.Show();
            }
            else
            {
                Mkontrol.Focus();
            }
            Mkontrol.WindowState = FormWindowState.Maximized;
        }

        private void boşOdalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bodalar == null || Bodalar.IsDisposed)
            {
                Bodalar = new BosOdalar();
                Bodalar.MdiParent = this;
                Bodalar.Show();
            }
            else
            {
                Bodalar.Focus();
            }
            Bodalar.WindowState = FormWindowState.Maximized;
        }

        private void doluOdalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dodalar == null || Dodalar.IsDisposed)
            {
                Dodalar = new DoluOdalar();
                Dodalar.MdiParent = this;
                Dodalar.Show();
            }
            else
            {
                Dodalar.Focus();
            }
            Dodalar.WindowState = FormWindowState.Maximized;
        }
    }
}
