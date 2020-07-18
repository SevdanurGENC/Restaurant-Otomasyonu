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
 
namespace RestaurantOtomasyonu_MasaUstuTerminali
{
    public partial class KontrolPaneliAdmin : Form
    {
        public KontrolPaneliAdmin()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source=SEVDANUR-PC\GENC;Initial Catalog=RestaurantOtomasyonu;Integrated Security=True");


        private void KontrolPaneliAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantOtomasyonuDataSet6.Tbl_Masalar' table. You can move, or remove it, as needed.
            this.tbl_MasalarTableAdapter.Fill(this.restaurantOtomasyonuDataSet6.Tbl_Masalar);
            // TODO: This line of code loads data into the 'restaurantOtomasyonuDataSet5.Tbl_Stoklar' table. You can move, or remove it, as needed.
            this.tbl_StoklarTableAdapter.Fill(this.restaurantOtomasyonuDataSet5.Tbl_Stoklar);
            // TODO: This line of code loads data into the 'restaurantOtomasyonuDataSet4.Tbl_AltMenuler' table. You can move, or remove it, as needed.
            this.tbl_AltMenulerTableAdapter.Fill(this.restaurantOtomasyonuDataSet4.Tbl_AltMenuler);
            // TODO: This line of code loads data into the 'restaurantOtomasyonuDataSet3.Tbl_AnaMenuler' table. You can move, or remove it, as needed.
            this.tbl_AnaMenulerTableAdapter.Fill(this.restaurantOtomasyonuDataSet3.Tbl_AnaMenuler);
             this.tbl_YetkilerTableAdapter.Fill(this.restaurantOtomasyonuDataSet2.Tbl_Yetkiler);
             this.tbl_KullanicilarTableAdapter.Fill(this.restaurantOtomasyonuDataSet1.Tbl_Kullanicilar);
             this.tbl_SiparislerTableAdapter.Fill(this.restaurantOtomasyonuDataSet.Tbl_Siparisler);
               
        }

        public void GridDoldurTab1(string sqlCumle)
        {
            string sql = sqlCumle;
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvSiparisler.DataSource = ds.Tables[0];
        }   
        public void GridDoldurTab2(string sqlCumle)
        {
            string sql = sqlCumle;
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvKullanicilar.DataSource = ds.Tables[0];
        }
        public void GridDoldurTab3(string sqlCumle)
        {
            string sql = sqlCumle;
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvYetkiler.DataSource = ds.Tables[0];
        }
        public void GridDoldurTab4(string sqlCumle)
        {
            string sql = sqlCumle;
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvAnaMenuler.DataSource = ds.Tables[0];
        }
        public void GridDoldurTab5(string sqlCumle)
        {
            string sql = sqlCumle;
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvAltMenuler.DataSource = ds.Tables[0];
        }
        public void GridDoldurTab6(string sqlCumle)
        {
            string sql = sqlCumle;
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvStoklar.DataSource = ds.Tables[0];
        }
        public void GridDoldurTab7(string sqlCumle)
        {
            string sql = sqlCumle;
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvMasalar.DataSource = ds.Tables[0];
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            tbl_SiparislerTableAdapter.Update(restaurantOtomasyonuDataSet.Tbl_Siparisler);
            dgvSiparisler.Refresh();
        }
        private void button4_Click(object sender, EventArgs e)
        { 
            DataGridViewRow satir = dgvSiparisler.SelectedRows[0];
            baglanti.Open();
            string GuncelSqlCumlesi = "Delete from tbl_siparisler where Id=" + satir.Cells[0].Value + "";
            SqlCommand cmd = new SqlCommand(GuncelSqlCumlesi, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydiniz Sistemden Tamamen Silinmistir...");
            
            GridDoldurTab1("select * from tbl_siparisler");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dgvKullanicilar.SelectedRows[0];
            baglanti.Open();
            string GuncelSqlCumlesi = "Delete from tbl_kullanicilar where Id=" + satir.Cells[0].Value + "";
            SqlCommand cmd = new SqlCommand(GuncelSqlCumlesi, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydiniz Sistemden Tamamen Silinmistir...");

            GridDoldurTab2("select * from tbl_kullanicilar");


            DataGridViewRow satir2 = dgvYetkiler.SelectedRows[0];
            baglanti.Open();
            string GuncelSqlCumlesi2 = "Delete from tbl_yetkiler where Id=" + satir2.Cells[0].Value + "";
            SqlCommand cmd2 = new SqlCommand(GuncelSqlCumlesi2, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydiniz Sistemden Tamamen Silinmistir...");

            GridDoldurTab3("select * from tbl_yetkiler");


        }
        private void button1_Click(object sender, EventArgs e)
        {
            tbl_KullanicilarTableAdapter.Update(restaurantOtomasyonuDataSet1.Tbl_Kullanicilar);
         
            tbl_YetkilerTableAdapter.Update(restaurantOtomasyonuDataSet2.Tbl_Yetkiler);

            dgvKullanicilar.Refresh();
            dgvYetkiler.Refresh();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dgvAnaMenuler.SelectedRows[0];
            baglanti.Open();
            string GuncelSqlCumlesi = "Delete from tbl_anamenuler where Id=" + satir.Cells[0].Value + "";
            SqlCommand cmd = new SqlCommand(GuncelSqlCumlesi, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydiniz Sistemden Tamamen Silinmistir...");

            GridDoldurTab4("select * from tbl_anamenuler");


            DataGridViewRow satir2 = dgvAltMenuler.SelectedRows[0];
            baglanti.Open();
            string GuncelSqlCumlesi2 = "Delete from tbl_altmenuler where Id=" + satir2.Cells[0].Value + "";
            SqlCommand cmd2 = new SqlCommand(GuncelSqlCumlesi2, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydiniz Sistemden Tamamen Silinmistir...");

            GridDoldurTab5("select * from tbl_altmenuler");

        }
        private void button7_Click(object sender, EventArgs e)
        {
            tbl_AnaMenulerTableAdapter.Update(restaurantOtomasyonuDataSet3.Tbl_AnaMenuler);

            tbl_AltMenulerTableAdapter.Update(restaurantOtomasyonuDataSet4.Tbl_AltMenuler);

            dgvAnaMenuler.Refresh();
            dgvAltMenuler.Refresh();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dgvStoklar.SelectedRows[0];
            baglanti.Open();
            string GuncelSqlCumlesi = "Delete from tbl_stoklar where Id=" + satir.Cells[0].Value + "";
            SqlCommand cmd = new SqlCommand(GuncelSqlCumlesi, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydiniz Sistemden Tamamen Silinmistir...");

            GridDoldurTab6("select * from tbl_stoklar");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            tbl_StoklarTableAdapter.Update(restaurantOtomasyonuDataSet5.Tbl_Stoklar);

            dgvStoklar.Refresh();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            tbl_MasalarTableAdapter.Update(restaurantOtomasyonuDataSet6.Tbl_Masalar);
            dgvMasalar.Refresh();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dgvMasalar.SelectedRows[0];
            baglanti.Open();
            string GuncelSqlCumlesi = "Delete from tbl_masalar where Id=" + satir.Cells[0].Value + "";
            SqlCommand cmd = new SqlCommand(GuncelSqlCumlesi, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydiniz Sistemden Tamamen Silinmistir...");

            GridDoldurTab7("select * from tbl_masalar");
  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form KullaniciGirisi = new KullaniciGirisi();
            KullaniciGirisi.Show();


            Close();
        }

       
      
      
    
    
    }
}
