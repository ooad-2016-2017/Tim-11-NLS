using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Doktor:Uposlenik
    {
        
        private List<Zatvorenik> listaZatvorenika;
        public Doktor(string ime, string prezime, string jmbg, DateTime datumRodjenja, decimal plata, string zanimanje = "Doktor") : base(ime, prezime, jmbg, zanimanje, datumRodjenja, plata)
        {
            ListaZatvorenika = new List<Zatvorenik>();
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
    }
}
