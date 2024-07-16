using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace LabOdev2 {
    public class FilmDukkani {
        private List<Film> filmler;
        private List<Kisi> kisiler;
        private List<Kiralama> kiralamalar;
        private readonly string filmDosyaYolu = "Filmler.csv";
        private readonly string kiralamaDosyaYolu = "Kiralamalar.csv";

        public FilmDukkani() {
            filmler = new List<Film>();
            kisiler = new List<Kisi>();
            kiralamalar = new List<Kiralama>();
            FilmleriYukle();
            KiralamalariYukle();
        }

        private void FilmleriYukle() {
            if (!File.Exists(filmDosyaYolu)) return;
            foreach (var line in File.ReadLines(filmDosyaYolu)) {
                var parts = line.Split(',');
                var film = new Film(parts[0], parts[1], parts[2], parts[3], parts[4], decimal.Parse(parts[5]));
                filmler.Add(film);
            }
        }

        private void KiralamalariYukle() {
            if (!File.Exists(kiralamaDosyaYolu)) return;
            foreach (var line in File.ReadLines(kiralamaDosyaYolu)) {
                var parts = line.Split(',');
                var kisi = new Kisi(parts[0], parts[1]);
                var film = filmler.FirstOrDefault(f => f.Ad == parts[2]);
                var kiralama = new Kiralama(kisi, film, DateTime.Parse(parts[3]), DateTime.Parse(parts[4]));
                kiralamalar.Add(kiralama);
            }
        }

        public void FilmEkle(Film film) {
            filmler.Add(film);
            FilmleriKaydet();
        }

        public void FilmSil(string filmAdi) {
            var film = filmler.FirstOrDefault(f => f.Ad == filmAdi);
            if (film != null) {
                filmler.Remove(film);
                FilmleriKaydet();
            }
        }

        public void FilmGuncelle(int index, Film film) {
            if (index >= 0 && index < filmler.Count) {
                filmler[index] = film;
                FilmleriKaydet();
            }
        }

        public void FilmleriKaydet() {
            using (var sw = new StreamWriter(filmDosyaYolu)) {
                foreach (var film in filmler) {
                    sw.WriteLine($"{film.Ad},{film.Dil},{film.Sure},{film.Tur},{film.KiralamaDurumu},{film.Ucret}");
                }
            }
        }

        public void KiralamaEkle(Kiralama kiralama) {
            kiralamalar.Add(kiralama);
            KiralamalariKaydet();
        }

        public void KiralamaSil(string filmAdi) {
            var kiralama = kiralamalar.FirstOrDefault(k => k.KiralananFilm.Ad == filmAdi);
            if (kiralama != null) {
                kiralamalar.Remove(kiralama);
                KiralamalariKaydet();
            }
        }

        public void KiralamaGuncelle(int index, Kiralama kiralama) {
            if (index >= 0 && index < kiralamalar.Count) {
                kiralamalar[index] = kiralama;
                KiralamalariKaydet();
            }
        }

        private void KiralamalariKaydet() {
            using (var sw = new StreamWriter(kiralamaDosyaYolu)) {
                foreach (var kiralama in kiralamalar) {
                    sw.WriteLine($"{kiralama.Kiralayan.Ad},{kiralama.Kiralayan.Soyad},{kiralama.KiralananFilm.Ad},{kiralama.AlimTarihi},{kiralama.TeslimTarihi},{kiralama.ToplamUcret}");
                }
            }
        }

        public List<Film> FilmleriGetir() {
            return filmler;
        }

        public List<Kiralama> KiralamalariGetir() {
            return kiralamalar;
        }
    }
}
