﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Modeller
{
    public class DbStokCikiscs
    {
        public int IslemId { get; set; }
        public int UrunId { get; set; }
        public int MusteriId { get; set; }
        public float BirimFiyat { get; set; }
        public int Miktar { get; set; }
        public DateTime Tarih { get; set; }
        public int KullaniciId { get; set; }
    }
}