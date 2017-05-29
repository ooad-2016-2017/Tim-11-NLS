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
    public sealed partial class KoordinatorZaPosjeteITransportForma : Page, INotifyPropertyChanged
    {
        private UltraMegaGigaViewModel UltraMegaGiga;

        public event PropertyChangedEventHandler PropertyChanged;

        public KoordinatorZaPosjeteITransportForma()
        {
            this.InitializeComponent();
            
            Frejm.Navigate(typeof(KoordinatorPocetna));
        }
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
        public void PrikaziMeni_Click(object sender, RoutedEventArgs e) { MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen; }
        public void RasporedPosjeta_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
            Frejm.Navigate(typeof(RasporedPosjeta), this.DataContext);
        }
        public void Posjetioci_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;

            Frejm.Navigate(typeof(Posjetioci),this.DataContext);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlavniFrame.Navigate(typeof(LoginPage), this.DataContext);
        }
        public void RasporedTransporta_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
            Frejm.Navigate(typeof(RasporedTransporta), this.DataContext);
        }

        
    }
}
