namespace Formen
{
    public class Kreis
    {
        private decimal _radius;

        public Kreis(decimal radius)
        {
            checked
            {
                _radius = radius;
            }
        }

        public Kreis() { }

        public decimal Radius
        {
            get { return _radius; }
            set { checked { _radius = value; } }
        }

        public decimal berechne_flaeche()
        {
            checked
            {
                return (decimal)Math.PI * _radius * _radius;
            }
        }

        public decimal berechne_umfang()
        {
            checked
            {
                return 2 * (decimal)Math.PI * _radius;
            }
        }
    }
}
