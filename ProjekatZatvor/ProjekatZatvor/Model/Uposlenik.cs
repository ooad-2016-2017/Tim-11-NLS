using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
     public class Uposlenik:Radnik
    {

       
        private List<Zaliha> listaZaliha;


        public Uposlenik(String ime, String prezime, String jmbg, String zanimanje, DateTime datumRodjenja, Decimal plata) : base(ime, prezime, jmbg, zanimanje, datumRodjenja, plata)
        {
            ListaZaliha = new List<Zaliha>();
        }


        public void naruciZalihe(String naziv, Decimal cijena, int kolicina, Upravnik n)
        {
            Narudzba nar = new Narudzba(naziv, cijena, kolicina);
            n.dodajNarudzbu(nar);

        }

        public List<String> pregledZaliha()
        {
            List<String> vrati = new List<string>();
            foreach (Zaliha z in ListaZaliha)
            {
                vrati.Add(z.ToString());
            }
            return vrati;
        }


        public void naruciZalihe(String naziv, Decimal cijena, int kolicina)
        {
           
        }

        public List<Zaliha> ListaZaliha
        {
            get
            {
                return listaZaliha;
            }

            set
            {
                listaZaliha = value;
            }
        }
    }
}
