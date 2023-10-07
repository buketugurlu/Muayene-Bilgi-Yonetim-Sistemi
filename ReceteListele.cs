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
    public partial class ReceteListele : Form
    {
        public ReceteListele()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Hastane;User Id=postgres;Password=1234");

        private void ReceteListele_Load(object sender, EventArgs e)
        {
            string sorgu = ("select * from recete");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            receteListeleDataGridView.DataSource = ds.Tables[0];
        }
    }
}
