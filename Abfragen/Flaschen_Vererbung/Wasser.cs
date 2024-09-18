

namespace Flaschen_Vererbung
{
    public  class Wasser : Flasche
    {
        private static int counter;
        
        private int localIndex;

        public Wasser() { localIndex = Interlocked.Increment(ref counter); }

        public Wasser(int maxmenge, int fuellmenge, int leergewicht) : this() { }

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

        public override int getGewicht()
        {
            return base.getGewicht();
        }

        public override void trinken(int menge)
        {
            base.trinken(menge);
        }

        public override bool speichern(string fileName, int index, int zuckergehalt = 0)
        {
            return base.speichern(fileName, localIndex, zuckergehalt);
        }

        public override bool laden(string fileName)
        {
            return base.laden(fileName);
        }
    }
}
