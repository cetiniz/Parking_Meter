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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Parking_Meter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DeductFromAccount : Page
    {
        double topay, balanceRemaining;
        int hours, mins;

        public DeductFromAccount()
        {
            this.InitializeComponent();
            this.topay = 0.0;
            this.balanceRemaining = 0.0;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var minsHours = (int[])e.Parameter;
            this.topay = minsHours[0] * 60 * 0.05 + minsHours[1] * 0.05;
            this.hours = minsHours[0];
            this.mins = minsHours[1];
            amountToBeDeducted.Text = "$ " + this.topay;
            accountBalance.Text = "$ " + (this.topay + 5.00);
            this.balanceRemaining = 5.00;
        }

        private void confirmAccountDeduction(object sender, RoutedEventArgs e)
        {
            int[] args = { this.hours, this.mins, Convert.ToInt32(this.balanceRemaining) };
            this.Frame.Navigate(typeof(FinalAccountBalance), args);
        }
        private void goBack(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.GoBack();
            //int[] passArgs = { this.mins, this.hours, };
            //this.Frame.Navigate(typeof(CityParkPay), passArgs);
        }

        private void goStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StartPage));
        }

        private void goHelp(object sender, RoutedEventArgs e)
        {

        }
    }
}
