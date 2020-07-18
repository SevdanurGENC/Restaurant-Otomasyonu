using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantOtomasyonu_MasaUstuTerminali
{
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source=SEVDANUR-PC\GENC;Initial Catalog=RestaurantOtomasyonu;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            int yetkiid = 0;

            if (comboBox1.Text == "Asci")
            {
                Form AsciPaneli = new KontrolPaneliAsci();
                AsciPaneli.Show();
                yetkiid = 3;
            }
            else if (comboBox1.Text == "Admin")
            {
                Form AdminPaneli = new KontrolPaneliAdmin();
                AdminPaneli.Show();
                yetkiid = 1;
            }
            else if (comboBox1.Text == "Kasiyer") //veritabaninda kasiyer=mudur
            {
                Form KasiyerPaneli = new KontrolPaneliKasiyer();
                KasiyerPaneli.Show();
                yetkiid = 2;
            }

            try
            {

                baglanti.Open();

                SqlParameter kadi = new SqlParameter("@kadi", textBox1.Text);
                SqlParameter sif = new SqlParameter("@sif", textBox2.Text);
                SqlParameter yid = new SqlParameter("@yet", Convert.ToInt32(yetkiid));
                 
                string sqlCumlesi = "select * from tbl_kullanicilar, tbl_yetkiler where tbl_yetkiler.yetkiId=tbl_kullanicilar.yetkiid and tbl_kullanicilar.kullaniciadi=@kadi and tbl_kullanicilar.sifre=@sif and tbl_kullanicilar.yetkiid=@yet";

                SqlCommand cmd = new SqlCommand(sqlCumlesi,baglanti);

                cmd.Parameters.Add(kadi);
                cmd.Parameters.Add(sif);
                cmd.Parameters.Add(yid);
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Girisiniz Basarilidir, Hosgeldiniz...");
                }
                else
                {
                    MessageBox.Show("Sistemimizde boyle bir kullanici bulunmamaktadir");
                }

                baglanti.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
             
        }
    }
}
