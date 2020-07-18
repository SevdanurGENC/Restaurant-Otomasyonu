using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using RestaurantOtomasyonu_ElTerminali.ServiceReference1;

namespace RestaurantOtomasyonu_ElTerminali
{
    public partial class SiparisEkrani : PhoneApplicationPage
    {
        private string kadi;
        private string sif; 

        public SiparisEkrani(string kadi, string sif)
        {
            InitializeComponent();

            Service1Client proxy = new Service1Client();

            proxy.KullaniciGirisiCompleted += new EventHandler<KullaniciGirisiCompletedEventArgs>(proxy_KullaniciGirisiCompleted);
            proxy.KullaniciGirisiAsync(kadi, sif);
      
            proxy.SiparisBulCompleted += new EventHandler<SiparisBulCompletedEventArgs>(proxy_SiparisBulCompleted);
            proxy.SiparisBulAsync(true,false);

        }

        void proxy_SiparisBulCompleted(object sender, SiparisBulCompletedEventArgs e)
        {
            listBox1.ItemsSource = e.Result;
        }

        void proxy_KullaniciGirisiCompleted(object sender, KullaniciGirisiCompletedEventArgs e)
        {
            MessageBox.Show("Sisteme Hosgeldiniz...");
        }

        private void TahsilEt_Click(object sender, RoutedEventArgs e)
        {

        }

 
    }
}