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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjekatZatvor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UposlenikForme : Page, INotifyPropertyChanged
    {
        private UltraMegaGigaViewModel UltraMegaGiga;
        public UposlenikForme(){
            this.InitializeComponent();
        }

        public class Params {
            public int myProperty { get; set; }
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

      
        private void PrikaziMeni_Click(object sender, RoutedEventArgs e){
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
        }

        private void PrikaziSadrzaj_Click(object sender, RoutedEventArgs e){
            sadrzajPodstranice.Navigate(typeof(ZaposliRadnika), this.DataContext);
        }

        private void PrikazZaliha_Click(object sender, RoutedEventArgs e) {
            sadrzajPodstranice.Navigate(typeof(PrikazZaliha), this.DataContext);
        }

        private void PodnosenjeZahtjeva_Click(object sender, RoutedEventArgs e) {
            sadrzajPodstranice.Navigate(typeof(PodnesiZahtjev), this.DataContext);
        }

        private void ZahtjevZaNarudzbu_Click(object sender, RoutedEventArgs e) {
            sadrzajPodstranice.Navigate(typeof(NarudzbaForma), this.DataContext);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlavniFrame.Navigate(typeof(LoginPage), this.DataContext);
        }
    }
}
