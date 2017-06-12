using ProjekatZatvor.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using static ProjekatZatvor.UpraviteljForme;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatZatvor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ZaposliRadnika : Page, INotifyPropertyChanged
    {
        private UltraMegaGigaViewModel UltraMegaGiga;
        Validacija val;
        public ZaposliRadnika() {
            this.InitializeComponent();
            val = new Validacija();
        }

        public event PropertyChangedEventHandler PropertyChanged;


        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            UltraMegaGiga = (UltraMegaGigaViewModel)e.Parameter;
            this.DataContext = UltraMegaGiga;
            base.OnNavigatedTo(e);
        }
        private void textBlock1_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock2_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            val.ZaposliRadnikaValidacija(textBox1.Text, prezime.Text, textBox.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox.Items[comboBox.SelectedIndex].ToString(), textBox5.Text);
        }
    }
}
