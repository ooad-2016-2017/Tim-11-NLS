using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Nadzornik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NadzornikId { get; set; }
        private String ime;
        private String prezime;
        private String jmbg;
        private Decimal plata;
        private DateTime datumRodjenja;
        private List<Strazar> listaStrazara;
        private List<ElementRasporeda<Strazar>> rasporedStrazara;
        public LoginPodaci login { get; set; }

        public Nadzornik(String ime, String prezime, String jmbg, DateTime datumRodjenja, Decimal plata)
        {
            Ime = ime; Prezime = prezime; Jmbg = jmbg; DatumRodjenja = datumRodjenja; Plata = plata;

            ListaStrazara = new List<Strazar>();
            RasporedStrazara = new List<ElementRasporeda<Strazar>>();
        }


        public List<String> pregledajRaspored()
        {
            List<String> vrati = new List<string>();
            foreach (ElementRasporeda<Strazar> s in RasporedStrazara)
            {
                vrati.Add(s.ToString());
            }
            return vrati;
        }

        public void izbrisiIzRasporeda(ElementRasporeda<Strazar> termin)
        {
            foreach (ElementRasporeda<Strazar> s in RasporedStrazara)
            {
                if (s == termin) RasporedStrazara.Remove(s);
            }

        }


        public void dodajURaspored(ElementRasporeda<Strazar> termin)
        {
            RasporedStrazara.Add(termin);
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

        public List<Strazar> ListaStrazara
        {
            get
            {
                return listaStrazara;
            }

            set
            {
                listaStrazara = value;
            }
        }

        public List<ElementRasporeda<Strazar>> RasporedStrazara
        {
            get
            {
                return rasporedStrazara;
            }

            set
            {
                rasporedStrazara = value;
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
    }
}
