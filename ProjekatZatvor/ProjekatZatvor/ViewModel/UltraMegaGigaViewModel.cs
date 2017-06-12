using ProjekatZatvor.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static ProjekatZatvor.PrijavaUKlub;

namespace ProjekatZatvor.ViewModel
{
    class UltraMegaGigaViewModel : INotifyPropertyChanged
    {

        #region Atributi
        #region Pomocni

        public static Zatvorenik pomZatvorenik1 = new Zatvorenik("prvi", "prvi", "123", DateTime.Now, DateTime.Now, DateTime.Now, new Celija(2, "pin"), "");
        private Zatvorenik pomZatvorenik2 = new Zatvorenik("drugi", "drugi", "123", DateTime.Now, DateTime.Now, DateTime.Now, new Celija(2, "pin"), "");
        public static Model.Vozac pomVozac1 = new Vozac("vozac1", "vozac1", "123", DateTime.Now);
        private Zahtjev<Zatvorenik> pomZahtjev = new Zahtjev<Zatvorenik>("Premjestaj", "pliz pliz", pomZatvorenik1);
        private String pomIme;
        public Zahtjev<Radnik> pomZR = new Zahtjev<Radnik>("Radnik", "Molbaaaa", pomVozac1);
        private ElementRasporeda<Posjetilac> pomocnaPosjeta;
        private Voznja v1, v2;
        private String pomLista;
        #endregion

        #region Sve

        private List<Radnik> listaRadnika;
        private List<Strazar> listaStrazara;
        private List<Vozac> listaVozaca;
        private List<Voznja> listaVoznji;
        private List<Zatvorenik> listaZatvorenika;
        private List<ElementRasporeda<Posjetilac>> listaPosjeta;
        private ObservableCollection<String> listaPosjetaString;
        private List<Celija> listaCelija;
        private List<Narudzba> listaNarudzbi;
        private List<Narudzba> listaOdobrenihNarudzbi;
        private List<Prekrsaj> listaSvihPrekrsaja;
        private List<LoginPodaci> listaLogina;
        private List<Posjetilac> listaPosjetilaca;
        private Model.KoordinatorZaPosjeteITransport koordinator;
        private Model.Upravnik upravnik;
        private Zatvorenik zatvorenikTrenutni;
        private Strazar strazarTrenutni;
        private Vozac vozacTrenutni;
        private UpraviteljZaLjudskeResurse upraviteljTrenutni;

        #endregion

        #region Zatvorenik

        private List<Enumerative.VrstaKluba> listaVrstaKlubova;
        private Enumerative.VrstaKluba oznaceniKlub;
        private Zahtjev<Zatvorenik> zahtjevZaPrijavuUKlub;
        private Zahtjev<Zatvorenik> zahtjevDoktor;
        private Zahtjev<Zatvorenik> zahtjevZaPremjestaj;
        private String imeZatvorenika;
        private String prezimeZatvorenika;
        private String passwordZatvorenika;
        private String molba;
        #endregion

        #region Koordinator za posjete i transport

        private String imePosjetioca;
        private String prezimePosjetioca;
        private String brojLicneKartePosjetioca;
        private String terminPosjete;
        private DateTime datumPosjete= DateTime.Now;
        private Posjetilac noviPosjetilac;

        private Vozac oznaceniVozac;
        private Zatvorenik oznaceniZatvorenik;
        private String odrediste;
        private DateTime datumVoznje;

        private ObservableCollection<String> listaImenaPosjetilaca;
        private ObservableCollection<String> listaPrezimenaPosjetilaca;
        private ObservableCollection<String> listaGodistaPosjetilaca;
        private ObservableCollection<String> listaBrojevaLicneKartePosjetilaca;

        private ObservableCollection<String> listaZatvorenikaVoznja;
        private ObservableCollection<String> listaDatumaVoznja;
        private ObservableCollection<String> listaOdredistaVoznja;
        private ObservableCollection<String> listaVozacaVoznja;


        #endregion

        #region Upravnik

        private Zahtjev<Zatvorenik> oznaceniZahtjevZatvorenik;
        private Zahtjev<Radnik> oznaceniZahtjevUposlenik;
        private String tekstMolbe;
        private Narudzba oznacenaNarudzba;

        private List<Radnik> listaRadnikaNaDopustu;
        private ObservableCollection<Zahtjev<Radnik>> listaZahtjevaUposlenika;
        private ObservableCollection<Zahtjev<Zatvorenik>> listaZahtjevaZatvorenika;
        private ObservableCollection<String> listaImenaRadnikaNaDopustu;
        private ObservableCollection<String> listaPrezimenaRadnikaNaDopustu;
        private ObservableCollection<String> listaCelijaZatvorenika;

        private int brojZaposlenih;
        private int brojZatvorenika;
        private int brojCelija;
        private int prihod;
        private int rashod;
        private int trenutnoStanjeBudzeta;
        private int iznosPovecanja;
        #endregion

        #region Strazar
        private ObservableCollection<String> listaDatumaStrazara;
        private ObservableCollection<String> listaVremenaStrazara;
        private ObservableCollection<String> listaMjestaStrazara;
        private ObservableCollection<String> listaImenaStrazara;
        private String imeZatvorenikaIzvjestaj;
        private String prezimeZatvorenikaIzvjestaj;
        private String celijaZatvorenikaIzvjestaj;
        private DateTime datumIzvjestaj;
        private String tekstPrekrsaja;
        private String tekstPohvale;
        private String ukupanBrojPrekrsaja = "0";
        private String ukupanBrojPohvala = "0";
        private Boolean bolovanje;
        private Boolean godisnjiOdmor;
        private DateTime datumOdlaska;
        private DateTime datumPovratka;
        #endregion

        #region Vozac

        private ObservableCollection<String> listaZatvorenikaVozac;
        private ObservableCollection<String> listaDatumaVozac;
        private ObservableCollection<String> listaOdredistaVozac;
        private ObservableCollection<String> listaVozacaVozac;
        private String oznacenaVoznja;
        private int indeksOznaceneVoznje;
        private Voznja voznjaZaObrisati;
        private String oznacenZatvorenikVoznja = "";
        private String oznacenDatumVoznja = "";
        private String oznacenoOdredisteVoznja = "";
        #endregion

        #region Uposlenik

        private Narudzba novaNarudzba;

        #endregion

        #region Upravitelj za ljudske resurse

        private Radnik noviRadnik;
        private Radnik otpustiRadnik;
        private ObservableCollection<String> listaPozicija;
        private String oznacenaPozicija;
        private decimal pomPlata;
        private String plataText;
        private String imeRadnika;
        private String prezimeRadnika;
        private String otpremninaString;
        private decimal otpremnina;
        private Zatvorenik noviZatvorenik;
        private Celija oznacenaCelija;
        #endregion

        #endregion

