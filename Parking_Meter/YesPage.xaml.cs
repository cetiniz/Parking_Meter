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
    public sealed partial class YesPage : Page
    {
        String phoneNumber = "";

        public YesPage()
        {
            this.InitializeComponent();
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PaymentSuccessPage));
        }

        private void goHelp(object sender, RoutedEventArgs e)
        {

        }

        private void enter0(object sender, RoutedEventArgs e)
        {
            if (phoneNumber.Length < 12)
            {
                if (phoneNumber.Length == 3 || phoneNumber.Length == 7)
                    this.phoneNumber += "-0";
                else
                    this.phoneNumber += "0";

                updateString();
            }
        }
        private void enter1(object sender, RoutedEventArgs e)
        {
            if (phoneNumber.Length < 12)
            {
                if (phoneNumber.Length == 3 || phoneNumber.Length == 7)
                    this.phoneNumber += "-1";
                else
                    this.phoneNumber += "1";
                updateString();
            }
        }
        private void enter2(object sender, RoutedEventArgs e)
        {
            if (phoneNumber.Length < 12)
            {
                if (phoneNumber.Length == 3 || phoneNumber.Length == 7)
                    this.phoneNumber += "-2";
                else
                    this.phoneNumber += "2";
                updateString();
            }
        }
        private void enter3(object sender, RoutedEventArgs e)
        {
            if (phoneNumber.Length < 12)
            {
                if (phoneNumber.Length == 3 || phoneNumber.Length == 7)
                    this.phoneNumber += "-3";
                else
                    this.phoneNumber += "3";
                updateString();
            }
        }
        private void enter4(object sender, RoutedEventArgs e)
        {
            if (phoneNumber.Length < 12)
            {
                if (phoneNumber.Length == 3 || phoneNumber.Length == 7)
                    this.phoneNumber += "-4";
                else
                    this.phoneNumber += "4";
                updateString();
            }
        }
        private void enter5(object sender, RoutedEventArgs e)
        {
            if (phoneNumber.Length < 12)
            {
                if (phoneNumber.Length == 3 || phoneNumber.Length == 7)
                    this.phoneNumber += "-5";
                else
                    this.phoneNumber += "5";
                updateString();
            }
        }
        private void enter6(object sender, RoutedEventArgs e)
        {
            if (phoneNumber.Length < 12)
            {
                if (phoneNumber.Length == 3 || phoneNumber.Length == 7)
                    this.phoneNumber += "-6";
                else
                    this.phoneNumber += "6";
                updateString();
            }
        }
        private void enter7(object sender, RoutedEventArgs e)
        {
            if (phoneNumber.Length < 12)
            {
                if (phoneNumber.Length == 3 || phoneNumber.Length == 7)
                    this.phoneNumber += "-7";
                else
                    this.phoneNumber += "7";
                updateString();
            }
        }
        private void enter8(object sender, RoutedEventArgs e)
        {
            if (phoneNumber.Length < 12)
            {
                if (phoneNumber.Length == 3 || phoneNumber.Length == 7)
                    this.phoneNumber += "-8";
                else
                    this.phoneNumber += "8";
                updateString();
            }
        }
        private void enter9(object sender, RoutedEventArgs e)
        {
            if (phoneNumber.Length < 12)
            {
                if (phoneNumber.Length == 3 || phoneNumber.Length == 7)
                    this.phoneNumber += "-9";
                else
                    this.phoneNumber += "9";
                updateString();
            }
        }

        private void RemoveCharFunc(object sender, RoutedEventArgs e)
        {
            if(this.phoneNumber.Length > 0) { 
            if(this.phoneNumber.Length == 5)
            {
                this.phoneNumber = this.phoneNumber.Remove(this.phoneNumber.Length - 2);
            }
            else if (this.phoneNumber.Length == 9)
            {
                this.phoneNumber = this.phoneNumber.Remove(this.phoneNumber.Length - 2);
            }
            else { 
                this.phoneNumber = this.phoneNumber.Remove(this.phoneNumber.Length - 1);
            }
            updateString();
            }
        }

        private void updateString()
        {
            NumberBox.Text = phoneNumber;
        }
    }
}
