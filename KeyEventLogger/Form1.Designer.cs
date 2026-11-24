namespace KeyEventLogger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlGosterge = new Panel();
            lblDurum = new Label();
            btnBaslat = new Button();
            btnDurdur = new Button();
            btnTemizle = new Button();
            btnKaydet = new Button();
            chkKeyUp = new CheckBox();
            lstKayitlar = new ListBox();
            grpIstatistik = new GroupBox();
            lstEnSik = new ListBox();
            lblEnSik = new Label();
            lblToplam = new Label();
            grpFiltre = new GroupBox();
            btnFiltreKaldir = new Button();
            btnFiltrele = new Button();
            dtpBitis = new DateTimePicker();
            dtpBaslangic = new DateTimePicker();
            lblBitis = new Label();
            lblBaslangic = new Label();
            lblNot = new Label();
            grpIstatistik.SuspendLayout();
            grpFiltre.SuspendLayout();
            SuspendLayout();
            //
            // pnlGosterge
            //
            pnlGosterge.BackColor = Color.IndianRed;
            pnlGosterge.Location = new Point(16, 18);
            pnlGosterge.Name = "pnlGosterge";
            pnlGosterge.Size = new Size(22, 22);
            pnlGosterge.TabIndex = 0;
            //
            // lblDurum
            //
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDurum.ForeColor = Color.IndianRed;
            lblDurum.Location = new Point(44, 18);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(126, 20);
            lblDurum.TabIndex = 1;
            lblDurum.Text = "KAYIT KAPALI";
            //
            // btnBaslat
            //
            btnBaslat.Location = new Point(220, 12);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(100, 32);
            btnBaslat.TabIndex = 2;
            btnBaslat.TabStop = false;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            //
            // btnDurdur
            //
            btnDurdur.Enabled = false;
            btnDurdur.Location = new Point(326, 12);
            btnDurdur.Name = "btnDurdur";
            btnDurdur.Size = new Size(100, 32);
            btnDurdur.TabIndex = 3;
            btnDurdur.TabStop = false;
            btnDurdur.Text = "Durdur";
            btnDurdur.UseVisualStyleBackColor = true;
            btnDurdur.Click += btnDurdur_Click;
            //
            // btnTemizle
            //
            btnTemizle.Location = new Point(432, 12);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(100, 32);
            btnTemizle.TabIndex = 4;
            btnTemizle.TabStop = false;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            //
            // btnKaydet
            //
            btnKaydet.Location = new Point(538, 12);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(120, 32);
            btnKaydet.TabIndex = 5;
            btnKaydet.TabStop = false;
            btnKaydet.Text = "Dosyaya Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            //
            // chkKeyUp
            //
            chkKeyUp.AutoSize = true;
            chkKeyUp.Location = new Point(16, 56);
            chkKeyUp.Name = "chkKeyUp";
            chkKeyUp.Size = new Size(195, 19);
            chkKeyUp.TabIndex = 6;
            chkKeyUp.TabStop = false;
            chkKeyUp.Text = "KeyUp olaylarını da kaydet";
            chkKeyUp.UseVisualStyleBackColor = true;
            //
            // lstKayitlar
            //
            lstKayitlar.Font = new Font("Consolas", 10F);
            lstKayitlar.FormattingEnabled = true;
            lstKayitlar.HorizontalScrollbar = true;
            lstKayitlar.IntegralHeight = false;
            lstKayitlar.Location = new Point(16, 84);
            lstKayitlar.Name = "lstKayitlar";
            lstKayitlar.Size = new Size(470, 400);
            lstKayitlar.TabIndex = 7;
            //
            // grpIstatistik
            //
            grpIstatistik.Controls.Add(lstEnSik);
            grpIstatistik.Controls.Add(lblEnSik);
            grpIstatistik.Controls.Add(lblToplam);
            grpIstatistik.Location = new Point(500, 78);
            grpIstatistik.Name = "grpIstatistik";
            grpIstatistik.Size = new Size(240, 220);
            grpIstatistik.TabIndex = 8;
            grpIstatistik.TabStop = false;
            grpIstatistik.Text = "İstatistik";
            //
            // lstEnSik
            //
            lstEnSik.FormattingEnabled = true;
            lstEnSik.Location = new Point(12, 70);
            lstEnSik.Name = "lstEnSik";
            lstEnSik.Size = new Size(214, 139);
            lstEnSik.TabIndex = 2;
            lstEnSik.TabStop = false;
            //
            // lblEnSik
            //
            lblEnSik.AutoSize = true;
            lblEnSik.Location = new Point(12, 50);
            lblEnSik.Name = "lblEnSik";
            lblEnSik.Size = new Size(128, 15);
            lblEnSik.TabIndex = 1;
            lblEnSik.Text = "En sık kullanılan tuşlar:";
            //
            // lblToplam
            //
            lblToplam.AutoSize = true;
            lblToplam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblToplam.Location = new Point(12, 24);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(118, 15);
            lblToplam.TabIndex = 0;
            lblToplam.Text = "Toplam tuş basma: 0";
            //
            // grpFiltre
            //
            grpFiltre.Controls.Add(btnFiltreKaldir);
            grpFiltre.Controls.Add(btnFiltrele);
            grpFiltre.Controls.Add(dtpBitis);
            grpFiltre.Controls.Add(dtpBaslangic);
            grpFiltre.Controls.Add(lblBitis);
            grpFiltre.Controls.Add(lblBaslangic);
            grpFiltre.Location = new Point(500, 306);
            grpFiltre.Name = "grpFiltre";
            grpFiltre.Size = new Size(240, 178);
            grpFiltre.TabIndex = 9;
            grpFiltre.TabStop = false;
            grpFiltre.Text = "Zaman Aralığına Göre Filtre";
            //
            // btnFiltreKaldir
            //
            btnFiltreKaldir.Location = new Point(124, 132);
            btnFiltreKaldir.Name = "btnFiltreKaldir";
            btnFiltreKaldir.Size = new Size(102, 30);
            btnFiltreKaldir.TabIndex = 5;
            btnFiltreKaldir.TabStop = false;
            btnFiltreKaldir.Text = "Tümünü Göster";
            btnFiltreKaldir.UseVisualStyleBackColor = true;
            btnFiltreKaldir.Click += btnFiltreKaldir_Click;
            //
            // btnFiltrele
            //
            btnFiltrele.Location = new Point(12, 132);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(102, 30);
            btnFiltrele.TabIndex = 4;
            btnFiltrele.TabStop = false;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = true;
            btnFiltrele.Click += btnFiltrele_Click;
            //
            // dtpBitis
            //
            dtpBitis.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dtpBitis.Format = DateTimePickerFormat.Custom;
            dtpBitis.Location = new Point(12, 98);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.ShowUpDown = true;
            dtpBitis.Size = new Size(214, 23);
            dtpBitis.TabIndex = 3;
            //
            // dtpBaslangic
            //
            dtpBaslangic.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dtpBaslangic.Format = DateTimePickerFormat.Custom;
            dtpBaslangic.Location = new Point(12, 46);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.ShowUpDown = true;
            dtpBaslangic.Size = new Size(214, 23);
            dtpBaslangic.TabIndex = 2;
            //
            // lblBitis
            //
            lblBitis.AutoSize = true;
            lblBitis.Location = new Point(12, 78);
            lblBitis.Name = "lblBitis";
            lblBitis.Size = new Size(32, 15);
            lblBitis.TabIndex = 1;
            lblBitis.Text = "Bitiş:";
            //
            // lblBaslangic
            //
            lblBaslangic.AutoSize = true;
            lblBaslangic.Location = new Point(12, 26);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(59, 15);
            lblBaslangic.TabIndex = 0;
            lblBaslangic.Text = "Başlangıç:";
            //
            // lblNot
            //
            lblNot.AutoSize = true;
            lblNot.ForeColor = Color.DimGray;
            lblNot.Location = new Point(16, 494);
            lblNot.Name = "lblNot";
            lblNot.Size = new Size(520, 15);
            lblNot.TabIndex = 10;
            lblNot.Text = "Not: Eğitsel amaçlıdır. Tuşlar yalnızca bu pencere aktifken yakalanır, başka uygulamalar izlenmez.";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 520);
            Controls.Add(lblNot);
            Controls.Add(grpFiltre);
            Controls.Add(grpIstatistik);
            Controls.Add(lstKayitlar);
            Controls.Add(chkKeyUp);
            Controls.Add(btnKaydet);
            Controls.Add(btnTemizle);
            Controls.Add(btnDurdur);
            Controls.Add(btnBaslat);
            Controls.Add(lblDurum);
            Controls.Add(pnlGosterge);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Key Event Logger (Eğitsel) - YMH219";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            grpIstatistik.ResumeLayout(false);
            grpIstatistik.PerformLayout();
            grpFiltre.ResumeLayout(false);
            grpFiltre.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlGosterge;
        private Label lblDurum;
        private Button btnBaslat;
        private Button btnDurdur;
        private Button btnTemizle;
        private Button btnKaydet;
        private CheckBox chkKeyUp;
        private ListBox lstKayitlar;
        private GroupBox grpIstatistik;
        private ListBox lstEnSik;
        private Label lblEnSik;
        private Label lblToplam;
        private GroupBox grpFiltre;
        private Button btnFiltreKaldir;
        private Button btnFiltrele;
        private DateTimePicker dtpBitis;
        private DateTimePicker dtpBaslangic;
        private Label lblBitis;
        private Label lblBaslangic;
        private Label lblNot;
    }
}
