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
    public sealed partial class MenuPage : Page
    {
        public MenuPage()
        {
            this.InitializeComponent();
        }

        
        private void goBack(object sender, RoutedEventArgs e)
        {
            
            this.Frame.Navigate(typeof(StartPage));
        }

        private void goStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StartPage));
        }

        private void goHelp(object sender, RoutedEventArgs e)
        {

        }

        private void goPurchase(object sender, RoutedEventArgs e)
        {
            int[] param = new int[2] { 30, 0 };
            this.Frame.Navigate(typeof(PurchasePage), param);
        }

        private void goAdd(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EnterPinOnTicket));
        }

        private void goRefund(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EnterPinforRefund));
        }
    }
}
