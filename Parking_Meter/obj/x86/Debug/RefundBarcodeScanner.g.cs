﻿#pragma checksum "C:\Users\Zach\source\repos\Parking_Meter\Parking_Meter\RefundBarcodeScanner.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "563C8CB2FFB05C982E636B86D6D1BFFB"
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
    partial class RefundBarcodeScanner : 
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
                    #line 20 "..\..\..\RefundBarcodeScanner.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.back).Click += this.goBack;
                    #line default
                }
                break;
            case 3:
                {
                    this.cancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\RefundBarcodeScanner.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancel).Click += this.goStart;
                    #line default
                }
                break;
            case 4:
                {
                    this.help = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 30 "..\..\..\RefundBarcodeScanner.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.help).Click += this.goHelp;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 36 "..\..\..\RefundBarcodeScanner.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.goNext;
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

