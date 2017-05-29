using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Zatvorenik: INotifyPropertyChanged
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZatvorenikId { get; set; }
        private String ime;
        private String prezime;
        private String optuzenZa;
        private String jmbg;
        private String pinZaKlub;
        private DateTime datumRodjenja;
        private DateTime primljen;
        private DateTime otpusten;
        private List<Izvjestaj> listaPrekrsaja;
        private SmrtnaKazna smrtnaKazna;
        public Celija Celija { get; set; }
        public Upravnik UpravnikId { get; set; }
        public LoginPodaci login { get; set; }

        public override string ToString()
        {
            return Ime+" "+Prezime;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Zatvorenik() { }

        public Zatvorenik(String ime, String prezime, String jmbg, DateTime datumRodjenja, DateTime primljen, DateTime izlazi, Celija celija, String optuzenZa)
        {
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            DatumRodjenja = datumRodjenja;
            Primljen = primljen;
            Otpusten = izlazi;
            Celija = celija;
            OptuzenZa = optuzenZa;
            ListaPrekrsaja = new List<Izvjestaj>();
            
          
        }

        public int odsluzenoVrijeme()
        {
            double odsluzeno = (Primljen - Otpusten).TotalDays;
            return Convert.ToInt32(odsluzeno);
        }

        public void podnesiZahtjev(String naziv, String tekstMolbe, Upravnik u)
        {

            Zahtjev<Zatvorenik> zz = new Zahtjev<Zatvorenik>( naziv, tekstMolbe, this);
            u.ListaZahtjevaZatvorenika.Add(zz);

        }


        public void prijaviUKlub(Klub klub)
        {
            klub.dodajClana(this);
        }

        public List<Izvjestaj> ispisiPrekrsaje()
        {
            List<Izvjestaj> Ispisi = new List<Izvjestaj>();
            foreach (Izvjestaj p in ListaPrekrsaja)
            {
                Ispisi.Add(p);
            }
            return Ispisi;
        }


        public void produziKaznu(double brojDana)
        {
            Otpusten.AddDays(brojDana);
        }

        /**
         * 
         * @param pocinjeniPrekrsaj
         */

        public void obrisiPrekrsaj(Izvjestaj pocinjeniPrekrsaj)
        {
            foreach (Izvjestaj p in ListaPrekrsaja)
            {
                if (p == pocinjeniPrekrsaj) ListaPrekrsaja.Remove(p);
            }
        }

        /**
         * 
         * @param brojDana
         */

        public void skratiKaznu(int brojDana)
        {
            Otpusten.AddDays(brojDana * (-1));
        }

        public void pocniOdbrojavanje()
        {

        }


        public void osudiNaSmrtnuKaznu(SmrtnaKazna smrtnaKazna, String mjesto, DateTime vrijeme, String posljednjaZelja)
        {
            smrtnaKazna = new SmrtnaKazna(mjesto, vrijeme, posljednjaZelja);
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
                OnPropertyChanged("ImeZatvorenika");
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
                OnPropertyChanged("PrezimeZatvorenika");
            }
        }

        public string OptuzenZa
        {
            get
            {
                return optuzenZa;
            }

            set
            {
                optuzenZa = value;
                OnPropertyChanged("OptuzenZa");
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
                OnPropertyChanged("JmbgZatvorenika");
            }
        }

        public string PinZaKlub
        {
            get
            {
                return pinZaKlub;
            }

            set
            {
                pinZaKlub = value;
                OnPropertyChanged("PinZaKlub");
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
                OnPropertyChanged("DatumRodjenjaZatvorenika");
            }
        }

        public DateTime Primljen
        {
            get
            {
                return primljen;
            }

            set
            {
                primljen = value;
                OnPropertyChanged("Primljen");
            }
        }

        public DateTime Otpusten
        {
            get
            {
                return otpusten;
            }

            set
            {
                otpusten = value;
                OnPropertyChanged("Otpusten");
            }
        }

        public List<Izvjestaj> ListaPrekrsaja
        {
            get
            {
                return listaPrekrsaja;
            }

            set
            {
                listaPrekrsaja = value;
                OnPropertyChanged("ListaPrekrsaja");
            }
        }

        public SmrtnaKazna SmrtnaKazna
        {
            get
            {
                return smrtnaKazna;
            }

            set
            {
                smrtnaKazna = value;
                OnPropertyChanged("SmrtnaKazna");
            }
        }


       
    }
}
