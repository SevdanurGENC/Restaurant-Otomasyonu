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

namespace RestaurantOtomasyonu_GarsonElTerminali
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            SupportedOrientations = SupportedPageOrientation.Portrait | SupportedPageOrientation.Landscape;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string kadi = textBox1.Text;
            string sif = textBox2.Text;
            this.Content = new AnaSayfa(kadi, sif);
        }
    }
}