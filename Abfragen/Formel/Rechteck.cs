namespace Formen
{
    public class Rechteck : Form
    {
        private float _seiteA;
        private float _seiteB;

        public Rechteck() { }

        public Rechteck(float seiteA, float seiteB) :this()
        {
            checked
            {
                _seiteA = seiteA;
                _seiteB = seiteB;
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

        public override float berechne_flaeche()
        {
            checked
            {
                return _seiteA * _seiteB;
            }
        }

        public override float berechne_umfang()
        {
            checked
            {
                return 2 * (_seiteA + _seiteB);
            }
        }
    }
}
