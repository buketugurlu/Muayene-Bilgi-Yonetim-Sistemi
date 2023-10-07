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
    public partial class MuayeneBilgisiEkle : Form
    {
        public MuayeneBilgisiEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Hastane;User Id=postgres;Password=1234");

        private void muayeneBilgisiEkleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into muayenebilgileri (tckimlikno, muayenetarihi, hastasikayeti, tani, tedavi, recete) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
            
            komut.Parameters.AddWithValue("@p1", muayeneBilgisiEkleTCKimlikNoTxt.Text);
            komut.Parameters.AddWithValue("@p2", Convert.ToDateTime(muayeneBilgisiEkleMuayeneTarihiTxt.Text));
            komut.Parameters.AddWithValue("@p3", muayeneBilgisiEkleHastaSikayetiTxt.Text);
            komut.Parameters.AddWithValue("@p4", muayeneBilgisiEkleTaniTxt.Text);
            komut.Parameters.AddWithValue("@p5", muayeneBilgisiEkleTedaviTxt.Text);
            komut.Parameters.AddWithValue("@p6", muayeneBilgisiEkleReceteNoTxt.Text);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Muayene bilgisi kaydedilmiştir.");
        }

        private void muayeneBilgisiEkleSilmeBtn_Click(object sender, EventArgs e)
        {
            //kaydı siler
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from muayenebilgileri where tckimlikno=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", muayeneBilgisiEkleTCKimlikNoTxt.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Muayene bilgisi silinmiştir.");
        }

        private void MuayeneBilgisiEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
