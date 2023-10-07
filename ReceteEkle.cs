using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210601028_BuketUgurlu_muayenebilgiyonetimsistemi
{
    public partial class ReceteEkle : Form
    {
        public ReceteEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localHost;Port=5432;Database=Hastane;User Id=postgres;Password=1234");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void ReceteEkle_Load(object sender, EventArgs e)
        {
        }

        private void receteEkleKaydetBtn_Click(object sender, EventArgs e)
        {
            //textbox tan girilen bütün bilgiler eklenir
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into recetedetaylari (tckimlikno, ad, soyad, recetetarihi, tani, doktoradi, doktorsoyadi, barkodnumarasi1, ilacadi1, ilackutusayisi1, barkodnumarasi2, ilacadi2, ilackutusayisi2, barkodnumarasi3, ilacadi3, ilackutusayisi3, barkodnumarasi4, ilacadi4, ilackutusayisi4, barkodnumarasi5, ilacadi5, ilackutusayisi5, ilacdozu, ilacsayisi) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24)", baglanti);

            komut.Parameters.AddWithValue("@p1", receteEkleTCKimlikNoTxt.Text);
            komut.Parameters.AddWithValue("@p2", receteEkleHastaAdTxt.Text);
            komut.Parameters.AddWithValue("@p3", receteEkleHastaSoyadTxt.Text);
            komut.Parameters.AddWithValue("@p4", Convert.ToDateTime(receteEkleReceteTarihiTxt.Text));
            komut.Parameters.AddWithValue("@p5", receteEkleTaniTxt.Text);
            komut.Parameters.AddWithValue("@p6", receteEkleDoktorAdiTxt.Text);
            komut.Parameters.AddWithValue("@p7", receteEkleDoktorSoyadiTxt.Text);
            komut.Parameters.AddWithValue("@p8", Convert.ToInt32(receteEkleIlac1BarkodNoTxt.Text));
            komut.Parameters.AddWithValue("@p9", receteEkleIlac1AdTxt.Text);
            komut.Parameters.AddWithValue("@p10", Convert.ToInt32(receteEkleIlac1SayisiTxt.Text));
            komut.Parameters.AddWithValue("@p11", Convert.ToInt32(receteEkleIlac2BarkodNoTxt.Text));
            komut.Parameters.AddWithValue("@p12", receteEkleIlac2AdTxt.Text);
            komut.Parameters.AddWithValue("@p13", Convert.ToInt32(receteEkleIlac2SayiTxt.Text));
            komut.Parameters.AddWithValue("@p14", Convert.ToInt32(receteEkleIlac3BarkodNoTxt.Text));
            komut.Parameters.AddWithValue("@p15", receteEkleIlac3AdTxt.Text);
            komut.Parameters.AddWithValue("@p16", Convert.ToInt32(receteEkleIlac3SayiTxt.Text));
            komut.Parameters.AddWithValue("@p17", Convert.ToInt32(receteEkleIlac4BarkodNoTxt.Text));
            komut.Parameters.AddWithValue("@p18", receteEkleIlac4AdTxt.Text);
            komut.Parameters.AddWithValue("@p19", Convert.ToInt32(receteEkleIlac4SayiTxt.Text));
            komut.Parameters.AddWithValue("@p20", Convert.ToInt32(receteEkleIlac5BarkodNoTxt.Text));
            komut.Parameters.AddWithValue("@p21", receteEkleIlac5AdTxt.Text);
            komut.Parameters.AddWithValue("@p22", Convert.ToInt32(receteEkleIlac5SayiTxt.Text));
            komut.Parameters.AddWithValue("@p23", receteEkleIlacDozuTxt.Text);
            komut.Parameters.AddWithValue("@p24", Convert.ToInt32(receteEkleIlacSayisiTxt.Text));

            //ilaç sayısı eğer 5'ten azsa boş textboxlar null değer döndürmemesi için kapatılır
            if (receteEkleIlac2AdTxt.Text == "")
            {
                receteEkleIlac2AdTxt.Visible = false;
            }
            if (Convert.ToInt32(receteEkleIlac2BarkodNoTxt.Text) == 0)
            {
                receteEkleIlac2AdTxt.Visible = false;
            }
            if (Convert.ToInt32(receteEkleIlac2SayiTxt.Text) == 0)
            {
                receteEkleIlac2SayiTxt.Visible = false;
            }

            if (receteEkleIlac3AdTxt.Text == "")
            {
                    receteEkleIlac3AdTxt.Visible = false;
            }
            if (Convert.ToInt32(receteEkleIlac3BarkodNoTxt.Text) == 0)
            {
                    receteEkleIlac3BarkodNoTxt.Visible = false;
            }
            if (Convert.ToInt32(receteEkleIlac3SayiTxt.Text) == 0)
            {
                    receteEkleIlac3SayiTxt.Visible = false;
            }

            if (receteEkleIlac4AdTxt.Text == "")
            {
                receteEkleIlac4AdTxt.Visible = false;
            }
            if (Convert.ToInt32(receteEkleIlac4BarkodNoTxt.Text) == 0)
            {
                    receteEkleIlac4BarkodNoTxt.Visible = false;
            }
            if (Convert.ToInt32(receteEkleIlac4SayiTxt.Text) == 0)
            {
                    receteEkleIlac4SayiTxt.Visible = false;
            }

            if (receteEkleIlac5AdTxt.Text == "")
            {
                receteEkleIlac5AdTxt.Visible = false;
            }
            if (Convert.ToInt32(receteEkleIlac5BarkodNoTxt.Text) == 0)
            {
                receteEkleIlac5BarkodNoTxt.Visible = false;
            }
            if (Convert.ToInt32(receteEkleIlac5SayiTxt.Text) == 0)
            {
                receteEkleIlac5SayiTxt.Visible = false;
            }
            //yazılan ilaçların kutu sayısının max 3 değer alabilmesini kontrol eder
            if (Convert.ToInt32(receteEkleIlac1SayisiTxt.Text) > 3 || Convert.ToInt32(receteEkleIlac2SayiTxt.Text) > 3 || Convert.ToInt32(receteEkleIlac3SayiTxt.Text) > 3 || Convert.ToInt32(receteEkleIlac4SayiTxt.Text) > 3 || Convert.ToInt32(receteEkleIlac5SayiTxt.Text) > 3)

            {
                MessageBox.Show("Aynı ilaçtan 3 kutudan fazla yazılamaz!");
            }
            //bir hastaya kayıtlı sadece 1 reçete bulunmasını kontrol eder
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("select * from recetedetaylari", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int kontrol = 0;
            int i = 0;
            for(i=0; i< dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == receteEkleTCKimlikNoTxt.Text)
                {
                    kontrol++;
                    if (kontrol > 0)
                    {
                        MessageBox.Show("İlgili muayeneye ait reçete bulunmaktadır!!");
                        break;
                    }
                }
            }
            if (kontrol == 0)
            {
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Reçete kaydedilmiştir.");
            }
        }

        private void receteEkleSilmeBtn_Click(object sender, EventArgs e)
        {
            //silme işlemini yapar
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from recetedetaylari where tckimlikno=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", receteEkleTCKimlikNoTxt.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Reçete kaydı silinmiştir.");
        }
    }
}