        #region Konstruktor
        public UltraMegaGigaViewModel()
        {
            ListaStrazara = new List<Strazar>();
            ListaZatvorenika = new List<Zatvorenik>();
            ListaPosjeta = new List<ElementRasporeda<Posjetilac>>();
            ListaPosjetaString = new ObservableCollection<string>();
            Upravnik = new Upravnik();
            Koordinator = new KoordinatorZaPosjeteITransport();
            Koordinator.ListaPosjeta = ListaPosjeta;
            ListaZahtjevaUposlenika = new ObservableCollection<Zahtjev<Radnik>>();
            ListaZahtjevaZatvorenika = new ObservableCollection<Zahtjev<Zatvorenik>>();
           // ListaZahtjevaZatvorenika.Add(pomZahtjev);
            ListaNarudzbi = new List<Narudzba>();
            ListaStrazara = new List<Strazar>();
            ListaCelija = new List<Celija>();
            PopuniListuCelija();
            ListaRadnika = new List<Radnik>();
            StrazarTrenutni = new Strazar();
            VozacTrenutni = new Vozac();
            UpraviteljTrenutni = new UpraviteljZaLjudskeResurse();
            ListaOdobrenihNarudzbi = new List<Narudzba>();
            ListaSvihPrekrsaja = new List<Prekrsaj>();

            Celija c1 = new Celija(1, "1");
            Celija c2 = new Celija(2, "2");
            ListaCelija.Add(c1); ListaCelija.Add(c2);
            listaPosjetilaca = new List<Posjetilac>();

            ListaImenaPosjetilaca = new ObservableCollection<string>();
            ListaPrezimenaPosjetilaca = new ObservableCollection<string>();
            ListaBrojevaLicneKartePosjetilaca = new ObservableCollection<string>();

            ListaZatvorenikaVoznja = new ObservableCollection<String>();
            listaDatumaVoznja = new ObservableCollection<String>();
            listaOdredistaVoznja = new ObservableCollection<String>();
            listaVozacaVoznja = new ObservableCollection<String>();

            ListaImenaStrazara = new ObservableCollection<string>();
            ListaVremenaStrazara = new ObservableCollection<string>();
            ListaMjestaStrazara = new ObservableCollection<string>();
            ListaDatumaStrazara = new ObservableCollection<string>();

            ListaCelijaZatvorenika = new ObservableCollection<string>();

            ListaVozaca = new List<Vozac>();

            ListaVoznji = new List<Voznja>();
            ListaOdredistaVoznja = new ObservableCollection<string>();
            ListaDatumaVoznja = new ObservableCollection<string>();
            ListaZatvorenikaVoznja = new ObservableCollection<string>();
            ListaVozacaVoznja = new ObservableCollection<string>();

            OznaceniZahtjevZatvorenik = new Zahtjev<Zatvorenik>();

            OznaceniZahtjevUposlenik = new Zahtjev<Radnik>();

            NovaNarudzba = new Narudzba();

            using (var db = new dbContext())
            {

                var lista = db.Strazari.ToList();
                ListaStrazara = lista;
                PomLista = ListaStrazara.ElementAt(0).ToString();

                var lista1 = db.Logini.ToList();
                ListaLogina = lista1;

                var lista2 = db.Upravnici.ToList();
                Upravnik = lista2.ElementAt(0);

                var lista3 = db.ZahtjeviRadnika.ToList();

                foreach (var i in lista3)
                {
                    ListaZahtjevaUposlenika.Add(i);
                }

                var lista4 = db.RasporedPosjeta.ToList();
                ListaPosjeta = lista4;

                var lista5 = db.Posjetioci.ToList();
                listaPosjetilaca = lista5;


                foreach (var i in lista5)
                {
                    ListaPosjetaString.Add(i.Ime + " " + i.Prezime + " " + DateTime.Now.ToString());
                    ListaImenaPosjetilaca.Add(i.Ime);
                    ListaPrezimenaPosjetilaca.Add(i.Prezime);
                    ListaBrojevaLicneKartePosjetilaca.Add(i.BrojLicneKarte);

                }

                var lista6 = db.Voznje.ToList();
                ListaVoznji = lista6;

                foreach (var i in lista6)
                {
                    foreach (var j in db.Zatvorenici)
                    {
                        if (i.Zatvorenik == j) listaZatvorenikaVoznja.Add(j.ToString());

                    }

                    listaDatumaVoznja.Add(i.Termin.Datum.ToString());
                    listaOdredistaVoznja.Add(i.Mjesto);
                    //listaVozacaVoznja.Add(i.Termin.TipRasporeda.Ime);
                }

                var lista7 = db.Narudzba.ToList();
                ListaNarudzbi = lista7;

                var lista8 = db.Strazari.ToList();
                var lista9 = db.RasporedStrazara.ToList();

                foreach (var i in lista8)
                {
                    ListaImenaStrazara.Add(i.Ime);
                    //ListaVremenaStrazara.Add(/*new DateTime().ToString()*/i.RasporedStrazara.ElementAt(0).ToString());

                    foreach (var j in lista9)
                    {
                        if (j.Id == i.Id)
                        {
                            ListaVremenaStrazara.Add(j.Vrijeme);
                            ListaDatumaStrazara.Add(j.Datum.ToString().Substring(0, j.Datum.ToString().Length - 11));
                            ListaMjestaStrazara.Add(j.Mjesto);
                        }
                    }
                }

                ListaZatvorenika = db.Zatvorenici.ToList();

                var lista11 = db.Celije.ToList();

                foreach (var i in lista11)
                {
                    ListaCelijaZatvorenika.Add(i.ToString());
                }

                foreach (var i in db.Strazari) ListaRadnika.Add(i);
                foreach (var i in db.KoordinatorPT) ListaRadnika.Add(i);
               // foreach (var i in db.Doktor) ListaRadnika.Add(i);
                //foreach (var i in db.Doktor) ListaRadnika.Add(i);
                //foreach (var i in db.Kuhari) ListaRadnika.Add(i);
               // foreach (var i in db.UpravniciKluba) ListaRadnika.Add(i);
                //foreach (var i in db.Vozaci) ListaRadnika.Add(i);

                ListaVozaca = db.Vozaci.ToList();

                foreach (var i in db.ZahtjeviZatvorenika) ListaZahtjevaZatvorenika.Add(i);

            }

            #region Zatvorenik
            ListaVrstaKlubova = new List<Enumerative.VrstaKluba>();
            ListaVrstaKlubova.Add(Enumerative.VrstaKluba.Biblioteka);
            ListaVrstaKlubova.Add(Enumerative.VrstaKluba.Teretana);
            ListaVrstaKlubova.Add(Enumerative.VrstaKluba.InternetKlub);
            oznaceniKlub = Enumerative.VrstaKluba.Biblioteka;
            ZahtjevDoktor = new Zahtjev<Zatvorenik>();
            ZahtjevZaPremjestaj = new Zahtjev<Zatvorenik>();
            ZahtjevZaPrijavuUKlub = new Zahtjev<Zatvorenik>();
            ZatvorenikTrenutni = new Zatvorenik();
            ImeZatvorenika = ZatvorenikTrenutni.Ime;
            PrezimeZatvorenika = ZatvorenikTrenutni.Prezime;
            #endregion

            #region Koordinator za posjete i transport
            NoviPosjetilac = new Posjetilac();
            PomocnaPosjeta = new ElementRasporeda<Posjetilac>();
           // ListaImenaPosjetilaca = new ObservableCollection<string>();
            //ListaPrezimenaPosjetilaca = new ObservableCollection<string>();
            //ListaBrojevaLicneKartePosjetilaca = new ObservableCollection<string>();
            ListaGodistaPosjetilaca = new ObservableCollection<string>();
            /*ListaVozaca = new List<Vozac>();
            ListaVoznji = new List<Voznja>();
            ListaOdredistaVoznja = new ObservableCollection<string>();
            ListaDatumaVoznja = new ObservableCollection<string>();
            ListaZatvorenikaVoznja = new ObservableCollection<string>();
            ListaVozacaVoznja = new ObservableCollection<string>();*/
            #endregion

            #region Upravnik
           // OznaceniZahtjevUposlenik = new Zahtjev<Radnik>();
            //OznaceniZahtjevZatvorenik = new Zahtjev<Zatvorenik>();
            listaRadnikaNaDopustu = new List<Radnik>();
            ListaImenaRadnikaNaDopustu = new ObservableCollection<string>();
            ListaPrezimenaRadnikaNaDopustu = new ObservableCollection<string>();
            OznacenaNarudzba = new Narudzba();
            //ListaCelijaZatvorenika = new ObservableCollection<string>();

            #region Pomocni
            ListaZatvorenika.Add(pomZatvorenik1);
            ListaZatvorenika.Add(pomZatvorenik2);
            ListaVozaca.Add(pomVozac1);
            ListaZahtjevaUposlenika.Add(pomZR);
            V1 = new Voznja(new ElementRasporeda<Vozac>(pomVozac1, DateTime.Now, "drugi zatvor", "8:00"), "Drugi zatvor", pomZatvorenik1);
            V2 = new Voznja(new ElementRasporeda<Vozac>(pomVozac1, DateTime.Now, "drugi zatvor", "8:00"), "Drugi zatvor", pomZatvorenik2);
            ListaVoznji.Add(v1);
            ListaVoznji.Add(v2);
            VozacTrenutni = pomVozac1;
            ListaNarudzbi.Add(new Narudzba("mlijeko", 2, 100));
            #endregion
            BrojCelija = ListaCelijaZatvorenika.Count();
           // BrojCelija = ListaCelija.Count();
            BrojZaposlenih = ListaRadnika.Count();
            BrojZatvorenika = ListaZatvorenika.Count();
            #endregion

            #region Strazar
           /* ListaImenaStrazara = new ObservableCollection<string>();
            ListaVremenaStrazara = new ObservableCollection<string>();
            ListaMjestaStrazara = new ObservableCollection<string>();
            ListaDatumaStrazara = new ObservableCollection<string>();*/
            Bolovanje = false;
            GodisnjiOdmor = false;
            #endregion

            #region Vozac
            ListaVozacaVozac = new ObservableCollection<string>();
            ListaZatvorenikaVozac = new ObservableCollection<string>();
            ListaDatumaVozac = new ObservableCollection<string>();
            ListaOdredistaVozac = new ObservableCollection<string>();
            PopuniListeZaVozaca();
            VoznjaZaObrisati = new Voznja();
            IndeksOznaceneVoznje = 0;
            #endregion

            #region Upravitelj za ljudske resurse

            NoviRadnik=new Radnik();
            ListaPozicija = new ObservableCollection<string>();
            PopuniListuPozicija();
            NoviZatvorenik = new Zatvorenik();
          
            OznacenaCelija = new Celija();
            #endregion

            #region Uposlenik
           // NovaNarudzba = new Narudzba();
            #endregion

        }


        #endregion

