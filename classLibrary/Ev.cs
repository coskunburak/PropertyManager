using ClassLibrary;
using System;
using System.IO;

namespace ClassLibrary
{
    public class Ev
    {
        private static int _emlakNumarasiCounter = 0;
        private int _odaSayisi;
        private int _katNumarasi;
        private string _semti;
        private double _alani;
        private DateTime _yapimTarihi;
        private EvTuru _turu;
        private bool _aktif;
        private int _emlakNumarasi;

        public Ev(int odaSayisi, int katNumarasi, string semti, double alani, DateTime yapimTarihi, EvTuru turu)
        {
            _emlakNumarasi = ++_emlakNumarasiCounter;
            OdaSayisi = odaSayisi;
            KatNumarasi = katNumarasi;
            Semti = semti;
            Alani = alani;
            YapimTarihi = yapimTarihi;
            Turu = turu;
            Aktif = true;
        }

        public int OdaSayisi
        {
            get => _odaSayisi;
            set
            {
                Log("OdaSayisi", value);
                _odaSayisi = value < 0 ? 0 : value;
            }
        }

        public int KatNumarasi
        {
            get => _katNumarasi;
            set => _katNumarasi = value;
        }

        public string Semti
        {
            get => _semti;
            set => _semti = value;
        }

        public double Alani
        {
            get => _alani;
            set => _alani = value;
        }

        public DateTime YapimTarihi
        {
            get => _yapimTarihi;
            set => _yapimTarihi = value;
        }

        public EvTuru Turu
        {
            get => _turu;
            set => _turu = value;
        }

        public bool Aktif
        {
            get => _aktif;
            set => _aktif = value;
        }

        public int EmlakNumarasi => _emlakNumarasi;

        public int Yas => DateTime.Now.Year - YapimTarihi.Year;

        public virtual string EvBilgileri()
        {
            return string.Format("Emlak Numarası: {0}, Oda Sayısı: {1}, Kat Numarası: {2}, Semti: {3}, Alanı: {4}, Yapım Tarihi: {5}, Türü: {6}, Aktif: {7}",
                                 EmlakNumarasi, OdaSayisi, KatNumarasi, Semti, Alani, YapimTarihi.ToShortDateString(), Turu, Aktif);
        }

        public double FiyatHesapla()
        {
            double katsayi = 200;
            if (File.Exists("room_cost.txt"))
            {
                katsayi = double.Parse(File.ReadAllText("room_cost.txt"));
            }
            return OdaSayisi * katsayi;
        }

        private void Log(string field, int value)
        {
            string logMessage = $"{DateTime.Now}: {field} değeri {value} olarak ayarlandı.\n";
            File.AppendAllText("log.txt", logMessage);
        }
    }
}
