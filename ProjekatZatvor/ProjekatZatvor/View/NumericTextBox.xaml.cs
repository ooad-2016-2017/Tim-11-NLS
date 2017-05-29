using ProjekatZatvor.Model;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ProjekatZatvor.View
{
    public sealed partial class NumericTextBox : UserControl
    {

        public NumericTextBox()
        {
            this.InitializeComponent();
        }
        public int DajVrijednost()
        {
            int vrijednost = 0;
            int.TryParse(Numeric.Text, out vrijednost);
            return vrijednost;
        }
        public string textblock
        {
            get { return (string)GetValue(textblockProperty); }
            set { SetValue(textblockProperty, value); }
        }
        private static readonly DependencyProperty textblockProperty = DependencyProperty.Register("textblock", typeof(string), typeof(NumericTextBox), null);
        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Tag != null)
            {
                ((ClsNumTextTagIn)tb.Tag).Refresh(tb);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Tag != null)
            {
                ((ClsNumTextTagIn)tb.Tag).Refresh(tb);
            }
        }

        private void TextBox_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Tag != null)
            {
                ((ClsNumTextTagIn)tb.Tag).NumericText(tb);
            }
        }
    }
}
