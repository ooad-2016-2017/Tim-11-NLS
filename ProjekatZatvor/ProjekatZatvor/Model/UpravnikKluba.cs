using ProjekatZatvor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class UpravnikKluba:Radnik
    {
        
        private List<Zatvorenik> trenutnoUKlubu;
        private List<Zatvorenik> listaZatvorenika;

        public UpravnikKluba(String ime, String prezime, String jmbg, String zanimanje, DateTime datumRodjenja, Decimal plata, Klub klubKojimUpravlja):base(ime,prezime,jmbg,zanimanje,datumRodjenja,plata)
        {
            TrenutnoUKlubu = new List<Zatvorenik>();
            ListaZatvorenika = new List<Zatvorenik>();
        }

        public void odbijZahtjev(Model.Zahtjev<Zatvorenik> zahtjev)
        {
            zahtjev.odbijZahtjev();
        }
        public void odobriZahtjev(Model.Zahtjev<Zatvorenik> zahtjev, Zatvorenik z)
        {
            zahtjev.odobriZahtjev();
            ListaZatvorenika.Add(z);
        }


        public void odbijZahtjev(Model.Zahtjev<Radnik> zahtjev)
        {
        }
        public List<Zatvorenik> TrenutnoUKlubu
        {
            get
            {
                return trenutnoUKlubu;
            }

            set
            {
                trenutnoUKlubu = value;
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
    }
}