 #region Dobavljanje podataka
        public void DajKoordinatora()
        {
            using (dbContext db = new dbContext())
            {
                var u = db.KoordinatorPT.ToList();
                Koordinator = u.ElementAt(0);
            }

        }
        public void DajListuStrazara()
        {

            using (dbContext db = new dbContext())
            {
                var u = db.Strazari.ToList();
                ListaStrazara = u.ToList();
            }

        }
        public void DajListuVozaca()
        {
            using (dbContext db = new dbContext())
            {
                var u = db.Vozaci.ToList();
                ListaVozaca = u.ToList();
            }
        }
        public void DajListuZahtjevaZatvorenika()
        {
            using (dbContext db = new dbContext())
            {
                var u = db.ZahtjeviZatvorenika.ToList();
                List<Zahtjev<Zatvorenik>> pom = u.ToList();
                foreach (Zahtjev<Zatvorenik> z in pom) ListaZahtjevaZatvorenika.Add(z);
            }
        }
        public void DajListuZahtjevaRadnika()
        {
            using (dbContext db = new dbContext())
            {
                var u = db.ZahtjeviRadnika.ToList();
                List<Zahtjev<Radnik>> pom = u.ToList();
                foreach (Zahtjev<Radnik> z in pom) ListaZahtjevaUposlenika.Add(z);
            }
        }

        public void DajListuUpravnikaKlubova()
        {
            using (dbContext db = new dbContext())
            {
                var u = db.UpravniciKluba.ToList();
                ListaUšravnikaKlubova = u.ToList();
            }
        }
        public void DajUpraviteljaZaLjudskeResurse()
        {
            using (dbContext db = new dbContext())
            {
                var u = db.UpraviteljLJR.ToList();
                UpraviteljTrenutni = u.ToList().ElementAt(0);
            }
        }
        public void DajListuRadnika()
        {
            using (dbContext db = new dbContext())
            {
                var u = db.Radnici.ToList();
                ListaRadnika = u.ToList();
            }
            foreach (Strazar s in ListaStrazara) ListaRadnika.Add(s as Radnik);
            foreach (Vozac s in ListaVozaca) ListaRadnika.Add(s as Radnik);
            foreach (UpravnikKluba s in ListaUšravnikaKlubova) ListaRadnika.Add(s as Radnik);
            ListaRadnika.Add(Koordinator as Radnik);
        }
        public void DajListuVoznji()
        {
            using (dbContext db = new dbContext())
            {
                var u = db.Voznje.ToList();
                ListaVoznji = u.ToList();
            }
        }

        public void DajListuZatvorenika()
        {
            using (dbContext db = new dbContext())
            {
                //   var u = db.Zatvorenici.ToList();
                // ListaZatvorenika = u.ToList();
            }
        }
        public void DajListuPosjeta()
        {
            using (dbContext db = new dbContext())
            {
                var u = db.RasporedPosjeta.ToList();
                ListaPosjeta = u.ToList();
            }

        }
        public void DajListuNarudbi()
        {
            using (dbContext db = new dbContext())
            {
                var u = db.Narudzba.ToList();
                ListaNarudzbi = u.ToList();
            }
        }
        public void DajListuPrekrsaja()
        {
            using (dbContext db = new dbContext())
            {
                var u = db.Prekrsaj.ToList();
                ListaSvihPrekrsaja = u.ToList();
            }
        }
        public void DajUpravnika()
        {
            using (dbContext db = new dbContext())
            {
                var u = db.Upravnici.ToList();
                Upravnik = u.ToList().ElementAt(0);
            }
        }
        public void PopuniListuCelija()
        {
            //UPIS IZ BAZE POSTAVITI
            Celija c1 = new Celija(1, "1");
            Celija c2 = new Celija(2, "2");
            Celija c3 = new Celija(3, "3");
            Celija c4 = new Celija(4, "4");
            ListaCelija.Add(c1); ListaCelija.Add(c2); ListaCelija.Add(c3); ListaCelija.Add(c4);
        }
        public void PopuniListuPozicija()
        {
            ListaPozicija.Add("Strazar");
            ListaPozicija.Add("Kuhar");
            ListaPozicija.Add("Doktor");
            ListaPozicija.Add("Uposlenik");
            ListaPozicija.Add("Vozac");
            ListaPozicija.Add("KoordinatorZaPosjeteITransport");
            ListaPozicija.Add("UpravnikKluba");
        }
        public void PopuniListeZaVozaca()
        {
           /* foreach (Voznja x in ListaVoznji)
            {
                if (x.Termin.TipRasporeda.Ime == VozacTrenutni.Ime)
                {
                    ListaVozacaVozac.Add(x.Termin.TipRasporeda.ToString());
                    ListaZatvorenikaVozac.Add(x.Zatvorenik.ToString());
                    ListaDatumaVozac.Add(x.Termin.Datum.Day.ToString() + "." + x.Termin.Datum.Month.ToString() + "." + x.Termin.Datum.Year.ToString() + ".");
                    ListaOdredistaVozac.Add(x.Mjesto);
                    VozacTrenutni.ListaVoznji.Add(x);
                }
            }*/
        }
        public void PopuniListuPosjetaString()
        {
            foreach (ElementRasporeda<Posjetilac> p in ListaPosjeta) ListaPosjetaString.Add(p.Ispisi());
        }
        public Task UpisiTask()
        {
            return Task.Factory.StartNew(() =>
            {
                DajKoordinatora();
                DajListuStrazara();
                DajListuUpravnikaKlubova();
                DajListuVozaca();
                DajUpraviteljaZaLjudskeResurse();
                DajListuRadnika();
                DajListuNarudbi();
                DajListuPosjeta();
                DajListuPrekrsaja();
                DajListuVoznji();
                DajListuZatvorenika();
                DajListuZahtjevaRadnika();
                DajListuZahtjevaZatvorenika();
                DajUpravnika();
                PopuniListeZaVozaca();
                PopuniListuCelija();
                PopuniListuPozicija();
                PopuniListuPosjetaString();
            });
        }
        public async void Upisi()
        {
            await UpisiTask();
        }
        #endregion

        #region Metode
        public void IzvrsiNarudzbu()
        {
            NovaNarudzba.Cijena = 8;
            Upravnik.ListaNarudzbi.Add(NovaNarudzba);
            ListaNarudzbi.Add(NovaNarudzba);

            using (var db = new dbContext())
            {
                db.Narudzba.Add(NovaNarudzba);
                db.SaveChanges();
            }
            NovaNarudzba = new Narudzba();
            // NovaNarudzba.Kolicina = 0;
        }

        public void PrijemZatvorenika()
        {
            NoviZatvorenik.Celija = OznacenaCelija;
            foreach (Celija x in ListaCelija)
            {
                if (x == OznacenaCelija) { x.oznaciPunom();  }
            }
            ListaZatvorenika.Add(NoviZatvorenik);

            using (var db = new dbContext())
            {
                db.Zatvorenici.Add(NoviZatvorenik);
                db.SaveChanges();
            }
            //obavijestiti zatvorenika o pinu i pinu celije
        }
      /*  public void PopuniListuCelija()
        {
            //UPIS IZ BAZE POSTAVITI
            Celija c1 = new Celija(1, "1");
            Celija c2 = new Celija(2, "2");
            Celija c3 = new Celija(3, "3");
            Celija c4 = new Celija(4, "4");
            ListaCelija.Add(c1); ListaCelija.Add(c2); ListaCelija.Add(c3); ListaCelija.Add(c4);
        }
        */

        public void OtpustiRadnika()
        {
            /* foreach(Radnik x in ListaRadnika)
                 {
                     if (x.Ime == ImeRadnika && x.Prezime == PrezimeRadnika) { OtpustiRadnik = x; break; }
                 }
                 ListaRadnika.Remove(OtpustiRadnik);*/
            //poslati radniku obavijest!!!


          
            using (var db = new dbContext())
            {
                String TipRadnika = "";

                foreach (var i in db.Kuhari)
                {
                    if (i.Ime == ImeRadnika && i.Prezime == PrezimeRadnika) { OtpustiRadnik = i; TipRadnika = "Kuhar"; break; }
                }

                foreach (var i in db.Doktor)
                {
                    if (i.Ime == ImeRadnika && i.Prezime == PrezimeRadnika) { OtpustiRadnik = i; TipRadnika = "Doktor"; break; }
                }

                foreach (var i in db.KoordinatorPT)
                {
                    if (i.Ime == ImeRadnika && i.Prezime == PrezimeRadnika) { OtpustiRadnik = i; TipRadnika = "Koordinator"; break; }
                }

                foreach (var i in db.UpravniciKluba)
                {
                    if (i.Ime == ImeRadnika && i.Prezime == PrezimeRadnika) { OtpustiRadnik = i; TipRadnika = "UpravnikKluba"; break; }
                }

                foreach (var i in db.Vozaci)
                {
                    if (i.Ime == ImeRadnika && i.Prezime == PrezimeRadnika) { OtpustiRadnik = i; TipRadnika = "Vozac"; break; }
                }

                if (TipRadnika == "Kuhar") db.Kuhari.Remove(OtpustiRadnik as Kuhar);
                else if (TipRadnika == "Doktor") db.Doktor.Remove(OtpustiRadnik as Doktor);
                else if (TipRadnika == "Koordinator") db.KoordinatorPT.Remove(OtpustiRadnik as KoordinatorZaPosjeteITransport);
                else if (TipRadnika == "UpravnikKluba") db.UpravniciKluba.Remove(OtpustiRadnik as UpravnikKluba);
                else if (TipRadnika == "Vozac") db.Vozaci.Remove(OtpustiRadnik as Vozac);

                db.SaveChanges();
            }
            

        }

