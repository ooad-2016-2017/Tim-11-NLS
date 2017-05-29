using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Celija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CelijaId { get; set; }
        private int brojCelije;
        private String pin;
        private DateTime vrijemeUnosa;
        private Enumerative.StatusCelije statusCelije;
       // private Zatvorenik zatvorenikUCeliji;

        public Celija() { }
        public Celija(int brojCelije, String pin)
        {
            BrojCelije = brojCelije;
            Pin = pin;
        }
        public override string ToString()
        {
            return "Broj: "+BrojCelije+" Pin: "+pin;
        }

        public void dodijeliCeliju(Zatvorenik zatvorenik)
        {
          

        }

        public void oznaciSlobodnom()
        {
            StatusCelije = Enumerative.StatusCelije.Slobodna;
        }

        public void oznaciPraznom()
        {
            StatusCelije = Enumerative.StatusCelije.Prazna;
        }

        public void oznaciPunom()
        {
            StatusCelije = Enumerative.StatusCelije.Puna;
        }

        public void paliAlarm()
        {

        }

        public void oslobodiCeliju()
        {
            StatusCelije = Enumerative.StatusCelije.Slobodna;
        }


        public int BrojCelije
        {
            get
            {
                return brojCelije;
            }

            set
            {
                brojCelije = value;
            }
        }

        public string Pin
        {
            get
            {
                return pin;
            }

            set
            {
                pin = value;
            }
        }

        public Enumerative.StatusCelije StatusCelije
        {
            get
            {
                return statusCelije;
            }

            set
            {
                statusCelije = value;
            }
        }

       /* internal Zatvorenik ZatvorenikUCeliji
        {
            get
            {
                return zatvorenikUCeliji;
            }

            set
            {
                zatvorenikUCeliji = value;
            }
        }*/
    }
}
