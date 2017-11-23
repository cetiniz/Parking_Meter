using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
    public sealed partial class PayWithCard : Page
    {
        double topay;
        int hours, mins;
        String accountNumber;
        String PIN;
        bool correctPin;
        bool fromSwipe = false;

        public PayWithCard()
        {
            this.InitializeComponent();
            this.topay = 0.0;
            this.accountNumber = "";
            this.PIN = "";
            this.correctPin = false;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var minsHours = (int[])e.Parameter;
            this.topay = minsHours[0] * 60 * 0.05 + minsHours[1] * 0.05;
            this.hours = minsHours[0];
            this.mins = minsHours[1];

            AmounttoPay.Text = "$" + this.topay;
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.GoBack();
            //int[] passArgs = { this.mins, this.hours };
            //this.Frame.Navigate(typeof(ChoosePaymentPage), passArgs);
        }
        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }



        private void goStart(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StartPage));
        }

        private void goHelp(object sender, RoutedEventArgs e)
        {

        }

        private void goFinal(object sender, RoutedEventArgs e)
        {
            if (fromSwipe)
            {
                if (this.accountNumber.Length == 4)
                {
                    int[] args = { this.hours, this.mins };
                    this.Frame.Navigate(typeof(PaymentSuccessPage), args);
                }
                else
                {
                    DisplayErrorPIN(sender, e);
                }
            }
            else
            {
                if (this.accountNumber.Length == 19)
                {
                    FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
                }
                else
                {
                    DisplayErrorCredit(sender, e);
                }
            }
        }
        private async void DisplayErrorCredit(object sender, RoutedEventArgs e)
        {
            ContentDialog NumberError = new ContentDialog
            {
                Title = "Account Number Incorrect or too Short!",
                Content = "Please retype account number",
                CloseButtonText = "Ok"
            };
            ContentDialogResult accountNumber = await NumberError.ShowAsync();
        }
        private async void DisplayErrorPIN(object sender, RoutedEventArgs e)
        {
            ContentDialog NumberError = new ContentDialog
            {
                Title = "PIN Incorrect!",
                Content = "Please retype PIN number",
                CloseButtonText = "Ok"
            };
            ContentDialogResult accountNumber = await NumberError.ShowAsync();
        }

        private void DialogPrompt(object sender, RoutedEventArgs e)
        {

        }
        private async void DisplayPromptFileDialog(object sender, RoutedEventArgs e)
        {
            ContentDialog promptFileDialog = new ContentDialog
            {
                Title = "Payment Type",
                Content = "Do you want to pay with Credit or Debit?",
                PrimaryButtonText = "Credit",
                CloseButtonText = "Debit"
            };

            ContentDialogResult result = await promptFileDialog.ShowAsync();

            // Delete the file if the user clicked the primary button.
            /// Otherwise, do nothing.
            if (result == ContentDialogResult.Primary)
            {
                ContentDialog creditChoice = new ContentDialog
                {
                    Title = "Credit Selected",

                    PrimaryButtonText = "Please enter PIN on keypad"
                };
                ContentDialogResult credit = await creditChoice.ShowAsync();

                if (credit == ContentDialogResult.Primary)
                {
                    this.fromSwipe = true;
                }
            }
            else
            {
                ContentDialog promptDebitSelection = new ContentDialog
                {
                    Title = "Account Type",
                    Content = "Which account would you like to withdraw money from: Chequing or Savings?",
                    PrimaryButtonText = "Chequing",
                    CloseButtonText = "Savings"
                };
                ContentDialogResult debitSelection = await promptDebitSelection.ShowAsync();
                if (debitSelection == ContentDialogResult.Primary)
                {
                    ContentDialog chequeing = new ContentDialog
                    {
                        Title = "Chequing account Selected",
                        //Content = "Please Procedure to enter Pin!",
                        PrimaryButtonText = "Please enter PIN on keypad"
                    };
                    ContentDialogResult chequingAcc = await chequeing.ShowAsync();

                    if (chequingAcc == ContentDialogResult.Primary)
                    {
                        this.fromSwipe = true;
                    }
                }
                else
                {
                    ContentDialog savings = new ContentDialog
                    {
                        Title = "Savings account Selected",
                        //Content = "Please Procedure to enter Pin!",
                        PrimaryButtonText = "Please enter PIN on keypad"
                    };
                    ContentDialogResult savingAcc = await savings.ShowAsync();

                    if (savingAcc == ContentDialogResult.Primary)
                    {
                        this.fromSwipe = true;
                    }
                }
            }
        }

        private void enter0(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 19)
            {
                if (accountNumber.Length == 4 || accountNumber.Length == 9 || accountNumber.Length == 14)
                    this.accountNumber += "-0";
                else
                    this.accountNumber += "0";

                updateString();
            }
        }
        private void enter1(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 19)
            {
                if (accountNumber.Length == 4 || accountNumber.Length == 9 || accountNumber.Length == 14)
                    this.accountNumber += "-1";
                else
                    this.accountNumber += "1";
                updateString();
            }
        }
        private void enter2(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 19)
            {
                if (accountNumber.Length == 4 || accountNumber.Length == 9 || accountNumber.Length == 14)
                    this.accountNumber += "-2";
                else
                    this.accountNumber += "2";
                updateString();
            }
        }
        private void enter3(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 19)
            {
                if (accountNumber.Length == 4 || accountNumber.Length == 9 || accountNumber.Length == 14)
                    this.accountNumber += "-3";
                else
                    this.accountNumber += "3";
                updateString();
            }
        }
        private void enter4(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 19)
            {
                if (accountNumber.Length == 4 || accountNumber.Length == 9 || accountNumber.Length == 14)
                    this.accountNumber += "-4";
                else
                    this.accountNumber += "4";
                updateString();
            }
        }
        private void enter5(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 19)
            {
                if (accountNumber.Length == 4 || accountNumber.Length == 9 || accountNumber.Length == 14)
                    this.accountNumber += "-5";
                else
                    this.accountNumber += "5";
                updateString();
            }
        }
        private void enter6(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 19)
            {
                if (accountNumber.Length == 4 || accountNumber.Length == 9 || accountNumber.Length == 14)
                    this.accountNumber += "-6";
                else
                    this.accountNumber += "6";
                updateString();
            }
        }
        private void enter7(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 19)
            {
                if (accountNumber.Length == 4 || accountNumber.Length == 9 || accountNumber.Length == 14)
                    this.accountNumber += "-7";
                else
                    this.accountNumber += "7";
                updateString();
            }
        }
        private void enter8(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 19)
            {
                if (accountNumber.Length == 4 || accountNumber.Length == 9 || accountNumber.Length == 14)
                    this.accountNumber += "-8";
                else
                    this.accountNumber += "8";
                updateString();
            }
        }
        private void enter9(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 19)
            {
                if (accountNumber.Length == 4 || accountNumber.Length == 9 || accountNumber.Length == 14)
                    this.accountNumber += "-9";
                else
                    this.accountNumber += "9";
                updateString();
            }
        }

        private void RemoveCharFunc(object sender, RoutedEventArgs e)
        {
            if (this.accountNumber.Length > 0)
            {
                if (this.accountNumber.Length == 6 || this.accountNumber.Length == 11 || this.accountNumber.Length == 16)
                {
                    this.accountNumber = this.accountNumber.Remove(this.accountNumber.Length - 2);
                }
                else
                {
                    this.accountNumber = this.accountNumber.Remove(this.accountNumber.Length - 1);
                }
                updateString();
            }
        }

        private void updateString()
        {
            NumberBox.Text = accountNumber;
        }
        //PinText.Text == name of textbox we are looking at
        private void ONE(object sender, RoutedEventArgs e)
        {
            if(this.PIN.Length < 4)
            { 
                this.PIN += "1";
                updatePin();
            }
        }
        private void TWO(object sender, RoutedEventArgs e)
        {
            if (this.PIN.Length < 4)
            {
                this.PIN += "2";
                updatePin();
            }
        }
        private void THREE(object sender, RoutedEventArgs e)
        {
            if (this.PIN.Length < 4)
            {
                this.PIN += "3";
                updatePin();
            }
        }
        private void FOUR(object sender, RoutedEventArgs e)
        {
            if (this.PIN.Length < 4)
            {
                this.PIN += "4";
                updatePin();
            }
        }
        private void FIVE(object sender, RoutedEventArgs e)
        {
            if (this.PIN.Length < 4)
            {
                this.PIN += "5";
                updatePin();
            }
        }
        private void SIX(object sender, RoutedEventArgs e)
        {
            if (this.PIN.Length < 4)
            {
                this.PIN += "6";
                updatePin();
            }
        }
        private void SEVEN(object sender, RoutedEventArgs e)
        {
            if (this.PIN.Length < 4)
            {
                this.PIN += "7";
                updatePin();
            }
        }
        private void EIGHT(object sender, RoutedEventArgs e)
        {
            if (this.PIN.Length < 4)
            {
                this.PIN += "8";
                updatePin();
            }
        }
        private void NINE(object sender, RoutedEventArgs e)
        {
            if (this.PIN.Length < 4)
            {
                this.PIN += "9";
                updatePin();
            }
        }
        private void ZERO(object sender, RoutedEventArgs e)
        {
            if (this.PIN.Length < 4)
            {
                this.PIN += "0";
                updatePin();
            }
        }
        private void DELETE(object sender, RoutedEventArgs e)
        {
            if (this.PIN.Length > 0)
            {
                this.PIN = this.PIN.Remove(this.PIN.Length - 1);
                updatePin();
            }
        }
        private async void ENTER(object sender, RoutedEventArgs e)
        {
            await checkPin();
            if (this.PIN.Length == 4 && correctPin)
            {
                this.correctPin = false;
                int[] args = { this.hours, this.mins };
                this.Frame.Navigate(typeof(PaymentSuccessPage),args);
            }
        }
        private void updatePin()
        {
            PinText.Text = this.PIN;
        }
        private async Task checkPin()
        {
            //METHOD TO READ FOR FILE!
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile = await storageFolder.GetFileAsync("users.txt");
            string text = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);

            if (text.Substring(0, 19).Equals(this.accountNumber))
            {
                if (text.Substring(20, 4).Equals(this.PIN))
                {
                    this.correctPin = true;
                }
                else { PinText.Text = text.Substring(21, 4); }
            }
            if (text.Substring(41, 19).Equals(this.accountNumber))
            {
                if (text.Substring(61, 4).Equals(this.PIN))
                {
                    this.correctPin = true;
                }
                else { PinText.Text = text.Substring(62, 4); }
            }
            if (text.Substring(80, 19).Equals(this.accountNumber))
            {
                if (text.Substring(103, 4).Equals(this.PIN))
                {
                    this.correctPin = true;
                }
                else { PinText.Text = text.Substring(103, 4); }
            }
        }
    }
}
