using ProjekatZatvor.Model;
using ProjekatZatvor.View;
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
using System.Collections;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatZatvor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page, INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private UltraMegaGigaViewModel UltraMegaGiga;
        public String ime, prezime;
        public List<Radnik> listaRadnika;
        public List<LoginPodaci> listaLogina;
        public Validacija val;

        private static Dictionary<string, string> loginPodaci;

      

        public bool HasErrors
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static Dictionary<string, string> LoginPodaciP
        {
            get
            {
                return loginPodaci;
            }

            set
            {
                loginPodaci = value;
            }
        }

        public LoginPage()
        {
            this.InitializeComponent();
            Labela.Text = " ";
            UltraMegaGiga = new UltraMegaGigaViewModel();
            this.DataContext = UltraMegaGiga;
            LoginPodaciP = new Dictionary<string, string>();
            LoginPodaciP.Add("Strazar", "Strazar");
            LoginPodaciP.Add("Upravnik", "Upravnik");
            LoginPodaciP.Add("Upravitelj", "Upravitelj");
            LoginPodaciP.Add("Kzpit", "Kzpit");
            LoginPodaciP.Add("Vozac", "Vozac");
            LoginPodaciP.Add("Zatvorenik", "Zatvorenik");
            LoginPodaciP.Add("Uposlenik", "Uposlenik");

            val = new Validacija(LoginPodaciP);
            using (var db = new dbContext())
            {
                listaLogina = new List<LoginPodaci>();
                var lista1 = db.Logini.ToList();
                listaLogina = lista1;

            }
        }
     
      
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
      
        private void button_Click(object sender, RoutedEventArgs e)
        {
            /*  if (passwordBox.Password == "1")
              {
                  GlavniFrame.Navigate(typeof(UpravnikForma), this.DataContext);
              }
              else if(passwordBox.Password == "2") { GlavniFrame.Navigate(typeof(UpraviteljForme), this.DataContext); }
              else if(passwordBox.Password == "3") { GlavniFrame.Navigate(typeof(VozacForma), this.DataContext); }
              else { GlavniFrame.Navigate(typeof(ZatvorenikForma), this.DataContext); }
              Debug.Write(listaRadnika);*/
         


            val.LoginPageValidacija(textBox1.Text, passwordBox.Password);
            
            Labela.Text = val.poruka;
            if(passwordBox.Password=="Strazar" && textBox1.Text=="Strazar") GlavniFrame.Navigate(typeof( StrazarForma),this.DataContext);
            if (passwordBox.Password == "Upravnik" && textBox1.Text == "Upravnik") GlavniFrame.Navigate(typeof(UpravnikForma), this.DataContext);
            if (passwordBox.Password == "Upravitelj" && textBox1.Text == "Upravitelj") GlavniFrame.Navigate(typeof(UpraviteljForme), this.DataContext);
            if (passwordBox.Password == "Kzpit" && textBox1.Text == "Kzpit") GlavniFrame.Navigate(typeof(KoordinatorZaPosjeteITransportForma), this.DataContext);
            if (passwordBox.Password == "Vozac" && textBox1.Text == "Vozac") GlavniFrame.Navigate(typeof(VozacForma), this.DataContext);
            if (passwordBox.Password == "Uposlenik" && textBox1.Text == "Uposlenik") GlavniFrame.Navigate(typeof(UposlenikForme), this.DataContext);
            if (passwordBox.Password == "Zatvorenik" && textBox1.Text == "Zatvorenik") GlavniFrame.Navigate(typeof(ZatvorenikForma), this.DataContext);
          //  else GlavniFrame.Navigate(typeof(PrikazUserControle));
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
      

        private void textBox1_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var obj = e.Parameter as UltraMegaGigaViewModel;
            if(obj!=null)
            {
                 UltraMegaGiga = (UltraMegaGigaViewModel)e.Parameter;
                 this.DataContext = UltraMegaGiga;
               // DataContext = new Validacija();
            }
          
            base.OnNavigatedTo(e);
        }

        public IEnumerable GetErrors(string propertyName)
        {
            throw new NotImplementedException();
        }
    }
}
