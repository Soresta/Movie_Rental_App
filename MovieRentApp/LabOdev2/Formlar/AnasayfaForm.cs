using LabOdev2.Properties;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Drawing;

namespace LabOdev2 {
    public partial class AnasayfaForm : Form {
        FilmDukkani dukkan = new FilmDukkani();
        // Kapatma ve Küçültme buttonları için eventHandler
        public event EventHandler RequestMainFormClose;
        public event EventHandler RequestMinimizeForms;

        // Bu kısım uygulamanın kenarlarını dairesel olarak çizer:
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // anasayfa oluşturucu
        public AnasayfaForm() {
            InitializeComponent();
            this.DoubleBuffered = true;
            anaBackground.SetDoubleBuffered(true);
        }

        private void pictureBox5_Click(object sender, EventArgs e) {
            RequestMainFormClose?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox6_Click(object sender, EventArgs e) {
            RequestMinimizeForms?.Invoke(this, EventArgs.Empty);
        }

        private void onLoad(object sender, EventArgs e) {
            // Set the form's region to a rounded rectangle
            IntPtr hRgn = CreateRoundRectRgn(0, 0, this.Width, this.Height, 40, 40);
            SetWindowRgn(this.Handle, hRgn, true);
        }

        private async void avatarPoster_Click(object sender, EventArgs e) {
            await ChangeBackgroundImageAsync(Resources.avatar);
        }

        private async void bodyPoster_Click(object sender, EventArgs e) {
            await ChangeBackgroundImageAsync(Resources._3bodyProblem);
        }

        private async void inseptPoster_Click(object sender, EventArgs e) {
            await ChangeBackgroundImageAsync(Resources.joker);
        }

        private async void interstallerPoster_Click(object sender, EventArgs e) {
            await ChangeBackgroundImageAsync(Resources.interstellar);
        }

        private void Btn3Click(object sender, EventArgs e) {
            filmlerForm filmeEkleFormForm = new filmlerForm(dukkan);
            filmeEkleFormForm.ShowDialog();
        }

        private void Btn4Click(object sender, EventArgs e) {
            KiralarForm kiraForm = new KiralarForm(dukkan);
            kiraForm.ShowDialog();
        }

        private void Btn2Click(object sender, EventArgs e) {
            new GirisForm().Show();
            this.Close();
        }

        private async Task ChangeBackgroundImageAsync(Image image) {
            // Arka planda resmi yüklüyoruz
            var loadedImage = await Task.Run(() => image);

            // Yükleme tamamlandıktan sonra panelin arka plan resmini değiştiriyoruz
            if (anaBackground.InvokeRequired) {
                anaBackground.Invoke(new Action(() => {
                    anaBackground.BackgroundImage = loadedImage;
                    anaBackground.BackgroundImageLayout = ImageLayout.Stretch; // İstediğiniz gibi ayarlayabilirsiniz
                }));
            } else {
                anaBackground.BackgroundImage = loadedImage;
                anaBackground.BackgroundImageLayout = ImageLayout.Stretch; // İstediğiniz gibi ayarlayabilirsiniz
            }
        }
    }

    public static class ControlExtensions {
        public static void SetDoubleBuffered(this Control control, bool enable) {
            var doubleBufferPropertyInfo = control.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (doubleBufferPropertyInfo != null) {
                doubleBufferPropertyInfo.SetValue(control, enable, null);
            }
        }
    }
}
