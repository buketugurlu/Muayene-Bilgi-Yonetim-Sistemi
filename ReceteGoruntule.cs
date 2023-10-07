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
    public partial class ReceteGoruntule : Form
    {
        public ReceteGoruntule()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Hastane;User Id=postgres;Password=1234");

        private void ReceteGoruntule_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textbox a yazılan tc numarasına göre istenilen kaydı sıralar
            baglanti.Open();
            string kayit = "Select * From recetedetaylari Where tckimlikno=@tckimlikno";
            NpgsqlCommand komut = new NpgsqlCommand(kayit, baglanti);

            komut.Parameters.AddWithValue("@tckimlikno", receteBilgisiGoruntuleTCKimlikNoTxt.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            receteBilgisiGoruntuleDataGridView.DataSource = dt;
            baglanti.Close();
        }
    }
}
