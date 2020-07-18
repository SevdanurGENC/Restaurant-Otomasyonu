using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class OncekiSiparislerim : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=SEVDANUR-PC\GENC;Initial Catalog=RestaurantOtomasyonu;Integrated Security=True");
      
    public string KullaniciIDAl;

    protected void Page_Load(object sender, EventArgs e)
    {
        KullaniciIDAl = Request.QueryString["KullaniciID"].ToString();
       
        if (!IsPostBack)
        {
            SqlCommand sorgu = new SqlCommand("select * from Tbl_Siparisler where KullaniciID = " + Convert.ToInt32(KullaniciIDAl) + " " , conn);

            try
            {
                conn.Open();
                SqlDataReader reader = sorgu.ExecuteReader();

                GridView1.DataSource = reader;
               
                GridView1.DataBind();


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
}