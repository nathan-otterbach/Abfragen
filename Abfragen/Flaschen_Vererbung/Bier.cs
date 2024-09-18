

namespace Flaschen_Vererbung
{
    public class Bier : Flasche
    {
        private static int counter;

        private int localIndex;
        private int zuckergehalt;

        public Bier() { localIndex = Interlocked.Increment(ref counter); }

        public Bier(int maxmenge, int fuellmenge, int leergewicht, int zuckergehalt) : this()
        {
            this.zuckergehalt = zuckergehalt;
        }

        public override int Maxmenge
        {
            get { return base.Maxmenge; }
            set { base.Maxmenge = value; }
        }

        public override int Fuellmenge
        {
            get { return base.Fuellmenge; }
            set { base.Fuellmenge = value; }
        }

        public override int Leergewicht
        {
            get { return base.Leergewicht; }
            set { base.Leergewicht = value; }
        }

        public int Zuckergehalt
        {
            get { return zuckergehalt; }
            set { zuckergehalt = value; }
        }

        public override int getGewicht()
        {
            return base.getGewicht();
        }

        public override void trinken(int menge)
        {
            base.trinken(menge);
        }

        public override bool speichern(string fileName, int index, int zuckergehalt)
        {
            return base.speichern(fileName, localIndex, Zuckergehalt);
        }

        public override bool laden(string fileName)
        {
            return base.laden(fileName);
        }
    }
}
