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
    public partial class kayitlihastamuayene : Form
    {
        public kayitlihastamuayene()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Hastane;User Id=postgres;Password=1234");

        private void kayitlihastamuayene_Load(object sender, EventArgs e)
        {
            string sorgu2 = ("select * from kayitlihastamuayene");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            kayitliHastaDataGridView.DataSource = ds.Tables[0];
        }
        private void kayitliHastaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into kayitlihastamuayene (tckimlikno, muayenetarihi, sirano, receteno) values (@p1, @p2, @p3, @p4)", baglanti);

            komut.Parameters.AddWithValue("@p1", kayitliHastaTCKimlikNoTxt.Text);
            komut.Parameters.AddWithValue("@p2", kayitliHastaMuayeneTarihi.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToInt32(kayitliHastaSiraNoTxt.Text));
            komut.Parameters.AddWithValue("@p4", kayitliHastaReceteNoTxt.Text);

            //bir hastanının aynı günde sadece 1 tane muayene bilgisi olup olmadığını kontrol eder.
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("select * from kayitlihastamuayene", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int kontrol = 0;
            int i = 0;
            int a = 0;
            //datatable ın satırları boyunca inceler
            for (i = 0; i < dt.Rows.Count; i++)
            {
                //hasta tc kimlik numaralarının aynılığını kontrol ediyor
                if (dt.Rows[i][2].ToString() == kayitliHastaTCKimlikNoTxt.Text)
                {
                    for (a = 0; a < dt.Rows.Count; a++)
                    {
                        //aynı olan tc kimlik numaraları arasında tarihlerin farklılığını inceliyor.
                        if (dt.Rows[a][3].ToString() == kayitliHastaMuayeneTarihi.Text)
                        {
                            kontrol++;
                        }
                    }
                }
            }
            if (kontrol > 0)
            {
                MessageBox.Show("Bir hasta aynı günde sadece bir kez muayene olabilir.");
            }
            if (kontrol == 0)
            {
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Muayene bilgisi kaydedilmiştir.");
            }

            string sorgu = ("select * from kayitlihastamuayene");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            kayitliHastaDataGridView.DataSource = ds.Tables[0];
        }

        private void kayitliHastaSilmeBtn_Click(object sender, EventArgs e)
        {
            //kayıt siler
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from kayitlihastamuayene where tckimlikno=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", kayitliHastaTCKimlikNoTxt.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Muayene bilgisi silinmiştir.");
        }
    }
}
