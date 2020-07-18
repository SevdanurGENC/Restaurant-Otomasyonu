using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElTerminaliService
{
    public class SiparisListesi
    {
        public System.String MasaAdi
        { get; set; }
        public System.Int32 MasaNo
        { get; set; }
        public System.String Isim
        { get; set; }
        public System.String Soyisim
        { get; set; }
        public System.String MenuAdi
        { get; set; }
        public System.String AltMenuAdi
        { get; set; }
        public System.Int32 Adet
        { get; set; }
        public System.String SiparisZamani
        { get; set; }
        public System.String Aciklama
        { get; set; }
        public System.String EkIstekler
        { get; set; }
        public System.Int32 GenelToplam
        { get; set; }
    }
}