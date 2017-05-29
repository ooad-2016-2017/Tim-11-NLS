using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class KoordinatorZaPosjeteITransport: Radnik, INotifyPropertyChanged
    {
        
        private List<Posjetilac> listaPosjetioca;
        private List<Zatvorenik> listaZatvorenika;
        private List<Voznja> listaVoznji;
        private List<ElementRasporeda<Posjetilac>> listaPosjeta;
        private List<String> listaPosjetaString;
        private List<Vozac> listaVozaca;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
  

        public KoordinatorZaPosjeteITransport():base() {
            ListaPosjeta = new List<ElementRasporeda<Posjetilac>>();
            ListaPosjetioca = new List<Posjetilac>();
            ListaVoznji = new List<Voznja>();
            ListaZatvorenika = new List<Zatvorenik>();
            ListaPosjetaString = new List<string>();
            ListaVozaca = new List<Vozac>();
        }

        public KoordinatorZaPosjeteITransport(String ime, String prezime, String jmbg, String strucnoZvanje, DateTime datumRodjenja, Decimal plata):base(ime,prezime,jmbg,strucnoZvanje,datumRodjenja,plata)
        {
            ListaPosjeta = new List<ElementRasporeda<Posjetilac>>();
            ListaPosjetioca = new List<Posjetilac>();
            ListaVoznji = new List<Voznja>();
            ListaZatvorenika = new List<Zatvorenik>();
            ListaPosjetaString = new List<string>();
            ListaVozaca = new List<Vozac>();
        }

        public void dodajPosjetioca(Posjetilac posjetilac)
        {
            ListaPosjetioca.Add(posjetilac);
        }

        public void dodajUPosjete(ElementRasporeda<Posjetilac> posjeta)
        {
            ListaPosjeta.Add(posjeta);
        }

        public void dodajVoznju(Voznja voznja)
        {
            ListaVoznji.Add(voznja);
        }

        public List<Vozac> pregledDostupnihVozaca()

        {
            List<Vozac> vrati = new List<Vozac>();
            foreach (Vozac x in ListaVozaca)
            {
                if (x.ListaVoznji.Count() == 0) vrati.Add(x);
            }
            return vrati;
        }

        public List<ElementRasporeda<Posjetilac>> pregledPosjeta()
        {
            return ListaPosjeta;
        }

        public List<Voznja> pregledVoznji()
        {
            return ListaVoznji;
        }

        public List<Posjetilac> ListaPosjetioca
        {
            get
            {
                return listaPosjetioca;
            }

            set
            {
                listaPosjetioca = value;
                OnPropertyChanged("ListaPosjetioca");
            }
        }

        public List<Zatvorenik> ListaZatvorenika
        {
            get
            {
                return listaZatvorenika;
            }

            set
            {
                listaZatvorenika = value;
                OnPropertyChanged("ListaZatvorenika");
            }
        }

        public List<Voznja> ListaVoznji
        {
            get
            {
                return listaVoznji;
            }

            set
            {
                listaVoznji = value;
                OnPropertyChanged("ListaVoznji");
            }
        }

        public List<ElementRasporeda<Posjetilac>> ListaPosjeta
        {
            get
            {
                return listaPosjeta;
            }

            set
            {
                listaPosjeta = value;
                OnPropertyChanged("ListaPosjeta");
            }
        }

        public List<string> ListaPosjetaString
        {
            get
            {
                return listaPosjetaString;
            }

            set
            {
                listaPosjetaString = value;
                OnPropertyChanged("ListaPosjeta");
            }
        }

        public List<Vozac> ListaVozaca
        {
            get
            {
                return listaVozaca;
            }

            set
            {
                listaVozaca = value;
            }
        }
    }
}
