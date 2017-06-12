using ProjekatZatvor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjekatZatvor.Model
{
    public class Klub
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KlubId { get; set; }
        private Enumerative.VrstaKluba imeKluba;
        private int brojClanova;
        private const int maxBrojClanova = 100;
        private UpravnikKluba upravnikKluba;
        private Strazar strazarKluba;

        public Klub() {

        }
        public Klub(Enumerative.VrstaKluba ime, UpravnikKluba upravnikKluba, Strazar strazar)
        {
            ImeKluba = ime;
            UpravnikKluba = upravnikKluba;
            StrazarKluba = strazar;
        }

        public void dodajClana(Zatvorenik zatvorenik)
        {
            upravnikKluba.ListaZatvorenika.Add(zatvorenik);
        }

        public int dajBrojSlobodnihMjesta()
        {
            return MaxBrojClanova - UpravnikKluba.ListaZatvorenika.Count();
        }

        public String toString()
        {
            return ImeKluba.ToString();
        }

        public Enumerative.VrstaKluba ImeKluba
        {
            get
            {
                return imeKluba;
            }

            set
            {
                imeKluba = value;
            }
        }

        public int BrojClanova
        {
            get
            {
                return brojClanova;
            }

            set
            {
                brojClanova = value;
            }
        }

        public static int MaxBrojClanova
        {
            get
            {
                return maxBrojClanova;
            }
        }

        public UpravnikKluba UpravnikKluba
        {
            get
            {
                return upravnikKluba;
            }

            set
            {
                upravnikKluba = value;
            }
        }

        public Strazar StrazarKluba
        {
            get
            {
                return strazarKluba;
            }

            set
            {
                strazarKluba = value;
            }
        }
    }
}
