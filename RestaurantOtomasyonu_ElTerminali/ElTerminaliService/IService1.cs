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
        List<ElTerminali> SiparisBul(bool WebSiparisMi, bool TahsilatDurumu);

        [OperationContract]
        void TahsilEt(int SiparisNo, bool deger);
    }
}
