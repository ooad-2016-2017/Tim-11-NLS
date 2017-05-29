using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class UpraviteljZaLjudskeResurse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        private String ime;
        private String prezime;
        private String jmbg;
        private DateTime datumRodjenja;
        private Decimal plata;
        private List<Zatvorenik> listaZatvorenika;
        private List<Celija> listaCelija;
        private List<Radnik> listaRadnika;
        public LoginPodaci login { get; set; }

        public UpraviteljZaLjudskeResurse()
        {
            ListaZatvorenika = new List<Zatvorenik>();
            ListaCelija = new List<Celija>();
            ListaRadnika = new List<Radnik>();
        }
        public UpraviteljZaLjudskeResurse(String ime, String prezime, String jmbg, DateTime datumRodjenja, Decimal plata)
        {
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            DatumRodjenja = datumRodjenja;
            Plata = plata;
            ListaZatvorenika = new List<Zatvorenik>();
            ListaCelija = new List<Celija>();
            ListaRadnika = new List<Radnik>();
        }



        public void otpustiRadnika(Radnik radnik)
        {
            foreach (Radnik r in ListaRadnika)
            {
                if (r == radnik) ListaRadnika.Remove(r);
            }
        }

        public void zaposliRadnika(Radnik radnik)
        {
            ListaRadnika.Add(radnik);
        }


        public void primiZatvorenika(Zatvorenik zatvorenik)
        {
            ListaZatvorenika.Add(zatvorenik);
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

        public List<Celija> ListaCelija
        {
            get
            {
                return listaCelija;
            }

            set
            {
                listaCelija = value;
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
    }
}
