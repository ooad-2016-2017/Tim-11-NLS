using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjekatZatvor.Model
{
    public class Narudzba:INotifyPropertyChanged
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NarudzbaId { get; set; }
        private String nazivArtikla;
        private Decimal cijena;
        private int kolicina;
        private Boolean odobreno;


    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public Narudzba() { }
        public Narudzba(String naziv, Decimal cijena, int kolicina)
        {
            NazivArtikla = naziv;
            Cijena = cijena;
            Kolicina = kolicina;
            Odobreno = false;
        }
        public override string ToString()
        {
            return "Naziv artikla: "+NazivArtikla+" Cijena: "+Cijena.ToString()+" Kolicina: "+Kolicina.ToString();
        }

        public Decimal dajUkupnuCijenu()
        {
            return Kolicina * Cijena;
        }

        public void Odobri()
        {
            Odobreno = true;
        }

        public void Prolongiraj()
        {
            Odobreno = false;
        }


        public string NazivArtikla
        {
            get
            {
                return nazivArtikla;
            }

            set
            {
                nazivArtikla = value;
                OnPropertyChanged("NazivArtikla");
            }
        }

        public decimal Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
                OnPropertyChanged("Cijena");
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
                OnPropertyChanged("Kolicina");
            }
        }

        public bool Odobreno
        {
            get
            {
                return odobreno;
            }

            set
            {
                odobreno = value;
                OnPropertyChanged("Odobreno");
            }
        }
    }
}
