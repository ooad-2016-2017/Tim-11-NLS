﻿#pragma checksum "C:\Users\Korisnik\Desktop\OVDJERADIS\ProjekatZatvor\ProjekatZatvor\View\RasporedTransporta.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8147466AB4CE153124C9876284A8EFC0"
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
    partial class RasporedTransporta : 
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
                    this.ime = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 2:
                {
                    this.zatvorenik = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 3:
                {
                    this.Odrediste = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 95 "..\..\..\View\RasporedTransporta.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.Button_Click;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 33 "..\..\..\View\RasporedTransporta.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.Back_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.listica4 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 7:
                {
                    this.listica3 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 8:
                {
                    this.listica2 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 9:
                {
                    this.listica1 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
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

