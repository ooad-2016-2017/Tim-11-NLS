using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Zaliha
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZalihaId { get; set; }
        private String naziv;
        private int kolicina;
        private Enumerative.TipZalihe tipZalihe;

        public Zaliha(String naziv, int kolicina, Enumerative.TipZalihe tip)
        {
            Naziv = naziv;
            Kolicina = kolicina;
            TipZalihe = tip;
        }
        public override string ToString()
        {
            return naziv + " " + Kolicina.ToString() + " " + TipZalihe.ToString();
        }
        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public int Kolicina
        {
            get
            {
                return kolicina;
            }

            set
            {
                kolicina = value;
            }
        }

        public Enumerative.TipZalihe TipZalihe
        {
            get
            {
                return tipZalihe;
            }

            set
            {
                tipZalihe = value;
            }
        }
    }
}
