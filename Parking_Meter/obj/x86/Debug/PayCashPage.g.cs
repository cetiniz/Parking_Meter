﻿#pragma checksum "C:\Users\Zach\source\repos\Parking_Meter\Parking_Meter\PayCashPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "17298DBE0965C87A7858FABF7985E359"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parking_Meter
{
    partial class PayCashPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.cancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancel).Click += this.goStart;
                    #line default
                }
                break;
            case 3:
                {
                    this.help = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.help).Click += this.goHelp;
                    #line default
                }
                break;
            case 4:
                {
                    this.paidBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.topayBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.ChangeDue = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.proceed = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 54 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.proceed).Click += this.goPaymentSuccess;
                    #line default
                }
                break;
            case 8:
                {
                    this.GoBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 57 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.GoBack).Click += this.GoBackAction;
                    #line default
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.Image element9 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 60 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)element9).Tapped += this.Image_Tapped;
                    #line default
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.Image element10 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 75 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)element10).Tapped += this.Tap_to_insert_bills;
                    #line default
                }
                break;
            case 11:
                {
                    this.bill5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 79 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bill5).Click += this.Bill5;
                    #line default
                }
                break;
            case 12:
                {
                    this.bill10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 80 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bill10).Click += this.Bill10;
                    #line default
                }
                break;
            case 13:
                {
                    this.bill20 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 81 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bill20).Click += this.Bill20;
                    #line default
                }
                break;
            case 14:
                {
                    this.bill50 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 82 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bill50).Click += this.Bill50;
                    #line default
                }
                break;
            case 15:
                {
                    this.bill100 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 83 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bill100).Click += this.Bill100;
                    #line default
                }
                break;
            case 16:
                {
                    this.Nickel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 64 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Nickel).Click += this.NickelP;
                    #line default
                }
                break;
            case 17:
                {
                    this.Dime = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 65 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Dime).Click += this.DimeP;
                    #line default
                }
                break;
            case 18:
                {
                    this.Quarter = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 66 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Quarter).Click += this.QuarterP;
                    #line default
                }
                break;
            case 19:
                {
                    this.Loonie = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 67 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Loonie).Click += this.LoonieP;
                    #line default
                }
                break;
            case 20:
                {
                    this.Toonie = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 68 "..\..\..\PayCashPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Toonie).Click += this.ToonieP;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

