﻿#pragma checksum "C:\Users\Korisnik\Desktop\ProjekatLilaForme\ProjekatZatvor\View\UposlenikForme.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "00F6C3D0FDB21B7C848981DAAC259EC4"
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
    partial class UposlenikForme : 
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
                    #line 67 "..\..\..\View\UposlenikForme.xaml"
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
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 94 "..\..\..\View\UposlenikForme.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.textBlock1).Tapped += this.PrikazZaliha_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6:
                {
                    this.textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 97 "..\..\..\View\UposlenikForme.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.textBlock2).Tapped += this.PodnosenjeZahtjeva_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.image1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 8:
                {
                    this.textBlock3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 100 "..\..\..\View\UposlenikForme.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.textBlock3).Tapped += this.ZahtjevZaNarudzbu_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.image2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10:
                {
                    this.sadrzajPodstranice = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 11:
                {
                    this.PrikaziMeni = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 65 "..\..\..\View\UposlenikForme.xaml"
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

