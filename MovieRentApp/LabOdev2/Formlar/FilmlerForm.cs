// FilmEkleForm.cs
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LabOdev2 {

    public enum filmturler {
        Aksiyon,
        BilimKurgu,
        Korku,
        Komedi
    }
    public partial class filmlerForm : Form {
        private FilmDukkani filmDukkani;

        // Bu kısım uygulamanın kenarlarını dairesel olarak çizer:
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public filmlerForm(FilmDukkani filmDukkani) {
            InitializeComponent();
            this.filmDukkani = filmDukkani;
            turCombo.DataSource = Enum.GetValues(typeof(filmturler));
            FilmleriGuncelle();
            // Set the form's region to a rounded rectangle
            IntPtr hRgn = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20);
            SetWindowRgn(this.Handle, hRgn, true);
        }

        private void FilmleriGuncelle() {
            filmlerListesiG.Rows.Clear();
            foreach (var film in filmDukkani.FilmleriGetir()) {
                filmlerListesiG.Rows.Add(film.Ad, film.Dil, film.Sure, film.Tur, film.KiralamaDurumu, film.Ucret);
            }
        }

        private void filmEkleBtn_Click(object sender, EventArgs e) {
            var film = new Film(filmAd.Text, dilTxt.Text, sureTxt.Text, turCombo.Text, durumBox.Text, decimal.Parse(FilmUcret.Text));
            filmDukkani.FilmEkle(film);
            FilmleriGuncelle();
            Temizle();
        }

        private void Temizle() {
            filmAd.Text = "";
            dilTxt.Text = "";
            sureTxt.Text = "";
            durumBox.Text = string.Empty;
            FilmUcret.Text = "";
        }

        private void kaldirBtn_Click(object sender, EventArgs e) {
            filmDukkani.FilmSil(filmAd.Text);
            FilmleriGuncelle();
            Temizle();
        }

        private void guncelleBtn_Click(object sender, EventArgs e) {
            var index = filmlerListesiG.CurrentCell.RowIndex;
            var film = new Film(filmAd.Text, dilTxt.Text, sureTxt.Text, turCombo.Text, durumBox.Text, decimal.Parse(FilmUcret.Text));
            filmDukkani.FilmGuncelle(index, film);
            FilmleriGuncelle();
            Temizle();
        }

        private void filmerGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            var row = filmlerListesiG.Rows[e.RowIndex];
            if (row.Cells[0].Value!=null)
            {
            filmAd.Text = row.Cells[0].Value.ToString();
            dilTxt.Text = row.Cells[1].Value.ToString();
            sureTxt.Text = row.Cells[2].Value.ToString();
            turCombo.Text = row.Cells[3].Value.ToString();
            durumBox.Text = row.Cells[4].Value.ToString();
            FilmUcret.Text = row.Cells[5].Value.ToString();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
