using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ElTerminaliService
{
    public class Service1 : IService1
    {

        public List<Tbl_Kullanicilar> KullaniciGirisi(string KullaniciAdi, string Sifre)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var sonuc = from kul in context.Tbl_Kullanicilars
                        where kul.KullaniciAdi == KullaniciAdi &&
                        kul.Sifre == Sifre
                        select kul;

            return sonuc.ToList<Tbl_Kullanicilar>();

        }       
        
        public List<ElTerminali> SiparisBul(bool WebSiparisMi, bool TahsilatDurumu)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var res = from kul in context.Tbl_Kullanicilars
                      from sip in context.Tbl_Siparislers
                      from anam in context.Tbl_AnaMenulers
                      from altm in context.Tbl_AltMenulers
                      where kul.KullaniciID == sip.KullaniciID &&
                            sip.AltMenuID == altm.AltMenuID &&
                            sip.MenuID == anam.MenuID &&
                            sip.WebSiparisiMi == true &&
                            sip.TahsilatDurumu == false 
                      select new ElTerminali
                      {
                          Isim = kul.Isim,
                          Soyisim = kul.Soyisim,
                          Adres = kul.Adres,
                          MenuAdi = anam.MenuAdi,
                          AltMenuAdi = altm.AltMenuAdi,
                          Adet = Convert.ToInt32(sip.Adet),
                          Fiyat = Convert.ToInt32(sip.Fiyat),
                          SiparisZamani = Convert.ToDateTime(sip.SiparisZamani),
                          Aciklama = sip.Aciklama,
                          EkIstekler = sip.EkIstekler,
                          GenelToplam = Convert.ToInt32(sip.GenelToplam)
                      };

            return res.ToList<ElTerminali>();
        }

        public void TahsilEt(int SiparisNo, bool deger)
        {
            //DataClasses1DataContext context = new DataClasses1DataContext();
            //var query = from sip in context.Tbl_Siparislers
            //            where sip.SiparisID == SiparisNo
            //            select sip;
             
            //        foreach (Tbl_Siparisler ord in query)
            //        {
            //            ord.TahsilatDurumu = true;
            //        }

            //       context.SubmitChanges(); 
                    //return query.ToList<Tbl_Siparisler>();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Tbl_Siparisler sip = db.Tbl_Siparislers.FirstOrDefault(p => p.SiparisID == SiparisNo);
                sip.TahsilatDurumu = deger;
                db.SubmitChanges();
            }

            //var son = from si in context.Tbl_Siparislers
            //          where si.SiparisID == SiparisNo
            //          select new ElTerminali { SiparisID = Convert.ToInt32(si.SiparisID)};

            //return son.ToList<ElTerminali>();
        
        }
    
    }
}




//var res = (from p in context.Tbl_Siparislers
//           where p.SiparisID == SiparisNo
//           select p).Single();

//res.TahsilatDurumu = true;

//context.SubmitChanges();