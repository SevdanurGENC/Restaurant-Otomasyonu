using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ElTerminaliService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Tbl_Kullanicilar> KullaniciGirisi(string KullaniciAdi, string Sifre);

        [OperationContract]
        List<SiparisListesi> SiparisListele(bool MID);

        [OperationContract]
        List<SiparisListesi> SiparisHazirMiKontrolu(bool SHM);

        [OperationContract]
        List<SiparisListesi> HesapIstendiMiKontrolu(bool HIM);

    } 
}
