using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace ProjekatZatvorMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "LoginPodaci",
                columns: table => new
                {
                    LoginPodaciId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    Password = table.Column(type: "TEXT", nullable: true),
                    Username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginPodaci", x => x.LoginPodaciId);
                });
            migration.CreateTable(
                name: "SmrtnaKazna",
                columns: table => new
                {
                    SmrtnaKaznaId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    Mjesto = table.Column(type: "TEXT", nullable: true),
                    PosljednjaZelja = table.Column(type: "TEXT", nullable: true),
                    Vrijeme = table.Column(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmrtnaKazna", x => x.SmrtnaKaznaId);
                });
            migration.CreateTable(
                name: "Doktor",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    BrojIskoristenihDopusta = table.Column(type: "INTEGER", nullable: false),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    NaDopustu = table.Column(type: "INTEGER", nullable: false),
                    Plata = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Zanimanje = table.Column(type: "TEXT", nullable: true),
                    loginLoginPodaciId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doktor_LoginPodaci_loginLoginPodaciId",
                        columns: x => x.loginLoginPodaciId,
                        referencedTable: "LoginPodaci",
                        referencedColumn: "LoginPodaciId");
                });
            migration.CreateTable(
                name: "KoordinatorZaPosjeteITransport",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    BrojIskoristenihDopusta = table.Column(type: "INTEGER", nullable: false),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    NaDopustu = table.Column(type: "INTEGER", nullable: false),
                    Plata = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Zanimanje = table.Column(type: "TEXT", nullable: true),
                    loginLoginPodaciId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KoordinatorZaPosjeteITransport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KoordinatorZaPosjeteITransport_LoginPodaci_loginLoginPodaciId",
                        columns: x => x.loginLoginPodaciId,
                        referencedTable: "LoginPodaci",
                        referencedColumn: "LoginPodaciId");
                });
            migration.CreateTable(
                name: "Kuhar",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    BrojIskoristenihDopusta = table.Column(type: "INTEGER", nullable: false),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    NaDopustu = table.Column(type: "INTEGER", nullable: false),
                    Plata = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Zanimanje = table.Column(type: "TEXT", nullable: true),
                    loginLoginPodaciId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kuhar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kuhar_LoginPodaci_loginLoginPodaciId",
                        columns: x => x.loginLoginPodaciId,
                        referencedTable: "LoginPodaci",
                        referencedColumn: "LoginPodaciId");
                });
            migration.CreateTable(
                name: "Nadzornik",
                columns: table => new
                {
                    NadzornikId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    Plata = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    loginLoginPodaciId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nadzornik", x => x.NadzornikId);
                    table.ForeignKey(
                        name: "FK_Nadzornik_LoginPodaci_loginLoginPodaciId",
                        columns: x => x.loginLoginPodaciId,
                        referencedTable: "LoginPodaci",
                        referencedColumn: "LoginPodaciId");
                });
            migration.CreateTable(
                name: "Uposlenik",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    BrojIskoristenihDopusta = table.Column(type: "INTEGER", nullable: false),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    NaDopustu = table.Column(type: "INTEGER", nullable: false),
                    Plata = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Zanimanje = table.Column(type: "TEXT", nullable: true),
                    loginLoginPodaciId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposlenik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uposlenik_LoginPodaci_loginLoginPodaciId",
                        columns: x => x.loginLoginPodaciId,
                        referencedTable: "LoginPodaci",
                        referencedColumn: "LoginPodaciId");
                });
            migration.CreateTable(
                name: "UpraviteljZaLjudskeResurse",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    Plata = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    loginLoginPodaciId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpraviteljZaLjudskeResurse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpraviteljZaLjudskeResurse_LoginPodaci_loginLoginPodaciId",
                        columns: x => x.loginLoginPodaciId,
                        referencedTable: "LoginPodaci",
                        referencedColumn: "LoginPodaciId");
                });
            migration.CreateTable(
                name: "Upravnik",
                columns: table => new
                {
                    UpravnikId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    Budzet = table.Column(type: "TEXT", nullable: false),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    Pin = table.Column(type: "TEXT", nullable: true),
                    Plata = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Prihod = table.Column(type: "TEXT", nullable: false),
                    Rashod = table.Column(type: "TEXT", nullable: false),
                    Usermane = table.Column(type: "TEXT", nullable: true),
                    loginLoginPodaciId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upravnik", x => x.UpravnikId);
                    table.ForeignKey(
                        name: "FK_Upravnik_LoginPodaci_loginLoginPodaciId",
                        columns: x => x.loginLoginPodaciId,
                        referencedTable: "LoginPodaci",
                        referencedColumn: "LoginPodaciId");
                });
            migration.CreateTable(
                name: "UpravnikKluba",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    BrojIskoristenihDopusta = table.Column(type: "INTEGER", nullable: false),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    NaDopustu = table.Column(type: "INTEGER", nullable: false),
                    Plata = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Zanimanje = table.Column(type: "TEXT", nullable: true),
                    loginLoginPodaciId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpravnikKluba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpravnikKluba_LoginPodaci_loginLoginPodaciId",
                        columns: x => x.loginLoginPodaciId,
                        referencedTable: "LoginPodaci",
                        referencedColumn: "LoginPodaciId");
                });
            migration.CreateTable(
                name: "Posjetilac",
                columns: table => new
                {
                    PosjetilacId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    BrojLicneKarte = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    KoordinatorZaPosjeteITransportId = table.Column(type: "INTEGER", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posjetilac", x => x.PosjetilacId);
                    table.ForeignKey(
                        name: "FK_Posjetilac_KoordinatorZaPosjeteITransport_KoordinatorZaPosjeteITransportId",
                        columns: x => x.KoordinatorZaPosjeteITransportId,
                        referencedTable: "KoordinatorZaPosjeteITransport",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "Vozac",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    BrojIskoristenihDopusta = table.Column(type: "INTEGER", nullable: false),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    KoordinatorZaPosjeteITransportId = table.Column(type: "INTEGER", nullable: true),
                    NaDopustu = table.Column(type: "INTEGER", nullable: false),
                    Plata = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Zanimanje = table.Column(type: "TEXT", nullable: true),
                    loginLoginPodaciId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vozac_KoordinatorZaPosjeteITransport_KoordinatorZaPosjeteITransportId",
                        columns: x => x.KoordinatorZaPosjeteITransportId,
                        referencedTable: "KoordinatorZaPosjeteITransport",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vozac_LoginPodaci_loginLoginPodaciId",
                        columns: x => x.loginLoginPodaciId,
                        referencedTable: "LoginPodaci",
                        referencedColumn: "LoginPodaciId");
                });
            migration.CreateTable(
                name: "Strazar",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    BrojIskoristenihDopusta = table.Column(type: "INTEGER", nullable: false),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    NaDopustu = table.Column(type: "INTEGER", nullable: false),
                    NadzornikNadzornikId = table.Column(type: "INTEGER", nullable: true),
                    Plata = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Zanimanje = table.Column(type: "TEXT", nullable: true),
                    loginLoginPodaciId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strazar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Strazar_Nadzornik_NadzornikNadzornikId",
                        columns: x => x.NadzornikNadzornikId,
                        referencedTable: "Nadzornik",
                        referencedColumn: "NadzornikId");
                    table.ForeignKey(
                        name: "FK_Strazar_LoginPodaci_loginLoginPodaciId",
                        columns: x => x.loginLoginPodaciId,
                        referencedTable: "LoginPodaci",
                        referencedColumn: "LoginPodaciId");
                });
            migration.CreateTable(
                name: "Zaliha",
                columns: table => new
                {
                    ZalihaId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    DoktorId = table.Column(type: "INTEGER", nullable: true),
                    Kolicina = table.Column(type: "INTEGER", nullable: false),
                    KuharId = table.Column(type: "INTEGER", nullable: true),
                    Naziv = table.Column(type: "TEXT", nullable: true),
                    TipZalihe = table.Column(type: "INTEGER", nullable: false),
                    UposlenikId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaliha", x => x.ZalihaId);
                    table.ForeignKey(
                        name: "FK_Zaliha_Doktor_DoktorId",
                        columns: x => x.DoktorId,
                        referencedTable: "Doktor",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Zaliha_Kuhar_KuharId",
                        columns: x => x.KuharId,
                        referencedTable: "Kuhar",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Zaliha_Uposlenik_UposlenikId",
                        columns: x => x.UposlenikId,
                        referencedTable: "Uposlenik",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "Celija",
                columns: table => new
                {
                    CelijaId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    BrojCelije = table.Column(type: "INTEGER", nullable: false),
                    Pin = table.Column(type: "TEXT", nullable: true),
                    StatusCelije = table.Column(type: "INTEGER", nullable: false),
                    UpraviteljZaLjudskeResurseId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celija", x => x.CelijaId);
                    table.ForeignKey(
                        name: "FK_Celija_UpraviteljZaLjudskeResurse_UpraviteljZaLjudskeResurseId",
                        columns: x => x.UpraviteljZaLjudskeResurseId,
                        referencedTable: "UpraviteljZaLjudskeResurse",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    NarudzbaId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    Cijena = table.Column(type: "TEXT", nullable: false),
                    Kolicina = table.Column(type: "INTEGER", nullable: false),
                    NazivArtikla = table.Column(type: "TEXT", nullable: true),
                    Odobreno = table.Column(type: "INTEGER", nullable: false),
                    UpravnikUpravnikId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.NarudzbaId);
                    table.ForeignKey(
                        name: "FK_Narudzba_Upravnik_UpravnikUpravnikId",
                        columns: x => x.UpravnikUpravnikId,
                        referencedTable: "Upravnik",
                        referencedColumn: "UpravnikId");
                });
            migration.CreateTable(
                name: "Radnik",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    BrojIskoristenihDopusta = table.Column(type: "INTEGER", nullable: false),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    NaDopustu = table.Column(type: "INTEGER", nullable: false),
                    Plata = table.Column(type: "TEXT", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    UpraviteljZaLjudskeResurseId = table.Column(type: "INTEGER", nullable: true),
                    UpravnikUpravnikId = table.Column(type: "INTEGER", nullable: true),
                    Zanimanje = table.Column(type: "TEXT", nullable: true),
                    loginLoginPodaciId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radnik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Radnik_UpraviteljZaLjudskeResurse_UpraviteljZaLjudskeResurseId",
                        columns: x => x.UpraviteljZaLjudskeResurseId,
                        referencedTable: "UpraviteljZaLjudskeResurse",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Radnik_Upravnik_UpravnikUpravnikId",
                        columns: x => x.UpravnikUpravnikId,
                        referencedTable: "Upravnik",
                        referencedColumn: "UpravnikId");
                    table.ForeignKey(
                        name: "FK_Radnik_LoginPodaci_loginLoginPodaciId",
                        columns: x => x.loginLoginPodaciId,
                        referencedTable: "LoginPodaci",
                        referencedColumn: "LoginPodaciId");
                });
            migration.CreateTable(
                name: "ElementRasporeda<Posjetilac>",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    Datum = table.Column(type: "TEXT", nullable: false),
                    KoordinatorZaPosjeteITransportId = table.Column(type: "INTEGER", nullable: true),
                    Mjesto = table.Column(type: "TEXT", nullable: true),
                    TipRasporedaPosjetilacId = table.Column(type: "INTEGER", nullable: true),
                    Vrijeme = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementRasporeda<Posjetilac>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementRasporeda<Posjetilac>_KoordinatorZaPosjeteITransport_KoordinatorZaPosjeteITransportId",
                        columns: x => x.KoordinatorZaPosjeteITransportId,
                        referencedTable: "KoordinatorZaPosjeteITransport",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ElementRasporeda<Posjetilac>_Posjetilac_TipRasporedaPosjetilacId",
                        columns: x => x.TipRasporedaPosjetilacId,
                        referencedTable: "Posjetilac",
                        referencedColumn: "PosjetilacId");
                });
            migration.CreateTable(
                name: "ElementRasporeda<Vozac>",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    Datum = table.Column(type: "TEXT", nullable: false),
                    Mjesto = table.Column(type: "TEXT", nullable: true),
                    TipRasporedaId = table.Column(type: "INTEGER", nullable: true),
                    Vrijeme = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementRasporeda<Vozac>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementRasporeda<Vozac>_Vozac_TipRasporedaId",
                        columns: x => x.TipRasporedaId,
                        referencedTable: "Vozac",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "ElementRasporeda<Strazar>",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    Datum = table.Column(type: "TEXT", nullable: false),
                    Mjesto = table.Column(type: "TEXT", nullable: true),
                    NadzornikNadzornikId = table.Column(type: "INTEGER", nullable: true),
                    TipRasporedaId = table.Column(type: "INTEGER", nullable: true),
                    Vrijeme = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementRasporeda<Strazar>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementRasporeda<Strazar>_Nadzornik_NadzornikNadzornikId",
                        columns: x => x.NadzornikNadzornikId,
                        referencedTable: "Nadzornik",
                        referencedColumn: "NadzornikId");
                    table.ForeignKey(
                        name: "FK_ElementRasporeda<Strazar>_Strazar_TipRasporedaId",
                        columns: x => x.TipRasporedaId,
                        referencedTable: "Strazar",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "Klub",
                columns: table => new
                {
                    KlubId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    BrojClanova = table.Column(type: "INTEGER", nullable: false),
                    ImeKluba = table.Column(type: "INTEGER", nullable: false),
                    StrazarKlubaId = table.Column(type: "INTEGER", nullable: true),
                    UpravnikKlubaId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klub", x => x.KlubId);
                    table.ForeignKey(
                        name: "FK_Klub_Strazar_StrazarKlubaId",
                        columns: x => x.StrazarKlubaId,
                        referencedTable: "Strazar",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Klub_UpravnikKluba_UpravnikKlubaId",
                        columns: x => x.UpravnikKlubaId,
                        referencedTable: "UpravnikKluba",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "Zatvorenik",
                columns: table => new
                {
                    ZatvorenikId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    CelijaCelijaId = table.Column(type: "INTEGER", nullable: true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    DoktorId = table.Column(type: "INTEGER", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    KoordinatorZaPosjeteITransportId = table.Column(type: "INTEGER", nullable: true),
                    OptuzenZa = table.Column(type: "TEXT", nullable: true),
                    Otpusten = table.Column(type: "TEXT", nullable: false),
                    PinZaKlub = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Primljen = table.Column(type: "TEXT", nullable: false),
                    SmrtnaKaznaSmrtnaKaznaId = table.Column(type: "INTEGER", nullable: true),
                    StrazarId = table.Column(type: "INTEGER", nullable: true),
                    UpraviteljZaLjudskeResurseId = table.Column(type: "INTEGER", nullable: true),
                    UpravnikIdUpravnikId = table.Column(type: "INTEGER", nullable: true),
                    UpravnikKlubaId = table.Column(type: "INTEGER", nullable: true),
                    UpravnikKlubaId1 = table.Column(type: "INTEGER", nullable: true),
                    loginLoginPodaciId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zatvorenik", x => x.ZatvorenikId);
                    table.ForeignKey(
                        name: "FK_Zatvorenik_Celija_CelijaCelijaId",
                        columns: x => x.CelijaCelijaId,
                        referencedTable: "Celija",
                        referencedColumn: "CelijaId");
                    table.ForeignKey(
                        name: "FK_Zatvorenik_Doktor_DoktorId",
                        columns: x => x.DoktorId,
                        referencedTable: "Doktor",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Zatvorenik_KoordinatorZaPosjeteITransport_KoordinatorZaPosjeteITransportId",
                        columns: x => x.KoordinatorZaPosjeteITransportId,
                        referencedTable: "KoordinatorZaPosjeteITransport",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Zatvorenik_SmrtnaKazna_SmrtnaKaznaSmrtnaKaznaId",
                        columns: x => x.SmrtnaKaznaSmrtnaKaznaId,
                        referencedTable: "SmrtnaKazna",
                        referencedColumn: "SmrtnaKaznaId");
                    table.ForeignKey(
                        name: "FK_Zatvorenik_Strazar_StrazarId",
                        columns: x => x.StrazarId,
                        referencedTable: "Strazar",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Zatvorenik_UpraviteljZaLjudskeResurse_UpraviteljZaLjudskeResurseId",
                        columns: x => x.UpraviteljZaLjudskeResurseId,
                        referencedTable: "UpraviteljZaLjudskeResurse",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Zatvorenik_Upravnik_UpravnikIdUpravnikId",
                        columns: x => x.UpravnikIdUpravnikId,
                        referencedTable: "Upravnik",
                        referencedColumn: "UpravnikId");
                    table.ForeignKey(
                        name: "FK_Zatvorenik_UpravnikKluba_UpravnikKlubaId",
                        columns: x => x.UpravnikKlubaId,
                        referencedTable: "UpravnikKluba",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Zatvorenik_UpravnikKluba_UpravnikKlubaId1",
                        columns: x => x.UpravnikKlubaId1,
                        referencedTable: "UpravnikKluba",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Zatvorenik_LoginPodaci_loginLoginPodaciId",
                        columns: x => x.loginLoginPodaciId,
                        referencedTable: "LoginPodaci",
                        referencedColumn: "LoginPodaciId");
                });
            migration.CreateTable(
                name: "Zahtjev<Radnik>",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    JeLiOdobren = table.Column(type: "INTEGER", nullable: false),
                    Naziv = table.Column(type: "TEXT", nullable: true),
                    PosiljalacId = table.Column(type: "INTEGER", nullable: true),
                    TekstMolbe = table.Column(type: "TEXT", nullable: true),
                    UpravnikUpravnikId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev<Radnik>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zahtjev<Radnik>_Radnik_PosiljalacId",
                        columns: x => x.PosiljalacId,
                        referencedTable: "Radnik",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Zahtjev<Radnik>_Upravnik_UpravnikUpravnikId",
                        columns: x => x.UpravnikUpravnikId,
                        referencedTable: "Upravnik",
                        referencedColumn: "UpravnikId");
                });
            migration.CreateTable(
                name: "Izvjestaj",
                columns: table => new
                {
                    IzvjestajId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    StrazarId = table.Column(type: "INTEGER", nullable: true),
                    Tekst = table.Column(type: "TEXT", nullable: true),
                    TipIzvjestaja = table.Column(type: "INTEGER", nullable: false),
                    ZatvorenikZatvorenikId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izvjestaj", x => x.IzvjestajId);
                    table.ForeignKey(
                        name: "FK_Izvjestaj_Strazar_StrazarId",
                        columns: x => x.StrazarId,
                        referencedTable: "Strazar",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Izvjestaj_Zatvorenik_ZatvorenikZatvorenikId",
                        columns: x => x.ZatvorenikZatvorenikId,
                        referencedTable: "Zatvorenik",
                        referencedColumn: "ZatvorenikId");
                });
            migration.CreateTable(
                name: "Prekrsaj",
                columns: table => new
                {
                    PrekrsajId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    Opis = table.Column(type: "TEXT", nullable: true),
                    PocinilacPrekrsajaZatvorenikId = table.Column(type: "INTEGER", nullable: true),
                    Tip = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prekrsaj", x => x.PrekrsajId);
                    table.ForeignKey(
                        name: "FK_Prekrsaj_Zatvorenik_PocinilacPrekrsajaZatvorenikId",
                        columns: x => x.PocinilacPrekrsajaZatvorenikId,
                        referencedTable: "Zatvorenik",
                        referencedColumn: "ZatvorenikId");
                });
            migration.CreateTable(
                name: "Voznja",
                columns: table => new
                {
                    VoznjaId = table.Column(type: "INTEGER", nullable: false)
                        ,
                    KoordinatorZaPosjeteITransportId = table.Column(type: "INTEGER", nullable: true),
                    Mjesto = table.Column(type: "TEXT", nullable: true),
                    TerminId = table.Column(type: "INTEGER", nullable: true),
                    UspjesnaVoznja = table.Column(type: "INTEGER", nullable: false),
                    VozacId = table.Column(type: "INTEGER", nullable: true),
                    ZatvorenikZatvorenikId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voznja", x => x.VoznjaId);
                    table.ForeignKey(
                        name: "FK_Voznja_KoordinatorZaPosjeteITransport_KoordinatorZaPosjeteITransportId",
                        columns: x => x.KoordinatorZaPosjeteITransportId,
                        referencedTable: "KoordinatorZaPosjeteITransport",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Voznja_ElementRasporeda<Vozac>_TerminId",
                        columns: x => x.TerminId,
                        referencedTable: "ElementRasporeda<Vozac>",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Voznja_Vozac_VozacId",
                        columns: x => x.VozacId,
                        referencedTable: "Vozac",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Voznja_Zatvorenik_ZatvorenikZatvorenikId",
                        columns: x => x.ZatvorenikZatvorenikId,
                        referencedTable: "Zatvorenik",
                        referencedColumn: "ZatvorenikId");
                });
            migration.CreateTable(
                name: "Zahtjev<Zatvorenik>",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    JeLiOdobren = table.Column(type: "INTEGER", nullable: false),
                    Naziv = table.Column(type: "TEXT", nullable: true),
                    PosiljalacZatvorenikId = table.Column(type: "INTEGER", nullable: true),
                    TekstMolbe = table.Column(type: "TEXT", nullable: true),
                    UpravnikUpravnikId = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev<Zatvorenik>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zahtjev<Zatvorenik>_Zatvorenik_PosiljalacZatvorenikId",
                        columns: x => x.PosiljalacZatvorenikId,
                        referencedTable: "Zatvorenik",
                        referencedColumn: "ZatvorenikId");
                    table.ForeignKey(
                        name: "FK_Zahtjev<Zatvorenik>_Upravnik_UpravnikUpravnikId",
                        columns: x => x.UpravnikUpravnikId,
                        referencedTable: "Upravnik",
                        referencedColumn: "UpravnikId");
                });
            migration.CreateTable(
                name: "ElementRasporeda<Voznja>",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        ,
                    Datum = table.Column(type: "TEXT", nullable: false),
                    Mjesto = table.Column(type: "TEXT", nullable: true),
                    TipRasporedaVoznjaId = table.Column(type: "INTEGER", nullable: true),
                    Vrijeme = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementRasporeda<Voznja>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementRasporeda<Voznja>_Voznja_TipRasporedaVoznjaId",
                        columns: x => x.TipRasporedaVoznjaId,
                        referencedTable: "Voznja",
                        referencedColumn: "VoznjaId");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("ElementRasporeda<Posjetilac>");
            migration.DropTable("ElementRasporeda<Strazar>");
            migration.DropTable("ElementRasporeda<Voznja>");
            migration.DropTable("Izvjestaj");
            migration.DropTable("Klub");
            migration.DropTable("Narudzba");
            migration.DropTable("Prekrsaj");
            migration.DropTable("Zahtjev<Radnik>");
            migration.DropTable("Zahtjev<Zatvorenik>");
            migration.DropTable("Zaliha");
            migration.DropTable("Posjetilac");
            migration.DropTable("Voznja");
            migration.DropTable("Radnik");
            migration.DropTable("Kuhar");
            migration.DropTable("Uposlenik");
            migration.DropTable("ElementRasporeda<Vozac>");
            migration.DropTable("Zatvorenik");
            migration.DropTable("Vozac");
            migration.DropTable("Celija");
            migration.DropTable("Doktor");
            migration.DropTable("SmrtnaKazna");
            migration.DropTable("Strazar");
            migration.DropTable("Upravnik");
            migration.DropTable("UpravnikKluba");
            migration.DropTable("KoordinatorZaPosjeteITransport");
            migration.DropTable("UpraviteljZaLjudskeResurse");
            migration.DropTable("Nadzornik");
            migration.DropTable("LoginPodaci");
        }
    }
}
