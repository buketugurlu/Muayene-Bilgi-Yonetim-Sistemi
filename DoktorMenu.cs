using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210601028_BuketUgurlu_muayenebilgiyonetimsistemi
{
    public partial class DoktorMenu : Form
    {
        public DoktorMenu()
        {
            InitializeComponent();
        }

        private void DoktorMenu_Load(object sender, EventArgs e)
        {
            //mdi container back color
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.MistyRose;
        }

        private void reçeteBilgiGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void muayeneListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void muayeneBilgisiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneBilgisiEkle muayeneBilgisiEkle = new MuayeneBilgisiEkle();
            muayeneBilgisiEkle.Show();
        }

        private void hastaSırasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaSirasi hastaSirasi = new HastaSirasi();
            hastaSirasi.Show();
        }

        private void reçeteEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceteEkle receteekle = new ReceteEkle();
            receteekle.Show();
        }

        private void muayeneBilgileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneBilgileriListele muayeneBilgileriListele = new MuayeneBilgileriListele();
            muayeneBilgileriListele.Show();
        }

        private void reçeteListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceteListeleDoktor receteListele = new ReceteListeleDoktor();
            receteListele.Show();
        }

        private void reçeteGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceteGoruntule receteGoruntule = new ReceteGoruntule();
            receteGoruntule.Show();
        }

        private void kayıtlıHastaMuayeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitlihastamuayene ky = new kayitlihastamuayene();
            ky.Show();
        }
    }
}
