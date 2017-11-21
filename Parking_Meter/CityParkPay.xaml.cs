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
    public sealed partial class CityParkPay : Page
    {
        String accountCode = "";
        double topay;
        int hours, mins;

        public CityParkPay()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var minsHours = (int[])e.Parameter;
            this.topay = minsHours[0] * 60 * 0.05 + minsHours[1] * 0.05;
            this.hours = minsHours[0];
            this.mins = minsHours[1];
        }

        private void enter0(object sender, RoutedEventArgs e)
        {
            if (accountCode.Length < 11)
            {
                if (accountCode.Length == 3 || accountCode.Length == 7)
                    this.accountCode += " 0";
                else
                    this.accountCode += "0";

                updateString();
            }
        }
        private void enter1(object sender, RoutedEventArgs e)
        {
            if (accountCode.Length < 11)
            {
                if (accountCode.Length == 3 || accountCode.Length == 7)
                    this.accountCode += " 1";
                else
                    this.accountCode += "1";
                updateString();
            }
        }
        private void enter2(object sender, RoutedEventArgs e)
        {
            if (accountCode.Length < 11)
            {
                if (accountCode.Length == 3 || accountCode.Length == 7)
                    this.accountCode += " 2";
                else
                    this.accountCode += "2";
                updateString();
            }
        }
        private void enter3(object sender, RoutedEventArgs e)
        {
            if (accountCode.Length < 11)
            {
                if (accountCode.Length == 3 || accountCode.Length == 7)
                    this.accountCode += " 3";
                else
                    this.accountCode += "3";
                updateString();
            }
        }
        private void enter4(object sender, RoutedEventArgs e)
        {
            if (accountCode.Length < 11)
            {
                if (accountCode.Length == 3 || accountCode.Length == 7)
                    this.accountCode += " 4";
                else
                    this.accountCode += "4";
                updateString();
            }
        }
        private void enter5(object sender, RoutedEventArgs e)
        {
            if (accountCode.Length < 11)
            {
                if (accountCode.Length == 3 || accountCode.Length == 7)
                    this.accountCode += " 5";
                else
                    this.accountCode += "5";
                updateString();
            }
        }
        private void enter6(object sender, RoutedEventArgs e)
        {
            if (accountCode.Length < 11)
            {
                if (accountCode.Length == 3 || accountCode.Length == 7)
                    this.accountCode += " 6";
                else
                    this.accountCode += "6";
                updateString();
            }
        }
        private void enter7(object sender, RoutedEventArgs e)
        {
            if (accountCode.Length < 11)
            {
                if (accountCode.Length == 3 || accountCode.Length == 7)
                    this.accountCode += " 7";
                else
                    this.accountCode += "7";
                updateString();
            }
        }
        private void enter8(object sender, RoutedEventArgs e)
        {
            if (accountCode.Length < 11)
            {
                if (accountCode.Length == 3 || accountCode.Length == 7)
                    this.accountCode += " 8";
                else
                    this.accountCode += "8";
                updateString();
            }
        }
        private void enter9(object sender, RoutedEventArgs e)
        {
            if (accountCode.Length < 11)
            {
                if (accountCode.Length == 3 || accountCode.Length == 7)
                    this.accountCode += " 9";
                else
                    this.accountCode += "9";
                updateString();
            }
        }

        private void RemoveCharFunc(object sender, RoutedEventArgs e)
        {
            if (this.accountCode.Length > 0)
            {
                if (this.accountCode.Length == 5)
                {
                    this.accountCode = this.accountCode.Remove(this.accountCode.Length - 2);
                }
                else if (this.accountCode.Length == 9)
                {
                    this.accountCode = this.accountCode.Remove(this.accountCode.Length - 2);
                }
                else
                {
                    this.accountCode = this.accountCode.Remove(this.accountCode.Length - 1);
                }
                updateString();
            }
        }

        private void updateString()
        {
            NumberBox.Text = accountCode;
        }

        private void confirmAccountDeduction(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(PaymentSuccessPage));
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            int[] passArgs = { this.mins, this.hours };
            this.Frame.Navigate(typeof(ChoosePaymentPage), passArgs);
        }

        private void goStart(object sender, RoutedEventArgs e)
        {
            int[] passArgs = { this.mins, this.hours };
            this.Frame.Navigate(typeof(StartPage));
        }

        private void goHelp(object sender, RoutedEventArgs e)
        {

        }
    }
}
