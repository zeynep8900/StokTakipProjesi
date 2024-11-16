using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Modeller
{
    public class DbStokGiris
    {
        public int IslemId { get; set; }
        public int UrunId { get; set; }
        public int TedarikciId { get; set; }
        public float BirimFiyat { get; set; }
        public float Miktar { get; set; }
        public DateTime Tarih { get; set; }
        public int KullaniciId { get; set; }

        public DbUrunler Urun { get; set; }
        public DbTedarikciler Tedarikci { get; set; }
        public DbKullanicilar Kullanici { get; set; }
    }
}