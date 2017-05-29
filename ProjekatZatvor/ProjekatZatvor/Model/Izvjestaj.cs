using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Izvjestaj
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IzvjestajId { get; set; }
        private Zatvorenik zatvorenik;
        private String tekst;
        private Enumerative.TipIzvjestaja tipIzvjestaja;

        public Izvjestaj() { }
        public Izvjestaj(Zatvorenik zatvorenik, String text, Enumerative.TipIzvjestaja tip)
        {
            Zatvorenik = zatvorenik;
            Tekst = text;
            TipIzvjestaja = tip;
        }
        public string ispisiIzvjestaj()
        {

            return Tekst;
        }

        public Izvjestaj dodajIzvjestaj(Zatvorenik zatvorenik, string tekst, Enumerative.TipIzvjestaja tip)
        {
            return new Izvjestaj(zatvorenik, tekst, tip);
        }

        public void izbrisiIzvjestaj()
        {

        }


        public Zatvorenik Zatvorenik
        {
            get
            {
                return zatvorenik;
            }

            set
            {
                zatvorenik = value;
            }
        }

        public string Tekst
        {
            get
            {
                return tekst;
            }

            set
            {
                tekst = value;
            }
        }

        public Enumerative.TipIzvjestaja TipIzvjestaja
        {
            get
            {
                return tipIzvjestaja;
            }

            set
            {
                tipIzvjestaja = value;
            }
        }
       
    }
}
