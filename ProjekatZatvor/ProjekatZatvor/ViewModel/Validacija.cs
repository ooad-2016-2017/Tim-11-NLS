
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Windows.UI.Popups;
using System.Collections;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;


namespace ProjekatZatvor.ViewModel
{
 public   class Validacija: INotifyDataErrorInfo
    {
        public String poruka=" ";
      

            private int idValue;
            public int Id
            {
                get { return idValue; }
                set { if (IsIdValid(value) && idValue != value) idValue = value; }
            }

            private string nameValue;
            public string Name
            {
                get { return nameValue; }
                set { if (IsNameValid(value) && nameValue != value) nameValue = value; }
            }

            // Validates the Id property, updating the errors collection as needed.
            public bool IsIdValid(int value)
            {
                bool isValid = true;

                if (value < 5)
                {
                    AddError("Id", ID_ERROR, false);
                    isValid = false;
                }
                else RemoveError("Id", ID_ERROR);

                if (value < 10) AddError("Id", ID_WARNING, true);
                else RemoveError("Id", ID_WARNING);

                return isValid;
            }

            // Validates the Name property, updating the errors collection as needed.
            public bool IsNameValid(string value)
            {
                bool isValid = true;

                if (value.Contains(" "))
                {
                    AddError("Name", NAME_ERROR, false);
                    isValid = false;
                }
                else RemoveError("Name", NAME_ERROR);

                if (value.Length > 5) AddError("Name", NAME_WARNING, true);
                else RemoveError("Name", NAME_WARNING);

                return isValid;
            }

            private Dictionary<String, List<String>> errors =
                new Dictionary<string, List<string>>();
            private const string ID_ERROR = "Value cannot be less than 5.";
            private const string ID_WARNING = "Value should not be less than 10.";
            private const string NAME_ERROR = "Value must not contain any spaces.";
            private const string NAME_WARNING = "Value should be 5 characters or less.";

            // Adds the specified error to the errors collection if it is not 
            // already present, inserting it in the first position if isWarning is 
            // false. Raises the ErrorsChanged event if the collection changes. 
            public void AddError(string propertyName, string error, bool isWarning)
            {
                if (!errors.ContainsKey(propertyName))
                    errors[propertyName] = new List<string>();

                if (!errors[propertyName].Contains(error))
                {
                    if (isWarning) errors[propertyName].Add(error);
                    else errors[propertyName].Insert(0, error);
                    RaiseErrorsChanged(propertyName);
                }
            }

            // Removes the specified error from the errors collection if it is
            // present. Raises the ErrorsChanged event if the collection changes.
            public void RemoveError(string propertyName, string error)
            {
                if (errors.ContainsKey(propertyName) &&
                    errors[propertyName].Contains(error))
                {
                    errors[propertyName].Remove(error);
                    if (errors[propertyName].Count == 0) errors.Remove(propertyName);
                    RaiseErrorsChanged(propertyName);
                }
            }

            public void RaiseErrorsChanged(string propertyName)
            {
                if (ErrorsChanged != null)
                    ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
            }

            #region INotifyDataErrorInfo Members

            public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

            public System.Collections.IEnumerable GetErrors(string propertyName)
            {
                if (String.IsNullOrEmpty(propertyName) ||
                    !errors.ContainsKey(propertyName)) return null;
                return errors[propertyName];
            }

            public bool HasErrors
            {
                get { return errors.Count > 0; }
            }

        #endregion

       public string this[string columnName]
{
    get
    {
        string result = string.Empty;
        if (columnName == "Name")
        {
            if (this.korisnickoIme == "")
                result = "Name can not be empty";
        }
        return result;
    }
} 
        private string korisnickoIme;
        private Dictionary<String, String> podaci;

        public Validacija(Dictionary<string, string> podaciF) { podaci = podaciF; }


