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
        double paid, topay, change, constant_pay;
        int hours, mins;


        public PayCashPage()
        {
            this.InitializeComponent();

            this.paid = 0.0;
            this.topay = 0.0;
            this.change = 0.0;
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var minsHours = (int[])e.Parameter;
            this.topay = minsHours[0] * 60 * 0.05 + minsHours[1] * 0.05;
            this.constant_pay = minsHours[0] * 60 * 0.05 + minsHours[1] * 0.05;
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
            if(this.topay <= 0) { 
                this.Frame.Navigate(typeof(PaymentSuccessPage));
            }
            else
            {
                DisplayErrorCredit(sender, e);
            }
        }

        private async void DisplayErrorCredit(object sender, RoutedEventArgs e)
        {
            ContentDialog NumberError = new ContentDialog
            {
                Title = "Not enough money provided!",
                Content = "Please add more money into the machine",
                CloseButtonText = "Ok"
            };
            ContentDialogResult accountNumber = await NumberError.ShowAsync();
        }

        private void GoBackAction(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.GoBack();
            //int[] passArgs = { this.mins, this.hours };
            //this.Frame.Navigate(typeof(ChoosePaymentPage), passArgs);
        }
        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        //ADD CHANGE FUNCTIONS BELOW

        private void NickelP(object sender, RoutedEventArgs e)
        {
            this.paid += 0.05;
            this.topay -= 0.05;

            paidBox.Text = "$ " + this.paid;
            topayBox.Text = "$ " + this.topay;

            if (this.topay == 0 && this.paid == this.constant_pay)
            {
                //this.Frame.Navigate(typeof(PaymentSuccessPage));
            } else if (this.topay < 0 && this.paid == 0)
            {
                change = -1 * topay;
            }
        }
        private void DimeP(object sender, RoutedEventArgs e)
        {
            this.paid += 0.1;
            this.topay -= 0.1;

            paidBox.Text = "$ " + this.paid;
            topayBox.Text = "$ " + this.topay;

            if (this.topay == 0 && this.paid == this.constant_pay)
            {
                //this.Frame.Navigate(typeof(PaymentSuccessPage));
            }
            else if (this.topay < 0 && this.paid == 0)
            {
                change = -1 * topay;
            }
        }

        private void QuarterP(object sender, RoutedEventArgs e)
        {
            this.paid += 0.25;
            this.topay -= 0.25;

            paidBox.Text = "$ " + this.paid;
            topayBox.Text = "$ " + this.topay;

            if (this.topay == 0 && this.paid == this.constant_pay)
            {
                // this.Frame.Navigate(typeof(PaymentSuccessPage));
            }
            else if (this.topay < 0 && this.paid == 0)
            {
                change = -1 * topay;
            }
        }

        private void LoonieP(object sender, RoutedEventArgs e)
        {
            this.paid += 1;
            this.topay -= 1;

            paidBox.Text = "$ " + this.paid;
            topayBox.Text = "$ " + this.topay;

            if (this.topay == 0 && this.paid == this.constant_pay)
            {
                //this.Frame.Navigate(typeof(PaymentSuccessPage));
            }
            else if (this.topay < 0 && this.paid == 0)
            {
                change = -1 * topay;
            }
        }

        private void ToonieP(object sender, RoutedEventArgs e)
        {
            this.paid += 2;
            this.topay -= 2;

            paidBox.Text = "$ " + this.paid;
            topayBox.Text = "$ " + this.topay;

            if (this.topay == 0 && this.paid == this.constant_pay)
            {
                //this.Frame.Navigate(typeof(PaymentSuccessPage));
            }
            else if (this.topay < 0 && this.paid == 0)
            {
                change = -1 * topay;
            }
        }

        private void Tap_to_insert_bills(object sender, TappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        private void Bill5(object sender, RoutedEventArgs e)
        {
            this.paid += 5;
            this.topay -= 5;

            paidBox.Text = "$ " + this.paid;
            topayBox.Text = "$ " + this.topay;

            if (this.topay == 0 && this.paid == this.constant_pay)
            {
                //this.Frame.Navigate(typeof(PaymentSuccessPage));
            }
            else if (this.topay < 0 && this.paid == 0)
            {
                change = -1 * topay;
            }
        }
        private void Bill10(object sender, RoutedEventArgs e)
        {
            this.paid += 10;
            this.topay -= 10;

            paidBox.Text = "$ " + this.paid;
            topayBox.Text = "$ " + this.topay;

            if (this.topay == 0 && this.paid == this.constant_pay)
            {
                //this.Frame.Navigate(typeof(PaymentSuccessPage));
            }
            else if (this.topay < 0 && this.paid == 0)
            {
                change = -1 * topay;
            }
        }

        private void Bill20(object sender, RoutedEventArgs e)
        {
            this.paid += 20;
            this.topay -= 20;

            paidBox.Text = "$ " + this.paid;
            topayBox.Text = "$ " + this.topay;

            if (this.topay == 0 && this.paid == this.constant_pay)
            {
                //this.Frame.Navigate(typeof(PaymentSuccessPage));
            }
            else if (this.topay < 0 && this.paid == 0)
            {
                change = -1 * topay;
            }
        }

        private void Bill50(object sender, RoutedEventArgs e)
        {
            this.paid += 50;
            this.topay -= 50;

            paidBox.Text = "$ " + this.paid;
            topayBox.Text = "$ " + this.topay;

            if (this.topay == 0 && this.paid == this.constant_pay)
            {
                //this.Frame.Navigate(typeof(PaymentSuccessPage));
            }
            else if (this.topay < 0 && this.paid == 0)
            {
                change = -1 * topay;
            }
        }

        private void Bill100(object sender, RoutedEventArgs e)
        {
            this.paid += 100;
            this.topay -= 100;

            paidBox.Text = "$ " + this.paid;
            topayBox.Text = "$ " + this.topay;

            if (this.topay == 0 && this.paid == this.constant_pay)
            {
                //this.Frame.Navigate(typeof(PaymentSuccessPage));
            }
            else if (this.topay < 0 && this.paid == 0)
            {
                change = -1 * topay;
            }
        }

    }
}
