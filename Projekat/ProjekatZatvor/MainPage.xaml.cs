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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjekatZatvor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }
        public class Params {
            public int myProperty { get; set; }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            
        }
        private void PrikaziMeni_Click(object sender, RoutedEventArgs e) {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
        }
        
       /* public void PrikaziRaspored_Click(object sender, RoutedEventArgs e)
        {
           // var menuPodstranica = (e.AddedItems[0]);
            sadrzajPodstranice.Navigate(typeof(UpravnikRaspored), new Params() { myProperty=42});
            //sadrzajPodstranice.Navigate(typeof(MainPage1));

        }*/
        public void PrikaziZahtjeve_Click(object sender, RoutedEventArgs e)
        {
            // var menuPodstranica = (e.AddedItems[0]);
            sadrzajPodstranice.Navigate(typeof(ZahtjeviUposlenika), new Params() { myProperty = 42 });
            //sadrzajPodstranice.Navigate(typeof(MainPage1));

        }
        public void PrikaziNarudzbe_Click(object sender, RoutedEventArgs e)
        {
            // var menuPodstranica = (e.AddedItems[0]);
            sadrzajPodstranice.Navigate(typeof(NarudzbeUpravnik), new Params() { myProperty = 42 });
            //sadrzajPodstranice.Navigate(typeof(MainPage1));

        }
        public void PrikaziFinansije_Click(object sender, RoutedEventArgs e)
        {
            // var menuPodstranica = (e.AddedItems[0]);
            sadrzajPodstranice.Navigate(typeof(Finansije), new Params() { myProperty = 42 });
            //sadrzajPodstranice.Navigate(typeof(MainPage1));

        }
        public void PrikaziIzvjestaj_Click(object sender, RoutedEventArgs e)
        {
            // var menuPodstranica = (e.AddedItems[0]);
            sadrzajPodstranice.Navigate(typeof(strazarIzvjestaj), new Params() { myProperty = 42 });
            //sadrzajPodstranice.Navigate(typeof(MainPage1));

        }
        public void PrikaziZahtjev_Click(object sender, RoutedEventArgs e)
        {
            // var menuPodstranica = (e.AddedItems[0]);
            sadrzajPodstranice.Navigate(typeof(PodnesiZahtjev), new Params() { myProperty = 42 });
            //sadrzajPodstranice.Navigate(typeof(MainPage1));

        }
        public void PrikaziRaspored_Click(object sender, RoutedEventArgs e)
        {
            // var menuPodstranica = (e.AddedItems[0]);
            sadrzajPodstranice.Navigate(typeof(strazarRaspored), new Params() { myProperty = 42 });
            //sadrzajPodstranice.Navigate(typeof(MainPage1));

        }
    }
}
