using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Template : System.Web.UI.MasterPage
{
    //SqlConnection conn = new SqlConnection(@"Data Source=SEVDANUR-PC\NANO;Initial Catalog=RestaurantOtomasyonu;Integrated Security=True"); 
 

    protected void Page_Load(object sender, EventArgs e)
    {

    }
 

    


    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    SqlCommand sorgu = new SqlCommand("select * from Tbl_Kullanicilar", conn);

        //    try
        //    {
        //        conn.Open();
        

        //        if (Menu1.Items.Equals(0))
        //            Response.Redirect("SiparisVermeEkrani.aspx?KullaniciID=" + Session["KullaniciID"] + "");
        //        if (Menu1.Items.Equals(1))
        //            Response.Redirect("OncekiSiparislerim.aspx?KullaniciID=" + Session["KullaniciID"] + "");
        //        if (Menu1.Items.Equals(2))
        //            Response.Redirect("KisiselBilgilerim.aspx?KullaniciID=" + Session["KullaniciID"] + "");
          
                
        //    }
        //    catch
        //    {
        //        Response.Write("Bir hata oluştu");
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
      

    }
}
