namespace KeyEventLogger
{
    public partial class Form1 : Form
    {
        private readonly KayitYoneticisi yonetici = new KayitYoneticisi();

        // filtre açıkken yeni kayıtlar listeye eklenmesin diye
        private bool filtreAktif = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Now.AddMinutes(-10);
            dtpBitis.Value = DateTime.Now.AddMinutes(10);
            DurumuGuncelle();
            IstatistikGuncelle();
        }

        // KeyPreview = true olduğu için form içindeki tüm tuşlar önce buraya gelir
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            TusuIsle(e, "KeyDown");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (chkKeyUp.Checked)
                TusuIsle(e, "KeyUp");
        }

        private void TusuIsle(KeyEventArgs e, string olayTipi)
        {
            TusKaydi kayit = yonetici.Ekle(e.KeyCode, olayTipi, e.Shift, e.Control, e.Alt);
            if (kayit == null) return; // kayıt kapalı

            if (!filtreAktif)
            {
                lstKayitlar.Items.Add(kayit.ToString());
                lstKayitlar.TopIndex = lstKayitlar.Items.Count - 1; // en alta kaydır
            }
            IstatistikGuncelle();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            yonetici.Baslat();
            DurumuGuncelle();
            OdagiListeyeVer();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            yonetici.Durdur();
            DurumuGuncelle();
            OdagiListeyeVer();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (yonetici.ToplamKayit == 0) return;

            DialogResult cevap = MessageBox.Show("Tüm kayıtlar silinsin mi?", "Temizle",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                yonetici.Temizle();
                lstKayitlar.Items.Clear();
                filtreAktif = false;
                IstatistikGuncelle();
            }
            OdagiListeyeVer();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<TusKaydi> kaydedilecekler = filtreAktif
                ? yonetici.Filtrele(dtpBaslangic.Value, dtpBitis.Value)
                : yonetici.TumKayitlar();

            if (kaydedilecekler.Count == 0)
            {
                MessageBox.Show("Kaydedilecek kayıt yok.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Metin dosyası (*.txt)|*.txt";
                sfd.FileName = "tus_kayitlari_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        yonetici.DosyayaKaydet(sfd.FileName, kaydedilecekler);
                        MessageBox.Show(kaydedilecekler.Count + " kayıt dosyaya yazıldı.", "Kaydedildi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Bu konuma yazma izniniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Dosya yazılırken hata oluştu: " + ex.Message, "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            OdagiListeyeVer();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            if (dtpBaslangic.Value > dtpBitis.Value)
            {
                MessageBox.Show("Başlangıç zamanı bitişten büyük olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<TusKaydi> sonuc = yonetici.Filtrele(dtpBaslangic.Value, dtpBitis.Value);
            ListeyiDoldur(sonuc);
            filtreAktif = true;
            Text = $"Key Event Logger (Eğitsel) - Filtre: {sonuc.Count} kayıt";
            OdagiListeyeVer();
        }

        private void btnFiltreKaldir_Click(object sender, EventArgs e)
        {
            filtreAktif = false;
            ListeyiDoldur(yonetici.TumKayitlar());
            Text = "Key Event Logger (Eğitsel) - YMH219";
            OdagiListeyeVer();
        }

        private void ListeyiDoldur(List<TusKaydi> liste)
        {
            lstKayitlar.BeginUpdate();
            lstKayitlar.Items.Clear();
            foreach (TusKaydi k in liste)
                lstKayitlar.Items.Add(k.ToString());
            lstKayitlar.EndUpdate();
        }

        private void DurumuGuncelle()
        {
            if (yonetici.KayitAktif)
            {
                lblDurum.Text = "KAYIT AÇIK";
                lblDurum.ForeColor = Color.SeaGreen;
                pnlGosterge.BackColor = Color.LimeGreen;
            }
            else
            {
                lblDurum.Text = "KAYIT KAPALI";
                lblDurum.ForeColor = Color.IndianRed;
                pnlGosterge.BackColor = Color.IndianRed;
            }
            btnBaslat.Enabled = !yonetici.KayitAktif;
            btnDurdur.Enabled = yonetici.KayitAktif;
        }

        private void IstatistikGuncelle()
        {
            lblToplam.Text = "Toplam tuş basma: " + yonetici.ToplamTusBasma;

            lstEnSik.Items.Clear();
            foreach (var tus in yonetici.EnSikTuslar(8))
            {
                lstEnSik.Items.Add($"{tus.Key,-12} {tus.Value} kez");
            }
        }

        // butona tıklandıktan sonra Space/Enter tekrar butonu tetiklemesin
        private void OdagiListeyeVer()
        {
            ActiveControl = lstKayitlar;
        }
    }
}
