using ProjekatZatvor.Model;
using ProjekatZatvor.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatZatvor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PrijavaUKlub : Page, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private UltraMegaGigaViewModel UltraMegaGiga;

        Validacija val;
        public PrijavaUKlub()
        {
            this.InitializeComponent();
            val = new Validacija();
        }

        public void Back_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null && this.Frame.CanGoBack) this.Frame.GoBack();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            PageStackEntry previousPage = Frame.BackStack.Last();
            Type previousPageType = previousPage?.SourcePageType;
            UltraMegaGiga = (UltraMegaGigaViewModel)e.Parameter;
            this.DataContext = UltraMegaGiga;
            base.OnNavigatedTo(e);
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String naziv = Klub.Items[Klub.SelectedIndex].ToString();
            val.PrijavaUKlubValidacija(Ime.Text, Prezime.Text, Pin.Text, naziv);
        }
    }
    
}
