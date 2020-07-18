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
    public partial class HesapHareketleri : PhoneApplicationPage
    {
        private bool p;

        public HesapHareketleri(bool p)
        {
            InitializeComponent();

            Service1Client proxy = new Service1Client();

            proxy.HesapIstendiMiKontroluCompleted += new EventHandler<HesapIstendiMiKontroluCompletedEventArgs>(proxy_HesapIstendiMiKontroluCompleted);
            proxy.HesapIstendiMiKontroluAsync(p);


        }

        void proxy_HesapIstendiMiKontroluCompleted(object sender, HesapIstendiMiKontroluCompletedEventArgs e)
        {
            listBox1.ItemsSource = e.Result;
        }
       

        private void KasayaGonder_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}