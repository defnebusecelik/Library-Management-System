using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak istiyor musunuz?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void yeniKitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle kitap=new KitapEkle();
            kitap.Show();
        }

        private void kitaplarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapGörüntüle kitap1=new KitapGörüntüle();
            kitap1.Show();
        }

        private void yeniÖğrenciKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenci=new OgrenciEkle();
            ogrenci.Show();
        }

        private void öğrenciBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrencileriGoruntule ogrenci1=new OgrencileriGoruntule();
            ogrenci1.Show();
        }

        private void ödünçAlınmışKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OduncAlma odunc=new OduncAlma();
            odunc.Show();
        }

        private void geriGelmişKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OduncVer odunc1= new OduncVer();
            odunc1.Show();
        }

        private void kitapBilgisiDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapDetayları detay=new KitapDetayları();
            detay.Show();
        }
    }
}
