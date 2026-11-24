namespace KeyEventLogger
{
    // Tuş kayıtlarını tutar, istatistik çıkarır ve dosyaya yazar
    public class KayitYoneticisi
    {
        private readonly List<TusKaydi> kayitlar = new List<TusKaydi>();

        public bool KayitAktif { get; private set; }

        public int ToplamKayit
        {
            get { return kayitlar.Count; }
        }

        // sadece KeyDown olaylarını "basılan tuş" olarak sayıyoruz
        public int ToplamTusBasma
        {
            get { return kayitlar.Count(k => k.OlayTipi == "KeyDown"); }
        }

        public void Baslat()
        {
            KayitAktif = true;
        }

        public void Durdur()
        {
            KayitAktif = false;
        }

        // kayıt aktif değilse null döner
        public TusKaydi Ekle(Keys tus, string olayTipi, bool shift, bool ctrl, bool alt)
        {
            if (!KayitAktif) return null;

            var kayit = new TusKaydi(tus.ToString(), olayTipi, shift, ctrl, alt);
            kayitlar.Add(kayit);
            return kayit;
        }

        public void Temizle()
        {
            kayitlar.Clear();
        }

        public List<TusKaydi> TumKayitlar()
        {
            return new List<TusKaydi>(kayitlar);
        }

        // tarih aralığına göre filtreleme
        public List<TusKaydi> Filtrele(DateTime baslangic, DateTime bitis)
        {
            return kayitlar.Where(k => k.Zaman >= baslangic && k.Zaman <= bitis).ToList();
        }

        // en çok basılan n tuş
        public List<KeyValuePair<string, int>> EnSikTuslar(int adet)
        {
            return kayitlar
                .Where(k => k.OlayTipi == "KeyDown")
                .GroupBy(k => k.TusAdi)
                .Select(grup => new KeyValuePair<string, int>(grup.Key, grup.Count()))
                .OrderByDescending(x => x.Value)
                .Take(adet)
                .ToList();
        }

        public void DosyayaKaydet(string dosyaYolu, List<TusKaydi> kaydedilecekler)
        {
            using (StreamWriter yazici = new StreamWriter(dosyaYolu, false, System.Text.Encoding.UTF8))
            {
                yazici.WriteLine("Key Event Logger - Kayıt Dosyası");
                yazici.WriteLine("Oluşturma zamanı: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
                yazici.WriteLine("Kayıt sayısı: " + kaydedilecekler.Count);
                yazici.WriteLine(new string('-', 50));

                foreach (TusKaydi k in kaydedilecekler)
                {
                    yazici.WriteLine(k.ToString());
                }
            }
        }
    }
}
