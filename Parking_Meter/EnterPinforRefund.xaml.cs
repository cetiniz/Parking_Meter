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
    public sealed partial class EnterPinforRefund : Page
    {

        String PIN;

        public EnterPinforRefund()
        {
            this.InitializeComponent();
            this.PIN = "";
        }
        private void goBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuPage));
        }

        private void goHelp(object sender, RoutedEventArgs e)
        {

        }
        private void goFinal(object sender, RoutedEventArgs e)
        {
            int[] passArgs = { 30, 1 };
            this.Frame.Navigate(typeof(RefundTicketChange), passArgs);
        }


        private void enter0(object sender, RoutedEventArgs e)
        {
            if (PIN.Length < 4)
            {
                this.PIN += "0";

                updateString();
            }
        }
        private void enter1(object sender, RoutedEventArgs e)
        {
            if (PIN.Length < 4)
            {
                this.PIN += "1";
                updateString();
            }
        }
        private void enter2(object sender, RoutedEventArgs e)
        {
            if (PIN.Length < 4)
            {
                this.PIN += "2";
                updateString();
            }
        }
        private void enter3(object sender, RoutedEventArgs e)
        {
            if (PIN.Length < 3)
            {
                this.PIN += "1";
                updateString();
            }
        }
        private void enter4(object sender, RoutedEventArgs e)
        {
            if (PIN.Length < 4)
            {
                this.PIN += "4";
                updateString();
            }
        }
        private void enter5(object sender, RoutedEventArgs e)
        {
            if (PIN.Length < 4)
            {
                this.PIN += "5";
                updateString();
            }
        }
        private void enter6(object sender, RoutedEventArgs e)
        {
            if (PIN.Length < 6)
            {
                this.PIN += "1";
                updateString();
            }
        }
        private void enter7(object sender, RoutedEventArgs e)
        {
            if (PIN.Length < 7)
            {
                this.PIN += "1";
                updateString();
            }
        }
        private void enter8(object sender, RoutedEventArgs e)
        {
            if (PIN.Length < 8)
            {
                this.PIN += "1";
                updateString();
            }
        }
        private void enter9(object sender, RoutedEventArgs e)
        {
            if (PIN.Length < 4)
            {
                this.PIN += "9";
                updateString();
            }
        }

        private void RemoveCharFunc(object sender, RoutedEventArgs e)
        {
            if (this.PIN.Length > 0)
            {
                this.PIN = this.PIN.Remove(this.PIN.Length - 1);
                updateString();
            }
        }

        private void updateString()
        {
            NumberBox.Text = PIN;
        }
    }
}
