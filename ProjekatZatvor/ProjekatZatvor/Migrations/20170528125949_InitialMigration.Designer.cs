using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using ProjekatZatvor.Model;

namespace ProjekatZatvorMigrations
{
    [ContextType(typeof(dbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20170528125949_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("ProjekatZatvor.Model.Celija", b =>
                {
                    b.Property<int>("CelijaId")
                        .ValueGeneratedOnAdd()
                        .Annotation("Relational:ColumnType", "INTEGER");

                    b.Property<int>("BrojCelije");

                    b.Property<string>("Pin");

                    b.Property<int>("StatusCelije");

                    b.Property<int?>("UpraviteljZaLjudskeResurseId");

                    b.Key("CelijaId");
                });

            builder.Entity("ProjekatZatvor.Model.Doktor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojIskoristenihDopusta");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<bool>("NaDopustu");

                    b.Property<decimal>("Plata");

                    b.Property<string>("Prezime");

                    b.Property<string>("Zanimanje");

                    b.Property<int?>("loginLoginPodaciId");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.ElementRasporeda<ProjekatZatvor.Model.Posjetilac>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum");

                    b.Property<int?>("KoordinatorZaPosjeteITransportId");

                    b.Property<string>("Mjesto");

                    b.Property<int?>("TipRasporedaPosjetilacId");

                    b.Property<string>("Vrijeme");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.ElementRasporeda<ProjekatZatvor.Model.Strazar>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum");

                    b.Property<string>("Mjesto");

                    b.Property<int?>("NadzornikNadzornikId");

                    b.Property<int?>("TipRasporedaId");

                    b.Property<string>("Vrijeme");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.ElementRasporeda<ProjekatZatvor.Model.Vozac>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum");

                    b.Property<string>("Mjesto");

                    b.Property<int?>("TipRasporedaId");

                    b.Property<string>("Vrijeme");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.ElementRasporeda<ProjekatZatvor.Model.Voznja>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum");

                    b.Property<string>("Mjesto");

                    b.Property<int?>("TipRasporedaVoznjaId");

                    b.Property<string>("Vrijeme");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.Izvjestaj", b =>
                {
                    b.Property<int>("IzvjestajId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("StrazarId");

                    b.Property<string>("Tekst");

                    b.Property<int>("TipIzvjestaja");

                    b.Property<int?>("ZatvorenikZatvorenikId");

                    b.Key("IzvjestajId");
                });

            builder.Entity("ProjekatZatvor.Model.Klub", b =>
                {
                    b.Property<int>("KlubId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojClanova");

                    b.Property<int>("ImeKluba");

                    b.Property<int?>("StrazarKlubaId");

                    b.Property<int?>("UpravnikKlubaId");

                    b.Key("KlubId");
                });

            builder.Entity("ProjekatZatvor.Model.KoordinatorZaPosjeteITransport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojIskoristenihDopusta");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<bool>("NaDopustu");

                    b.Property<decimal>("Plata");

                    b.Property<string>("Prezime");

                    b.Property<string>("Zanimanje");

                    b.Property<int?>("loginLoginPodaciId");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.Kuhar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojIskoristenihDopusta");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<bool>("NaDopustu");

                    b.Property<decimal>("Plata");

                    b.Property<string>("Prezime");

                    b.Property<string>("Zanimanje");

                    b.Property<int?>("loginLoginPodaciId");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.LoginPodaci", b =>
                {
                    b.Property<int>("LoginPodaciId")
                        .ValueGeneratedOnAdd()
                        .Annotation("Relational:ColumnType", "INTEGER");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.Key("LoginPodaciId");
                });

            builder.Entity("ProjekatZatvor.Model.Nadzornik", b =>
                {
                    b.Property<int>("NadzornikId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<decimal>("Plata");

                    b.Property<string>("Prezime");

                    b.Property<int?>("loginLoginPodaciId");

                    b.Key("NadzornikId");
                });

            builder.Entity("ProjekatZatvor.Model.Narudzba", b =>
                {
                    b.Property<int>("NarudzbaId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cijena");

                    b.Property<int>("Kolicina");

                    b.Property<string>("NazivArtikla");

                    b.Property<bool>("Odobreno");

                    b.Property<int?>("UpravnikUpravnikId");

                    b.Key("NarudzbaId");
                });

            builder.Entity("ProjekatZatvor.Model.Posjetilac", b =>
                {
                    b.Property<int>("PosjetilacId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojLicneKarte");

                    b.Property<string>("Ime");

                    b.Property<int?>("KoordinatorZaPosjeteITransportId");

                    b.Property<string>("Prezime");

                    b.Key("PosjetilacId");
                });

            builder.Entity("ProjekatZatvor.Model.Prekrsaj", b =>
                {
                    b.Property<int>("PrekrsajId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Opis");

                    b.Property<int?>("PocinilacPrekrsajaZatvorenikId");

                    b.Property<string>("Tip");

                    b.Key("PrekrsajId");
                });

            builder.Entity("ProjekatZatvor.Model.Radnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojIskoristenihDopusta");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<bool>("NaDopustu");

                    b.Property<decimal>("Plata");

                    b.Property<string>("Prezime");

                    b.Property<int?>("UpraviteljZaLjudskeResurseId");

                    b.Property<int?>("UpravnikUpravnikId");

                    b.Property<string>("Zanimanje");

                    b.Property<int?>("loginLoginPodaciId");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.SmrtnaKazna", b =>
                {
                    b.Property<int>("SmrtnaKaznaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Mjesto");

                    b.Property<string>("PosljednjaZelja");

                    b.Property<DateTime>("Vrijeme");

                    b.Key("SmrtnaKaznaId");
                });

            builder.Entity("ProjekatZatvor.Model.Strazar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojIskoristenihDopusta");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<bool>("NaDopustu");

                    b.Property<int?>("NadzornikNadzornikId");

                    b.Property<decimal>("Plata");

                    b.Property<string>("Prezime");

                    b.Property<string>("Zanimanje");

                    b.Property<int?>("loginLoginPodaciId");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.Uposlenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojIskoristenihDopusta");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<bool>("NaDopustu");

                    b.Property<decimal>("Plata");

                    b.Property<string>("Prezime");

                    b.Property<string>("Zanimanje");

                    b.Property<int?>("loginLoginPodaciId");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.UpraviteljZaLjudskeResurse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<decimal>("Plata");

                    b.Property<string>("Prezime");

                    b.Property<int?>("loginLoginPodaciId");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.Upravnik", b =>
                {
                    b.Property<int>("UpravnikId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Budzet");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<string>("Pin");

                    b.Property<decimal>("Plata");

                    b.Property<string>("Prezime");

                    b.Property<decimal>("Prihod");

                    b.Property<decimal>("Rashod");

                    b.Property<string>("Usermane");

                    b.Property<int?>("loginLoginPodaciId");

                    b.Key("UpravnikId");
                });

            builder.Entity("ProjekatZatvor.Model.UpravnikKluba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojIskoristenihDopusta");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<bool>("NaDopustu");

                    b.Property<decimal>("Plata");

                    b.Property<string>("Prezime");

                    b.Property<string>("Zanimanje");

                    b.Property<int?>("loginLoginPodaciId");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.Vozac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojIskoristenihDopusta");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<int?>("KoordinatorZaPosjeteITransportId");

                    b.Property<bool>("NaDopustu");

                    b.Property<decimal>("Plata");

                    b.Property<string>("Prezime");

                    b.Property<string>("Zanimanje");

                    b.Property<int?>("loginLoginPodaciId");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.Voznja", b =>
                {
                    b.Property<int>("VoznjaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("KoordinatorZaPosjeteITransportId");

                    b.Property<string>("Mjesto");

                    b.Property<int?>("TerminId");

                    b.Property<bool>("UspjesnaVoznja");

                    b.Property<int?>("VozacId");

                    b.Property<int?>("ZatvorenikZatvorenikId");

                    b.Key("VoznjaId");
                });

            builder.Entity("ProjekatZatvor.Model.Zahtjev<ProjekatZatvor.Model.Radnik>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("JeLiOdobren");

                    b.Property<string>("Naziv");

                    b.Property<int?>("PosiljalacId");

                    b.Property<string>("TekstMolbe");

                    b.Property<int?>("UpravnikUpravnikId");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.Zahtjev<ProjekatZatvor.Model.Zatvorenik>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("JeLiOdobren");

                    b.Property<string>("Naziv");

                    b.Property<int?>("PosiljalacZatvorenikId");

                    b.Property<string>("TekstMolbe");

                    b.Property<int?>("UpravnikUpravnikId");

                    b.Key("Id");
                });

