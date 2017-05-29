using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
   public class Enumerative
    {
        public enum VrstaKluba
        {
            Biblioteka,
            Teretana,
            InternetKlub
        };
        public enum StatusCelije
        {
            Puna,
            Prazna,
            Slobodna
        };
        public enum TipZalihe
        {
            Doktorska,
            Kuharska
        };
        public enum TipIzvjestaja
        {
            Pohvala,
            Kazna
        };
    }
}
