using ProjekatZatvor.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
using static ProjekatZatvor.MainPage;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatZatvor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UpravnikForma : Page, INotifyPropertyChanged
    {
        private UltraMegaGigaViewModel UltraMegaGiga;
        public UpravnikForma()
        {
            this.InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void PrikaziMeni_Click(object sender, RoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
        }

        public void PrikaziRaspored_Click(object sender, RoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
            sadrzajPodstranice.Navigate(typeof(UpravnikRaspored), this.DataContext);
            
        }
        public void PrikaziZahtjeve_Click(object sender, RoutedEventArgs e)
        {
            sadrzajPodstranice.Navigate(typeof(ZahtjeviUposlenika), this.DataContext);

        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Debug.Write("ovdje");
          
        }
        public void PrikaziNarudzbe_Click(object sender, RoutedEventArgs e)
        {
          
            sadrzajPodstranice.Navigate(typeof(NarudzbeUpravnik), this.DataContext);
   
        }
        public void PrikaziFinansije_Click(object sender, RoutedEventArgs e)
        {
    
            sadrzajPodstranice.Navigate(typeof(Finansije), this.DataContext);
         
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Debug.Write("radis li ");
            UltraMegaGiga = (UltraMegaGigaViewModel)e.Parameter;
            this.DataContext = UltraMegaGiga;
            base.OnNavigatedTo(e);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlavniFrame.Navigate(typeof(LoginPage), this.DataContext);
        }
    }
}
