using Microsoft.EntityFrameworkCore;
using StokTakip.Modeller;

namespace StokTakip.Db
{
    public class StokTakipContext : DbContext
    {
        public DbSet<DbBirimler> Birimler { get; set; }
        public DbSet<DbKategoriler> Kategoriler { get; set; }
        public DbSet<DbKullanicilar> Kullanicilar { get; set; }
        public DbSet<DbMusteriler> Musteriler { get; set; }
        public DbSet<DbStokCikis> StokCikis { get; set; }
        public DbSet<DbStokGiris> StokGiris { get; set; }
        public DbSet<DbTedarikciler> Tedarikciler { get; set; }
        public DbSet<DbUrunler> Urunler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokTakipBtk_Db;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TblKategoriler
            modelBuilder.Entity<DbKategoriler>()
                .HasKey(e => e.KategoriId);

            // TblBirimler
            modelBuilder.Entity<DbBirimler>()
                .HasKey(e => e.BirimId);

            // TblUrunler
            modelBuilder.Entity<DbUrunler>()
                .HasKey(e => e.UrunId);
            modelBuilder.Entity<DbUrunler>()
                .HasOne(e => e.Kategori)
                .WithMany(k => k.Urunler)
                .HasForeignKey(e => e.KategoriId);
            modelBuilder.Entity<DbUrunler>()
                .HasOne(e => e.Birim)
                .WithMany(b => b.Urunler)
                .HasForeignKey(e => e.BirimId);

            // TblStokGiris
            modelBuilder.Entity<DbStokGiris>()
                .HasKey(e => e.IslemId);
            modelBuilder.Entity<DbStokGiris>()
                .HasOne(e => e.Urun)
                .WithMany(u => u.StokGirisler)
                .HasForeignKey(e => e.UrunId);


            modelBuilder.Entity<DbStokGiris>()
                .HasOne(e => e.Tedarikci)
                .WithMany(t => t.StokGirisler)
                .HasForeignKey(e => e.TedarikciId);
            modelBuilder.Entity<DbStokGiris>()
                .HasOne(e => e.Kullanici)
                .WithMany(k => k.StokGirisler)
                .HasForeignKey(e => e.KullaniciId);

            // TblStokCikis
            modelBuilder.Entity<DbStokCikis>()
                .HasKey(e => e.IslemId);
            modelBuilder.Entity<DbStokCikis>()
                .HasOne(e => e.Urun)
                .WithMany(u => u.StokCikislar)
                .HasForeignKey(e => e.UrunId);
            modelBuilder.Entity<DbStokCikis>()
                .HasOne(e => e.Musteri)
                .WithMany(m => m.StokCikislar)
                .HasForeignKey(e => e.MusteriId);
            modelBuilder.Entity<DbStokCikis>()
                .HasOne(e => e.Kullanici)
                .WithMany(k => k.StokCikislar)
                .HasForeignKey(e => e.KullaniciId);

            // TblMusteriler
            modelBuilder.Entity<DbMusteriler>()
                .HasKey(e => e.MusteriId);

            // TblTedarikciler
            modelBuilder.Entity<DbTedarikciler>()
                .HasKey(e => e.TedarikciId);

            // TblKullanicilar
            modelBuilder.Entity<DbKullanicilar>()
                .HasKey(e => e.KullaniciId);
        }
    }
}