        public void DodajNovogRadnika()
	        {
	            bool a = decimal.TryParse(PlataText, out pomPlata);
	            if (!a) NoviRadnik.Plata = 0;
            else NoviRadnik.Plata = pomPlata;
	            Radnik pomocniRadnik = new Radnik(NoviRadnik.Ime, NoviRadnik.Prezime, NoviRadnik.Jmbg, NoviRadnik.Zanimanje, NoviRadnik.DatumRodjenja, NoviRadnik.Plata);
	            if (OznacenaPozicija == "Strazar") { ListaRadnika.Add(NoviRadnik as Strazar); }
	            else if (OznacenaPozicija == "Doktor" || OznacenaPozicija=="Kuhar" || OznacenaPozicija=="Uposlenik") { ListaRadnika.Add(NoviRadnik as Uposlenik); }
	            else if (OznacenaPozicija == "Vozav") { ListaRadnika.Add(NoviRadnik as Vozac); }
	            else if (OznacenaPozicija == "KoordinatorZaPosjeteITransport") { ListaRadnika.Add(NoviRadnik as KoordinatorZaPosjeteITransport); }
	            else if (OznacenaPozicija == "UpravnikKluba") { ListaRadnika.Add(NoviRadnik as UpravnikKluba); }
	            //UPDATE OSTALE LISTE
	            Debug.WriteLine(pomocniRadnik);
            using (var db = new dbContext())
            {

                if (OznacenaPozicija == "Strazar") db.Strazari.Add(new Strazar(NoviRadnik.Ime, NoviRadnik.Prezime, NoviRadnik.Jmbg, NoviRadnik.Zanimanje, NoviRadnik.DatumRodjenja, NoviRadnik.Plata));
                else if (OznacenaPozicija == "Doktor") db.Doktor.Add(new Doktor(NoviRadnik.Ime, NoviRadnik.Prezime, NoviRadnik.Jmbg, NoviRadnik.DatumRodjenja, NoviRadnik.Plata, NoviRadnik.Zanimanje));
                else if (OznacenaPozicija == "Kuhar") db.Kuhari.Add(new Kuhar(NoviRadnik.Ime, NoviRadnik.Prezime, NoviRadnik.Jmbg, NoviRadnik.DatumRodjenja, NoviRadnik.Plata, NoviRadnik.Zanimanje));
                else if (OznacenaPozicija == "KoordinatorZaPosjeteITransport") db.KoordinatorPT.Add(new KoordinatorZaPosjeteITransport(NoviRadnik.Ime, NoviRadnik.Prezime, NoviRadnik.Jmbg, NoviRadnik.Zanimanje, NoviRadnik.DatumRodjenja, NoviRadnik.Plata));
                else if (OznacenaPozicija == "UpravnikKluba") db.UpravniciKluba.Add(new UpravnikKluba(NoviRadnik.Ime, NoviRadnik.Prezime, NoviRadnik.Jmbg, NoviRadnik.Zanimanje, NoviRadnik.DatumRodjenja, NoviRadnik.Plata, new Klub()));

                else if (OznacenaPozicija == "Vozac")
                {
                    db.Vozaci.Add(new Vozac(NoviRadnik.Ime, NoviRadnik.Prezime, NoviRadnik.Jmbg, NoviRadnik.DatumRodjenja));
                    ListaVozaca.Add(new Vozac(NoviRadnik.Ime, NoviRadnik.Prezime, NoviRadnik.Jmbg, NoviRadnik.DatumRodjenja));
                }



                db.SaveChanges();
            }

        }
     /*   public void PopuniListuPozicija()
       {			
	            ListaPozicija.Add("Strazar");
            ListaPozicija.Add("Kuhar");			
    ListaPozicija.Add("Doktor");			
	            ListaPozicija.Add("Uposlenik");			
	            ListaPozicija.Add("Vozac");			
	            ListaPozicija.Add("KoordinatorZaPosjeteITransport");			
	            ListaPozicija.Add("UpravnikKluba");			
	        }			
	        public void PopuniListeZaVozaca()
	        {			
	            /*foreach (Voznja x in ListaVoznji)			
575	            {			
576	                if (x.Termin.TipRasporeda.Ime == VozacTrenutni.Ime)			
577	                {			
578	                    ListaVozacaVozac.Add(x.Termin.TipRasporeda.ToString());			
579	                    ListaZatvorenikaVozac.Add(x.Zatvorenik.ToString());			
580	                    ListaDatumaVozac.Add(x.Termin.Datum.Day.ToString() + "." + x.Termin.Datum.Month.ToString() + "." + x.Termin.Datum.Year.ToString() + ".");			
581	                    ListaOdredistaVozac.Add(x.Mjesto);			
582	                    VozacTrenutni.ListaVoznji.Add(x);			
583	                }			
584	            }		
	        }*/

public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void OznaciVoznjuUspjesnom()
        {
            int novipom = IndeksOznaceneVoznje;
            Debug.WriteLine("indeks " + novipom);

               
              ListaZatvorenikaVozac.Remove(OznacenZatvorenikVoznja);
              ListaDatumaVozac.Remove(OznacenDatumVoznja);
              ListaOdredistaVozac.Remove(OznacenoOdredisteVoznja);
               
        }
        public void SelektovanaVoznja()
        {
         
            foreach (Voznja x in ListaVoznji)
            {
                Debug.WriteLine(oznacenZatvorenikVoznja);
                if (OznacenZatvorenikVoznja != null)
                {
                    if (OznacenZatvorenikVoznja.Contains(x.Zatvorenik.ToString()))
                    {
                        OznacenDatumVoznja = x.Termin.Datum.Day.ToString() + "." + x.Termin.Datum.Month.ToString() + "." + x.Termin.Datum.Year.ToString() + ".";
                        OznacenoOdredisteVoznja = x.Mjesto;
                        //OZNACITI VOZNJU USPRESNOM
                        break;
                    }
                }
              //  Debug.WriteLine(listaZatvorenikaVozac.ElementAt(indeks));
                //indeks++;
            }
       

        }

        public void PrijaviPrekrsaj()
        {
            int brojacPohvale = 0, brojacPrekrsaj = 0;

            foreach (Zatvorenik x in ListaZatvorenika)
            {
              //  Debug.WriteLine(x.Ime + " " + x.Prezime + " " + x.Celija.BrojCelije.ToString());
                if (x.Ime == ImeZatvorenikaIzvjestaj && x.Prezime == PrezimeZatvorenikaIzvjestaj )
                {
                    Debug.WriteLine("radi");
                    x.ListaPrekrsaja.Add(new Izvjestaj(x, TekstPrekrsaja, Enumerative.TipIzvjestaja.Kazna));

                    using (var db = new dbContext())
                    {
                        db.Prekrsaj.Add(new Prekrsaj("Kazna", TekstPrekrsaja, x));
                        db.SaveChanges();
                    }


                    foreach (Izvjestaj y in x.ListaPrekrsaja) { if (y.TipIzvjestaja == Enumerative.TipIzvjestaja.Kazna) brojacPrekrsaj++; else brojacPohvale++; }
                }
            }
            UkupanBrojPohvala = brojacPohvale.ToString();
            UkupanBrojPrekrsaja = brojacPrekrsaj.ToString();
            Debug.WriteLine(UkupanBrojPrekrsaja);
        }
        public void PrijaviPohvalu()
        {
            int brojacPohvale = 0, brojacPrekrsaj = 0;
            foreach (Zatvorenik x in ListaZatvorenika)
            {
                if (x.Ime == ImeZatvorenikaIzvjestaj && x.Prezime == PrezimeZatvorenikaIzvjestaj && x.Celija.BrojCelije.ToString() == CelijaZatvorenikaIzvjestaj)
                {
                    x.ListaPrekrsaja.Add(new Izvjestaj(x, "Pohvala za dobro ponasanje", Enumerative.TipIzvjestaja.Pohvala));

                    using (var db = new dbContext())
                    {
                        db.Izvjestaji.Add(new Izvjestaj(x, "Pohvala", Enumerative.TipIzvjestaja.Pohvala));
                        db.SaveChanges();
                    }

                    foreach (Izvjestaj y in x.ListaPrekrsaja) { if (y.TipIzvjestaja == Enumerative.TipIzvjestaja.Kazna) brojacPrekrsaj++; else brojacPohvale++; }

                }
            }
            UkupanBrojPohvala = brojacPohvale.ToString();
            UkupanBrojPrekrsaja = brojacPrekrsaj.ToString();
        }
        public void OdbijZahtjev()
        {
            if (ListaZahtjevaZatvorenika.Contains(oznaceniZahtjevZatvorenik))
            {
                //OBAVIJESTITI ZATVORENIKA
                using (var db = new dbContext())
                {
                    db.ZahtjeviZatvorenika.Remove(oznaceniZahtjevZatvorenik);
                    db.SaveChanges();
                }

                ListaZahtjevaZatvorenika.Remove(oznaceniZahtjevZatvorenik);
            }
            if (ListaZahtjevaUposlenika.Contains(OznaceniZahtjevUposlenik))
            {
                using (var db = new dbContext())
                {
                    db.ZahtjeviRadnika.Remove(OznaceniZahtjevUposlenik);
                    db.SaveChanges();
                }

                ListaZahtjevaUposlenika.Remove(OznaceniZahtjevUposlenik);
            }
        }
        public void OdobriZahtjev()
        {
            if (ListaZahtjevaZatvorenika.Contains(OznaceniZahtjevZatvorenik))
            {

                using (var db = new dbContext())
                {
                    db.ZahtjeviZatvorenika.Remove(OznaceniZahtjevZatvorenik);
                    db.SaveChanges();
                }

                ListaZahtjevaZatvorenika.Remove(OznaceniZahtjevZatvorenik);
            }

            if (ListaZahtjevaUposlenika.Contains(OznaceniZahtjevUposlenik))
            {
                // if (OznaceniZahtjevUposlenik.Posiljalac.BrojIskoristenihDopusta < 30)
                // {
                //    OznaceniZahtjevUposlenik.Posiljalac.NaDopustu = true;
                //    Debug.WriteLine(OznaceniZahtjevUposlenik.Posiljalac.Ime);
                    ListaImenaRadnikaNaDopustu.Add(OznaceniZahtjevUposlenik.Posiljalac.Ime);
                  ListaPrezimenaRadnikaNaDopustu.Add(OznaceniZahtjevUposlenik.Posiljalac.Prezime);
                //}

                using (var db = new dbContext())
                {
                  //  db.ZahtjeviRadnika.Remove(OznaceniZahtjevUposlenik);
                    //db.SaveChanges();
                }

                ListaZahtjevaUposlenika.Remove(OznaceniZahtjevUposlenik);
                Upravnik.ListaZahtjevaRadnika.Remove(OznaceniZahtjevUposlenik);
            }

        }

