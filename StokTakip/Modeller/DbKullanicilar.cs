using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Modeller
{
    public class DbKullanicilar
    {
        public int KullaniciId { get; set; }
        public string KullaniciMail { get; set; }
        public string Parola { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yetki { get; set; }
        public ICollection<DbStokGiris> StokGirisler { get; set; }
        public ICollection<DbStokCikis> StokCikislar { get; set; }
    }
}