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
    public partial class SekreterMenu : Form
    {
        public SekreterMenu()
        {
            InitializeComponent();
        }

        private void SekreterMenu_Load(object sender, EventArgs e)
        {
            //mdi container back color
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.MistyRose;
        }

        private void ilaçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IlacEkle ekle = new IlacEkle();
            ekle.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hastaKayıtEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaKayitEkrani hke = new HastaKayitEkrani();
            hke.Show();
        }

        private void ilaçListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IlacListele listele = new IlacListele();
            listele.Show();
        }

        private void sıraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceteListele recete = new ReceteListele();
            recete.Show();
        }
    }
}
