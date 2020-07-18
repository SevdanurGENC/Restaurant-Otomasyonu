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
    public partial class KontrolPaneliAsci : Form
    {
        public KontrolPaneliAsci()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection(@"Data Source=SEVDANUR-PC\GENC;Initial Catalog=RestaurantOtomasyonu;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        { 
            Form KullaniciGirisi = new KullaniciGirisi();
            KullaniciGirisi.Show();


            Close();
        }

        private void KontrolPaneliAsci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantOtomasyonuDataSet7.Tbl_Stoklar' table. You can move, or remove it, as needed.
            this.tbl_StoklarTableAdapter.Fill(this.restaurantOtomasyonuDataSet7.Tbl_Stoklar);
            baglanti.Open();
            GridDoldurTab1("Select tbl_siparisler.SiparisID,Tbl_AnaMenuler.MenuAdi, Tbl_AltMenuler.AltMenuAdi From Tbl_Siparisler, Tbl_AltMenuler, Tbl_AnaMenuler where tbl_siparisler.WebSiparisiMi=1 and Tbl_AnaMenuler.MenuID=Tbl_Siparisler.MenuID and Tbl_AltMenuler.AltMenuID = Tbl_Siparisler.AltMenuID");
            GridDoldurTab2("Select tbl_siparisler.SiparisID, Tbl_Masalar.MasaNo, Tbl_Masalar.MasaAdi, Tbl_AnaMenuler.MenuAdi, Tbl_AltMenuler.AltMenuAdi From Tbl_Siparisler, Tbl_AltMenuler, Tbl_AnaMenuler, Tbl_Masalar where tbl_siparisler.MasaSiparisiMi=1 and Tbl_AnaMenuler.MenuID=Tbl_Siparisler.MenuID and Tbl_AltMenuler.AltMenuID = Tbl_Siparisler.AltMenuID and Tbl_Siparisler.MasaID = Tbl_Masalar.ID");
            GridDoldurTab3("Select * From Tbl_Siparisler");
            baglanti.Close();        
        }

        private void button2_Click(object sender, EventArgs e)    //web siparis onay butonu
        {
            DataGridViewRow satir = dgvWebSiparisleri.SelectedRows[0]; 
            baglanti.Open();            
            string GuncelSqlCumlesi = "update tbl_siparisler set SiparisHazirMi = 1 where SiparisId=" + satir.Cells[0].Value + "";
            SqlCommand cmd = new SqlCommand(GuncelSqlCumlesi, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dgvSalonSiparisleri.SelectedRows[0];
            baglanti.Open();
            string GuncelSqlCumlesi = "update tbl_siparisler set SiparisHazirMi = 1 where SiparisId=" + satir.Cells[0].Value + "";
            SqlCommand cmd = new SqlCommand(GuncelSqlCumlesi, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }    
   
        public void GridDoldurTab1(string sqlCumle)
        {
            string sql = sqlCumle; 
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvWebSiparisleri.DataSource = ds.Tables[0];
        
        }    //web siparisleri
        public void GridDoldurTab2(string sqlCumle) 
        {
            string sql = sqlCumle;
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvSalonSiparisleri.DataSource = ds.Tables[0];
            

        }   //salon siparisleri
        public void GridDoldurTab3(string sqlCumle)
        {
            string sql = sqlCumle;
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTumSiparisler.DataSource = ds.Tables[0];

        }

        public void GridDoldurTab4(string sqlCumle)
        {
            string sql = sqlCumle;
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }    

        private void button4_Click(object sender, EventArgs e)
        { 
            tbl_StoklarTableAdapter.Update(restaurantOtomasyonuDataSet7.Tbl_Stoklar);
            dataGridView1.Refresh();
            GridDoldurTab4("Select * from tbl_stoklar");
        }

     
        
    }
}
