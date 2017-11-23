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
    public sealed partial class RefundTicketChange : Page
    {

        int hours, mins;
        double changeBack;
        public RefundTicketChange()
        {
            this.InitializeComponent();
        }

        private void goHelp(object sender, RoutedEventArgs e)
        {

        }
        private void goNext(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StartPage));
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            //METHOD TO READ FOR FILE!
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile = await storageFolder.GetFileAsync("tickets.txt");
            string text = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
            
            //Loop through entries
            base.OnNavigatedTo(e);
            String minsHours = (String)e.Parameter;

            if (minsHours == text.Substring(0, 4))
            {
                this.hours = 2;
                this.mins = 20;
                this.changeBack = this.hours * 60 * 0.05 + this.mins * 0.05;
                minutesEarly.Text = this.hours + " hours, " + this.mins + " minutes";
                priceBox.Text = "$" + Convert.ToString(this.changeBack);
            }
            else if(minsHours == text.Substring(25, 4))
            {
                this.hours = 1;
                this.mins = 10;
                this.changeBack = this.hours * 60 * 0.05 + this.mins * 0.05;
                minutesEarly.Text = this.hours + " hours, " + this.mins + " minutes";
                priceBox.Text = "$" + Convert.ToString(this.changeBack);
            }
            else if(minsHours == text.Substring(50, 4))
            {
                this.hours = 4;
                this.mins = 40;
                this.changeBack = this.hours * 60 * 0.05 + this.mins * 0.05;
                minutesEarly.Text = this.hours + " hours, " + this.mins + " minutes";
                priceBox.Text = "$" + Convert.ToString(this.changeBack);
            }
        }
    }
}
