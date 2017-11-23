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
    /// 

    public sealed partial class FINALTICKET : Page
    {
        String timeBought;
        int hours, mins;
        public FINALTICKET()
        {
            this.InitializeComponent();
            CurrentTime.Text = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
            CurrentDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

        }
        private void NavigateHome(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StartPage));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var minsHours = (int[])e.Parameter;
            this.hours = minsHours[0];
            this.mins = minsHours[1];

            Cost.Text = "$" + Convert.ToString(this.hours * 60 * 0.05 + this.mins * 0.05);

            DateTime temp = DateTime.Now.AddMinutes(this.mins+this.hours*60);

            ExpireTime.Text = string.Format("{0:hh:mm:ss tt}", temp); 
        }
    }
}
