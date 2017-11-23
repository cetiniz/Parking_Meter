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
    public sealed partial class PaymentSuccessPage : Page
    {
        int hours, mins;
        public PaymentSuccessPage()
        {
            this.InitializeComponent();
        }

        private void goHelp(object sender, RoutedEventArgs e)
        {
            
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var minsHours = (int[])e.Parameter;
            this.hours = minsHours[0];
            this.mins = minsHours[1];
        }
        private void goYes(object sender, RoutedEventArgs e)
        {
            int[] args = { this.hours, this.mins };
            this.Frame.Navigate(typeof(YesPage), args);
        }

        private void goNo(object sender, RoutedEventArgs e)
        {
            int[] args = { this.hours, this.mins };
            this.Frame.Navigate(typeof(NoPage), args);
        }
    }
}
