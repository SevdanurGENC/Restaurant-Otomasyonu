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
    public partial class AsciOnaylari : PhoneApplicationPage
    {
        private bool p;

        public AsciOnaylari(bool a)
        {
            InitializeComponent();

            Service1Client proxy = new Service1Client();

            proxy.SiparisHazirMiKontroluCompleted += new EventHandler<SiparisHazirMiKontroluCompletedEventArgs>(proxy_SiparisHazirMiKontroluCompleted);
            proxy.SiparisHazirMiKontroluAsync(a);

        }

        void proxy_SiparisHazirMiKontroluCompleted(object sender, SiparisHazirMiKontroluCompletedEventArgs e)
        {
            listBox1.ItemsSource = e.Result;
        }
        
    }
}