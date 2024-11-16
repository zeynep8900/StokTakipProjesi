using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Modeller
{
    public class DbKategoriler
    {
        public int KategoriId { get; set; } // Primary Key
        public string KategoriAd { get; set; }

        // Navigasyon özelliği
        public ICollection<DbUrunler> Urunler { get; set; }
    }
}