            builder.Entity("ProjekatZatvor.Model.Zaliha", b =>
                {
                    b.Property<int>("ZalihaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DoktorId");

                    b.Property<int>("Kolicina");

                    b.Property<int?>("KuharId");

                    b.Property<string>("Naziv");

                    b.Property<int>("TipZalihe");

                    b.Property<int?>("UposlenikId");

                    b.Key("ZalihaId");
                });

            builder.Entity("ProjekatZatvor.Model.Zatvorenik", b =>
                {
                    b.Property<int>("ZatvorenikId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CelijaCelijaId");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<int?>("DoktorId");

                    b.Property<string>("Ime");

                    b.Property<string>("Jmbg");

                    b.Property<int?>("KoordinatorZaPosjeteITransportId");

                    b.Property<string>("OptuzenZa");

                    b.Property<DateTime>("Otpusten");

                    b.Property<string>("PinZaKlub");

                    b.Property<string>("Prezime");

                    b.Property<DateTime>("Primljen");

                    b.Property<int?>("SmrtnaKaznaSmrtnaKaznaId");

                    b.Property<int?>("StrazarId");

                    b.Property<int?>("UpraviteljZaLjudskeResurseId");

                    b.Property<int?>("UpravnikIdUpravnikId");

                    b.Property<int?>("UpravnikKlubaId");

                    b.Property<int?>("UpravnikKlubaId1");

                    b.Property<int?>("loginLoginPodaciId");

                    b.Key("ZatvorenikId");
                });

