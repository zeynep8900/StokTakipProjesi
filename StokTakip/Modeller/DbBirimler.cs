using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Modeller
{
    public class DbBirimler
    {
        public int BirimId { get; set; } // Primary Key
        public string BirimAd { get; set; }

        // Navigasyon özelliği
        public ICollection<DbUrunler> Urunler { get; set; }
    }
}