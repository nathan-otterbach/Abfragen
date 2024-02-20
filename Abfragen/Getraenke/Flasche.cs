
namespace Getraenke
{
    public class Flasche
    {
        private int _leer_gewicht = 150;
        private int _fuell_stand;

        public Flasche() { }

        public Flasche(int fuell_stand)
        {
            _fuell_stand = fuell_stand;
        }

        public Flasche(int leer_gewicht, int fuell_stand)
        {
            _leer_gewicht = leer_gewicht;
            _fuell_stand = fuell_stand;
        }

        public int Leergewicht
        {
            get { return _leer_gewicht; }
            set {  _leer_gewicht = value; }
        }

        public int Fuellstand
        {
            get { return _fuell_stand; }
            set { checked { _fuell_stand = value; } }
        }

        public int get_gewicht()
        {
            return _leer_gewicht + _fuell_stand;
        }
    }
}
