namespace LabOdev2 {
    partial class AnasayfaForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnasayfaForm));
            ustPanel = new Panel();
            formNameL = new Label();
            logo = new PictureBox();
            minimizeABtn = new PictureBox();
            exitABtn = new PictureBox();
            anaBackground = new Panel();
            nameL = new Label();
            interstallerL = new Label();
            jokerL = new Label();
            bodyL = new Label();
            interstallerPoster = new PictureBox();
            jokerPoster = new PictureBox();
            bodyPoster = new PictureBox();
            avatarL = new Label();
            avatarPoster = new PictureBox();
            cikisBtn = new FontAwesome.Sharp.IconButton();
            filmEkleBtn = new FontAwesome.Sharp.IconButton();
            kiralarBtn = new FontAwesome.Sharp.IconButton();
            filmlerBtn = new FontAwesome.Sharp.IconButton();
            bigLogo = new PictureBox();
            altPanel = new Panel();
            ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize) minimizeABtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize) exitABtn).BeginInit();
            anaBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) interstallerPoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize) jokerPoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize) bodyPoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize) avatarPoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize) bigLogo).BeginInit();
            SuspendLayout();
            // 
            // ustPanel
            // 
            ustPanel.BackColor = Color.Black;
            ustPanel.Controls.Add(formNameL);
            ustPanel.Controls.Add(logo);
            ustPanel.Controls.Add(minimizeABtn);
            ustPanel.Controls.Add(exitABtn);
            ustPanel.Dock = DockStyle.Top;
            ustPanel.Location = new Point(0, 0);
            ustPanel.Margin = new Padding(0);
            ustPanel.Name = "ustPanel";
            ustPanel.Size = new Size(1500, 50);
            ustPanel.TabIndex = 1;
            // 
            // formNameL
            // 
            formNameL.AutoSize = true;
            formNameL.BackColor = Color.Transparent;
            formNameL.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point,  162);
            formNameL.ForeColor = Color.White;
            formNameL.Location = new Point(64, 16);
            formNameL.Name = "formNameL";
            formNameL.Size = new Size(56, 18);
            formNameL.TabIndex = 14;
            formNameL.Text = "Home";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Cursor = Cursors.Hand;
            logo.ErrorImage = null;
            logo.Image = (Image) resources.GetObject("logo.Image");
            logo.Location = new Point(28, 12);
            logo.Name = "logo";
            logo.Size = new Size(30, 30);
            logo.TabIndex = 13;
            logo.TabStop = false;
            // 
            // minimizeABtn
            // 
            minimizeABtn.BackColor = Color.Transparent;
            minimizeABtn.Cursor = Cursors.Hand;
            minimizeABtn.ErrorImage = null;
            minimizeABtn.Image = (Image) resources.GetObject("minimizeABtn.Image");
            minimizeABtn.Location = new Point(1410, 12);
            minimizeABtn.Name = "minimizeABtn";
            minimizeABtn.Size = new Size(30, 30);
            minimizeABtn.TabIndex = 12;
            minimizeABtn.TabStop = false;
            minimizeABtn.Click += pictureBox6_Click;
            // 
            // exitABtn
            // 
            exitABtn.BackColor = Color.Transparent;
            exitABtn.Cursor = Cursors.Hand;
            exitABtn.ErrorImage = null;
            exitABtn.Image = (Image) resources.GetObject("exitABtn.Image");
            exitABtn.Location = new Point(1446, 12);
            exitABtn.Name = "exitABtn";
            exitABtn.Size = new Size(30, 30);
            exitABtn.TabIndex = 11;
            exitABtn.TabStop = false;
            exitABtn.Click += pictureBox5_Click;
            // 
            // anaBackground
            // 
            anaBackground.BackgroundImage = (Image) resources.GetObject("anaBackground.BackgroundImage");
            anaBackground.Controls.Add(nameL);
            anaBackground.Controls.Add(interstallerL);
            anaBackground.Controls.Add(jokerL);
            anaBackground.Controls.Add(bodyL);
            anaBackground.Controls.Add(interstallerPoster);
            anaBackground.Controls.Add(jokerPoster);
            anaBackground.Controls.Add(bodyPoster);
            anaBackground.Controls.Add(avatarL);
            anaBackground.Controls.Add(avatarPoster);
            anaBackground.Controls.Add(cikisBtn);
            anaBackground.Controls.Add(filmEkleBtn);
            anaBackground.Controls.Add(kiralarBtn);
            anaBackground.Controls.Add(filmlerBtn);
            anaBackground.Controls.Add(bigLogo);
            anaBackground.Location = new Point(0, 50);
            anaBackground.Margin = new Padding(0);
            anaBackground.Name = "anaBackground";
            anaBackground.Size = new Size(1500, 841);
            anaBackground.TabIndex = 2;
            // 
            // nameL
            // 
            nameL.AutoSize = true;
            nameL.BackColor = Color.Transparent;
            nameL.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point,  162);
            nameL.ForeColor = Color.Orange;
            nameL.Location = new Point(43, 184);
            nameL.Name = "nameL";
            nameL.Size = new Size(148, 48);
            nameL.TabIndex = 14;
            nameL.Text = "Nyala";
            // 
            // interstallerL
            // 
            interstallerL.AutoSize = true;
            interstallerL.BackColor = Color.Transparent;
            interstallerL.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point,  162);
            interstallerL.ForeColor = Color.White;
            interstallerL.Location = new Point(1320, 790);
            interstallerL.Name = "interstallerL";
            interstallerL.Size = new Size(117, 20);
            interstallerL.TabIndex = 13;
            interstallerL.Text = "Interstaller";
            // 
            // jokerL
            // 
            jokerL.AutoSize = true;
            jokerL.BackColor = Color.Transparent;
            jokerL.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point,  162);
            jokerL.ForeColor = Color.White;
            jokerL.Location = new Point(1320, 588);
            jokerL.Name = "jokerL";
            jokerL.Size = new Size(60, 20);
            jokerL.TabIndex = 12;
            jokerL.Text = "Joker";
            // 
            // bodyL
            // 
            bodyL.AutoSize = true;
            bodyL.BackColor = Color.Transparent;
            bodyL.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point,  162);
            bodyL.ForeColor = Color.White;
            bodyL.Location = new Point(1320, 386);
            bodyL.Name = "bodyL";
            bodyL.Size = new Size(160, 20);
            bodyL.TabIndex = 11;
            bodyL.Text = "3 Body Problem";
            // 
            // interstallerPoster
            // 
            interstallerPoster.BackColor = Color.Transparent;
            interstallerPoster.Cursor = Cursors.Hand;
            interstallerPoster.Image = (Image) resources.GetObject("interstallerPoster.Image");
            interstallerPoster.Location = new Point(1323, 616);
            interstallerPoster.Name = "interstallerPoster";
            interstallerPoster.Size = new Size(120, 170);
            interstallerPoster.TabIndex = 10;
            interstallerPoster.TabStop = false;
            interstallerPoster.Click += interstallerPoster_Click;
            // 
            // jokerPoster
            // 
            jokerPoster.BackColor = Color.Transparent;
            jokerPoster.Cursor = Cursors.Hand;
            jokerPoster.Image = (Image) resources.GetObject("jokerPoster.Image");
            jokerPoster.Location = new Point(1323, 415);
            jokerPoster.Name = "jokerPoster";
            jokerPoster.Size = new Size(120, 170);
            jokerPoster.TabIndex = 9;
            jokerPoster.TabStop = false;
            jokerPoster.Click += inseptPoster_Click;
            // 
            // bodyPoster
            // 
            bodyPoster.BackColor = Color.Transparent;
            bodyPoster.Cursor = Cursors.Hand;
            bodyPoster.Image = (Image) resources.GetObject("bodyPoster.Image");
            bodyPoster.Location = new Point(1323, 212);
            bodyPoster.Name = "bodyPoster";
            bodyPoster.Size = new Size(120, 170);
            bodyPoster.TabIndex = 8;
            bodyPoster.TabStop = false;
            bodyPoster.Click += bodyPoster_Click;
            // 
            // avatarL
            // 
            avatarL.AutoSize = true;
            avatarL.BackColor = Color.Transparent;
            avatarL.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point,  162);
            avatarL.ForeColor = Color.White;
            avatarL.Location = new Point(1320, 184);
            avatarL.Name = "avatarL";
            avatarL.Size = new Size(71, 20);
            avatarL.TabIndex = 7;
            avatarL.Text = "Avatar";
            // 
            // avatarPoster
            // 
            avatarPoster.BackColor = Color.Transparent;
            avatarPoster.Cursor = Cursors.Hand;
            avatarPoster.Image = (Image) resources.GetObject("avatarPoster.Image");
            avatarPoster.Location = new Point(1323, 11);
            avatarPoster.Name = "avatarPoster";
            avatarPoster.Size = new Size(120, 170);
            avatarPoster.TabIndex = 6;
            avatarPoster.TabStop = false;
            avatarPoster.Click += avatarPoster_Click;
            // 
            // cikisBtn
            // 
            cikisBtn.BackColor = Color.Transparent;
            cikisBtn.Cursor = Cursors.Hand;
            cikisBtn.FlatStyle = FlatStyle.Flat;
            cikisBtn.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  162);
            cikisBtn.ForeColor = Color.DarkRed;
            cikisBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            cikisBtn.IconColor = Color.Black;
            cikisBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cikisBtn.Location = new Point(25, 769);
            cikisBtn.Name = "cikisBtn";
            cikisBtn.Size = new Size(178, 58);
            cikisBtn.TabIndex = 5;
            cikisBtn.Text = "Çıkış Yap";
            cikisBtn.UseVisualStyleBackColor = false;
            cikisBtn.Click += Btn2Click;
            // 
            // filmEkleBtn
            // 
            filmEkleBtn.BackColor = Color.Transparent;
            filmEkleBtn.Cursor = Cursors.Hand;
            filmEkleBtn.FlatStyle = FlatStyle.Flat;
            filmEkleBtn.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  162);
            filmEkleBtn.ForeColor = Color.WhiteSmoke;
            filmEkleBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            filmEkleBtn.IconColor = Color.Black;
            filmEkleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            filmEkleBtn.Location = new Point(25, 455);
            filmEkleBtn.Name = "filmEkleBtn";
            filmEkleBtn.Size = new Size(178, 58);
            filmEkleBtn.TabIndex = 3;
            filmEkleBtn.Text = "Film Ekle";
            filmEkleBtn.UseVisualStyleBackColor = false;
            filmEkleBtn.Click += Btn3Click;
            // 
            // kiralarBtn
            // 
            kiralarBtn.BackColor = Color.Transparent;
            kiralarBtn.Cursor = Cursors.Hand;
            kiralarBtn.FlatStyle = FlatStyle.Flat;
            kiralarBtn.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  162);
            kiralarBtn.ForeColor = Color.WhiteSmoke;
            kiralarBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            kiralarBtn.IconColor = Color.Black;
            kiralarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            kiralarBtn.Location = new Point(25, 375);
            kiralarBtn.Name = "kiralarBtn";
            kiralarBtn.Size = new Size(178, 58);
            kiralarBtn.TabIndex = 2;
            kiralarBtn.Text = "Kiralar";
            kiralarBtn.UseVisualStyleBackColor = false;
            kiralarBtn.Click += Btn4Click;
            // 
            // filmlerBtn
            // 
            filmlerBtn.BackColor = Color.Transparent;
            filmlerBtn.Cursor = Cursors.Hand;
            filmlerBtn.FlatStyle = FlatStyle.Flat;
            filmlerBtn.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  162);
            filmlerBtn.ForeColor = Color.WhiteSmoke;
            filmlerBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            filmlerBtn.IconColor = Color.Black;
            filmlerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            filmlerBtn.Location = new Point(25, 297);
            filmlerBtn.Name = "filmlerBtn";
            filmlerBtn.Size = new Size(178, 58);
            filmlerBtn.TabIndex = 1;
            filmlerBtn.Text = "Filmler";
            filmlerBtn.UseVisualStyleBackColor = false;
            // 
            // bigLogo
            // 
            bigLogo.BackColor = Color.Transparent;
            bigLogo.Image = (Image) resources.GetObject("bigLogo.Image");
            bigLogo.Location = new Point(43, 25);
            bigLogo.Name = "bigLogo";
            bigLogo.Size = new Size(150, 150);
            bigLogo.TabIndex = 0;
            bigLogo.TabStop = false;
            // 
            // altPanel
            // 
            altPanel.BackColor = Color.Black;
            altPanel.Dock = DockStyle.Bottom;
            altPanel.Location = new Point(0, 888);
            altPanel.Name = "altPanel";
            altPanel.Size = new Size(1500, 62);
            altPanel.TabIndex = 3;
            // 
            // AnasayfaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1500, 950);
            Controls.Add(altPanel);
            Controls.Add(anaBackground);
            Controls.Add(ustPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnasayfaForm";
            Text = "AnasayfaForm";
            Load += onLoad;
            ustPanel.ResumeLayout(false);
            ustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) logo).EndInit();
            ((System.ComponentModel.ISupportInitialize) minimizeABtn).EndInit();
            ((System.ComponentModel.ISupportInitialize) exitABtn).EndInit();
            anaBackground.ResumeLayout(false);
            anaBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) interstallerPoster).EndInit();
            ((System.ComponentModel.ISupportInitialize) jokerPoster).EndInit();
            ((System.ComponentModel.ISupportInitialize) bodyPoster).EndInit();
            ((System.ComponentModel.ISupportInitialize) avatarPoster).EndInit();
            ((System.ComponentModel.ISupportInitialize) bigLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ustPanel;

        private PictureBox avatarPoster;
        private PictureBox exitABtn;
        private PictureBox minimizeABtn;
        private PictureBox logo;
        private Label formNameL;
        private Panel anaBackground;
        private PictureBox bigLogo;
        private FontAwesome.Sharp.IconButton filmlerBtn;
        private FontAwesome.Sharp.IconButton cikisBtn;
        private FontAwesome.Sharp.IconButton filmEkleBtn;
        private FontAwesome.Sharp.IconButton kiralarBtn;
        private Label avatarL;
        private Label jokerL;
        private Label bodyL;
        private PictureBox interstallerPoster;
        private PictureBox jokerPoster;
        private PictureBox bodyPoster;
        private Panel altPanel;
        private Label interstallerL;
        private Label nameL;
    }
}