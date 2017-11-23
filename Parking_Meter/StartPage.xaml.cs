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
    public sealed partial class StartPage : Page
    {
        public StartPage()
        {
            this.InitializeComponent();

            this.createFiles();
        }

        private async void createFiles()
        {
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;

            // Create and populate bank accounts file
            Windows.Storage.StorageFile usersFile = await storageFolder.CreateFileAsync("users.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);

            await Windows.Storage.FileIO.WriteTextAsync(usersFile, "1234-5678-9012-3456\t1234\t100\t983-203-482\n" +
                                                                   "8273-1628-9384-2361\t9182\t10\t101-402-308\n" +
                                                                   "1729-1843-2863-1183\t0192\t1\t507-203-879");

            // Create and populate bank accounts file
            Windows.Storage.StorageFile ticketsFile = await storageFolder.CreateFileAsync("tickets.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);

            await Windows.Storage.FileIO.WriteTextAsync(ticketsFile, "8765\t1511389200\t9000\t7.5\n" +
                                                                     "1435\t1511387200\t9000\t7.5\n" +
                                                                     "9867\t1511385200\t9000\t7.5");

            // Reading text from the file
            // string text = await Windows.Storage.FileIO.ReadTextAsync(usersFile);
            // this.test.Text = text;
        }

        private void goNext(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuPage));
        }
    }
}
