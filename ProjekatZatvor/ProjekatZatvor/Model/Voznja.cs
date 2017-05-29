using ProjekatZatvor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Voznja
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VoznjaId { get; set; }
        private String mjesto;
        private Boolean uspjesnaVoznja;
        private Zatvorenik zatvorenik;
        private ElementRasporeda<Vozac> termin;

        public Voznja(ElementRasporeda<Vozac> termin, String mjesto,Zatvorenik zatvorenik)
        {
            Termin = termin;
            Mjesto = mjesto;
            Zatvorenik = zatvorenik;
            UspjesnaVoznja = false;
        }
        public Voznja() { Termin = new ElementRasporeda<Vozac>(); }

        public void oznaciVoznjuUspjesnom()
        {
            UspjesnaVoznja = true;
        }


        public override String ToString()
        {
            return Mjesto + Termin.ToString();
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

        public bool UspjesnaVoznja
        {
            get
            {
                return uspjesnaVoznja;
            }

            set
            {
                uspjesnaVoznja = value;
            }
        }

    
        public ElementRasporeda<Vozac> Termin
        {
            get
            {
                return termin;
            }

            set
            {
                termin = value;
            }
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
    }
}
