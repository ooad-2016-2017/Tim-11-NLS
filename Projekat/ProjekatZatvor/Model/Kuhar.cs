using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Kuhar:Uposlenik
    {
        
        public Kuhar(string ime, string prezime, string jmbg, DateTime datumRodjenja, decimal plata, string zanimanje = "Doktor") : base(ime, prezime, jmbg, zanimanje, datumRodjenja, plata)
        {

        }
    }
}
