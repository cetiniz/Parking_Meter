﻿#pragma checksum "C:\Users\Zach\source\repos\Parking_Meter\Parking_Meter\PayWithCard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2A9A96194D37BA3685B61EB5EDD39AF1"
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
    partial class PayWithCard : 
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
                    this.back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.back).Click += this.goBack;
                    #line default
                }
                break;
            case 3:
                {
                    this.help = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.help).Click += this.goHelp;
                    #line default
                }
                break;
            case 4:
                {
                    this.proceed = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.proceed).Click += this.goFinal;
                    #line default
                }
                break;
            case 5:
                {
                    this.b0 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 38 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b0).Click += this.enter0;
                    #line default
                }
                break;
            case 6:
                {
                    this.b1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 44 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b1).Click += this.enter1;
                    #line default
                }
                break;
            case 7:
                {
                    this.b2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 50 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b2).Click += this.enter2;
                    #line default
                }
                break;
            case 8:
                {
                    this.b3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 56 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b3).Click += this.enter3;
                    #line default
                }
                break;
            case 9:
                {
                    this.b4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 62 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b4).Click += this.enter4;
                    #line default
                }
                break;
            case 10:
                {
                    this.b5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 68 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b5).Click += this.enter5;
                    #line default
                }
                break;
            case 11:
                {
                    this.b6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 74 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b6).Click += this.enter6;
                    #line default
                }
                break;
            case 12:
                {
                    this.b7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 80 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b7).Click += this.enter7;
                    #line default
                }
                break;
            case 13:
                {
                    this.b8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 86 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b8).Click += this.enter8;
                    #line default
                }
                break;
            case 14:
                {
                    this.b9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 92 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.b9).Click += this.enter9;
                    #line default
                }
                break;
            case 15:
                {
                    this.NumberBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.AmounttoPay = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.RemoveChar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 100 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.RemoveChar).Click += this.RemoveCharFunc;
                    #line default
                }
                break;
            case 18:
                {
                    global::Windows.UI.Xaml.Controls.Button element18 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 105 "..\..\..\PayWithCard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element18).Click += this.DisplayPromptFileDialog;
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
