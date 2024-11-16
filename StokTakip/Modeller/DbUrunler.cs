using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Modeller
{
    public class DbUrunler
    {
        public int UrunId { get; set; }
        public string UrunKodu { get; set; }
        public int KategoriId { get; set; }
        public string UrunAd { get; set; }
        public int BirimId { get; set; }
        public string UrunAciklama { get; set; }
        public float MinStok { get; set; }
        public float MaxStok { get; set; }
    }
}
