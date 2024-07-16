
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOdev2 {
    public class Kiralama {
        public Kisi Kiralayan { get; set; }
        public Film KiralananFilm { get; set; }
        public DateTime AlimTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public decimal ToplamUcret => (TeslimTarihi - AlimTarihi).Days * KiralananFilm.Ucret;

        public Kiralama(Kisi kiralayan, Film kiralananFilm, DateTime alimTarihi, DateTime teslimTarihi) {
            Kiralayan = kiralayan;
            KiralananFilm = kiralananFilm;
            AlimTarihi = alimTarihi;
            TeslimTarihi = teslimTarihi;
        }
    }
}

