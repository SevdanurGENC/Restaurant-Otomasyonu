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

        public List<SiparisListesi> SiparisListele(bool MID)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var res = from kul in context.Tbl_Kullanicilars
                      from sip in context.Tbl_Siparislers
                      from anam in context.Tbl_AnaMenulers
                      from altm in context.Tbl_AltMenulers
                      from mas in context.Tbl_Masalars
                      where kul.KullaniciID == sip.KullaniciID &&
                            sip.AltMenuID == altm.AltMenuID &&
                            sip.MenuID == anam.MenuID && 
                            mas.ID == sip.MasaID &&
                            sip.MasaSiparisiMi == MID && 
                            sip.TahsilatDurumu == false
                      select new SiparisListesi
                      {
                          MasaNo = Convert.ToInt32(mas.MasaNo),
                          MasaAdi = mas.MasaAdi,
                          Isim = kul.Isim,
                          Soyisim = kul.Soyisim,
                          MenuAdi = anam.MenuAdi,
                          AltMenuAdi = altm.AltMenuAdi,
                          Adet = Convert.ToInt32(sip.Adet),
                          SiparisZamani = sip.SiparisZamani,
                          Aciklama = sip.Aciklama,
                          EkIstekler = sip.EkIstekler,
                          GenelToplam = Convert.ToInt32(sip.GenelToplam)
                      };
            return res.ToList<SiparisListesi>();
        }

        public List<SiparisListesi> SiparisHazirMiKontrolu(bool SHM)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var res = from kul in context.Tbl_Kullanicilars
                      from sip in context.Tbl_Siparislers
                      from anam in context.Tbl_AnaMenulers
                      from altm in context.Tbl_AltMenulers
                      from mas in context.Tbl_Masalars
                      where kul.KullaniciID == sip.KullaniciID &&
                            sip.AltMenuID == altm.AltMenuID &&
                            sip.MenuID == anam.MenuID &&
                            mas.ID == sip.MasaID &&
                            sip.MasaSiparisiMi == SHM &&
                            sip.TahsilatDurumu == false
                      select new SiparisListesi
                      {
                          MasaNo = Convert.ToInt32(mas.MasaNo),
                          MasaAdi = mas.MasaAdi,
                          MenuAdi = anam.MenuAdi,
                          AltMenuAdi = altm.AltMenuAdi,
                          Adet = Convert.ToInt32(sip.Adet),
                          SiparisZamani = sip.SiparisZamani,
                          Aciklama = sip.Aciklama,
                          EkIstekler = sip.EkIstekler,
                      };
            return res.ToList<SiparisListesi>();
        
        }

        public List<SiparisListesi> HesapIstendiMiKontrolu(bool HIM)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var res = from kul in context.Tbl_Kullanicilars
                      from sip in context.Tbl_Siparislers
                      from anam in context.Tbl_AnaMenulers
                      from altm in context.Tbl_AltMenulers
                      from mas in context.Tbl_Masalars
                      where kul.KullaniciID == sip.KullaniciID &&
                            sip.AltMenuID == altm.AltMenuID &&
                            sip.MenuID == anam.MenuID &&
                            mas.ID == sip.MasaID &&
                            sip.MasaSiparisiMi == true &&
                            sip.TahsilatDurumu == false &&
                            sip.SiparisHazirMi == HIM
                      select new SiparisListesi
                      {
                          MasaNo = Convert.ToInt32(mas.MasaNo),
                          MasaAdi = mas.MasaAdi,
                          GenelToplam = Convert.ToInt32(sip.GenelToplam)
                      };
            return res.ToList<SiparisListesi>();
        
        }

    }
}

