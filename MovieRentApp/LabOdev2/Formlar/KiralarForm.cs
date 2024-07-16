using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabOdev2 {
    public partial class KiralarForm : Form {
        private FilmDukkani filmDukkani;
        // Bu kısım uygulamanın kenarlarını dairesel olarak çizer:
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public KiralarForm(FilmDukkani filmDukkani) {
            InitializeComponent();
            this.filmDukkani = filmDukkani;
            FilmleriGuncelle();
            KiralamalariGuncelle();
            // Set the form's region to a rounded rectangle
            IntPtr hRgn = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20);
            SetWindowRgn(this.Handle, hRgn, true);
        }

        private void FilmleriGuncelle() {
            FilmComboBox.Items.Clear();
            foreach (var film in filmDukkani.FilmleriGetir()) {
                FilmComboBox.Items.Add(film.Ad);
            }
        }

        private void KiralamalariGuncelle() {
            kiralarListesiG.Rows.Clear();
            foreach (var kiralama in filmDukkani.KiralamalariGetir()) {
                kiralarListesiG.Rows.Add(kiralama.Kiralayan.Ad, kiralama.Kiralayan.Soyad, kiralama.KiralananFilm.Ad,kiralama.KiralananFilm.KiralamaDurumu, kiralama.AlimTarihi, kiralama.TeslimTarihi, kiralama.ToplamUcret);
            }
        }

        private void kiralaBtn_Click(object sender, EventArgs e) {
            if (filmDurumuBox.Text.Equals("False")) {
                MessageBox.Show("Bu Film Kiralanmıştır!");
            } else {
                var kisi = new Kisi(isimTxt.Text, soyisimTxt.Text);
                filmDukkani.FilmleriGetir().Find(f => f.Ad == FilmComboBox.Text).KiralamaDurumu = "False";
                var film = filmDukkani.FilmleriGetir().Find(f => f.Ad == FilmComboBox.Text);
                var index = filmDukkani.FilmleriGetir().IndexOf(filmDukkani.FilmleriGetir().Find(f => f.Ad == FilmComboBox.Text));
                filmDukkani.FilmGuncelle(index, film);
                var kiralama = new Kiralama(kisi, film, DateTime.Now, DateTime.Now.AddDays(Convert.ToInt32(sureBox.Text)));
                
                
                FilmComboBox_SelectedIndexChanged(sender, e);
                filmDukkani.KiralamaEkle(kiralama);
                KiralamalariGuncelle();
                Temizle();
            }

        }

        private void kaldirBtn_Click(object sender, EventArgs e) {
            filmDukkani.KiralamaSil(FilmComboBox.Text);
            filmDukkani.FilmleriGetir().Find(f => f.Ad == FilmComboBox.Text).KiralamaDurumu = "True";
            var film = filmDukkani.FilmleriGetir().Find(f => f.Ad == FilmComboBox.Text);
            var index = filmDukkani.FilmleriGetir().IndexOf(filmDukkani.FilmleriGetir().Find(f => f.Ad == FilmComboBox.Text));
            filmDukkani.FilmGuncelle(index, film);
            FilmComboBox_SelectedIndexChanged(sender, e);
            KiralamalariGuncelle();
            Temizle();
        }

        private void guncelleBtn_Click(object sender, EventArgs e) {
            var index = kiralarListesiG.CurrentCell.RowIndex;
            var kisi = new Kisi(isimTxt.Text, soyisimTxt.Text);
            var film = filmDukkani.FilmleriGetir().Find(f => f.Ad == FilmComboBox.Text);
            var kiralama = new Kiralama(kisi, film, DateTime.Now, DateTime.Now.AddDays(Convert.ToInt32(sureBox.Text)));
            filmDukkani.KiralamaGuncelle(index, kiralama);
            KiralamalariGuncelle();
            var index1 = filmDukkani.FilmleriGetir().IndexOf(filmDukkani.FilmleriGetir().Find(f => f.Ad == FilmComboBox.Text));
            filmDukkani.FilmGuncelle(index1, film);
            Temizle();
        }

        private void kiralamalarGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = kiralarListesiG.Rows[e.RowIndex];
            if (row.Cells[0].Value!=null)
            {
                DateTime teslimTarihi = Convert.ToDateTime(row.Cells[4].Value.ToString());
                DateTime alimTarihi = Convert.ToDateTime(row.Cells[5].Value.ToString());
                TimeSpan sure = alimTarihi - teslimTarihi;
                isimTxt.Text = row.Cells[0].Value.ToString();
                soyisimTxt.Text = row.Cells[1].Value.ToString();
                FilmComboBox.Text = row.Cells[2].Value.ToString();
                filmDurumuBox.Text = row.Cells[3].Value.ToString();
                sureBox.Text = sure.Days.ToString();
            }
        }

        private void Temizle() {
            isimTxt.Text = "";
            soyisimTxt.Text = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void FilmComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            filmDurumuBox.Text = filmDukkani.FilmleriGetir().Find(f => f.Ad == FilmComboBox.Text).KiralamaDurumu;
        }

    }
}
