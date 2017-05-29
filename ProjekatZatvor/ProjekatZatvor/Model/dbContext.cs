using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System.IO;
using Windows.Storage;
using ProjekatZatvor.Model;
using Microsoft.Data.Entity.Storage;

namespace ProjekatZatvor.Model
{
    public class dbContext : DbContext
    {
       
/* static dbContext()
 {
     using (var database = new dbContext())
     {
         database.Database.ApplyMigrations();
     }
 }*/
//Svi restorani koji su u tabeli se dobijaju iz ovog seta
        public virtual DbSet<Celija> Celije { get; set; }
     //   public DbSet<Zatvorenik> Zatvorenici { get; set; }
        public virtual DbSet<LoginPodaci> Logini { get; set; }
        public virtual DbSet<Doktor> Doktor { get; set; }
        public virtual DbSet<Izvjestaj> Izvjestaji { get; set; }
        public virtual DbSet<Klub> Klubovi { get; set; }
        public virtual DbSet<KoordinatorZaPosjeteITransport> KoordinatorPT{ get; set; }
        public virtual DbSet<UpraviteljZaLjudskeResurse> UpraviteljLJR{ get; set; }
        public virtual DbSet<Kuhar> Kuhari { get; set; }
        public virtual DbSet<Nadzornik> Nadzornik{ get; set; }
        public virtual DbSet<Narudzba> Narudzba { get; set; }
        public virtual DbSet<Posjetilac> Posjetioci { get; set; }
        public virtual DbSet<Prekrsaj> Prekrsaj { get; set; }
        public virtual DbSet<Radnik> Radnici { get; set; }
        public virtual DbSet<Uposlenik> Uposlenici { get; set; }
        public virtual DbSet<Strazar> Strazari { get; set; }
        public virtual DbSet<Upravnik> Upravnici { get; set; }
        public virtual DbSet<UpravnikKluba> UpravniciKluba { get; set; }
        public virtual DbSet<Vozac> Vozaci { get; set; }
        public virtual DbSet<Voznja> Voznje { get; set; }
        public virtual DbSet<Zaliha> Zalihe { get; set; }
        public virtual DbSet<ElementRasporeda<Strazar>> RasporedStrazara { get; set; }
        public virtual DbSet<ElementRasporeda<Posjetilac>> RasporedPosjeta { get; set; }
        public virtual DbSet<ElementRasporeda<Voznja>> RasporedVoznji { get; set; }
        public virtual DbSet<Zatvorenik> Zatvorenici { get; set; }

        public virtual DbSet<Zahtjev<Radnik>> ZahtjeviRadnika { get; set; }
        public virtual DbSet<Zahtjev<Zatvorenik>> ZahtjeviZatvorenika { get; set; }



        /* public DbSet<Celija>  { get; set; }
         public DbSet<Zatvorenik> Zatvorenici { get; set; }*/
        //Metoda koja će promijeniti konfiguraciju i odrediti gdje se spašava klasa i kako se zove.
        //Ovisno od uređaja spasiti će se na različite lokacije, za desktop se kreira poseban folder

        //Svaki korisnik koji pokrene aplikaciju će imati kreiranu bazu lokalno kod sebe
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "Ooadbaza.db";
            try
            {
                //za tačnu putanju gdje se nalazi baza uraditi ovdje debug i procitati Path
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path,
                databaseFilePath);

                //optionsBuilder.UseSqlite("Data Source=Ooadbaza.db");
            }
            catch (InvalidOperationException) { }
            //Sqlite baza
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //jedno od polja je image da se zna šta je zapravo predstavlja byte[]
            modelBuilder.Entity<Celija>().Property(p => p.CelijaId).HasColumnType("INTEGER");
            modelBuilder.Entity<LoginPodaci>().Property(p => p.LoginPodaciId).HasColumnType("INTEGER");
            //modelBuilder.Entity<Doktor>().Property(p => p.DoktorId).HasColumnType("INTEGER");
            //   optionsBuilder.UseSqlite("Data Source.db");
        }

        
    }
}
