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
    public sealed partial class UpraviteljForme : Page
    {
        public UpraviteljForme() {
            this.InitializeComponent();
        }

        public class Params {
            public int myProperty { get; set; }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            base.OnNavigatedTo(e);    
        }

        private void PrikaziMeni_Click(object sender, RoutedEventArgs e) {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
        }
        
        private void PrikaziSadrzaj_Click(object sender, RoutedEventArgs e) {
             sadrzajPodstranice.Navigate(typeof(ZaposliRadnika), new Params() { myProperty=42});
        }

        private void PrikaziFormuZaposljenja_Click(object sender, RoutedEventArgs e) {
            sadrzajPodstranice.Navigate(typeof(ZaposliRadnika), new Params() { myProperty = 42 });
        }

        private void PrikaziFormuOtpustanja_Click(object sender, RoutedEventArgs e) {
            sadrzajPodstranice.Navigate(typeof(OtpustiRadnika), new Params() { myProperty = 42 });
        }

        private void PrijemZatvorenikaForma_Click(object sender, RoutedEventArgs e) {
            sadrzajPodstranice.Navigate(typeof(PrijemZatvorenika), new Params() { myProperty = 42 });
        }
    }
}
