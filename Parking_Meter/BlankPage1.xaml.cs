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
    public sealed partial class BlankPage1 : Page
    {
        int hours, min;

        public BlankPage1()
        {
            this.InitializeComponent();
        }


        private void goNext(object sender, RoutedEventArgs e)
        {
            int[] param = new int[2] { this.min, this.hours };
            this.Frame.Navigate(typeof(Processing), param);
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            int[] param = new int[2] { this.min, this.hours };
            this.Frame.Navigate(typeof(PurchasePage), param);
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
