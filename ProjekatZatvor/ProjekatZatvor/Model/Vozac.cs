using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Vozac:Radnik
    {

        private List<Voznja> listaVoznji;

        public Vozac():base() { ListaVoznji = new List<Voznja>(); }

        public Vozac(String ime, String prezime, String jmbg, DateTime datumRodjenja) :base(ime,prezime,jmbg,"Vozac",datumRodjenja,2000)
        {
            ListaVoznji = new List<Voznja>();
        }

        public override string ToString()
        {
            return Ime+" "+Prezime;
        }

        public void obavijestiOVoznji(Voznja voznja)
        {
            ListaVoznji.Add(voznja);
        }

        public List<String> pregledRasporeda()
        {
            List<String> vrati = new List<string>();
            foreach (Voznja v in ListaVoznji) vrati.Add(v.ToString());
            return vrati;
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
            }
        }
    }
}
