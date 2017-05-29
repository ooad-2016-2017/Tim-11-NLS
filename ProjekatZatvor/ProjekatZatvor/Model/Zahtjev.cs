using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Zahtjev<Tip>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        private String naziv;
        private String tekstMolbe;
        private Tip posiljalac;
        private Boolean jeLiOdobren;
        private Zatvorenik zatvorenik;

        public Upravnik Upravnik { get; set; }

        public Zahtjev() { }
        public override string ToString()
        {
            return Posiljalac.ToString()+Naziv;
        }
        public Zahtjev(string naziv, string textMolbe, Tip posiljalac, Upravnik upravnikId , Boolean jeLiOdobren=false)
        {
            Naziv = naziv;
            TekstMolbe = "";
            if(textMolbe!=null) TekstMolbe = textMolbe;
            Posiljalac = posiljalac;
            JeLiOdobren = jeLiOdobren;
            Upravnik = upravnikId;
        }

        public Zahtjev(string naziv, string textMolbe, Tip posiljalac, Boolean jeLiOdobren = false)
        {
            Naziv = naziv;
            TekstMolbe = "";
            if (textMolbe != null) TekstMolbe = textMolbe;
            Posiljalac = posiljalac;
            JeLiOdobren = jeLiOdobren;
            
        }

        public Zahtjev(String naziv, String tekstMolbe)
        {
            Naziv = naziv;
            TekstMolbe = tekstMolbe;
        }

        public Zahtjev(string naziv, string tekstMolbe, Zatvorenik zatvorenik)
        {
            this.naziv = naziv;
            this.tekstMolbe = tekstMolbe;
            this.zatvorenik = zatvorenik;
        }

        public void odobriZahtjev()
        {
            JeLiOdobren = true;
        }
        public void odbijZahtjev()
        {
            JeLiOdobren = false;
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

        public string TekstMolbe
        {
            get
            {
                return tekstMolbe;
            }

            set
            {
                tekstMolbe = value;
            }
        }

        public Tip Posiljalac
        {
            get
            {
                return posiljalac;
            }

            set
            {
                posiljalac = value;
            }
        }

        public bool JeLiOdobren
        {
            get
            {
                return jeLiOdobren;
            }

            set
            {
                jeLiOdobren = value;
            }
        }
    }
}
