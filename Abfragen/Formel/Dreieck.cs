namespace Formen
{
    public class Dreieck : Form
    {
        private float _seiteA;
        private float _seiteB;
        private float _seiteC;

        public Dreieck() { }

        public Dreieck(float seiteA, float seiteB, float seiteC) : this()
        {
            checked
            {
                _seiteA = seiteA;
                _seiteB = seiteB;
                _seiteC = seiteC;
            }
        }

        public float SeiteA
        {
            get { return _seiteA; }
            set { checked { _seiteA = value; } }
        }

        public float SeiteB
        {
            get { return _seiteB; }
            set { checked { _seiteB = value; } }
        }
        
        public float SeiteC
        {
            get { return _seiteC; }
            set { checked { _seiteC = value; } }
        }

        public override float berechne_flaeche()
        {
            checked
            {
                float s = berechne_umfang() / 2;
                return (float)Math.Sqrt((s * (s - _seiteA) * (s - _seiteB) * (s - _seiteC)));
            }
        }

        public override float berechne_umfang()
        {
            checked
            {
                return _seiteA + _seiteB + _seiteC;
            }
        }
    }
}
