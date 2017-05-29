using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class SmrtnaKazna
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SmrtnaKaznaId { get; set; }
        private String mjesto;
        private string posljednjaZelja;
        private DateTime vrijeme;

        public SmrtnaKazna(String mjesto, DateTime vrijeme, String posljednjaZelja)
        {
            Mjesto = mjesto;
            Vrijeme = vrijeme;
            PosljednjaZelja = posljednjaZelja;
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

        public DateTime Vrijeme
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

        public string PosljednjaZelja
        {
            get
            {
                return posljednjaZelja;
            }

            set
            {
                posljednjaZelja = value;
            }
        }
    }
}
