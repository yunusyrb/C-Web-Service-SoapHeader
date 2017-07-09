using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public kullanicikimlik km;

    public object SqlConnnection { get; private set; }

    public bool KontrolEt()
    {
        //SqlConnection cnn = new SqlConnection("server=.;Database=Northwind;trusted_connection=true");
        //SqlCommand cmd = new SqlCommand("SELECT COUNT(*)  FROM Uyeler WHERE UyeAdi=@UyeAdi AND UyeSifre=@Sifre");
        //cmd.Parameters.AddWithValue("@UyeAdi", km.KullaniciAdi);
        //cmd.Parameters.AddWithValue("@Sifre", km.KullaniciSifres);
        //cnn.Open();
        //object Gelen = cmd.ExecuteScalar();
        //cnn.Close();
        //if (Gelen == "0")
        //{
        //    return false;
        //}
        //else
        //{
        //    return true;
        //}

        if (km.KullaniciAdi == "Yunus" && km.KullaniciSifres == "123")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    [WebMethod]
    [SoapHeader("km")]
    public string HelloWorld() {

        if (KontrolEt())
        {
            return "Hello World";
        }
        else
        {
            return "Hatalı Kullanıcı Adı veya Şifresi ";
        }
        
    }

    public class kullanicikimlik : SoapHeader 
    {
        public string KullaniciAdi { get; set; }
        public string KullaniciSifres { get; set; }

    }
}