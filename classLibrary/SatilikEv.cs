using ClassLibrary;

namespace ClassLibrary
{
    public class SatilikEv : Ev
    {
        public double Fiyati { get; set; }

        public SatilikEv(int odaSayisi, int katNumarasi, string semti, double alani, DateTime yapimTarihi, EvTuru turu, double fiyati)
            : base(odaSayisi, katNumarasi, semti, alani, yapimTarihi, turu)
        {
            Fiyati = fiyati;
        }

        public override string EvBilgileri()
        {
            return base.EvBilgileri() + string.Format(", Fiyat: {0}", Fiyati);
        }
    }
}
