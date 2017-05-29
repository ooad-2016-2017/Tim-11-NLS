using ProjekatZatvor.Model;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatZatvor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StrazarForma : Page, INotifyPropertyChanged
    {
        public List<Prekrsaj>listap= new List<Prekrsaj>();
        private UltraMegaGigaViewModel UltraMegaGiga;
        public StrazarForma()
        {
            this.InitializeComponent();
        }
        public class Params
        {
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
        private void Page_Loaded(object sender, RoutedEventArgs e)
        { Debug.Write("ovdje");
            using (var db = new dbContext())
            {
                listap = db.Prekrsaj.ToList();
               
                foreach (Prekrsaj p in listap) { Debug.WriteLine("lila"); }
               // Debug.Write(listap.ToString());

            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlavniFrame.Navigate(typeof(LoginPage), this.DataContext);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Debug.Write("lila");
            UltraMegaGiga = (UltraMegaGigaViewModel)e.Parameter;
            this.DataContext = UltraMegaGiga;
            base.OnNavigatedTo(e);
        }
     
        private void PrikaziMeni_Click(object sender, RoutedEventArgs e)
        {
            MojSplitView.IsPaneOpen = !MojSplitView.IsPaneOpen;
        }
        public void PrikaziIzvjestaj_Click(object sender, RoutedEventArgs e)
        {
            sadrzajPodstranice.Navigate(typeof(strazarIzvjestaj),this.DataContext);
        }
        public void PrikaziZahtjev_Click(object sender, RoutedEventArgs e)
        {
            // var menuPodstranica = (e.AddedItems[0]);
            sadrzajPodstranice.Navigate(typeof(PodnesiZahtjev), this.DataContext);
            //sadrzajPodstranice.Navigate(typeof(MainPage1));

        }
        public void PrikaziRaspored_Click(object sender, RoutedEventArgs e)
        {
            // var menuPodstranica = (e.AddedItems[0]);
            sadrzajPodstranice.Navigate(typeof(strazarRaspored), this.DataContext);
            //sadrzajPodstranice.Navigate(typeof(MainPage1));

        }
    }
}
