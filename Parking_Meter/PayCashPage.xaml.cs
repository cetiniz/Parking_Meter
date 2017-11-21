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
    public sealed partial class PayCashPage : Page
    {
        double paid, topay;
        int hours, mins;

        public PayCashPage()
        {
            this.InitializeComponent();

            this.paid = 0.0;
            this.topay = 0.0;
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var minsHours = (int[])e.Parameter;
            this.topay = minsHours[0] * 60 * 0.05 + minsHours[1] * 0.05;
            this.hours = minsHours[0];
            this.mins = minsHours[1];
            topayBox.Text = "$ " + this.topay;
            paidBox.Text = "$ " + this.paid;
        }


        private void goStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StartPage));
        }

        private void goHelp(object sender, RoutedEventArgs e)
        {

        }

        private void goPaymentSuccess(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PaymentSuccessPage));
        }
        private void GoBackAction(object sender, RoutedEventArgs e)
        {
            int[] passArgs = { this.mins, this.hours };
            this.Frame.Navigate(typeof(ChoosePaymentPage), passArgs);
        }
    }
}