            builder.Entity("ProjekatZatvor.Model.Celija", b =>
                {
                    b.Reference("ProjekatZatvor.Model.UpraviteljZaLjudskeResurse")
                        .InverseCollection()
                        .ForeignKey("UpraviteljZaLjudskeResurseId");
                });

            builder.Entity("ProjekatZatvor.Model.Doktor", b =>
                {
                    b.Reference("ProjekatZatvor.Model.LoginPodaci")
                        .InverseCollection()
                        .ForeignKey("loginLoginPodaciId");
                });

            builder.Entity("ProjekatZatvor.Model.ElementRasporeda<ProjekatZatvor.Model.Posjetilac>", b =>
                {
                    b.Reference("ProjekatZatvor.Model.KoordinatorZaPosjeteITransport")
                        .InverseCollection()
                        .ForeignKey("KoordinatorZaPosjeteITransportId");

                    b.Reference("ProjekatZatvor.Model.Posjetilac")
                        .InverseCollection()
                        .ForeignKey("TipRasporedaPosjetilacId");
                });

            builder.Entity("ProjekatZatvor.Model.ElementRasporeda<ProjekatZatvor.Model.Strazar>", b =>
                {
                    b.Reference("ProjekatZatvor.Model.Nadzornik")
                        .InverseCollection()
                        .ForeignKey("NadzornikNadzornikId");

                    b.Reference("ProjekatZatvor.Model.Strazar")
                        .InverseCollection()
                        .ForeignKey("TipRasporedaId");
                });

            builder.Entity("ProjekatZatvor.Model.ElementRasporeda<ProjekatZatvor.Model.Vozac>", b =>
                {
                    b.Reference("ProjekatZatvor.Model.Vozac")
                        .InverseCollection()
                        .ForeignKey("TipRasporedaId");
                });

            builder.Entity("ProjekatZatvor.Model.ElementRasporeda<ProjekatZatvor.Model.Voznja>", b =>
                {
                    b.Reference("ProjekatZatvor.Model.Voznja")
                        .InverseCollection()
                        .ForeignKey("TipRasporedaVoznjaId");
                });

            builder.Entity("ProjekatZatvor.Model.Izvjestaj", b =>
                {
                    b.Reference("ProjekatZatvor.Model.Strazar")
                        .InverseCollection()
                        .ForeignKey("StrazarId");

                    b.Reference("ProjekatZatvor.Model.Zatvorenik")
                        .InverseCollection()
                        .ForeignKey("ZatvorenikZatvorenikId");
                });

