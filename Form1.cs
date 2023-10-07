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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hastaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorMenu doktor = new DoktorMenu();
            doktor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SekreterMenu sekreter = new SekreterMenu();
            sekreter.Show();
        }
    }
}
