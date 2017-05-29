using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Posjetilac: INotifyPropertyChanged
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PosjetilacId { get; set; }
        private String ime;
        private String prezime;
        private String brojLicneKarte;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Posjetilac() { }

        public Posjetilac(String ime, String prezime, String brojLicne)
        {
            Ime = ime;
            Prezime = prezime;
            BrojLicneKarte = brojLicne;
        }
        public override string ToString()
        {
            return Ime + " " + Prezime+" ";
        }
        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
              //  OnPropertyChanged("ImePosjetioca");
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string BrojLicneKarte
        {
            get
            {
                return brojLicneKarte;
            }

            set
            {
                brojLicneKarte = value;
            }
        }
    }
}
