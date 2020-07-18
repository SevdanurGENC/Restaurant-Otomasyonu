using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using Microsoft.VisualBasic;

namespace RestaurantOtomasyonu_MasaUstuTerminali
{
    public partial class KontrolPaneliKasiyer : Form
    {
        public KontrolPaneliKasiyer()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source=SEVDANUR-PC\GENC;Initial Catalog=RestaurantOtomasyonu;Integrated Security=True");


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string KullaniciAdi = Interaction.InputBox("Kullanici Adinizi Giriniz : ", "Guvenlik Acisindan Tekrar Kullanici Girisi Yapiniz", null, 500, 350);
                string Sifre = Interaction.InputBox("Sifrenizi Giriniz : ", "Guvenlik Acisindan Tekrar Kullanici Girisi Yapiniz", null, 500, 350);

                DataGridViewRow satir = dvgAcikHesaplarEkrani.SelectedRows[0];
                baglanti.Open();
                string GuncelSqlCumlesi = "update Tbl_Siparisler set TahsilatYapanKullaniciID = (select KullaniciID from Tbl_Kullanicilar where Sifre = " + Sifre + " and KullaniciAdi = '" + KullaniciAdi + "'), TahsilatDurumu=1 where SiparisID=" + satir.Cells[0].Value + "";
                SqlCommand cmd = new SqlCommand(GuncelSqlCumlesi, baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Tahsil Edilmistir"); 
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Girmis oldugunuz Kullanici Adi ve Sifre Hatalidir... Hata : " + Ex.Message);
            }   //halen sistemde olmayan kullanicida hata vermekte
        }

        private void KontrolPaneliKasiyer_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            GridDoldurTab1("Select tbl_siparisler.SiparisID, Tbl_AnaMenuler.MenuAdi, Tbl_AltMenuler.AltMenuAdi From Tbl_Siparisler , Tbl_AltMenuler, Tbl_AnaMenuler where TahsilatDurumu=0 and Tbl_AnaMenuler.MenuID=Tbl_Siparisler.MenuID and Tbl_AltMenuler.AltMenuID = Tbl_Siparisler.AltMenuID"); 
            GridDoldurTab2("Select SiparisId, MenuId, AltMenuId From Tbl_Siparisler");
          
            baglanti.Close();    
        }


        public void GridDoldurTab1(string sqlCumle)
        {
            string sql = sqlCumle;
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dvgAcikHesaplarEkrani.DataSource = ds.Tables[0];

        }    //acik hesaplar ekrani

        public void GridDoldurTab2(string sqlCumle)
        {
            string sql = sqlCumle;
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dvgTumSatislarEkrani.DataSource = ds.Tables[0];


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bastarihi ; " + BaslangicTarihi.Value.ToShortDateString() + " bittarihi ; " + BitisTarihi.Value.ToShortDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form KullaniciGirisi = new KullaniciGirisi();
            KullaniciGirisi.Show();


            Close();
        }

        

    }
}
