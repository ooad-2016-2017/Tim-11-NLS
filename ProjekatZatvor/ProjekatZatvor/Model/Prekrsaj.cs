using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Prekrsaj
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrekrsajId { get; set; }

        private String tip;
        private String opis;
        private Zatvorenik pocinilacPrekrsaja;

        public Prekrsaj(String tip, String naziv, Zatvorenik pocinilacP)
        {
            Tip = tip; Opis = naziv; PocinilacPrekrsaja = pocinilacP;

        }
        public string Tip
        {
            get
            {
                return tip;
            }

            set
            {
                tip = value;
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
            }
        }

        public Zatvorenik PocinilacPrekrsaja
        {
            get
            {
                return pocinilacPrekrsaja;
            }

            set
            {
                pocinilacPrekrsaja = value;
            }
        }
    }
}
