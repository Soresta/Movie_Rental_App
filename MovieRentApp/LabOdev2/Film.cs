using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOdev2 {
    public class Film {
        public string Ad { get; set; }
        public string Dil { get; set; }
        public string Sure { get; set; }
        public string Tur { get; set; }
        public string KiralamaDurumu { get; set; }
        public decimal Ucret { get; set; }

        public Film(string ad, string dil, string sure, string tur, string kiralamaDurumu, decimal ucret) {
            Ad = ad;
            Dil = dil;
            Sure = sure;
            Tur = tur;
            KiralamaDurumu = kiralamaDurumu;
            Ucret = ucret;
        }
    }
}
