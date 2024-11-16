using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using StokTakip.Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Db
{
    public class StokTakipContext : DbContext
    {
        public DbSet<DbBirimler> Birimler { get; set; }
        public DbSet<DbKategoriler> Kategoriler { get; set; }
        public DbSet<DbKullanicilar> Kullanicilar { get; set; }
        public DbSet<DbMusteriler> Musteriler { get; set; }
        public DbSet<DbStokCikiscs> StokCikis { get; set; }
        public DbSet<DbStokGiris> StokGiris { get; set; }
        public DbSet<DbTedarikciler> Tedarikciler { get; set; }
        public DbSet<DbUrunler> Urunler {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokTakipBtk_Db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbBirimler>()
                
            modelBuilder.Entity<DbKategoriler>()

            modelBuilder.Entity<DbUrunler>()

            modelBuilder.Entity<DbKullanicilar>().HasData(
                new DbKullanicilar()
                {
                    KullaniciId = 1,
                    KullaniciAd = "admin",
                    Parola = "admin",
                    Yetki = YetkiTuru.Yonetici
                }
                );

            modelBuilder.Entity<DbStokGiris>()

            modelBuilder.Entity<DbStokCikiscs>()

            modelBuilder.Entity<DbMusteriler>()

            modelBuilder.Entity<DbTedarikciler>()
        }
    }
}
