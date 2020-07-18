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
    public partial class MasaSiparisleri : PhoneApplicationPage
    {
        private bool p;

        public MasaSiparisleri(bool a)
        {
            InitializeComponent();

            Service1Client proxy = new Service1Client();

            proxy.SiparisListeleCompleted += new EventHandler<SiparisListeleCompletedEventArgs>(proxy_SiparisListeleCompleted);
            proxy.SiparisListeleAsync(a);
        }


        void proxy_SiparisListeleCompleted(object sender, SiparisListeleCompletedEventArgs e)
        {
            listBox1.ItemsSource = e.Result;
        }

        private void AsciyaGonder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}