using ProjekatZatvor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace ProjekatZatvor.ViewModel
{
    class Validacija
    {

        public async void validacijaDatumZaposljavanja(DateTime d) {
            MessageDialog dial = new MessageDialog("Neispravan datum", "Greska");
            await dial.ShowAsync();

        }
        public async void LoginPageValidacija(string ime, string pw)
        {
            MessageDialog dial = new MessageDialog("Unesite korisnicko ime", "Greska");
            if (ime == "") dial = new MessageDialog("Unesite korisnicko ime", "Greska");
                else if (pw == " ") dial = new MessageDialog("Za pristup je potrebno unijeti lozinku", "Greska");
              
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
            MessageDialog dial = new MessageDialog("Unesite naziv artikla ", "Greska");

            if (cijena == "") dial = new MessageDialog("Unesite cijenu artikla", "Greska");
            else if(kolicina=="") dial = new MessageDialog("Unesite kolicinu koju zelite naruciti", "Greska");

            await dial.ShowAsync();

        }

        public async void finansijeValidacija(string iznos, string razlog)
        {
            MessageDialog dial = new MessageDialog("Unesite iznos povecanja budzeta ", "Greska");

            if (iznos == "") dial = new MessageDialog("Unesite cijenu artikla", "Greska");
            else if (razlog == "") dial = new MessageDialog("Unesite razlog povecanja budzeta", "Greska");

            await dial.ShowAsync();
            
        }
        public async void NarudzbaFormaValidacija(string naziv, string kolicina)
        {
            MessageDialog dial = new MessageDialog("Unesite naziv artikla ", "Greska");

            if (kolicina == "") dial = new MessageDialog("Unesite zeljenu kolicinu", "Greska");
            

            await dial.ShowAsync();
         
        }
        public async void OtpustiRadnikaValidacija(string imeprezime, string otpremine, string nadlezni)
        {

            MessageDialog dial = new MessageDialog("nesite ime i prezime ", "Greska");
            if (otpremine == "") dial = new MessageDialog("Unesite iznos otpremnine", "Greska");
            else if(nadlezni==" ")dial = new MessageDialog("Unesite nadleznu osobu", "Greska");


            await dial.ShowAsync();
         
        }
        public async void PrijavaUKlubValidacija(string ime, string prezime, string pin, string klub) {
            MessageDialog dial = new MessageDialog("  ", "Greska");
            if (ime == "") dial = new MessageDialog("Unesite ime", "Greska");
            else if (prezime == " ") dial = new MessageDialog("Unesite prezime", "Greska");
            else if (pin == "") dial = new MessageDialog("Unesite pin", "Greska");
            else if (klub == " ") dial = new MessageDialog("Unesite zeljeni klub", "Greska");

            await dial.ShowAsync();
          
        }
        public async void PrijemZatvorenikaValidacija(string imeprezime, string vrstaprekrsaja, string nadlezni) {

            MessageDialog dial = new MessageDialog("  ", "Greska");
            if (imeprezime == "") dial = new MessageDialog("Unesite ime i prezime", "Greska");
            else if (vrstaprekrsaja == " ") dial = new MessageDialog("Unesite vrstu prekrsaja", "Greska");
            else if (nadlezni == "") dial = new MessageDialog("Unesite nadleznu osobu", "Greska");
            

            await dial.ShowAsync();
           
        }

        public async void RasporedPosjetaValidacija(string ime, string prezime, string brlicne, string termin) {

           MessageDialog dial = new MessageDialog("  ", "Greska");
            if (ime == "") dial = new MessageDialog("Unesite ime", "Greska");
            else if (prezime == " ") dial = new MessageDialog("Unesite prezime", "Greska");
            else if (brlicne == "") dial = new MessageDialog("Unesite broj licne karte", "Greska");
            else if (termin == "") dial = new MessageDialog("Unesite termin posjete", "Greska");

            await dial.ShowAsync();
         
        }

        public async void RasporedTransportaValidacija(string ime, string zatvorenik, string odrediste) {
            MessageDialog dial = new MessageDialog("  ", "Greska");
            if (ime == "") dial = new MessageDialog("Unesite ime i prezime vozaca", "Greska");
            else if (zatvorenik == " ") dial = new MessageDialog("Unesite ime i prezime zatvorenika", "Greska");
            else if (odrediste == "") dial = new MessageDialog("Unesite odrediste voznje", "Greska");


            await dial.ShowAsync();

        }
        public async void strazarIzvjestajPrekrsajValidacija(string ime, string prezime, string brojCelije, string prekrsaj) {
            MessageDialog dial = new MessageDialog("  ", "Greska");
            if (ime == "") dial = new MessageDialog("Unesite ime zatvorenika", "Greska");
            else if (prezime == " ") dial = new MessageDialog("Unesiteprezime zatvorenika", "Greska");
            else if (brojCelije == "") dial = new MessageDialog("Unesite broj celije zatvorenika", "Greska");
            else if (prekrsaj == "") dial = new MessageDialog("Unesite pocinjeni prekrsaj", "Greska");

            await dial.ShowAsync();
           
        }
        public async void strazarIzvjestajPohvalaValidacija(string ime, string prezime, string brojCelije, string brprekrsaja, string brpohvala)
        {
            MessageDialog dial = new MessageDialog("  ", "Greska");
            if (ime == "") dial = new MessageDialog("Unesite ime zatvorenika", "Greska");
            else if (prezime == " ") dial = new MessageDialog("Unesiteprezime zatvorenika", "Greska");
            else if (brojCelije == "") dial = new MessageDialog("Unesite broj celije zatvorenika", "Greska");
            else if (brprekrsaja == "") dial = new MessageDialog("Unesite ukupan broj prekrsaja", "Greska");
            else if (brpohvala == "") dial = new MessageDialog("Unesite ukupan broj pohvala", "Greska");
            await dial.ShowAsync();
          
        }

        public async void ZahtjevZaOdlazakDoktoruValidacija(string ime, string prezime, string pin, string razlog) {

            MessageDialog dial = new MessageDialog("  ", "Greska");
            if (ime == "") dial = new MessageDialog("Unesite ime zatvorenika", "Greska");
            else if (prezime == " ") dial = new MessageDialog("Unesiteprezime zatvorenika", "Greska");
            else if (pin == "") dial = new MessageDialog("Unesite pin", "Greska");
            else if (razlog == "") dial = new MessageDialog("Unesite  razlog odlaska kod doktora", "Greska");
           
            await dial.ShowAsync();
           
        }

        public async void ZahtjevZaPremjestajValidacija(string ime, string prezime, string pin, string razlog)
        {
            MessageDialog dial = new MessageDialog("  ", "Greska");
            if (ime == "") dial = new MessageDialog("Unesite ime zatvorenika", "Greska");
            else if (prezime == " ") dial = new MessageDialog("Unesiteprezime zatvorenika", "Greska");
            else if (pin == "") dial = new MessageDialog("Unesite pin", "Greska");
            else if (razlog == "") dial = new MessageDialog("Unesite  razlog premjestaja", "Greska");

            await dial.ShowAsync();

        }
        public async void ZaposliRadnikaValidacija(string imeprezime, string telefon, string jmbg, string plata, string pozicija, string strucnoZavanje, string nadleznaOsoba)
        {
            MessageDialog dial = new MessageDialog("  ", "Greska");
            if (imeprezime == "") dial = new MessageDialog("Unesite ime i prezime", "Greska");
            else if (telefon == " ") dial = new MessageDialog("Unesite kontakt telefon", "Greska");
            else if (jmbg == "") dial = new MessageDialog("Unesite JMBG", "Greska");
            else if (plata == "") dial = new MessageDialog("Unesite iznos mjesecne plate", "Greska");
            else if (pozicija == " ") dial = new MessageDialog("Unesite radnu poziciju", "Greska");
            else if (strucnoZavanje == "") dial = new MessageDialog("Unesite strucno zvanje", "Greska");
            else if (nadleznaOsoba == "") dial = new MessageDialog("Unesite nadleznu osobu", "Greska");

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