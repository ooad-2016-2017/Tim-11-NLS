using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatZatvor.Model
{
    class DefaultPodaci
    {
        public static void Initialize(dbContext context)
        {
            if (!context.Celije.Any())
            {
                context.Celije.AddRange(

                    new Celija(1, "062238267")
                    {
                        StatusCelije = Enumerative.StatusCelije.Prazna,
                    },

                    new Celija(2, "136542897")
                    {
                        StatusCelije = Enumerative.StatusCelije.Prazna,
                    }

                /* new Celija(3, "246158932")
                 {
                     StatusCelije = Enumerative.StatusCelije.Prazna,
                 },

                 new Celija(4, "824175236")
                 {
                     StatusCelije = Enumerative.StatusCelije.Prazna,
                 },

                 new Celija(5, "971642397")
                 {
                     StatusCelije = Enumerative.StatusCelije.Prazna,
                 },

                 new Celija(6, "242456322")
                 {
                     StatusCelije = Enumerative.StatusCelije.Prazna,
                 }*/

                );

            }

            if (!context.Logini.Any())
            {
                context.Logini.AddRange(

                    new LoginPodaci("Strazar", "Strazar") { },
                    new LoginPodaci("Upravnik", "Upravnik") { },
                    new LoginPodaci("Upravitelj", "Upravitelj") { },
                    new LoginPodaci("Kzpit", "Kzpit") { },
                    new LoginPodaci("Vozac", "Vozac") { },
                    new LoginPodaci("Uposlenik", "Uposlenik") { },
                    new LoginPodaci("Zatvorenik", "Zatovrenik") { }
                 );
            }

            if (!context.Upravnici.Any())
            {
                context.Upravnici.AddRange(
                         new Upravnik("UpravnikIme", "UpravnikPrezime", "1234", "Upravnik", DateTime.Now, 1000)
                         {
                             Budzet = 10,
                             Prihod = 20,
                             Rashod = 5,
                         });

            }



            if (!context.Strazari.Any())
            {
                context.Strazari.AddRange(
                new Strazar("Reufik", "Mekic", "1234567891234", "Strazar", new DateTime(1970, 5, 21), 1000)
                {
                    BrojIskoristenihDopusta = 0,
                    NaDopustu = false,
                },

                new Strazar("Rifet", "Karic", "5623457894521", "Strazar", new DateTime(1975, 1, 4), 1000)
                {
                    BrojIskoristenihDopusta = 0,
                    NaDopustu = false,
                },

                new Strazar("Zivojin", "Ahmetagic", "5236124578945", "Strazar", new DateTime(1956, 8, 25), 1000)
                {
                    BrojIskoristenihDopusta = 0,
                    NaDopustu = false,
                }

                );
            }

            if (!context.RasporedStrazara.Any())
            {
                context.RasporedStrazara.AddRange(

                    new ElementRasporeda<Strazar>(new Strazar("Reufik", "Mekic", "1234567891234", "Strazar", new DateTime(1970, 5, 21), 1000)
                    {
                        BrojIskoristenihDopusta = 0,
                        NaDopustu = false,
                    }, new DateTime(2017, 6, 10), "Blok 1", "12:00-17:00")
                    { },

                    new ElementRasporeda<Strazar>(new Strazar("Rifet", "Karic", "5623457894521", "Strazar", new DateTime(1975, 1, 4), 1000)
                    {
                        BrojIskoristenihDopusta = 0,
                        NaDopustu = false,
                    }, new DateTime(2017, 7, 10), "Blok 2", "13:00-18:00")
                    { },

                    new ElementRasporeda<Strazar>(new Strazar("Zivojin", "Ahmetagic", "5236124578945", "Strazar", new DateTime(1956, 8, 25), 1000)
                    {
                        BrojIskoristenihDopusta = 0,
                        NaDopustu = false,
                    }, new DateTime(2017, 8, 10), "Blok 3", "10:00-17:00")
                    { }

                );
            }

            if (!context.ZahtjeviRadnika.Any())
            {
                context.ZahtjeviRadnika.AddRange(
                new Zahtjev<Radnik>("Zahtjev radnika", "Tekst molbe", new Radnik(), false)
                {



                });


            }

            if (!context.Zatvorenici.Any())
            {
                context.Zatvorenici.AddRange(

                    new Zatvorenik("Grdoba", "Selimovic", "4582632789452", new DateTime(1965, 5, 21), new DateTime(2015, 7, 20), new DateTime(2020, 6, 11), new Celija(), "Ubistvo"),
                    new Zatvorenik("Michael", "Scofield", "4582632789452", new DateTime(1975, 10, 21), new DateTime(2016, 7, 20), new DateTime(2019, 6, 11), new Celija(), "Kradja")
                    );
            }

            context.SaveChanges();
        }
    }
}

