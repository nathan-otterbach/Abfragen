namespace Formen
{
    public class Dreieck
    {
        private decimal _seiteA;
        private decimal _seiteB;
        private decimal _seiteC;

        public Dreieck(decimal seiteA, decimal seiteB, decimal seiteC)
        {
            checked
            {
                _seiteA = seiteA;
                _seiteB = seiteB;
                _seiteC = seiteC;
            }
        }

        public Dreieck() { }

        public decimal SeiteA
        {
            get { return _seiteA; }
            set { checked { _seiteA = value; } }
        }

        public decimal SeiteB
        {
            get { return _seiteB; }
            set { checked { _seiteB = value; } }
        }

        public decimal SeiteC
        {
            get { return _seiteC; }
            set { checked { _seiteC = value; } }
        }

        public decimal berechne_flaeche()
        {
            checked
            {
                decimal s = berechne_umfang() / 2;
                return (decimal)Math.Sqrt((double)(s * (s - _seiteA) * (s - _seiteB) * (s - _seiteC)));
            }
        }

        public decimal berechne_umfang()
        {
            checked
            {
                return _seiteA + _seiteB + _seiteC;
            }
        }
    }
}