        public String SelektovanZahtjevZatvorenika()
        {
            if (OznaceniZahtjevZatvorenik != null)
            {
                TekstMolbe = OznaceniZahtjevZatvorenik.TekstMolbe;
                Debug.WriteLine("molba" + TekstMolbe);
            }
            else TekstMolbe = "";

            return TekstMolbe;
        }
        public String SelektovanZahtjevUposlenika()
        {
            if (OznaceniZahtjevUposlenik != null)
            {
                TekstMolbe = OznaceniZahtjevUposlenik.TekstMolbe;
                Debug.WriteLine("molba" + TekstMolbe);
            }
            else TekstMolbe = "";


            return TekstMolbe;
        }


private void PosaljiZahtjevZaPrijavuUKlub()
        {
            ZahtjevZaPrijavuUKlub = new Zahtjev<Zatvorenik>("Zahtjev za prijavu u klub", "", ZatvorenikTrenutni, Upravnik);
            Upravnik.ListaZahtjevaZatvorenika.Add(ZahtjevZaPrijavuUKlub);
            ListaZahtjevaZatvorenika.Add(zahtjevZaPrijavuUKlub);

            using (var db = new dbContext())
            {
                db.ZahtjeviZatvorenika.Add(ZahtjevZaPrijavuUKlub);
                db.SaveChanges();
            }

        }
        private void PosaljiZahtjevZaDoktora()
        {
            ZahtjevDoktor = new Zahtjev<Zatvorenik>("Zahtjev za posjetu doktoru", Molba, ZatvorenikTrenutni);
            Upravnik.ListaZahtjevaZatvorenika.Add(ZahtjevDoktor);
            ListaZahtjevaZatvorenika.Add(ZahtjevDoktor);

            using (var db = new dbContext())
            {
                db.ZahtjeviZatvorenika.Add(ZahtjevDoktor);
                db.SaveChanges();
            }
        }

        private void PosaljiZahtjevZaPremjestaj()
        {
            ZahtjevZaPremjestaj = new Zahtjev<Zatvorenik>("Zahtjev za premjestaj", Molba, ZatvorenikTrenutni);
            Upravnik.ListaZahtjevaZatvorenika.Add(ZahtjevZaPremjestaj);
            ListaZahtjevaZatvorenika.Add(ZahtjevZaPremjestaj);

            using (var db = new dbContext())
            {
                db.ZahtjeviZatvorenika.Add(ZahtjevZaPremjestaj);
                db.SaveChanges();
            }
        }

        private void DodajPosjetu()
        {

            NoviPosjetilac = new Posjetilac(ImePosjetioca, PrezimePosjetioca, BrojLicneKartePosjetioca);
            PomocnaPosjeta = new ElementRasporeda<Posjetilac>(NoviPosjetilac, DatumPosjete, "Zatvor", TerminPosjete);
            ListaPosjeta.Add(PomocnaPosjeta);

            using (var db = new dbContext())
            {
                db.RasporedPosjeta.Add(PomocnaPosjeta);
                db.Posjetioci.Add(NoviPosjetilac);
                db.SaveChanges();
            }

            ListaPosjetaString.Add(PomocnaPosjeta.Ispisi());//
            ListaGodistaPosjetilaca.Add(DatumPosjete.Year.ToString());
            ListaImenaPosjetilaca.Add(ImePosjetioca);
            ListaPrezimenaPosjetilaca.Add(PrezimePosjetioca);
            ListaBrojevaLicneKartePosjetilaca.Add(BrojLicneKartePosjetioca);
            ImePosjetioca = "";
            PrezimePosjetioca = "";
            TerminPosjete = "";
            BrojLicneKartePosjetioca = "";
            OnPropertyChanged("ListaPosjeta");
        }


        private void DodajVoznju()
        {
            Voznja pomVoznja = new Voznja(new ElementRasporeda<Vozac>(OznaceniVozac, DatumPosjete, "Zatvor", ""), Odrediste, OznaceniZatvorenik);
            ListaVoznji.Add(pomVoznja);
            ListaZatvorenikaVoznja.Add(pomVoznja.Zatvorenik.ToString());
            ListaDatumaVoznja.Add(DatumPosjete.Date.ToString() + "." + DatumPosjete.Month.ToString() + "." + DatumPosjete.Year.ToString());
            ListaOdredistaVoznja.Add(Odrediste);
            ListaVozacaVoznja.Add(OznaceniVozac.ToString());

            using (var db = new dbContext())
            {
                db.Voznje.Add(pomVoznja);
                db.SaveChanges();
            }
        }


        private void OdobriNarudzbu()
        {
            if (OznacenaNarudzba != null)
            {

                using (var db = new dbContext())
                {
                    Upravnik.ListaNarudzbi.Remove(OznacenaNarudzba);
                    ListaNarudzbi.Remove(OznacenaNarudzba);
                    if (db.Narudzba.Count() != 0 && db.Narudzba != null)//SANJA
                        db.Narudzba.Remove(OznacenaNarudzba);
                    db.SaveChanges();
                }

                ListaOdobrenihNarudzbi.Add(OznacenaNarudzba);


                // Debug.Write(ListaNarudzbi.ElementAt(0));
            }

        }
        private void OdbaciNarudzbu()
        {
            if (OznacenaNarudzba != null)
            {
                using (var db = new dbContext())
                {
                    if(db.Narudzba.Count()!=0 && db.Narudzba!=null)//SANJA
                    db.Narudzba.Remove(OznacenaNarudzba);
                    db.SaveChanges();
                }

                ListaNarudzbi.Remove(OznacenaNarudzba);
            }
            //OBAVIJESTITI DOKTORA/KUHARA
        }

        private void PodnesiZahtjevStrazar()
        {
            Debug.WriteLine("Ovo se poziva");
            string naziv;
            if (Bolovanje == true) naziv = "Zahtjev za bolovanje";
            else naziv = "Zahtjev za godisnji odmor";
            Zahtjev<Radnik> pom = new Zahtjev<Radnik>(naziv, Molba, StrazarTrenutni, Upravnik);
            Upravnik.ListaZahtjevaRadnika.Add(pom);
            ListaZahtjevaUposlenika.Add(pom);
            using (var db = new dbContext())
            {
                db.ZahtjeviRadnika.Add(pom);
                db.SaveChanges();
            }
        }

        #endregion

        #region Komande
        public ICommand IzvrsiNarudzbuCommand
        {
            get
            {
                return new CommandHandler(() => this.IzvrsiNarudzbu());
            }
        }
        public ICommand PrijemZatvorenikaCommand
        {
            get
            {
                return new CommandHandler(() => this.PrijemZatvorenika());
            }
        }
        public ICommand OtpustiRadnikaCommand
        {
            get
            {
                return new CommandHandler(() => this.OtpustiRadnika());
            }
        }
        public ICommand DodajNovogRadnikaCommand
        {
            get
            {
                return new CommandHandler(() => this.DodajNovogRadnika());
            }
        }

        public ICommand PodnesiZahtjevStrazarCommand
        {
            get
            {
                return new CommandHandler(() => this.PodnesiZahtjevStrazar());
            }

        }

