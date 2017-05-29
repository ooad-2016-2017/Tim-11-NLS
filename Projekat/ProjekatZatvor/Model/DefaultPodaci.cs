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
                new Celija()
                {
                    BrojCelije = 15,
                    Pin = "062238267",
                    StatusCelije = Enumerative.StatusCelije.Prazna,
                    

                });


            }
          /*  if (!context.Upravnici.Any())
            {
                context.Upravnici.AddRange(
                         new Upravnik("Ime", "Prezime", "21231", "Zvanje", DateTime.Now, 1000)
                         {
                             Budzet = 10000,
                             Prihod = 20,
                             Rashod = 100,
                         });
            }*/



              if (!context.Zatvorenici.Any())
             {
                 context.Zatvorenici.AddRange(
                          new Zatvorenik("Ime", "Prezime", "21231", DateTime.Now, DateTime.Now , DateTime.Now, new Celija(),"zlocin")
                          {

                          });
             }

            if (!context.Logini.Any())
            {
                context.Logini.AddRange(
                         new LoginPodaci("Strazar","Strazar")
                         {
                             

                         });
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
                if (!context.Radnici.Any())
            {
                context.Radnici.AddRange(
                         new Doktor("Ime", "Prezime", "1234", DateTime.Now, 1000)
                         {
                             BrojIskoristenihDopusta = 0,
                             NaDopustu = false,

                         },

                new Kuhar("Ime1", "Prezime1", "12345", DateTime.Now, 1000)
                {
                    BrojIskoristenihDopusta = 0,
                    NaDopustu = false,

                }
                ,

                new Strazar("StrazarIme", "StrazarPrezime", "12345", "Strazar", DateTime.Now, 1000)
                {
                    BrojIskoristenihDopusta = 0,
                    NaDopustu = false,



            }
                );
               
            }

            context.SaveChanges();
        }
    }
}

