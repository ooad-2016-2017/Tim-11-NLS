﻿#pragma checksum "C:\Users\Korisnik\Desktop\ProjekatLilaForme\ProjekatZatvor\View\NumericUpDown.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "83A1E580E1AE3D549D81354734B1B91C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjekatZatvor.View
{
    partial class NumericUpDown : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
                    this.txtNum = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 14 "..\..\..\View\NumericUpDown.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtNum).TextChanged += this.txtNum_TextChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.cmdUp = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\View\NumericUpDown.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.cmdUp).Click += this.cmdUp_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.cmdDown = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\View\NumericUpDown.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.cmdDown).Click += this.cmdDown_Click;
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
