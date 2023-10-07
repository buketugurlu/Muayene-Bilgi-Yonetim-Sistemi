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
    public partial class HastaSirasi : Form
    {
        public HastaSirasi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Hastane;User Id=postgres;Password=1234");

        private void HastaSirasi_Load(object sender, EventArgs e)
        {
            //muayene listesini artan sıra noya göre sıralar
            string sorgu = ("select * from muayenelistesi order by sirano");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            hastaSirasiDataGridView.DataSource = ds.Tables[0];
        }
    }
}
