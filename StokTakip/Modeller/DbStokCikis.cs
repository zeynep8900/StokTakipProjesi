using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Modeller
{
    public class DbStokCikis
    {
        public int IslemId { get; set; } // Düzeltildi
        public int UrunId { get; set; }
        public int MusteriId { get; set; }
        public float BirimFiyat { get; set; }
        public float Miktar { get; set; }
        public DateTime Tarih { get; set; }
        public int KullaniciId { get; set; }
        public DbUrunler Urun { get; set; }
        public DbMusteriler Musteri { get; set; }
        public DbKullanicilar Kullanici { get; set; }

    }
}