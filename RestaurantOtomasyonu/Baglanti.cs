using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Baglanti
/// </summary>
public class Baglanti
{ 
    
    public Baglanti()
	{   
            SqlConnection baglanti = new SqlConnection(@"Data Source=SEVDANUR-PC\NANO;
                Initial Catalog=RestaurantOtomasyonu;Integrated Security=True"); 
  
       
    }
     
     
}