        public ICommand SelektovanaVoznjaCommand
        {
            get
            {
                return new CommandHandler(() => this.SelektovanaVoznja());
            }
        }

        public ICommand OznaciVoznjuUspjesnomCommand
        {
            get
            {
                return new CommandHandler(() => this.OznaciVoznjuUspjesnom());
            }
        }
        public ICommand PrijaviPrekrsajCommand
        {
            get
            {
                return new CommandHandler(() => this.PrijaviPrekrsaj());
            }

        }
        public ICommand PrijaviPohvaluCommand
        {
            get
            {
                return new CommandHandler(() => this.PrijaviPohvalu());
            }

        }
        public ICommand OdbijNarudzbuCommand
        {
            get
            {
                return new CommandHandler(() => this.OdbaciNarudzbu());
            }

        }
        public ICommand OdobriNarudzbuCommand
        {
            get
            {
                return new CommandHandler(() => this.OdobriNarudzbu());
            }

        }
        public ICommand OdbijZahtjevCommand
        {
            get
            {
                return new CommandHandler(() => this.OdbijZahtjev());
            }

        }
        public ICommand OdobriZahtjevCommand
        {
            get
            {
                return new CommandHandler(() => this.OdobriZahtjev());
            }

        }

        public ICommand SelektovanZahtjevZatvorenikaCommand
        {
            get
            {
                return new CommandHandler(() => this.SelektovanZahtjevZatvorenika());
            }

        }
        public ICommand SelektovanZahtjevUposlenikaCommand
        {
            get { return new CommandHandler(() => this.SelektovanZahtjevUposlenika()); }

        }
        public ICommand PosaljiZahtjevZaPrijavuUKlubCommand
        {
            get { return new CommandHandler(() => this.PosaljiZahtjevZaPrijavuUKlub()); }
        }

        public ICommand DodajVoznjuCommand
        {
            get { return new CommandHandler(() => this.DodajVoznju()); }
        }
        public ICommand PosaljiZahtjevZaDoktoraCommand
        {
            get { return new CommandHandler(() => this.PosaljiZahtjevZaDoktora()); }
        }
        public ICommand PosaljiZahtjevZaPremjestajCommand
        {
            get { return new CommandHandler(() => this.PosaljiZahtjevZaPremjestaj()); }
        }

        public ICommand DodajPosjetuCommand
        {
            get { return new CommandHandler(() => this.DodajPosjetu()); }
        }



        #endregion

        #region Osobine


        public ObservableCollection<string> ListaDatumaStrazara
        {
            get
            {
                return listaDatumaStrazara;
            }

            set
            {
                listaDatumaStrazara = value;
                OnPropertyChanged("ListaDatumaStrazara");
            }
        }

        public Zahtjev<Zatvorenik> ZahtjevDoktor
        {
            get
            {
                return zahtjevDoktor;
            }

            set
            {
                zahtjevDoktor = value;
                OnPropertyChanged("ZahtjevDoktor");
            }
        }

        public Zahtjev<Zatvorenik> ZahtjevZaPremjestaj
        {
            get
            {
                return zahtjevZaPremjestaj;
            }

            set
            {
                zahtjevZaPremjestaj = value;
                OnPropertyChanged("ZahtjevZaPremjestaj");
            }
        }

        public string Molba
        {
            get
            {
                return molba;
            }

            set
            {
                molba = value;
                OnPropertyChanged("Molba");
            }
        }
        public Upravnik Upravnik
        {
            get
            {
                return upravnik;
            }

            set
            {
                upravnik = value;
                OnPropertyChanged("Upravnik");
            }
        }
        public List<Enumerative.VrstaKluba> ListaVrstaKlubova
        {
            get
            {
                return listaVrstaKlubova;
            }

            set
            {
                listaVrstaKlubova = value;
                OnPropertyChanged("ListaKlubova");
            }
        }

        public Enumerative.VrstaKluba OznaceniKlub
        {
            get
            {
                return oznaceniKlub;
            }

            set
            {
                oznaceniKlub = value;
                OnPropertyChanged("OznaceniKlub");
            }
        }

        public Zahtjev<Zatvorenik> ZahtjevZaPrijavuUKlub
        {
            get
            {
                return zahtjevZaPrijavuUKlub;
            }

            set
            {
                zahtjevZaPrijavuUKlub = value;
                OnPropertyChanged("ZahtjevZaPrijavuUKlub");

            }
        }

        public string ImeZatvorenika
        {
            get
            {
                return imeZatvorenika;
            }

            set
            {
                imeZatvorenika = value;
                OnPropertyChanged("ImeZatvorenika");

            }
        }

        public string PrezimeZatvorenika
        {
            get
            {
                return prezimeZatvorenika;
            }

            set
            {
                prezimeZatvorenika = value;
                OnPropertyChanged("PrezimeZatvorenika");

            }
        }

        public string PasswordZatvorenika
        {
            get
            {
                return passwordZatvorenika;
            }

            set
            {
                passwordZatvorenika = value;
                OnPropertyChanged("PasswordZatvorenika");
            }
        }

        public List<Zatvorenik> ListaZatvorenika
        {
            get
            {
                return listaZatvorenika;
            }

            set
            {
                listaZatvorenika = value;
                OnPropertyChanged("ListaZatvorenika");
            }
        }

        public List<Zatvorenik> ListaZatvorenika1
        {
            get
            {
                return listaZatvorenika;
            }

            set
            {
                listaZatvorenika = value;
                OnPropertyChanged("ListaZatvorenika");
            }
        }

        public Zatvorenik ZatvorenikTrenutni
        {
            get
            {
                return zatvorenikTrenutni;
            }

            set
            {
                zatvorenikTrenutni = value;
                OnPropertyChanged("ZatvorenikTrenutni");
            }
        }
       

        
        public List<Vozac> ListaVozaca
        {
            get
            {
                return listaVozaca;
            }

            set
            {
                listaVozaca = value;
                OnPropertyChanged("ListaVozaca");
            }
        }

        public List<Voznja> ListaVoznji
        {
            get
            {
                return listaVoznji;
            }

            set
            {
                listaVoznji = value;
                OnPropertyChanged("ListaVoznji");
            }
        }


        public ObservableCollection<string> ListaPrezimenaPosjetilaca
        {
            get
            {
                return listaPrezimenaPosjetilaca;
            }

            set
            {
                listaPrezimenaPosjetilaca = value;
                OnPropertyChanged("ListaPrezimenaPosjetilaca");
            }
        }

        public KoordinatorZaPosjeteITransport Koordinator
        {
            get
            {
                return koordinator;
            }

            set
            {
                koordinator = value;
                OnPropertyChanged("Koordinator");
            }
        }

        public ObservableCollection<string> ListaPosjetaString
        {
            get
            {
                return listaPosjetaString;
            }

            set
            {
                listaPosjetaString = value;
                OnPropertyChanged("ListaPosjetaString");
            }
        }

        public ObservableCollection<string> ListaImenaPosjetilaca
        {
            get
            {
                return listaImenaPosjetilaca;
            }

            set
            {
                listaImenaPosjetilaca = value;
                OnPropertyChanged("ListaImenaPosjetilaca");
            }
        }

        public ObservableCollection<string> ListaGodistaPosjetilaca
        {
            get
            {
                return listaGodistaPosjetilaca;
            }

            set
            {
                listaGodistaPosjetilaca = value;
                OnPropertyChanged("ListaGodistaPosjetilaca");
            }
        }

        public ObservableCollection<string> ListaBrojevaLicneKartePosjetilaca
        {
            get
            {
                return listaBrojevaLicneKartePosjetilaca;
            }

            set
            {
                listaBrojevaLicneKartePosjetilaca = value;
                OnPropertyChanged("ListaBrojevaLicneKartePosjetilaca");
            }
        }
        public List<ElementRasporeda<Posjetilac>> ListaPosjeta
        {
            get
            {
                return listaPosjeta;
            }

            set
            {
                listaPosjeta = value;
                OnPropertyChanged("ListaPosjeta");
            }
        }

        public ElementRasporeda<Posjetilac> PomocnaPosjeta
        {
            get
            {
                return pomocnaPosjeta;
            }

            set
            {
                pomocnaPosjeta = value;
                OnPropertyChanged("PomocnaPosjeta");
            }
        }


        public Posjetilac NoviPosjetilac
        {
            get
            {
                return noviPosjetilac;
            }

            set
            {
                noviPosjetilac = value;
                OnPropertyChanged("NoviPosjetilac");
            }
        }



        public string ImePosjetioca
        {
            get
            {
                return imePosjetioca;
            }

            set
            {
                imePosjetioca = value;
                OnPropertyChanged("ImePosjetioca");
            }
        }

        public string PrezimePosjetioca
        {
            get
            {
                return prezimePosjetioca;
            }

            set
            {
                prezimePosjetioca = value;
                OnPropertyChanged("PrezimePosjetioca");
            }
        }

        public string TerminPosjete
        {
            get
            {
                return terminPosjete;
            }

            set
            {
                terminPosjete = value;
                OnPropertyChanged("TerminPosjete");
            }
        }

