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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatZatvor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Strazar : Page
    {
        public Strazar()
        {
            this.InitializeComponent();
        }
        public class Params
        {
            public int myProperty { get; set; }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);


        }
        private void PrikaziMeni_Click(object sender, RoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
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
