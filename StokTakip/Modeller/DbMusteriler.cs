using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Modeller
{
    public class DbMusteriler
    {
        public int MusteriId { get; set; }
        public string FirmaAdi { get; set; }
        public string YetkiliAdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }

        // Navigation Property
        public ICollection<DbStokCikis> StokCikislar { get; set; }

    }
}