        public DateTime DatumPosjete
        {
            get
            {
                return datumPosjete;
            }

            set
            {
                datumPosjete = value;
                OnPropertyChanged("DatumPosjete");
            }
        }

        public string BrojLicneKartePosjetioca
        {
            get
            {
                return brojLicneKartePosjetioca;
            }

            set
            {
                brojLicneKartePosjetioca = value;
                OnPropertyChanged("BrojLicneKarte");
            }
        }

        
        public Vozac OznaceniVozac
        {
            get
            {
                return oznaceniVozac;
            }

            set
            {
                oznaceniVozac = value;
                OnPropertyChanged("OznaceniVozac");
            }
        }

        public Zatvorenik OznaceniZatvorenik
        {
            get
            {
                return oznaceniZatvorenik;
            }

            set
            {
                oznaceniZatvorenik = value;
                OnPropertyChanged("OznaceniZatvorenik");
            }
        }

        public string Odrediste
        {
            get
            {
                return odrediste;
            }

            set
            {
                odrediste = value;
                OnPropertyChanged("Odrediste");
            }
        }

        public DateTime DatumVoznje
        {
            get
            {
                return datumVoznje;
            }

            set
            {
                datumVoznje = value;
                OnPropertyChanged("DatumVoznje");
            }
        }

        public ObservableCollection<string> ListaZatvorenikaVoznja
        {
            get
            {
                return listaZatvorenikaVoznja;
            }

            set
            {
                listaZatvorenikaVoznja = value;
                OnPropertyChanged("ListaZatvorenikaVoznja");
            }
        }

        public ObservableCollection<string> ListaDatumaVoznja
        {
            get
            {
                return listaDatumaVoznja;
            }

            set
            {
                listaDatumaVoznja = value;
                OnPropertyChanged("ListaDatumaVoznja");
            }
        }

        public ObservableCollection<string> ListaOdredistaVoznja
        {
            get
            {
                return listaOdredistaVoznja;
            }

            set
            {
                listaOdredistaVoznja = value;
                OnPropertyChanged("ListaOdredistaVoznja");
            }
        }

        public ObservableCollection<string> ListaVozacaVoznja
        {
            get
            {
                return listaVozacaVoznja;
            }

            set
            {
                listaVozacaVoznja = value;
                OnPropertyChanged("ListaVozacaVoznja");
            }
        }

        public ObservableCollection<Zahtjev<Radnik>> ListaZahtjevaUposlenika
        {
            get
            {
                return listaZahtjevaUposlenika;
            }

            set
            {
                listaZahtjevaUposlenika = value;
                Debug.WriteLine("lista zahtjeva se mijenja");
                OnPropertyChanged("ListaZahtjevaUposlenika");

            }
        }

        public ObservableCollection<Zahtjev<Zatvorenik>> ListaZahtjevaZatvorenika
        {
            get
            {
                return listaZahtjevaZatvorenika;
            }

            set
            {
                listaZahtjevaZatvorenika = value;
                OnPropertyChanged("ListaZahtjevaZatvorenika");

            }
        }

        public string PomIme
        {
            get
            {
                return pomIme;
            }

            set
            {
                pomIme = value;
                OnPropertyChanged("PomIme");
            }
        }

        public Zahtjev<Zatvorenik> OznaceniZahtjevZatvorenik
        {
            get
            {
                return oznaceniZahtjevZatvorenik;
            }

            set
            {
               // TekstMolbe = value.TekstMolbe;
                oznaceniZahtjevZatvorenik = value;
                OnPropertyChanged("OznaceniZahtjevZatvorenik");

            }
        }

        public Zahtjev<Radnik> OznaceniZahtjevUposlenik
        {
            get
            {
                return oznaceniZahtjevUposlenik;
            }

            set
            {
                oznaceniZahtjevUposlenik = value;
                OnPropertyChanged("OznaceniZahtjevUposlenik");

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
                OnPropertyChanged("TekstMolbe");

            }
        }

        public List<Radnik> ListaRadnikaNaDopustu
        {
            get
            {
                return listaRadnikaNaDopustu;
            }

            set
            {
                listaRadnikaNaDopustu = value;
                OnPropertyChanged("ListaRadnikaNaDopustu");

            }
        }

        public ObservableCollection<string> ListaImenaRadnikaNaDopustu
        {
            get
            {
                return listaImenaRadnikaNaDopustu;
            }

            set
            {
                listaImenaRadnikaNaDopustu = value;
                OnPropertyChanged("ListaImenaRadnikaNaDopustu");

            }
        }

        public ObservableCollection<string> ListaPrezimenaRadnikaNaDopustu
        {
            get
            {
                return listaPrezimenaRadnikaNaDopustu;
            }

            set
            {
                listaPrezimenaRadnikaNaDopustu = value;
                OnPropertyChanged("ListaPrezimenaRadnikaNaDopustu");
            }
        }

        public List<Narudzba> ListaNarudzbi
        {
            get
            {
                return listaNarudzbi;
            }

            set
            {
                listaNarudzbi = value;
                OnPropertyChanged("ListaNarudzbi");

            }
        }

        public Narudzba OznacenaNarudzba
        {
            get
            {
                return oznacenaNarudzba;
            }

            set
            {
                oznacenaNarudzba = value;
                OnPropertyChanged("OznacenaNarudzba");

            }
        }

    

        public List<Strazar> ListaStrazara
        {
            get
            {
                return listaStrazara;
            }

            set
            {
                listaStrazara = value;
                OnPropertyChanged("ListaStrazara");

            }
        }

        public ObservableCollection<string> ListaImenaStrazara
        {
            get
            {
                return listaImenaStrazara;
            }

            set
            {
                listaImenaStrazara = value;
                OnPropertyChanged("ListaImenaStrazara");

            }
        }

        public ObservableCollection<string> ListaVremenaStrazara
        {
            get
            {
                return listaVremenaStrazara;
            }

            set
            {
                listaVremenaStrazara = value;
                OnPropertyChanged("ListaVremenaStrazara");

            }
        }

        public ObservableCollection<string> ListaMjestaStrazara
        {
            get
            {
                return listaMjestaStrazara;
            }

            set
            {
                listaMjestaStrazara = value;
                OnPropertyChanged("ListaMjestaStrazara");

            }
        }

        public ObservableCollection<string> ListaCelijaZatvorenika
        {
            get
            {
                return listaCelijaZatvorenika;
            }

            set
            {
                listaCelijaZatvorenika = value;
                OnPropertyChanged("ListaCelijaZatvorenika");

            }
        }

        public List<Celija> ListaCelija
        {
            get
            {
                return listaCelija;
            }

            set
            {
                listaCelija = value;
                OnPropertyChanged("ListaCelija");

            }
        }

        public int BrojZaposlenih
        {
            get
            {
                return brojZaposlenih;
            }

            set
            {
                brojZaposlenih = value;
                OnPropertyChanged("BrojZaposlenih");

            }
        }

        public int BrojZatvorenika
        {
            get
            {
                return brojZatvorenika;
            }

            set
            {
                brojZatvorenika = value;
                OnPropertyChanged("BrojZatvorenika");

            }
        }

        public int BrojCelija
        {
            get
            {
                return brojCelija;
            }

            set
            {
                brojCelija = value;
                OnPropertyChanged("BrojCelija");

            }
        }

        public List<Radnik> ListaRadnika
        {
            get
            {
                return listaRadnika;
            }

            set
            {
                listaRadnika = value;
                OnPropertyChanged("ListaRadnika");

            }
        }

        public int Prihod
        {
            get
            {
                return prihod;
            }

            set
            {
                prihod = value;
                OnPropertyChanged("Prihod");

            }
        }

        public int Rashod
        {
            get
            {
                return rashod;
            }

            set
            {
                rashod = value;
                OnPropertyChanged("Rashod");

            }
        }

        public int TrenutnoStanjeBudzeta
        {
            get
            {
                return trenutnoStanjeBudzeta;
            }

            set
            {
                trenutnoStanjeBudzeta = value;
                OnPropertyChanged("TrenutnoStanjeBudzeta");

            }
        }

        public int IznosPovecanja
        {
            get
            {
                return iznosPovecanja;
            }

            set
            {
                iznosPovecanja = value;
                OnPropertyChanged("IznosPovecanja");

            }
        }

        public string ImeZatvorenikaIzvjestaj
        {
            get
            {
                return imeZatvorenikaIzvjestaj;
            }

            set
            {
                imeZatvorenikaIzvjestaj = value;
                OnPropertyChanged("ImeZatvorenikaIzvjestaj");

            }
        }

        public string PrezimeZatvorenikaIzvjestaj
        {
            get
            {
                return prezimeZatvorenikaIzvjestaj;
            }

            set
            {
                prezimeZatvorenikaIzvjestaj = value;
                OnPropertyChanged("PrezimeZatvorenikaIzvjestaj");

            }
        }

        public string CelijaZatvorenikaIzvjestaj
        {
            get
            {
                return celijaZatvorenikaIzvjestaj;
            }

            set
            {
                celijaZatvorenikaIzvjestaj = value;
                OnPropertyChanged("CelijaZatvorenikaIzvjestaj");

            }
        }

      

