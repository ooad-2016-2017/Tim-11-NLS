using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class ElementRasporeda<Tip> 
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        private Tip tipRasporeda;
        private DateTime datum;
        private String vrijeme;
        private String mjesto;

        public ElementRasporeda() { }

        public ElementRasporeda (Tip tipZaposlenog, DateTime datum, String mjesto, String vrijeme)
        {
            TipRasporeda = tipZaposlenog;
            Datum = datum;
            Mjesto = mjesto;
            Vrijeme = vrijeme;
        }

        public String Ispisi()
        {
            return TipRasporeda.ToString() + " " + Datum.Date.ToString() + "." + Datum.Month.ToString() + "." + Datum.Year.ToString();
        }

        void promijeniDatum(DateTime datum)
        {
            Datum = datum;
        }

        public void promijeniVrijeme(DateTime vrijeme)
        {
            Vrijeme = vrijeme.ToString();

        }

        public void promijeniMjesto(String mjesto)
        {
            Mjesto = mjesto;
        }
        public override string ToString()
        {
            String tostr = " ";
            tostr = TipRasporeda.ToString() + " " + Datum.ToString() + " " + Mjesto + Vrijeme.ToString();
            return tostr;
        }

        public List<String> ispisiElementRasporeda()
        {
            List<String> raspored = new List<string>();
            raspored.Add(TipRasporeda.ToString());
            raspored.Add(Datum.ToString());
            raspored.Add(Mjesto);
            raspored.Add(Vrijeme.ToString());
            return raspored;
        }
        public Tip DajTip() { return TipRasporeda; }

        public Tip TipRasporeda
        {
            get
            {
                return tipRasporeda;
            }

            set
            {
                tipRasporeda = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

        public String Vrijeme
        {
            get
            {
                return vrijeme;
            }

            set
            {
                vrijeme = value;
            }
        }

        public string Mjesto
        {
            get
            {
                return mjesto;
            }

            set
            {
                mjesto = value;
            }
        }
    }
}
