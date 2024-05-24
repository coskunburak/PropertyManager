using ClassLibrary;

namespace ClassLibrary
{
    public class KiralikEv : Ev
    {
        public double Depozitosu { get; set; }
        public double Kirasi { get; set; }

        public KiralikEv(int odaSayisi, int katNumarasi, string semti, double alani, DateTime yapimTarihi, EvTuru turu, double depozitosu, double kirasi)
            : base(odaSayisi, katNumarasi, semti, alani, yapimTarihi, turu)
        {
            Depozitosu = depozitosu;
            Kirasi = kirasi;
        }

        public override string EvBilgileri()
        {
            return base.EvBilgileri() + string.Format(", Depozito: {0}, Kira: {1}", Depozitosu, Kirasi);
        }
    }
}
