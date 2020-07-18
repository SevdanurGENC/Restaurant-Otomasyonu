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

using RestaurantOtomasyonu_GarsonElTerminali.ServiceReference1;

namespace RestaurantOtomasyonu_GarsonElTerminali
{
    public partial class AnaSayfa : PhoneApplicationPage
    {
        private string kadi;
        private string sif;

        public AnaSayfa(string kadi, string sif)
        {
            InitializeComponent();

            Service1Client proxy = new Service1Client();

            proxy.KullaniciGirisiCompleted += new EventHandler<KullaniciGirisiCompletedEventArgs>(proxy_KullaniciGirisiCompleted);
            proxy.KullaniciGirisiAsync(kadi, sif);
 
        }

        

        void proxy_KullaniciGirisiCompleted(object sender, KullaniciGirisiCompletedEventArgs e)
        {
            MessageBox.Show("Sisteme Hosgeldiniz...");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new MasaSiparisleri(true);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new AsciOnaylari(true);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new HesapHareketleri(true);
        }
      
    }
}