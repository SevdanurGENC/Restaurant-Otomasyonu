using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
 

public partial class Default : System.Web.UI.Page
{

    SqlConnection conn = new SqlConnection(@"Data Source=SEVDANUR-PC\GENC;Initial Catalog=RestaurantOtomasyonu;Integrated Security=True"); 
  

    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        if ((txtKulAdi.Text == "") || (txtSifre.Text == ""))
        {
            Response.Write("Kullanici Adini ve Sifre bos birakmayiniz");
        
        }
        else
        {
          
            SqlCommand sorgu = new SqlCommand("Select * from Tbl_Kullanicilar where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre", conn);

            sorgu.Parameters.Add("@KullaniciAdi", txtKulAdi.Text);
            sorgu.Parameters.Add("@Sifre", txtSifre.Text);

            conn.Open();

            SqlDataReader dr = sorgu.ExecuteReader();

            if (dr.Read())
            {
                Session["ID"] = Convert.ToInt32(dr["ID"]);
                Session["YetkiID"] = Convert.ToInt32(dr["YetkiID"]);
                Session["KullaniciID"] = Convert.ToInt32(dr["KullaniciID"]);
               
                //Response.Redirect("KisiselBilgilerim.aspx?YetkiID=" + Session["YetkiID"] + 
                //    "&KullaniciID=" + Session["KullaniciID"] + "");
             Response.Redirect("SiparisVermeEkrani.aspx?YetkiID=" + Session["YetkiID"] +
                   "&KullaniciID=" + Session["KullaniciID"] + "");
                //Response.Redirect("OncekiSiparislerim.aspx?YetkiID=" + Session["YetkiID"] +
                //   "&KullaniciID=" + Session["KullaniciID"] + "");
                
               
            }
            else
            {
                Response.Write("Kullanıcı adı veya şifre yanlış");
            }
        }
    }
}