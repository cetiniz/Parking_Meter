using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Parking_Meter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChoosePaymentPage : Page
    {
        int min, hours;

        public ChoosePaymentPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var par = (int[])e.Parameter;
            this.hours = par[0];
            this.min = par[1];

            var price = this.min * 0.05 + this.hours * 60 * 0.05;
            feedback.Text = "The cost of parking for " + hours + " hours, " + min + "min is $ " + price;
        }


        private void goBack(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.GoBack();
            //int[] param = new int[2] { this.hours, this.min };
            //this.Frame.Navigate(typeof(PurchasePage), param);
        }

        private void goStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StartPage));
        }

        private void goHelp(object sender, RoutedEventArgs e)
        {

        }

        private void goCash(object sender, RoutedEventArgs e)
        {
            int[] hourMins = { this.hours, this.min };
            this.Frame.Navigate(typeof(PayCashPage), hourMins);
        }

        private void goDebitCredit(object sender, RoutedEventArgs e)
        {
            int[] passArgs = { this.hours, this.min };
            this.Frame.Navigate(typeof(PayWithCard), passArgs);
        }

        private void goAccount(object sender, RoutedEventArgs e)
        {
            int[] hourMins = { this.hours, this.min };
            this.Frame.Navigate(typeof(CityParkPay), hourMins);
        }
    }
}
