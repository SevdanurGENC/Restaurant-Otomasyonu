using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class SiparisVermeEkrani : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=SEVDANUR-PC\GENC;Initial Catalog=RestaurantOtomasyonu;Integrated Security=True");

    public string KullaniciIDAl;

    protected void Page_Load(object sender, EventArgs e)
    {
        KullaniciIDAl = Request.QueryString["KullaniciID"].ToString();


        if (!IsPostBack)
        {
            SqlCommand sorgu = new SqlCommand("select * from Tbl_AnaMenuler", conn);
         
            try
            {
                conn.Open();
                SqlDataReader reader = sorgu.ExecuteReader();
            
                DDLAnaMenu.DataSource = reader;
                DDLAnaMenu.DataValueField = "MenuID";
                DDLAnaMenu.DataTextField = "MenuAdi";
                   
                DDLAnaMenu.DataBind();

           
                reader.Close();
            }
            catch
            {
                Response.Write("Bir hata oluştu");
            }
            finally
            {
                conn.Close();
            }
        }
    }

    public int sonuc;
    public int araToplam;
     
    public int GenelToplamHesapla(int araToplamAl)
    {
        sonuc = sonuc + araToplamAl;
        return sonuc;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // listeye ekleme Ve fiyat hesaplamasi yapilacaktir.

        ListBox1.Items.Add(DDLAnaMenu.SelectedItem.ToString() + " - " + DDLAltMenu.SelectedItem.ToString() + " Adet = " + txtAdet.Text + " Toplam Fiyat = " + txtToplamTutar.Text);

        araToplam = Convert.ToInt32(txtToplamTutar.Text);
      
        txtGenelToplam.Text = Convert.ToString(Convert.ToInt32(txtGenelToplam.Text)+ GenelToplamHesapla(araToplam));

    }

    public int SiparisIDUret()
    {
        Random IdAl = new Random();
        return IdAl.Next(1,300);
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand Ekle = 
            new SqlCommand("Insert into Tbl_Siparisler(SiparisID, MenuID,AltMenuID, Adet,Fiyat,SiparisZamani, Aciklama,EkIstekler,KullaniciID,GenelToplam) Values(@SiparisID,@MenuID,@AltMenuID,@Adet,@Fiyat,@SiparisZamani,@Aciklama,@EkIstekler,@KullaniciID,@GenelToplam)", 
            conn);
        try
        {
            conn.Open();

            Ekle.Parameters.AddWithValue("@SiparisID", SiparisIDUret());
            Ekle.Parameters.AddWithValue("@MenuID", DDLAnaMenu.SelectedItem.Value );
            Ekle.Parameters.AddWithValue("@AltMenuID", DDLAltMenu.SelectedItem.Value );
            Ekle.Parameters.AddWithValue("@Adet", Convert.ToInt32(txtAdet.Text) );
            Ekle.Parameters.AddWithValue("@Fiyat", Convert.ToInt32(txtFiyat.Text));
            Ekle.Parameters.AddWithValue("@SiparisZamani", Convert.ToString(DateTime.Now));
            Ekle.Parameters.AddWithValue("@Aciklama", txtAciklama.Text );
            Ekle.Parameters.AddWithValue("@EkIstekler", txtEkIstekler.Text);
            Ekle.Parameters.AddWithValue("@KullaniciID", KullaniciIDAl);
            Ekle.Parameters.AddWithValue("@GenelToplam", Convert.ToInt32(txtGenelToplam.Text) );


            Ekle.ExecuteNonQuery();
         
          
        }
        catch (Exception ex)
        {
            Response.Write("Bir hata oluştu amaaaaaaaa " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    protected void DDLAnaMenu_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlCommand sorguIki = new SqlCommand("select Tbl_AltMenuler.AltMenuID,Tbl_AltMenuler.AltMenuAdi,Tbl_AltMenuler.Fiyat from Tbl_AltMenuler, Tbl_AnaMenuler where Tbl_AltMenuler.AnaMenuID=Tbl_AnaMenuler.MenuID and Tbl_AnaMenuler.MenuID = " + DDLAnaMenu.SelectedItem.Value + "", conn);
     //   Response.Write(DDLAnaMenu.SelectedItem.ToString());
        try
        {
            conn.Open();

             SqlDataReader readerIki = sorguIki.ExecuteReader();
 
                DDLAltMenu.DataSource = readerIki;
                DDLAltMenu.DataValueField = "AltMenuID";
                DDLAltMenu.DataTextField = "AltMenuAdi";

                //if (readerIki.Read())
                //{
                //    txtAdet.Text = readerIki["Fiyat"].ToString();
                //}  

            DDLAltMenu.DataBind();
        //    Label7.Text = Convert.ToString(readerIki["Fiyat"]);
           
            readerIki.Close();
        }
        catch(Exception ex)
        {
            Response.Write("Bir hata oluştu amaaaaaaaa " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
    protected void DDLAltMenu_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlCommand srg = new SqlCommand("Select Fiyat from TBL_AltMenuler where AltMenuAdi = '" + DDLAltMenu.SelectedItem.ToString() + "'", conn);

        try
        {
            conn.Open();

            SqlDataReader rd = srg.ExecuteReader();
            if (rd.Read())  
            {
                txtFiyat.Text = rd["Fiyat"].ToString();
            }

            rd.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Bir hata oluştu amaaaaaaaa " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
   
    protected void txtAdet_TextChanged(object sender, EventArgs e)
    {
      txtToplamTutar.Text = Convert.ToString((Convert.ToInt32(txtAdet.Text) * Convert.ToInt32(txtFiyat.Text)));
    }
   
}