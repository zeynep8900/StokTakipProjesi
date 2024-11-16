using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Modeller
{
    public class DbUrunler
    {
        public int UrunId { get; set; } // Primary Key
        public string UrunKodu { get; set; }
        public string UrunAd { get; set; }
        public int KategoriId { get; set; } // Foreign Key to TblKategoriler
        public int BirimId { get; set; } // Foreign Key to TblBirimler
        public string UrunAciklama { get; set; }
        public float MinStok { get; set; }
        public float MaksStok { get; set; }

        // Navigasyon özellikleri
        public DbKategoriler Kategori { get; set; } // Her ürün bir kategoriye ait
        public DbBirimler Birim { get; set; } // Her ürün bir birime ait

        // Stok ilişkileri
        public ICollection<DbStokGiris> StokGirisler { get; set; }
        public ICollection<DbStokCikis> StokCikislar { get; set; }
    }
}