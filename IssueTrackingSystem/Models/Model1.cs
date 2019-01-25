namespace IssueTrackingSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BOK_ADRES> BOK_ADRES { get; set; }
        public virtual DbSet<BOK_DANE_KONTAKTOWE> BOK_DANE_KONTAKTOWE { get; set; }
        public virtual DbSet<BOK_KLIENT> BOK_KLIENT { get; set; }
        public virtual DbSet<BOK_ODPOWIEDZ> BOK_ODPOWIEDZ { get; set; }
        public virtual DbSet<BOK_OPERATOR> BOK_OPERATOR { get; set; }
        public virtual DbSet<BOK_PRIORYTET> BOK_PRIORYTET { get; set; }
        public virtual DbSet<BOK_STATUS> BOK_STATUS { get; set; }
        public virtual DbSet<BOK_UZYTKOWNIK> BOK_UZYTKOWNIK { get; set; }
        public virtual DbSet<BOK_ZALACZNIK> BOK_ZALACZNIK { get; set; }
        public virtual DbSet<BOK_ZGLOSZENIE> BOK_ZGLOSZENIE { get; set; }
        public virtual DbSet<V_KLIENT> V_KLIENT { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BOK_ADRES>()
                .Property(e => e.ID_ADRES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_ADRES>()
                .Property(e => e.ULICA)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_ADRES>()
                .Property(e => e.MIASTO)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_ADRES>()
                .Property(e => e.POCZTA)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_DANE_KONTAKTOWE>()
                .Property(e => e.ID_DANE_KONTAKTOWE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_DANE_KONTAKTOWE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_DANE_KONTAKTOWE>()
                .Property(e => e.TELEFON)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_DANE_KONTAKTOWE>()
                .Property(e => e.INNY)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_KLIENT>()
                .Property(e => e.ID_KLIENTA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_KLIENT>()
                .Property(e => e.ID_DANE_KONTAKTOWE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_KLIENT>()
                .Property(e => e.ID_ADRES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_KLIENT>()
                .Property(e => e.NAZWA)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_ODPOWIEDZ>()
                .Property(e => e.ID_ODPOWIEDZI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_ODPOWIEDZ>()
                .Property(e => e.ID_ZGLOSZENIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_ODPOWIEDZ>()
                .Property(e => e.ID_OPERATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_ODPOWIEDZ>()
                .Property(e => e.OPIS)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_OPERATOR>()
                .Property(e => e.ID_OPERATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_OPERATOR>()
                .Property(e => e.NAZWA)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_PRIORYTET>()
                .Property(e => e.ID_PRIORYTET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_PRIORYTET>()
                .Property(e => e.OPIS)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_STATUS>()
                .Property(e => e.ID_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_STATUS>()
                .Property(e => e.OPIS)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_UZYTKOWNIK>()
                .Property(e => e.ID_UZYTKOWNIK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_UZYTKOWNIK>()
                .Property(e => e.ID_KLIENTA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_UZYTKOWNIK>()
                .Property(e => e.ID_OPERATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_UZYTKOWNIK>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_UZYTKOWNIK>()
                .Property(e => e.PASSWORD_HASH)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_ZALACZNIK>()
                .Property(e => e.ID_ZALACZNIK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_ZALACZNIK>()
                .Property(e => e.ID_ZGLOSZENIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_ZGLOSZENIE>()
                .Property(e => e.ID_ZGLOSZENIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_ZGLOSZENIE>()
                .Property(e => e.ID_KLIENTA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_ZGLOSZENIE>()
                .Property(e => e.ID_OPERATOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_ZGLOSZENIE>()
                .Property(e => e.ID_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_ZGLOSZENIE>()
                .Property(e => e.ID_PRIORYTET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BOK_ZGLOSZENIE>()
                .Property(e => e.OPIS)
                .IsUnicode(false);

            modelBuilder.Entity<BOK_ZGLOSZENIE>()
                .HasMany(e => e.BOK_ZALACZNIK)
                .WithOptional(e => e.BOK_ZGLOSZENIE)
                .HasForeignKey(e => e.ID_ZGLOSZENIA);

            modelBuilder.Entity<V_KLIENT>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<V_KLIENT>()
                .Property(e => e.IDKLIENTA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<V_KLIENT>()
                .Property(e => e.KLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<V_KLIENT>()
                .Property(e => e.ULICA)
                .IsUnicode(false);

            modelBuilder.Entity<V_KLIENT>()
                .Property(e => e.MIASTO)
                .IsUnicode(false);

            modelBuilder.Entity<V_KLIENT>()
                .Property(e => e.POCZTA)
                .IsUnicode(false);

            modelBuilder.Entity<V_KLIENT>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<V_KLIENT>()
                .Property(e => e.TELEFON)
                .IsUnicode(false);

            modelBuilder.Entity<V_KLIENT>()
                .Property(e => e.INNY)
                .IsUnicode(false);
        }
    }
}
