using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    public class Korisnik : INotifyPropertyChanged
    {
        private string korisnickoIme, password;

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public string KorisnickoIme
        {
            get
            {
                return korisnickoIme;
            }

            set
            {
                korisnickoIme = value;
                OnPropertyChanged("KorisnickoIme");

            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
                OnPropertyChanged("Password");

            }
        }


    }

}
