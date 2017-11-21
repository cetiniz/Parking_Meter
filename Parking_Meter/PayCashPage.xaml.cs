﻿using System;
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

        public PayCashPage()
        {
            this.InitializeComponent();

            this.paid = 0.0;
            this.topay = 0.0;
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.topay = (double)e.Parameter;
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
    }
}
