using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Strazar:Radnik
    {
       
        private List<Izvjestaj> listaIzvjestaja;
        private List<Zatvorenik> listaZatvorenika;
        private List<ElementRasporeda<Strazar>> rasporedStrazara;

        public override string ToString()
        {
            return base.ToString();
        }

        public Strazar() { }
        public Strazar(String ime, String prezime, String jmbg, String zanimanje, DateTime datumRodjenja, Decimal plata) : base(ime, prezime, jmbg, zanimanje, datumRodjenja, plata)
        {
            ListaIzvjestaja = new List<Izvjestaj>();
            ListaZatvorenika = new List<Zatvorenik>();
            RasporedStrazara = new List<ElementRasporeda<Strazar>>();
        }

        public List<String> pregledRasporeda()
        {
            List<String> vrati = new List<string>();
            foreach (ElementRasporeda<Strazar> s in RasporedStrazara)
            {
                vrati.Add(s.ToString());
            }
            return vrati;
        }

        public void podnesiIzvjestaj(Prekrsaj opisPrekrsaja, Zatvorenik zatvorenik)
        {
            Izvjestaj iz = new Izvjestaj(zatvorenik, opisPrekrsaja.Opis, Enumerative.TipIzvjestaja.Kazna);

        }


        public List<Izvjestaj> ListaIzvjestaja
        {
            get
            {
                return listaIzvjestaja;
            }

            set
            {
                listaIzvjestaja = value;
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
    }
}
