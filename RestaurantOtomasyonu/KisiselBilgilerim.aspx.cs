using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class KisiselBilgilerim : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=SEVDANUR-PC\GENC;Initial Catalog=RestaurantOtomasyonu;Integrated Security=True");

    public string YetkiAl;
    public string KullaniciIDAl;

    protected void Page_Load(object sender, EventArgs e)
    {
   //     Response.Redirect("KisiselBilgilerim.aspx?YetkiID=" + Session["YetkiID"]);
        YetkiAl = Request.QueryString["YetkiID"].ToString();
        KullaniciIDAl = Request.QueryString["KullaniciID"].ToString();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand sorgu =
            new SqlCommand("Update Tbl_Kullanicilar set KullaniciAdi=@KullaniciAdi,Sifre=@Sifre,Isim=@Isim,Soyisim=@Soyisim,Adres=@Adres where YetkiID=@YetkiID and KullaniciID=@KullaniciID", conn);

        sorgu.Parameters.Add("@KullaniciAdi", txtKulAdi.Text);
        sorgu.Parameters.Add("@Sifre", txtSifre.Text);
        sorgu.Parameters.Add("@Isim", txtIsim.Text);
        sorgu.Parameters.Add("@Soyisim", txtSoyisim.Text);
        sorgu.Parameters.Add("@Adres", txtAdres.Text);
        sorgu.Parameters.Add("@YetkiID",Convert.ToInt32(YetkiAl));
        sorgu.Parameters.Add("@KullaniciID", Convert.ToInt32(KullaniciIDAl));

        conn.Open();

        SqlDataReader dr = sorgu.ExecuteReader();

        Response.Write("Kaydiniz Basariyla Guncellenmistir.");

    }
}