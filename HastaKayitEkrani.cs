using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace _210601028_BuketUgurlu_muayenebilgiyonetimsistemi
{
    public partial class HastaKayitEkrani : Form
    {
        public HastaKayitEkrani()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Hastane;User Id=postgres;Password=1234");

        private void HastaKayitEkrani_Load(object sender, EventArgs e)
        {

        }

        private void hastaKayitEkleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into hastabilgiler (tckimlikno, ad, soyad, dogumyeri, dogumtarihi, medenidurumu, adres, telefon) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", baglanti);
           
            komut.Parameters.AddWithValue("@p1", hastaKayitTCKimlikNoTxt.Text);
            komut.Parameters.AddWithValue("@p2", hastaKayitAdTxt.Text);
            komut.Parameters.AddWithValue("@p3", hastaKayitSoyadTxt.Text);
            komut.Parameters.AddWithValue("@p4", hastaKayitDogumYeriTxt.Text);
            komut.Parameters.AddWithValue("@p5", Convert.ToDateTime(hastaKayitDogumTarihiTxt.Text));
            komut.Parameters.AddWithValue("@p6", hastaKayitMedeniDurumTxt.Text);
            komut.Parameters.AddWithValue("@p7", hastaKayitAdresTxt.Text);
            komut.Parameters.AddWithValue("@p8", hastaKayitTelefonTxt.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            string sorgu = ("select * from hastabilgiler");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            hastaKayitEkraniDataGridView.DataSource = ds.Tables[0];

            MessageBox.Show("Hasta bilgisi kaydedilmiştir.");
        }

        private void hastaKayitSilmeBtn_Click(object sender, EventArgs e)
        {
            //textboxa yazılan kimlikno ya göre bilgiyi siler
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from hastabilgiler where tckimlikno=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", hastaKayitTCKimlikNoTxt.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();

            string sorgu = ("select * from hastabilgiler");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            hastaKayitEkraniDataGridView.DataSource = ds.Tables[0];

            MessageBox.Show("Hasta kaydı silinmiştir.");
        }
    }
}
