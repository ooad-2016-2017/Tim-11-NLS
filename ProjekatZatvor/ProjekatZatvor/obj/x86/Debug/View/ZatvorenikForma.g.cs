﻿#pragma checksum "C:\Users\Korisnik\Desktop\OVDJERADIS\ProjekatZatvor\ProjekatZatvor\View\ZatvorenikForma.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7B7D311111D0E940E09E9A27474E736E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjekatZatvor
{
    partial class ZatvorenikForma : 
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
                    this.GlavniFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\View\ZatvorenikForma.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.Button_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.MojSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element4 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 51 "..\..\..\View\ZatvorenikForma.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element4).Tapped += this.PrijavaUKLub_Tapped;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 53 "..\..\..\View\ZatvorenikForma.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element5).Tapped += this.OdlazakDoktoru_Tapped;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element6 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 55 "..\..\..\View\ZatvorenikForma.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element6).Tapped += this.Zahtjev_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    this.Frejm = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 8:
                {
                    this.PrikaziMeni = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\View\ZatvorenikForma.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.PrikaziMeni).Click += this.PrikaziMeni_Click;
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