        public DateTime DatumIzvjestaj
        {
            get
            {
                return datumIzvjestaj;
            }

            set
            {
                datumIzvjestaj = value;
                OnPropertyChanged("DatumIzvjestaj");

            }
        }

        public string TekstPrekrsaja
        {
            get
            {
                return tekstPrekrsaja;
            }

            set
            {
                tekstPrekrsaja = value;
                OnPropertyChanged("TekstPrekrsaja");

            }
        }

        public string TekstPohvale
        {
            get
            {
                return tekstPohvale;
            }

            set
            {
                tekstPohvale = value;
                OnPropertyChanged("TekstPohvale");

            }
        }

        public string UkupanBrojPrekrsaja
        {
            get
            {
                return ukupanBrojPrekrsaja;
            }

            set
            {
                Debug.WriteLine("mijenja se");
                ukupanBrojPrekrsaja = value;
                OnPropertyChanged("UkupanBrojPrekrsaja");
            }
        }

        public string UkupanBrojPohvala
        {
            get
            {
                return ukupanBrojPohvala;
            }

            set
            {
                ukupanBrojPohvala = value;
                OnPropertyChanged("UkupanBrojPohvala");
            }
        }

        public bool Bolovanje
        {
            get
            {
                return bolovanje;
            }

            set
            {
                bolovanje = value;
                OnPropertyChanged("Bolovanje");
            }
        }

        public bool GodisnjiOdmor
        {
            get
            {
                return godisnjiOdmor;
            }

            set
            {
                godisnjiOdmor = value;
                OnPropertyChanged("GodisnjiOdmor");
            }
        }

        public DateTime DatumOdlaska
        {
            get
            {
                return datumOdlaska;
            }

            set
            {
                datumOdlaska = value;
                OnPropertyChanged("DatumOdlaska");
            }
        }

        public DateTime DatumPovratka
        {
            get
            {
                return datumPovratka;
            }

            set
            {
                datumPovratka = value;
                OnPropertyChanged("DatumPovratka");

            }
        }

        public Strazar StrazarTrenutni
        {
            get
            {
                return strazarTrenutni;
            }

            set
            {
                strazarTrenutni = value;
                OnPropertyChanged("StrazarTrenutni");
            }
        }

        public Vozac VozacTrenutni
        {
            get
            {
                return vozacTrenutni;
            }

            set
            {
                vozacTrenutni = value;
                OnPropertyChanged("VozacTrenutni");
            }
        }

        public ObservableCollection<string> ListaZatvorenikaVozac
        {
            get
            {
                return listaZatvorenikaVozac;
            }

            set
            {
                listaZatvorenikaVozac = value;
                OnPropertyChanged("ListaZatvorenikaVozac");
            }
        }

        public ObservableCollection<string> ListaDatumaVozac
        {
            get
            {
                return listaDatumaVozac;
            }

            set
            {
                listaDatumaVozac = value;
                OnPropertyChanged("ListaDatumaVozac");

            }
        }

        public ObservableCollection<string> ListaOdredistaVozac
        {
            get
            {
                return listaOdredistaVozac;
            }

            set
            {
                listaOdredistaVozac = value;
                OnPropertyChanged("ListaOdredistaVozac");

            }
        }

        public ObservableCollection<string> ListaVozacaVozac
        {
            get
            {
                return listaVozacaVozac;
            }

            set
            {
                listaVozacaVozac = value;
                OnPropertyChanged("ListaVozacaVozac");

            }
        }

        public Voznja V1
        {
            get
            {
                return v1;
            }

            set
            {
                v1 = value;
            }
        }

        public Voznja V2
        {
            get
            {
                return v2;
            }

            set
            {
                v2 = value;
            }
        }

        public string OznacenaVoznja
        {
            get
            {
                return oznacenaVoznja;
            }

            set
            {
                oznacenaVoznja = value;
                OnPropertyChanged("OznacenaVoznja");
            }
        }

        public Voznja VoznjaZaObrisati
        {
            get
            {
                return voznjaZaObrisati;
            }

            set
            {
                voznjaZaObrisati = value;
                OnPropertyChanged("VoznjaZaObrisati");
            }
        }

        public int IndeksOznaceneVoznje
        {
            get
            {
                return indeksOznaceneVoznje;
            }

            set
            {
                indeksOznaceneVoznje = value;
                OnPropertyChanged("IndeksOznaceneVoznje");
            }
        }

        public string OznacenZatvorenikVoznja
        {
            get
            {
                return oznacenZatvorenikVoznja;
            }

            set
            {
                oznacenZatvorenikVoznja = value;
                OnPropertyChanged("OznacenZatvorenikVoznja");
            }
        }

        public string OznacenDatumVoznja
        {
            get
            {
                return oznacenDatumVoznja;
            }

            set
            {
                oznacenDatumVoznja = value;
                OnPropertyChanged("OznacenDatumVoznja");
            }
        }

        public string OznacenoOdredisteVoznja
        {
            get
            {
                return oznacenoOdredisteVoznja;
            }

            set
            {
                oznacenoOdredisteVoznja = value;
                OnPropertyChanged("OznacenoVrijemeVoznja");
            }
        }

        public Radnik NoviRadnik
        {
            get
            {
                return noviRadnik;
            }

            set
            {
                noviRadnik = value;
                OnPropertyChanged("NoviRadnik");
            }
        }

        public ObservableCollection<string> ListaPozicija
        {
            get
            {
                return listaPozicija;
            }

            set
            {
                listaPozicija = value;
                OnPropertyChanged("ListaPozicija");
            }
        }

        public string OznacenaPozicija
        {
            get
            {
                return oznacenaPozicija;
            }

            set
            {
                oznacenaPozicija = value;
                OnPropertyChanged("OznacenaPozicija");
            }
        }

        public UpraviteljZaLjudskeResurse UpraviteljTrenutni
        {
            get
            {
                return upraviteljTrenutni;
            }

            set
            {
                upraviteljTrenutni = value;
                OnPropertyChanged("UpraviteljTrenutni");
            }
        }

        public decimal PomPlata
        {
            get
            {
                return pomPlata;
            }

            set
            {
                pomPlata = value;
                OnPropertyChanged("PomPlata");
            }
        }

        public string PlataText
        {
            get
            {
                return plataText;
            }

            set
            {
                plataText = value;
                OnPropertyChanged("PlataText");
            }
        }

        public Radnik OtpustiRadnik
        {
            get
            {
                return otpustiRadnik;
            }

            set
            {
                otpustiRadnik = value;
                OnPropertyChanged("OtpustiRadnik");
            }
        }

        public string ImeRadnika
        {
            get
            {
                return imeRadnika;
            }

            set
            {
                imeRadnika = value;
                OnPropertyChanged("ImeRadnika");
            }
        }

        public string PrezimeRadnika
        {
            get
            {
                return prezimeRadnika;
            }

            set
            {
                prezimeRadnika = value;
                OnPropertyChanged("PrezimeRadnika");
            }
        }

        public string OtpremninaString
        {
            get
            {
                return otpremninaString;
            }

            set
            {
                otpremninaString = value;
                OnPropertyChanged("OtpremninaString");
            }
        }

        public decimal Otpremnina
        {
            get
            {
                return otpremnina;
            }

            set
            {
                otpremnina = value;
                OnPropertyChanged("Otpremnina");
            }
        }

        public Zatvorenik NoviZatvorenik
        {
            get
            {
                return noviZatvorenik;
            }

            set
            {
                noviZatvorenik = value;
                OnPropertyChanged("NoviZatvorenik");
            }
        }

        public Celija OznacenaCelija
        {
            get
            {
                return oznacenaCelija;
            }

            set
            {
                oznacenaCelija = value;
                OnPropertyChanged("OznacenaCelija");
            }
        }

        public Narudzba NovaNarudzba
        {
            get
            {
                return novaNarudzba;
            }

            set
            {
                novaNarudzba = value;
                OnPropertyChanged("NovaNarudzba");
            }
        }

        public List<Narudzba> ListaOdobrenihNarudzbi
        {
            get
            {
                return listaOdobrenihNarudzbi;
            }

            set
            {
                listaOdobrenihNarudzbi = value;
                OnPropertyChanged("ListaOdobrenihNarudzbi");
            }
        }

        public List<Prekrsaj> ListaSvihPrekrsaja
        {
            get
            {
                return listaSvihPrekrsaja;
            }

            set
            {
                listaSvihPrekrsaja = value;
                OnPropertyChanged("ListaSvihPrekrsaja");
            }
        }

        public string PomLista
        {
            get
            {
                return pomLista;
                OnPropertyChanged("PomLista");
            }

            set
            {
                pomLista = value;
            }
        }

        public List<LoginPodaci> ListaLogina
        {
            get
            {
                return listaLogina;
            }

            set
            {
                listaLogina = value;
            }
        }

        public List<UpravnikKluba> ListaUšravnikaKlubova { get; private set; }


        #endregion

    }
}
