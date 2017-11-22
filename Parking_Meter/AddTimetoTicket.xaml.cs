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
    public sealed partial class AddTimetoTicket : Page
    {
        int min, hours;
        double price;

        public AddTimetoTicket()
        {
            this.InitializeComponent();

            this.min = 30;
            this.hours = 0;
            this.price = 1.5;

            this.computePrice();
            minutesBox.Text = "" + this.min;
            hoursBox.Text = "" + this.hours;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var par = (int[])e.Parameter;
            this.min = par[0];
            this.hours = par[1];

            computePrice();
            minutesBox.Text = "" + this.min;
            hoursBox.Text = "" + this.hours;
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuPage));
        }

        private void goStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StartPage));
        }

        private void goHelp(object sender, RoutedEventArgs e)
        {

        }

        private void goChoosePayment(object sender, RoutedEventArgs e)
        {
            int[] param = new int[2] { this.min, this.hours };
            this.Frame.Navigate(typeof(ChoosePaymentPage), param);
        }



        public double getPrice() { return this.price; }
        public int getHours() { return this.hours; }
        public int getMinutes() { return this.min; }



        private void incH(object sender, RoutedEventArgs e)
        {
            this.hours++;
            computePrice();
            minutesBox.Text = "" + this.min;
            hoursBox.Text = "" + this.hours;
        }

        private void decH(object sender, RoutedEventArgs e)
        {
            if (this.hours > 1) this.hours--;
            if (this.hours == 1 && this.min > 30) this.hours--;
            computePrice();
            minutesBox.Text = "" + this.min;
            hoursBox.Text = "" + this.hours;
        }

        private void incM(object sender, RoutedEventArgs e)
        {
            this.min += 5;
            if (this.min == 60) { this.min = 0; this.hours++; }
            computePrice();
            minutesBox.Text = "" + this.min;
            hoursBox.Text = "" + this.hours;
        }

        private void decM(object sender, RoutedEventArgs e)
        {
            if (this.min == 30 && this.hours == 0) { }
            else if (this.min == 0 && this.hours >= 1) { this.min = 55; this.hours--; }
            else this.min -= 5;
            computePrice();
            minutesBox.Text = "" + this.min;
            hoursBox.Text = "" + this.hours;
        }

        private void computePrice()
        {
            this.price = this.min * 0.05 + this.hours * 60 * 0.05;
            priceBox.Text = "$ " + this.price;
        }
    }
}

