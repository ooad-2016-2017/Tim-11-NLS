using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Upravnik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UpravnikId { get; set; }
        private String ime;
        private String prezime;
        private String jmbg;
        private String usermane;
        private String pin;
        private DateTime datumRodjenja;
        private Decimal plata;
        private List<Zatvorenik> listaZatvorenika;
        private List<Zahtjev<Zatvorenik>> listaZahtjevaZatvorenika;
        private List<Zahtjev<Radnik>> listaZahtjevaRadnika;
        private List<Radnik> listaRadnika;
        private List<Narudzba> listaNarudzbi;
        private LoginPodaci login { get; set; }
        private decimal prihod, rashod, budzet;

        public Upravnik(String ime, String prezime, String jmbg, String strucnoZvanje, DateTime datumRodjenja, Decimal plata)
        {
            ListaNarudzbi = new List<Narudzba>();
            ListaRadnika = new List<Radnik>();
            ListaZahtjevaRadnika = new List<Zahtjev<Radnik>>();
            ListaZahtjevaZatvorenika = new List<Zahtjev<Zatvorenik>>();
            //String usern = ime + jmbg.Substring(5, 7);
            login = new LoginPodaci(ime, jmbg);

        }
        public Upravnik()
        {
            ListaNarudzbi = new List<Narudzba>();
            ListaRadnika = new List<Radnik>();
            ListaZahtjevaRadnika = new List<Zahtjev<Radnik>>();
            ListaZahtjevaZatvorenika = new List<Zahtjev<Zatvorenik>>();
        }

        public void odbaciZahtjev(Zahtjev<Radnik> zahtjev)
        {
            foreach (Zahtjev<Radnik> zr in listaZahtjevaRadnika)
            {
                if (zr == zahtjev) listaZahtjevaRadnika.Remove(zr);
            }
        }

        public void odobriZahtjev(Zahtjev<Radnik> zahtjev)
        {
            zahtjev.odobriZahtjev();
            listaZahtjevaRadnika.Add(zahtjev);
        }

        public void odbaciZahtjev(Zahtjev<Zatvorenik> zahtjev)
        {
            foreach (Zahtjev<Zatvorenik> zr in listaZahtjevaZatvorenika)
            {
                if (zr == zahtjev) listaZahtjevaZatvorenika.Remove(zr);
            }
        }

        public void odobriZahtjev(Zahtjev<Zatvorenik> zahtjev)
        {
            listaZahtjevaZatvorenika.Add(zahtjev);
        }
        public void dodajNarudzbu(Narudzba n)
        {
            ListaNarudzbi.Add(n);

        }

        public List<String> pregledFinansija()
        {
            List<String> vrati = new List<string>();

            return vrati;


        }

        public void postaviBudzet(Decimal cifra)
        {
            Budzet = cifra;
        }
        public void postaviPrihod(Decimal cifra)
        {
            Prihod = cifra;
        }
        public void postaviRashod(Decimal cifra)
        {
            Rashod = cifra;
        }
        public void prosiriBudzet(Decimal cifra)
        {
            Budzet += cifra;
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
            }
        }

        public string Usermane
        {
            get
            {
                return usermane;
            }

            set
            {
                usermane = value;
            }
        }

        public string Pin
        {
            get
            {
                return pin;
            }

            set
            {
                pin = value;
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
            }
        }

        public List<Zahtjev<Zatvorenik>> ListaZahtjevaZatvorenika
        {
            get
            {
                return listaZahtjevaZatvorenika;
            }

            set
            {
                listaZahtjevaZatvorenika = value;
            }
        }

        public List<Zahtjev<Radnik>> ListaZahtjevaRadnika
        {
            get
            {
                return listaZahtjevaRadnika;
            }

            set
            {
                listaZahtjevaRadnika = value;
            }
        }

        public List<Radnik> ListaRadnika
        {
            get
            {
                return listaRadnika;
            }

            set
            {
                listaRadnika = value;
            }
        }

        public List<Narudzba> ListaNarudzbi
        {
            get
            {
                return listaNarudzbi;
            }

            set
            {
                listaNarudzbi = value;
            }
        }

        public decimal Prihod
        {
            get
            {
                return prihod;
            }

            set
            {
                prihod = value;
            }
        }

        public decimal Rashod
        {
            get
            {
                return rashod;
            }

            set
            {
                rashod = value;
            }
        }

        public decimal Budzet
        {
            get
            {
                return budzet;
            }

            set
            {
                budzet = value;
            }
        }
    }
}
