using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Modeller
{
    public enum YetkiTuru { Yonetici = 0, Kullanici = 1 };

    public class DbKullanicilar
    {
        public int KullaniciId { get; set; }
        public string KullaniciAd { get; set; }
        public string Parola { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public YetkiTuru Yetki { get; set; }
    }
}
