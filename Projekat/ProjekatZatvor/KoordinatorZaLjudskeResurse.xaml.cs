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
    public sealed partial class KoordinatorZaLjudskeResurse : Page
    {
        public KoordinatorZaLjudskeResurse()
        {
            this.InitializeComponent();
            Frejm.Navigate(typeof(KoordinatorPocetna));
        }
        public void PrikaziMeni_Click(object sender, RoutedEventArgs e) { MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen; }
        public void RasporedPosjeta_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
            Frejm.Navigate(typeof(RasporedPosjeta));
        }
        public void Posjetioci_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
            Frejm.Navigate(typeof(Posjetioci));
        }

        public void RasporedTransporta_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
            Frejm.Navigate(typeof(RasporedTransporta));
        }

        
    }
}
