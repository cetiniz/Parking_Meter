﻿#pragma checksum "C:\Users\Zach\source\repos\Parking_Meter\Parking_Meter\CityParkPay.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F62361BD5E881F30101FFE0F87F80AA3"
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
    partial class CityParkPay : 
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
                    this.back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.back).Click += this.goBack;
                    #line default
                }
                break;
            case 2:
                {
                    this.cancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancel).Click += this.goStart;
                    #line default
                }
                break;
            case 3:
                {
                    this.help = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.help).Click += this.goHelp;
                    #line default
                }
                break;
            case 4:
                {
                    this.b0 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b0).Click += this.enter0;
                    #line default
                }
                break;
            case 5:
                {
                    this.b1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 41 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b1).Click += this.enter1;
                    #line default
                }
                break;
            case 6:
                {
                    this.b2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 47 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b2).Click += this.enter2;
                    #line default
                }
                break;
            case 7:
                {
                    this.b3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 53 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b3).Click += this.enter3;
                    #line default
                }
                break;
            case 8:
                {
                    this.b5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 59 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b5).Click += this.enter5;
                    #line default
                }
                break;
            case 9:
                {
                    this.b6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 65 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b6).Click += this.enter6;
                    #line default
                }
                break;
            case 10:
                {
                    this.b7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 71 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b7).Click += this.enter7;
                    #line default
                }
                break;
            case 11:
                {
                    this.b8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 77 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b8).Click += this.enter8;
                    #line default
                }
                break;
            case 12:
                {
                    this.b9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 83 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b9).Click += this.enter9;
                    #line default
                }
                break;
            case 13:
                {
                    this.NumberBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.RemoveChar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 98 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.RemoveChar).Click += this.RemoveCharFunc;
                    #line default
                }
                break;
            case 15:
                {
                    this.proceed = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 106 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.proceed).Click += this.goToConfirm;
                    #line default
                }
                break;
            case 16:
                {
                    this.b4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 112 "..\..\..\CityParkPay.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b4).Click += this.enter4;
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

