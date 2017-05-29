using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Radnik : INotifyPropertyChanged
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        private String ime;
        private String prezime;
        private String jmbg;
        private String zanimanje;
        private DateTime datumRodjenja;
        private Boolean naDopustu;
        private int brojIskoristenihDopusta;
        private const int maxBrojDopusta = 30;
        private Decimal plata;
        public LoginPodaci login { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Radnik() { }
        public override string ToString()
        {
            return Ime+" "+Prezime;
        }

        public Radnik(String ime, String prezime, String jmbg, String zanimanje, DateTime datumRodjenja, Decimal plata)
        {
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            Zanimanje = zanimanje;
            DatumRodjenja = datumRodjenja;
            Plata = plata;
        }

        public void podnesiZahtjev(String naziv, String tekstMolbe)
        {
            Zahtjev<Radnik> z = new Zahtjev<Radnik>(naziv, tekstMolbe,this);
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
                OnPropertyChanged("Ime");
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
                OnPropertyChanged("Prezime");

            }
        }

        public string Jmbg
        {
            get
            {
                return jmbg;
            }

            set
            {
                jmbg = value;
                OnPropertyChanged("jmbg");
            }
        }

       

        public string Zanimanje
        {
            get
            {
                return zanimanje;
            }

            set
            {
                zanimanje = value;
                OnPropertyChanged("Zanimanje");
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                datumRodjenja = value;
                OnPropertyChanged("DatumRodjenja");
            }
        }

        public bool NaDopustu
        {
            get
            {
                return naDopustu;
            }

            set
            {
                naDopustu = value;
                OnPropertyChanged("naDopustu");
            }
        }

        public int BrojIskoristenihDopusta
        {
            get
            {
                return brojIskoristenihDopusta;
            }

            set
            {
                brojIskoristenihDopusta = value;
                OnPropertyChanged("BrojIskoristenihDopusta");
            }
        }

        public static int MaxBrojDopusta
        {
            get
            {
                return maxBrojDopusta;
            }

        }

        public decimal Plata
        {
            get
            {
                return plata;
            }

            set
            {
                plata = value;
                OnPropertyChanged("Plata");
            }
        }
    }
}