        public async void validacijaDatumZaposljavanja(DateTime d) {
            MessageDialog dial = new MessageDialog("Neispravan datum", "Greska");
            await dial.ShowAsync();

        }
        public async void LoginPageValidacija(string ime, string pw)
        {
            String vrijednost=null;
            if (!String.IsNullOrEmpty(ime) && podaci.ContainsKey(ime)) vrijednost = podaci[ime];
            MessageDialog dial;// = new MessageDialog("Unesite korisnicko ime", "Greska");
            poruka = " ";
            if (String.IsNullOrEmpty(ime))
            {
                dial = new MessageDialog("Unesite korisnicko ime", "Greska");
                poruka = "Niste unijeli korisnicko ime";
            }
            else if (String.IsNullOrEmpty(pw))
            {
                poruka = "Niste unijeli lozinku";
                dial = new MessageDialog("Za pristup je potrebno unijeti lozinku", "Greska");
            }
            
            else if (!podaci.ContainsKey(ime)) {
                dial = new MessageDialog("Neispravno korisnicko ime", "Greska");
            }
            else if (vrijednost!=pw)
            {
                dial = new MessageDialog("Neispravna lozinka!", "Greska");
            }
            else
            {
                dial = new MessageDialog(ime + ", počnite sa radom.", "Dobro dosli!");
                poruka = " ";
            }
          
            await dial.ShowAsync();
            
        }

        //provjeriti
        public async void ispravanPassword(Dictionary<string, string> korisnik, string pw)
        {
            MessageDialog dial = new MessageDialog("Unesite korisnicko ime", "Greska");
             if (pw == " ") dial = new MessageDialog("Za pristup je potrebno unijeti lozinku", "Greska");

            await dial.ShowAsync();
        }

        public async void detaljiONarudzbiValidacija(string naziv, string cijena, string kolicina)
        {
            MessageDialog dial=null;

            if (String.IsNullOrEmpty(cijena))
            {

                dial = new MessageDialog("Unesite cijenu artikla", "Greska");

            }
            else if (String.IsNullOrEmpty(kolicina)) {
                dial = new MessageDialog("Unesite kolicinu koju zelite naruciti", "Greska");
            }

           if(dial!=null) await dial.ShowAsync();

        }
        public Validacija() { }

        public async void finansijeValidacija(string iznos, string razlog)
        {
            MessageDialog dial=null;

            if (String.IsNullOrEmpty(iznos)) { dial = new MessageDialog("Unesite iznos povecanja budzeta", "Greska"); }
            else if (String.IsNullOrEmpty(razlog)) { dial = new MessageDialog("Unesite razlog povecanja budzeta", "Greska"); }
            else dial = new MessageDialog("Uspjestno poslan zahtjev!", " ");
            if (dial != null) await dial.ShowAsync();
            
        }
        public async void NarudzbaFormaValidacija(string naziv, string kolicina)
        {
            MessageDialog dial = null;
                if(String.IsNullOrEmpty(naziv)) new MessageDialog("Unesite naziv artikla ", "Greska");

            else if (String.IsNullOrEmpty(kolicina)) dial = new MessageDialog("Unesite zeljenu kolicinu", "Greska");
            else dial = new MessageDialog("Uspjesno izvrsena narudzba!", " ");

            if (dial!=null) await dial.ShowAsync();
         
        }
        public async void OtpustiRadnikaValidacija(string ime, string prezime, string otpremine, string nadlezni)
        {

            MessageDialog dial = null;
                if(String.IsNullOrEmpty(ime)) dial= new MessageDialog("Unesite ime radnika ", "Greska");
         else   if (String.IsNullOrEmpty(prezime)) dial = new MessageDialog("Unesite prezime radnika ", "Greska");
            else  if (String.IsNullOrEmpty(otpremine)) dial = new MessageDialog("Unesite iznos otpremnine", "Greska");
          //  else if(nadlezni==" ")dial = new MessageDialog("Unesite nadleznu osobu", "Greska");
          else dial = new MessageDialog("Radnik "+ ime +" "+prezime+ " je otpusten", "Otpusten radnik");

            await dial.ShowAsync();
         
        }
        public async void PrijavaUKlubValidacija(string ime, string prezime, string pin, string klub) {
            MessageDialog dial = null;
            if (String.IsNullOrEmpty(ime)) dial = new MessageDialog("Unesite ime", "Greska");
            else if (String.IsNullOrEmpty(prezime)) dial = new MessageDialog("Unesite prezime", "Greska");
            else if (String.IsNullOrEmpty(pin)) dial = new MessageDialog("Unesite pin", "Greska");
            else if (String.IsNullOrEmpty(klub)) dial = new MessageDialog("Unesite zeljeni klub", "Greska");
            else dial = new MessageDialog("Uspjesno poslan zahtjev za uclanjenje u klub "+ klub+". " , "Cekanje potvrde");
            await dial.ShowAsync();
          
        }
        public async void PrijemZatvorenikaValidacija(string ime, string prezime, string jmbg, string vrstaprekrsaja, string celija, string nadlezni) {

            MessageDialog dial =null;
            if (String.IsNullOrEmpty(ime)) dial = new MessageDialog("Unesite ime zatvorenika", "Greska");
            else if (String.IsNullOrEmpty(prezime)) dial = new MessageDialog("Unesite prezime zatvorenika", "Greska");
            else if (String.IsNullOrEmpty(vrstaprekrsaja)) dial = new MessageDialog("Unesite pocinjeni prekrsaj", "Greska");
            else if (String.IsNullOrEmpty(jmbg)) dial = new MessageDialog("Unesite JMBG zatovrenika", "Greska");
            else if (String.IsNullOrEmpty(celija)) dial = new MessageDialog("Obavezno je dodjeljivanje celije", "Greska");
            /*  else if (!String.IsNullOrEmpty(jmbg)) {
                 // ValidacijaMaticnogBroja(jmbg);
                  //ValidacijaMbr(jmbg);
              }*/
            else dial = new MessageDialog("Uspjesno ste registrovali Zatvorenika! Njegovo korisnicko ime je: " + ime.Substring(0, 1) + prezime.Substring(0, 1) + jmbg.Substring(0, 5) + " Lozinka: " + ime, "Dodali ste novog zatvorenika");
                await dial.ShowAsync();
            
        }

