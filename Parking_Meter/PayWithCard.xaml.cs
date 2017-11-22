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
    public sealed partial class PayWithCard : Page
    {
        double topay;
        int hours, mins;
        String accountNumber;

        public PayWithCard()
        {
            this.InitializeComponent();
            this.topay = 0.0;
            this.accountNumber = "";
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var minsHours = (int[])e.Parameter;
            this.topay = minsHours[0] * 60 * 0.05 + minsHours[1] * 0.05;
            this.hours = minsHours[0];
            this.mins = minsHours[1];
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            int[] passArgs = { this.mins, this.hours };
            this.Frame.Navigate(typeof(ChoosePaymentPage), passArgs);
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
            this.Frame.Navigate(typeof(PaymentSuccessPage));
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

                    CloseButtonText = "Please enter PIN on keypad"
                };
                ContentDialogResult credit = await creditChoice.ShowAsync();
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
                        CloseButtonText = "Please enter PIN on keypad"
                    };
                    ContentDialogResult credit = await chequeing.ShowAsync();
                }
                else
                {
                    ContentDialog savings = new ContentDialog
                    {
                        Title = "Savings account Selected",
                        //Content = "Please Procedure to enter Pin!",
                        CloseButtonText = "Please enter PIN on keypad"
                    };
                    ContentDialogResult savingAcc = await savings.ShowAsync();
                }
            }
        }

        private void enter0(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 12)
            {
                if (accountNumber.Length == 3 || accountNumber.Length == 7)
                    this.accountNumber += "-0";
                else
                    this.accountNumber += "0";

                updateString();
            }
        }
        private void enter1(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 12)
            {
                if (accountNumber.Length == 3 || accountNumber.Length == 7)
                    this.accountNumber += "-1";
                else
                    this.accountNumber += "1";
                updateString();
            }
        }
        private void enter2(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 12)
            {
                if (accountNumber.Length == 3 || accountNumber.Length == 7)
                    this.accountNumber += "-2";
                else
                    this.accountNumber += "2";
                updateString();
            }
        }
        private void enter3(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 12)
            {
                if (accountNumber.Length == 3 || accountNumber.Length == 7)
                    this.accountNumber += "-3";
                else
                    this.accountNumber += "3";
                updateString();
            }
        }
        private void enter4(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 12)
            {
                if (accountNumber.Length == 3 || accountNumber.Length == 7)
                    this.accountNumber += "-4";
                else
                    this.accountNumber += "4";
                updateString();
            }
        }
        private void enter5(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 12)
            {
                if (accountNumber.Length == 3 || accountNumber.Length == 7)
                    this.accountNumber += "-5";
                else
                    this.accountNumber += "5";
                updateString();
            }
        }
        private void enter6(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 12)
            {
                if (accountNumber.Length == 3 || accountNumber.Length == 7)
                    this.accountNumber += "-6";
                else
                    this.accountNumber += "6";
                updateString();
            }
        }
        private void enter7(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 12)
            {
                if (accountNumber.Length == 3 || accountNumber.Length == 7)
                    this.accountNumber += "-7";
                else
                    this.accountNumber += "7";
                updateString();
            }
        }
        private void enter8(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 12)
            {
                if (accountNumber.Length == 3 || accountNumber.Length == 7)
                    this.accountNumber += "-8";
                else
                    this.accountNumber += "8";
                updateString();
            }
        }
        private void enter9(object sender, RoutedEventArgs e)
        {
            if (accountNumber.Length < 12)
            {
                if (accountNumber.Length == 3 || accountNumber.Length == 7)
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
                if (this.accountNumber.Length == 5)
                {
                    this.accountNumber = this.accountNumber.Remove(this.accountNumber.Length - 2);
                }
                else if (this.accountNumber.Length == 9)
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

    }
}