            builder.Entity("ProjekatZatvor.Model.Klub", b =>
                {
                    b.Reference("ProjekatZatvor.Model.Strazar")
                        .InverseCollection()
                        .ForeignKey("StrazarKlubaId");

                    b.Reference("ProjekatZatvor.Model.UpravnikKluba")
                        .InverseCollection()
                        .ForeignKey("UpravnikKlubaId");
                });

            builder.Entity("ProjekatZatvor.Model.KoordinatorZaPosjeteITransport", b =>
                {
                    b.Reference("ProjekatZatvor.Model.LoginPodaci")
                        .InverseCollection()
                        .ForeignKey("loginLoginPodaciId");
                });

            builder.Entity("ProjekatZatvor.Model.Kuhar", b =>
                {
                    b.Reference("ProjekatZatvor.Model.LoginPodaci")
                        .InverseCollection()
                        .ForeignKey("loginLoginPodaciId");
                });

            builder.Entity("ProjekatZatvor.Model.Nadzornik", b =>
                {
                    b.Reference("ProjekatZatvor.Model.LoginPodaci")
                        .InverseCollection()
                        .ForeignKey("loginLoginPodaciId");
                });

            builder.Entity("ProjekatZatvor.Model.Narudzba", b =>
                {
                    b.Reference("ProjekatZatvor.Model.Upravnik")
                        .InverseCollection()
                        .ForeignKey("UpravnikUpravnikId");
                });

            builder.Entity("ProjekatZatvor.Model.Posjetilac", b =>
                {
                    b.Reference("ProjekatZatvor.Model.KoordinatorZaPosjeteITransport")
                        .InverseCollection()
                        .ForeignKey("KoordinatorZaPosjeteITransportId");
                });

            builder.Entity("ProjekatZatvor.Model.Prekrsaj", b =>
                {
                    b.Reference("ProjekatZatvor.Model.Zatvorenik")
                        .InverseCollection()
                        .ForeignKey("PocinilacPrekrsajaZatvorenikId");
                });

            builder.Entity("ProjekatZatvor.Model.Radnik", b =>
                {
                    b.Reference("ProjekatZatvor.Model.UpraviteljZaLjudskeResurse")
                        .InverseCollection()
                        .ForeignKey("UpraviteljZaLjudskeResurseId");

                    b.Reference("ProjekatZatvor.Model.Upravnik")
                        .InverseCollection()
                        .ForeignKey("UpravnikUpravnikId");

                    b.Reference("ProjekatZatvor.Model.LoginPodaci")
                        .InverseCollection()
                        .ForeignKey("loginLoginPodaciId");
                });

            builder.Entity("ProjekatZatvor.Model.Strazar", b =>
                {
                    b.Reference("ProjekatZatvor.Model.Nadzornik")
                        .InverseCollection()
                        .ForeignKey("NadzornikNadzornikId");

                    b.Reference("ProjekatZatvor.Model.LoginPodaci")
                        .InverseCollection()
                        .ForeignKey("loginLoginPodaciId");
                });

            builder.Entity("ProjekatZatvor.Model.Uposlenik", b =>
                {
                    b.Reference("ProjekatZatvor.Model.LoginPodaci")
                        .InverseCollection()
                        .ForeignKey("loginLoginPodaciId");
                });

            builder.Entity("ProjekatZatvor.Model.UpraviteljZaLjudskeResurse", b =>
                {
                    b.Reference("ProjekatZatvor.Model.LoginPodaci")
                        .InverseCollection()
                        .ForeignKey("loginLoginPodaciId");
                });

            builder.Entity("ProjekatZatvor.Model.Upravnik", b =>
                {
                    b.Reference("ProjekatZatvor.Model.LoginPodaci")
                        .InverseCollection()
                        .ForeignKey("loginLoginPodaciId");
                });

            builder.Entity("ProjekatZatvor.Model.UpravnikKluba", b =>
                {
                    b.Reference("ProjekatZatvor.Model.LoginPodaci")
                        .InverseCollection()
                        .ForeignKey("loginLoginPodaciId");
                });