        public async void RasporedPosjetaValidacija(string ime, string prezime, string brlicne, string termin) {

            MessageDialog dial = null;// = new MessageDialog("  ", "Greska");
            if (String.IsNullOrEmpty(ime)) dial = new MessageDialog("Unesite ime posjetioca", "Greska");
            else if (String.IsNullOrEmpty(prezime)) dial = new MessageDialog("Unesite prezime posjetioca", "Greska");
            else if (String.IsNullOrEmpty(brlicne)) dial = new MessageDialog("Unesite broj licne karte posjetioca", "Greska");
            else if (String.IsNullOrEmpty(termin)) dial = new MessageDialog("Unesite termin posjete", "Greska");
            else dial = new MessageDialog("Termin nove posjete je "+termin, "Uspjesno ste dodali novu posjetu!");
            await dial.ShowAsync();
         
        }

        public async void RasporedTransportaValidacija(string ime, string zatvorenik, string odrediste) {
            MessageDialog dial = null; //= new MessageDialog("  ", "Greska");
            if (String.IsNullOrEmpty(ime)) dial = new MessageDialog("Unesite ime i prezime vozaca", "Greska");
            else if (String.IsNullOrEmpty(zatvorenik)) dial = new MessageDialog("Unesite ime i prezime zatvorenika", "Greska");
            else if (String.IsNullOrEmpty(odrediste)) dial = new MessageDialog("Unesite odrediste voznje", "Greska");
            else dial = new MessageDialog("Uspjesno ste dodali novu voznju", "");

            await dial.ShowAsync();

        }
        public async void strazarIzvjestajPrekrsajValidacija(string ime, string prezime, string brojCelije, string prekrsaj) {
            MessageDialog dial = null;// new MessageDialog("  ", "Greska");
            if (String.IsNullOrEmpty(ime)) dial = new MessageDialog("Unesite ime zatvorenika", "Greska");
            else if (String.IsNullOrEmpty(prezime)) dial = new MessageDialog("Unesite prezime zatvorenika", "Greska");
            else if (String.IsNullOrEmpty(brojCelije)) dial = new MessageDialog("Unesite broj celije zatvorenika", "Greska");
            else if (String.IsNullOrEmpty(prekrsaj)) dial = new MessageDialog("Unesite pocinjeni prekrsaj", "Greska");
            else dial = new MessageDialog("Izvjestaj je uspjesno poslan", " ");
            await dial.ShowAsync();
           
        }
        public async void strazarIzvjestajPohvalaValidacija(string ime, string prezime, string brojCelije)
        {
            MessageDialog dial = null;// = new MessageDialog("  ", "Greska");
            if (String.IsNullOrEmpty(ime)) dial = new MessageDialog("Unesite ime zatvorenika", "Greska");
            else if (String.IsNullOrEmpty(prezime)) dial = new MessageDialog("Unesiteprezime zatvorenika", "Greska");
            else if (String.IsNullOrEmpty(brojCelije)) dial = new MessageDialog("Unesite broj celije zatvorenika", "Greska");
          //  else if (String.IsNullOrEmpty(brprekrsaja)) dial = new MessageDialog("Unesite ukupan broj prekrsaja", "Greska");
           // else if (String.IsNullOrEmpty(brpohvala)) dial = new MessageDialog("Unesite ukupan broj pohvala", "Greska");
            else dial = new MessageDialog("Izvjestaj je uspjesno poslan", " ");
            await dial.ShowAsync();
          
        }

