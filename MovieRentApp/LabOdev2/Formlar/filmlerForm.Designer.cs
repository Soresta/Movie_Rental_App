namespace LabOdev2 {
    partial class filmlerForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filmlerForm));
            filmlerListesiG = new DataGridView();
            AD = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Turu = new DataGridViewTextBoxColumn();
            durum = new DataGridViewTextBoxColumn();
            ucret = new DataGridViewTextBoxColumn();
            filmAd = new TextBox();
            FilmUcret = new TextBox();
            EkleBtn = new FontAwesome.Sharp.IconButton();
            adL = new Label();
            turL = new Label();
            durumL = new Label();
            ucretL = new Label();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel2 = new Panel();
            durumBox = new ComboBox();
            turCombo = new ComboBox();
            sureTxt = new TextBox();
            sureL = new Label();
            dilTxt = new TextBox();
            dilL = new Label();
            kaldirBtn = new FontAwesome.Sharp.IconButton();
            guncelleBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize) filmlerListesiG).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize) pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize) pictureBox5).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // filmlerListesiG
            // 
            filmlerListesiG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filmlerListesiG.Columns.AddRange(new DataGridViewColumn[] { AD, Column1, Column2, Turu, durum, ucret });
            filmlerListesiG.Location = new Point(381, 50);
            filmlerListesiG.Name = "filmlerListesiG";
            filmlerListesiG.RowHeadersWidth = 51;
            filmlerListesiG.Size = new Size(803, 516);
            filmlerListesiG.TabIndex = 0;
            filmlerListesiG.CellClick += filmerGrid_CellClick;
            // 
            // AD
            // 
            AD.HeaderText = "Ad";
            AD.MinimumWidth = 6;
            AD.Name = "AD";
            AD.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Dil";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Süre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Turu
            // 
            Turu.HeaderText = "Tür";
            Turu.MinimumWidth = 6;
            Turu.Name = "Turu";
            Turu.Width = 125;
            // 
            // durum
            // 
            durum.HeaderText = "Kiralama Durumu";
            durum.MinimumWidth = 6;
            durum.Name = "durum";
            durum.Width = 125;
            // 
            // ucret
            // 
            ucret.HeaderText = "Ücret";
            ucret.MinimumWidth = 6;
            ucret.Name = "ucret";
            ucret.Width = 125;
            // 
            // filmAd
            // 
            filmAd.Location = new Point(192, 18);
            filmAd.Name = "filmAd";
            filmAd.Size = new Size(183, 27);
            filmAd.TabIndex = 1;
            // 
            // FilmUcret
            // 
            FilmUcret.Location = new Point(192, 148);
            FilmUcret.Name = "FilmUcret";
            FilmUcret.Size = new Size(183, 27);
            FilmUcret.TabIndex = 4;
            // 
            // EkleBtn
            // 
            EkleBtn.BackColor = Color.Green;
            EkleBtn.Cursor = Cursors.Hand;
            EkleBtn.FlatStyle = FlatStyle.Flat;
            EkleBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point,  162);
            EkleBtn.ForeColor = Color.White;
            EkleBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            EkleBtn.IconColor = Color.Black;
            EkleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EkleBtn.Location = new Point(95, 300);
            EkleBtn.Name = "EkleBtn";
            EkleBtn.Size = new Size(190, 50);
            EkleBtn.TabIndex = 5;
            EkleBtn.Text = "Ekle";
            EkleBtn.UseVisualStyleBackColor = false;
            EkleBtn.Click += filmEkleBtn_Click;
            // 
            // adL
            // 
            adL.AutoSize = true;
            adL.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            adL.ForeColor = Color.White;
            adL.Location = new Point(29, 19);
            adL.Name = "adL";
            adL.Size = new Size(37, 22);
            adL.TabIndex = 6;
            adL.Text = "Ad";
            // 
            // turL
            // 
            turL.AutoSize = true;
            turL.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            turL.ForeColor = Color.White;
            turL.Location = new Point(29, 102);
            turL.Name = "turL";
            turL.Size = new Size(44, 22);
            turL.TabIndex = 7;
            turL.Text = "Tür";
            // 
            // durumL
            // 
            durumL.AutoSize = true;
            durumL.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            durumL.ForeColor = Color.White;
            durumL.Location = new Point(29, 59);
            durumL.Name = "durumL";
            durumL.Size = new Size(79, 22);
            durumL.TabIndex = 8;
            durumL.Text = "Durum";
            // 
            // ucretL
            // 
            ucretL.AutoSize = true;
            ucretL.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            ucretL.ForeColor = Color.White;
            ucretL.Location = new Point(29, 149);
            ucretL.Name = "ucretL";
            ucretL.Size = new Size(65, 22);
            ucretL.TabIndex = 9;
            ucretL.Text = "Ucret";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 50);
            panel1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point,  162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(47, 16);
            label7.Name = "label7";
            label7.Size = new Size(63, 18);
            label7.TabIndex = 15;
            label7.Text = "Filmler";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.ErrorImage = null;
            pictureBox7.Image = (Image) resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(11, 8);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.TabIndex = 14;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.ErrorImage = null;
            pictureBox6.Image = (Image) resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1098, 8);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.ErrorImage = null;
            pictureBox5.Image = (Image) resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1140, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(durumBox);
            panel2.Controls.Add(turCombo);
            panel2.Controls.Add(sureTxt);
            panel2.Controls.Add(sureL);
            panel2.Controls.Add(dilTxt);
            panel2.Controls.Add(dilL);
            panel2.Controls.Add(kaldirBtn);
            panel2.Controls.Add(guncelleBtn);
            panel2.Controls.Add(EkleBtn);
            panel2.Controls.Add(filmAd);
            panel2.Controls.Add(FilmUcret);
            panel2.Controls.Add(ucretL);
            panel2.Controls.Add(turL);
            panel2.Controls.Add(adL);
            panel2.Controls.Add(durumL);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 517);
            panel2.TabIndex = 11;
            // 
            // durumBox
            // 
            durumBox.FormattingEnabled = true;
            durumBox.Items.AddRange(new object[] { "True", "False" });
            durumBox.Location = new Point(192, 59);
            durumBox.Name = "durumBox";
            durumBox.Size = new Size(183, 28);
            durumBox.TabIndex = 21;
            // 
            // turCombo
            // 
            turCombo.FormattingEnabled = true;
            turCombo.Location = new Point(192, 102);
            turCombo.Name = "turCombo";
            turCombo.Size = new Size(183, 28);
            turCombo.TabIndex = 20;
            // 
            // sureTxt
            // 
            sureTxt.Location = new Point(192, 236);
            sureTxt.Name = "sureTxt";
            sureTxt.Size = new Size(183, 27);
            sureTxt.TabIndex = 18;
            // 
            // sureL
            // 
            sureL.AutoSize = true;
            sureL.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            sureL.ForeColor = Color.White;
            sureL.Location = new Point(29, 237);
            sureL.Name = "sureL";
            sureL.Size = new Size(57, 22);
            sureL.TabIndex = 19;
            sureL.Text = "Sure";
            // 
            // dilTxt
            // 
            dilTxt.Location = new Point(192, 190);
            dilTxt.Name = "dilTxt";
            dilTxt.Size = new Size(183, 27);
            dilTxt.TabIndex = 16;
            // 
            // dilL
            // 
            dilL.AutoSize = true;
            dilL.Font = new Font("Verdana", 10.8F, FontStyle.Bold);
            dilL.ForeColor = Color.White;
            dilL.Location = new Point(29, 191);
            dilL.Name = "dilL";
            dilL.Size = new Size(37, 22);
            dilL.TabIndex = 17;
            dilL.Text = "Dil";
            // 
            // kaldirBtn
            // 
            kaldirBtn.BackColor = Color.Maroon;
            kaldirBtn.Cursor = Cursors.Hand;
            kaldirBtn.FlatStyle = FlatStyle.Flat;
            kaldirBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point,  162);
            kaldirBtn.ForeColor = Color.White;
            kaldirBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            kaldirBtn.IconColor = Color.Black;
            kaldirBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            kaldirBtn.Location = new Point(95, 440);
            kaldirBtn.Name = "kaldirBtn";
            kaldirBtn.Size = new Size(190, 50);
            kaldirBtn.TabIndex = 15;
            kaldirBtn.Text = "Kaldir";
            kaldirBtn.UseVisualStyleBackColor = false;
            kaldirBtn.Click += kaldirBtn_Click;
            // 
            // guncelleBtn
            // 
            guncelleBtn.BackColor = Color.FromArgb(  8,   145,   203);
            guncelleBtn.Cursor = Cursors.Hand;
            guncelleBtn.FlatStyle = FlatStyle.Flat;
            guncelleBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point,  162);
            guncelleBtn.ForeColor = Color.White;
            guncelleBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            guncelleBtn.IconColor = Color.Black;
            guncelleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            guncelleBtn.Location = new Point(95, 370);
            guncelleBtn.Name = "guncelleBtn";
            guncelleBtn.Size = new Size(190, 50);
            guncelleBtn.TabIndex = 14;
            guncelleBtn.Text = "Güncelle";
            guncelleBtn.UseVisualStyleBackColor = false;
            guncelleBtn.Click += guncelleBtn_Click;
            // 
            // filmlerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  31,   32,   45);
            ClientSize = new Size(1182, 567);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(filmlerListesiG);
            FormBorderStyle = FormBorderStyle.None;
            Name = "filmlerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form2";
            ((System.ComponentModel.ISupportInitialize) filmlerListesiG).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize) pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize) pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView filmlerListesiG;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn AD;
        private DataGridViewTextBoxColumn Turu;
        private DataGridViewTextBoxColumn durum;
        private DataGridViewTextBoxColumn ucret;
        private TextBox filmAd;
        private TextBox FilmUcret;
        private FontAwesome.Sharp.IconButton EkleBtn;
        private Label adL;
        private Label turL;
        private Label durumL;
        private Label ucretL;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label7;
        private PictureBox pictureBox7;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton kaldirBtn;
        private FontAwesome.Sharp.IconButton guncelleBtn;
        private Label label6;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox sureTxt;
        private Label sureL;
        private TextBox dilTxt;
        private Label dilL;
        private ComboBox turCombo;
        private ComboBox durumBox;
    }
}