            builder.Entity("ProjekatZatvor.Model.Vozac", b =>
                {
                    b.Reference("ProjekatZatvor.Model.KoordinatorZaPosjeteITransport")
                        .InverseCollection()
                        .ForeignKey("KoordinatorZaPosjeteITransportId");

                    b.Reference("ProjekatZatvor.Model.LoginPodaci")
                        .InverseCollection()
                        .ForeignKey("loginLoginPodaciId");
                });

            builder.Entity("ProjekatZatvor.Model.Voznja", b =>
                {
                    b.Reference("ProjekatZatvor.Model.KoordinatorZaPosjeteITransport")
                        .InverseCollection()
                        .ForeignKey("KoordinatorZaPosjeteITransportId");

                    b.Reference("ProjekatZatvor.Model.ElementRasporeda<ProjekatZatvor.Model.Vozac>")
                        .InverseCollection()
                        .ForeignKey("TerminId");

                    b.Reference("ProjekatZatvor.Model.Vozac")
                        .InverseCollection()
                        .ForeignKey("VozacId");

                    b.Reference("ProjekatZatvor.Model.Zatvorenik")
                        .InverseCollection()
                        .ForeignKey("ZatvorenikZatvorenikId");
                });

            builder.Entity("ProjekatZatvor.Model.Zahtjev<ProjekatZatvor.Model.Radnik>", b =>
                {
                    b.Reference("ProjekatZatvor.Model.Radnik")
                        .InverseCollection()
                        .ForeignKey("PosiljalacId");

                    b.Reference("ProjekatZatvor.Model.Upravnik")
                        .InverseCollection()
                        .ForeignKey("UpravnikUpravnikId");
                });

            builder.Entity("ProjekatZatvor.Model.Zahtjev<ProjekatZatvor.Model.Zatvorenik>", b =>
                {
                    b.Reference("ProjekatZatvor.Model.Zatvorenik")
                        .InverseCollection()
                        .ForeignKey("PosiljalacZatvorenikId");

                    b.Reference("ProjekatZatvor.Model.Upravnik")
                        .InverseCollection()
                        .ForeignKey("UpravnikUpravnikId");
                });

            builder.Entity("ProjekatZatvor.Model.Zaliha", b =>
                {
                    b.Reference("ProjekatZatvor.Model.Doktor")
                        .InverseCollection()
                        .ForeignKey("DoktorId");

                    b.Reference("ProjekatZatvor.Model.Kuhar")
                        .InverseCollection()
                        .ForeignKey("KuharId");

                    b.Reference("ProjekatZatvor.Model.Uposlenik")
                        .InverseCollection()
                        .ForeignKey("UposlenikId");
                });

            builder.Entity("ProjekatZatvor.Model.Zatvorenik", b =>
                {
                    b.Reference("ProjekatZatvor.Model.Celija")
                        .InverseCollection()
                        .ForeignKey("CelijaCelijaId");

                    b.Reference("ProjekatZatvor.Model.Doktor")
                        .InverseCollection()
                        .ForeignKey("DoktorId");

                    b.Reference("ProjekatZatvor.Model.KoordinatorZaPosjeteITransport")
                        .InverseCollection()
                        .ForeignKey("KoordinatorZaPosjeteITransportId");

                    b.Reference("ProjekatZatvor.Model.SmrtnaKazna")
                        .InverseCollection()
                        .ForeignKey("SmrtnaKaznaSmrtnaKaznaId");

                    b.Reference("ProjekatZatvor.Model.Strazar")
                        .InverseCollection()
                        .ForeignKey("StrazarId");

                    b.Reference("ProjekatZatvor.Model.UpraviteljZaLjudskeResurse")
                        .InverseCollection()
                        .ForeignKey("UpraviteljZaLjudskeResurseId");

                    b.Reference("ProjekatZatvor.Model.Upravnik")
                        .InverseCollection()
                        .ForeignKey("UpravnikIdUpravnikId");

                    b.Reference("ProjekatZatvor.Model.UpravnikKluba")
                        .InverseCollection()
                        .ForeignKey("UpravnikKlubaId");

                    b.Reference("ProjekatZatvor.Model.UpravnikKluba")
                        .InverseCollection()
                        .ForeignKey("UpravnikKlubaId1");

                    b.Reference("ProjekatZatvor.Model.LoginPodaci")
                        .InverseCollection()
                        .ForeignKey("loginLoginPodaciId");
                });
        }
    }
}