        public async void ZahtjevZaOdlazakDoktoruValidacija(string ime, string prezime, string pin, string razlog) {

            MessageDialog dial = null;// new MessageDialog("  ", "Greska");
            if (String.IsNullOrEmpty(ime)) dial = new MessageDialog("Unesite ime zatvorenika", "Greska");
            else if (String.IsNullOrEmpty(prezime)) dial = new MessageDialog("Unesiteprezime zatvorenika", "Greska");
            else if (String.IsNullOrEmpty(pin)) dial = new MessageDialog("Unesite pin", "Greska");
            else if (String.IsNullOrEmpty(razlog)) dial = new MessageDialog("Unesite  razlog odlaska kod doktora", "Greska");
           else dial = new MessageDialog("Zahtjev je uspjesno poslan", " ");
            await dial.ShowAsync();
           
        }

        public async void ZahtjevZaPremjestajValidacija(string ime, string prezime, string pin, string razlog)
        {
            MessageDialog dial = new MessageDialog("  ", "Greska");
            if (String.IsNullOrEmpty(ime)) dial = new MessageDialog("Unesite ime zatvorenika", "Greska");
            else if (String.IsNullOrEmpty(prezime)) dial = new MessageDialog("Unesiteprezime zatvorenika", "Greska");
            else if (String.IsNullOrEmpty(pin)) dial = new MessageDialog("Unesite pin", "Greska");
            else if (String.IsNullOrEmpty(razlog)) dial = new MessageDialog("Unesite  razlog premjestaja", "Greska");
            else dial = new MessageDialog("Zahtjev je uspjesno poslan", " ");
            await dial.ShowAsync();

        }
        public async void ZaposliRadnikaValidacija(string ime, string prezime, string telefon, string jmbg, string plata, string pozicija, string strucnoZavanje, string nadleznaOsoba)
        {
            MessageDialog dial = new MessageDialog("  ", "Greska");
            if (String.IsNullOrEmpty(ime)) dial = new MessageDialog("Unesite ime ", "Greska");
            if (String.IsNullOrEmpty(prezime)) dial = new MessageDialog("Unesite prezime ", "Greska");
            else if (String.IsNullOrEmpty(telefon)) dial = new MessageDialog("Unesite kontakt telefon", "Greska");
            else if (String.IsNullOrEmpty(jmbg)) dial = new MessageDialog("Unesite JMBG", "Greska");
            else if (String.IsNullOrEmpty(plata)) dial = new MessageDialog("Unesite iznos mjesecne plate", "Greska");
            else if (String.IsNullOrEmpty(pozicija)) dial = new MessageDialog("Unesite radnu poziciju", "Greska");
            else if (String.IsNullOrEmpty(strucnoZavanje)) dial = new MessageDialog("Unesite strucno zvanje", "Greska");
            else if (String.IsNullOrEmpty(nadleznaOsoba) ) dial = new MessageDialog("Unesite nadleznu osobu", "Greska");
            else dial = new MessageDialog("Uspjesno ste zaposlili radnika", " ");
            await dial.ShowAsync();
           
        }
        static string jmbg;

    
        public static bool ValidacijaJmbgDatum(DateTime dr)
        {
            string s = dr.ToString();
            string prvih7 = s.Substring(0, 2) + s.Substring(3, 2) + s.Substring(7, 3);
            string dRodjenja = jmbg.Substring(0, 7);
            if (dRodjenja != prvih7) return false;
            else return true;
        }
        public static bool ValidacijaMaticnogBroja(string br)
        {
            jmbg = br;
            if (br.Length == 13)

                return true;

            else return false;
        }
        public static bool ValidacijaMbr(string broj)
        {
            string br = broj;

            System.Collections.Generic.List<int> mmat = new System.Collections.Generic.List<int>();
            int suma = 0;

            for (int i = 0; i < br.Length; i++)
            {

                mmat.Add(br[i] - 48);

            }
            int j = 7;
            for (int i = 0; i < 6; i++)
            {
                suma += mmat[i] * j;
                j--;

            }
            j = 7;
            for (int i = 6; i < 12; i++)
            {

                suma += mmat[i] * j;
                j--;
            }
            int pr = Convert.ToInt32(suma % 11);
            if ((11 - pr) == mmat[12]) return true;
            else if (pr == 0 && mmat[12] == pr) return true;
            else return false;

        }

       
    }

}