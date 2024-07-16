namespace LabOdev2 {
    partial class KiralarForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiralarForm));
            kiraSil = new FontAwesome.Sharp.IconButton();
            kiraGuncelle = new FontAwesome.Sharp.IconButton();
            kiraEkle = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            isimTxt = new TextBox();
            soyisimTxt = new TextBox();
            FilmComboBox = new ComboBox();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            sureBox = new ComboBox();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel2 = new Panel();
            filmDurumuBox = new TextBox();
            kiralarListesiG = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize) pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize) pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) kiralarListesiG).BeginInit();
            SuspendLayout();
            // 
            // kiraSil
            // 
            kiraSil.BackColor = Color.Maroon;
            kiraSil.Cursor = Cursors.Hand;
            kiraSil.FlatStyle = FlatStyle.Flat;
            kiraSil.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  162);
            kiraSil.ForeColor = Color.White;
            kiraSil.IconChar = FontAwesome.Sharp.IconChar.None;
            kiraSil.IconColor = Color.Black;
            kiraSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            kiraSil.Location = new Point(84, 480);
            kiraSil.Name = "kiraSil";
            kiraSil.Size = new Size(190, 50);
            kiraSil.TabIndex = 1;
            kiraSil.Text = "Kaldır";
            kiraSil.UseVisualStyleBackColor = false;
            kiraSil.Click += kaldirBtn_Click;
            // 
            // kiraGuncelle
            // 
            kiraGuncelle.BackColor = Color.FromArgb(  8,   145,   203);
            kiraGuncelle.Cursor = Cursors.Hand;
            kiraGuncelle.FlatStyle = FlatStyle.Flat;
            kiraGuncelle.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  162);
            kiraGuncelle.ForeColor = Color.White;
            kiraGuncelle.IconChar = FontAwesome.Sharp.IconChar.None;
            kiraGuncelle.IconColor = Color.Black;
            kiraGuncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            kiraGuncelle.Location = new Point(86, 410);
            kiraGuncelle.Name = "kiraGuncelle";
            kiraGuncelle.Size = new Size(190, 50);
            kiraGuncelle.TabIndex = 2;
            kiraGuncelle.Text = "Güncelle";
            kiraGuncelle.UseVisualStyleBackColor = false;
            kiraGuncelle.Click += guncelleBtn_Click;
            // 
            // kiraEkle
            // 
            kiraEkle.BackColor = Color.Green;
            kiraEkle.Cursor = Cursors.Hand;
            kiraEkle.FlatStyle = FlatStyle.Flat;
            kiraEkle.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  162);
            kiraEkle.ForeColor = Color.White;
            kiraEkle.IconChar = FontAwesome.Sharp.IconChar.None;
            kiraEkle.IconColor = Color.Black;
            kiraEkle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            kiraEkle.Location = new Point(86, 340);
            kiraEkle.Margin = new Padding(0);
            kiraEkle.Name = "kiraEkle";
            kiraEkle.Size = new Size(190, 50);
            kiraEkle.TabIndex = 3;
            kiraEkle.Text = "Ekle";
            kiraEkle.UseVisualStyleBackColor = false;
            kiraEkle.Click += kiralaBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(45, 18);
            label1.TabIndex = 4;
            label1.Text = "İsim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 80);
            label2.Name = "label2";
            label2.Size = new Size(72, 18);
            label2.TabIndex = 5;
            label2.Text = "Soyisim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 130);
            label3.Name = "label3";
            label3.Size = new Size(42, 18);
            label3.TabIndex = 6;
            label3.Text = "Film";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label5.Location = new Point(10, 224);
            label5.Name = "label5";
            label5.Size = new Size(137, 18);
            label5.TabIndex = 8;
            label5.Text = "Kiralama Süresi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label6.Location = new Point(10, 180);
            label6.Name = "label6";
            label6.Size = new Size(112, 18);
            label6.TabIndex = 9;
            label6.Text = "Film Durumu";
            // 
            // isimTxt
            // 
            isimTxt.Location = new Point(153, 30);
            isimTxt.Name = "isimTxt";
            isimTxt.Size = new Size(192, 27);
            isimTxt.TabIndex = 10;
            // 
            // soyisimTxt
            // 
            soyisimTxt.Location = new Point(153, 80);
            soyisimTxt.Name = "soyisimTxt";
            soyisimTxt.Size = new Size(192, 27);
            soyisimTxt.TabIndex = 11;
            // 
            // FilmComboBox
            // 
            FilmComboBox.FormattingEnabled = true;
            FilmComboBox.Location = new Point(153, 130);
            FilmComboBox.Name = "FilmComboBox";
            FilmComboBox.Size = new Size(192, 28);
            FilmComboBox.TabIndex = 12;
            FilmComboBox.SelectedIndexChanged += FilmComboBox_SelectedIndexChanged;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(1175, 439);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(8, 1);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // sureBox
            // 
            sureBox.FormattingEnabled = true;
            sureBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            sureBox.Location = new Point(153, 224);
            sureBox.Name = "sureBox";
            sureBox.Size = new Size(195, 28);
            sureBox.TabIndex = 15;
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
            panel1.Size = new Size(1285, 50);
            panel1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point,  162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(48, 16);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 17;
            label7.Text = "Kiralar";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.ErrorImage = null;
            pictureBox7.Image = (Image) resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 10);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.ErrorImage = null;
            pictureBox6.Image = (Image) resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1197, 14);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.ErrorImage = null;
            pictureBox5.Image = (Image) resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1243, 14);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(  31,   32,   45);
            panel2.Controls.Add(filmDurumuBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(isimTxt);
            panel2.Controls.Add(sureBox);
            panel2.Controls.Add(kiraSil);
            panel2.Controls.Add(kiraGuncelle);
            panel2.Controls.Add(kiraEkle);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(soyisimTxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(FilmComboBox);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 575);
            panel2.TabIndex = 19;
            // 
            // filmDurumuBox
            // 
            filmDurumuBox.Enabled = false;
            filmDurumuBox.Location = new Point(153, 180);
            filmDurumuBox.Name = "filmDurumuBox";
            filmDurumuBox.Size = new Size(192, 27);
            filmDurumuBox.TabIndex = 16;
            // 
            // kiralarListesiG
            // 
            kiralarListesiG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kiralarListesiG.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column1, Column6, Column7 });
            kiralarListesiG.Location = new Point(360, 50);
            kiralarListesiG.Name = "kiralarListesiG";
            kiralarListesiG.RowHeadersWidth = 51;
            kiralarListesiG.Size = new Size(927, 575);
            kiralarListesiG.TabIndex = 20;
            kiralarListesiG.CellClick += kiralamalarGrid_CellClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "Isim";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Soyisim";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Film";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Durumu";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Alım Tarihi";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Teslim Tarihi";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Toplam Ücret";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // KiralarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 625);
            Controls.Add(kiralarListesiG);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(kryptonBorderEdge1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KiralarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KiralarForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize) pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize) pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) kiralarListesiG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton kiraSil;
        private FontAwesome.Sharp.IconButton kiraGuncelle;
        private FontAwesome.Sharp.IconButton kiraEkle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox isimTxt;
        private TextBox soyisimTxt;
        private ComboBox FilmComboBox;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComboBox sureBox;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Panel panel2;
        private DataGridView kiralarListesiG;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TextBox filmDurumuBox;
    }
}