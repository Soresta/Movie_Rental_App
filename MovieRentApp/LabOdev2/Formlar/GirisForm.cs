using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LabOdev2.Properties;

namespace LabOdev2 {
    public partial class GirisForm : Form {
        private AnasayfaForm form;
        private bool closed = true;

        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public GirisForm() {
            InitializeComponent();
            form = new AnasayfaForm();
            form.RequestMainFormClose += pictureBox5_Click;
            form.RequestMinimizeForms += MinimizeForms;
        }

        private void onLoad(object sender, EventArgs e) {
            // Set the form's region to a rounded rectangle
            IntPtr hRgn = CreateRoundRectRgn(0, 0, this.Width, this.Height, 40, 40);
            SetWindowRgn(this.Handle, hRgn, true);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e) {
            pictureBox2.BackgroundImage = (Image) Resources.RedBorder;
            pictureBox3.BackgroundImage = (Image) Resources.WhiteBorder;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e) {
            pictureBox3.BackgroundImage = (Image) Resources.RedBorder;
            pictureBox2.BackgroundImage = (Image) Resources.WhiteBorder;
        }

        private void pictureBox4_Click(object sender, EventArgs e) {
            if (closed) {
                textBox3.PasswordChar = '\0';
                pictureBox4.Image = (Image) Resources.icons8_eye_90_12;
                closed = false;
            } else {
                textBox3.PasswordChar = '*';
                pictureBox4.Image = (Image) Resources.icons8_eye_90_1;
                closed = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text.Equals("Sorest") && textBox3.Text.Equals("1234"))
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý Adý Veya Þifre Hatalý.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label7_Click(object sender, EventArgs e) {
            // Optional: Implement logic for label7 click event if needed
        }

        private void pictureBox5_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e) {
            MinimizeForms(sender, e);
        }

        private void MinimizeForms(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
            form.WindowState = FormWindowState.Minimized;
        }

    }
}


