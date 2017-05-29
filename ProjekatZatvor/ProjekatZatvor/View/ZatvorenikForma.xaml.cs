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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatZatvor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ZatvorenikForma : Page, INotifyPropertyChanged
    {
        private UltraMegaGigaViewModel UltraMegaGiga;
        public ZatvorenikForma()
        {
            this.InitializeComponent();
            Frejm.Navigate(typeof(PocetnaZatvorenik),this.DataContext);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public void VratiSeNaPocetnu()
        {
            Frejm.Navigate(typeof(PocetnaZatvorenik),this.DataContext);
        }
        public void PrikaziMeni_Click(object sender, RoutedEventArgs e) { MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen; }
        public void PrijavaUKLub_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
            Frejm.Navigate(typeof(PrijavaUKlub),this.DataContext); 
        }
        public void OdlazakDoktoru_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
            Frejm.Navigate(typeof(ZahtjevZaOdlazakDoktoru),this.DataContext);
        }

        public void Zahtjev_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
            Frejm.Navigate(typeof(ZahtjevZaPremjestaj),this.DataContext);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlavniFrame.Navigate(typeof(LoginPage),this.DataContext);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            UltraMegaGiga = (UltraMegaGigaViewModel)e.Parameter;
            this.DataContext = UltraMegaGiga;
            base.OnNavigatedTo(e);
        }
    }
}
