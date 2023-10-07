using Npgsql;
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
    public partial class IlacEkle : Form
    {
        public IlacEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Hastane;User Id=postgres;Password=1234");

        private void button1_Click(object sender, EventArgs e)
        {
            //ilaç kaydı ekler
            baglanti.Open();

            NpgsqlCommand komut = new NpgsqlCommand("insert into ilacbilgisi (barkodnumarasi, ilacadi, ilactipi) values (@p1, @p2, @p3)", baglanti);
            
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(ilacEkleBarkodNoTxt.Text));
            komut.Parameters.AddWithValue("@p2", ilacEkleIlacAdiTxt.Text);
            komut.Parameters.AddWithValue("@p3", ilacEkleIlacTuruTxt.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlaç sisteme kaydedilmiştir.");
        }

        private void ilacEkleSilmeBtn_Click(object sender, EventArgs e)
        {
            //ilaç kaydı siler
            baglanti.Open();

            NpgsqlCommand komut2 = new NpgsqlCommand("delete from ilacbilgisi where barkodnumarasi=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(ilacEkleBarkodNoTxt.Text));

            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlaç kaydı silinmiştir.");
        }

        private void IlacEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
