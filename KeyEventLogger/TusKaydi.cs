namespace KeyEventLogger
{
    // Tek bir tuş olayını temsil eder
    public class TusKaydi
    {
        public DateTime Zaman { get; }
        public string TusAdi { get; }
        public string OlayTipi { get; }   // KeyDown / KeyUp
        public bool Shift { get; }
        public bool Ctrl { get; }
        public bool Alt { get; }

        public TusKaydi(string tusAdi, string olayTipi, bool shift, bool ctrl, bool alt)
        {
            Zaman = DateTime.Now;
            TusAdi = tusAdi;
            OlayTipi = olayTipi;
            Shift = shift;
            Ctrl = ctrl;
            Alt = alt;
        }

        // Ctrl+Shift+A gibi okunabilir hale getir
        public string KombinasyonMetni()
        {
            string metin = "";
            if (Ctrl) metin += "Ctrl+";
            if (Alt) metin += "Alt+";
            if (Shift) metin += "Shift+";
            return metin + TusAdi;
        }

        // Kayıt formatı: [tarih saat] Olay  Tuş
        public override string ToString()
        {
            return $"[{Zaman:dd.MM.yyyy HH:mm:ss.fff}] {OlayTipi,-7} {KombinasyonMetni()}";
        }
    }
}
