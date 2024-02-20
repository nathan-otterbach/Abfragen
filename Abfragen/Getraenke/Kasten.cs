using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getraenke
{
    public class Kasten
    {
        private int _leer_gewicht = 400;
        private readonly Random _random = new Random(Guid.NewGuid().GetHashCode());

        public Kasten() { }

        public Kasten(int leer_gewicht)
        {
            _leer_gewicht = leer_gewicht;
        }

        public int Leergewicht
        {
            get { return _leer_gewicht; }
            set { _leer_gewicht = value; }
        }

        public int get_gesamt_gewicht()
        {
            Flasche[] f = new Flasche[12];
            f[0] = new Flasche(0);
            int summe = f[0].get_gewicht() + _leer_gewicht;

            for (int i = 1; i < f.Length; i++)
            {
                f[i] = new Flasche(get_rnd());
                summe += f[i].get_gewicht();
            }

            return summe;
        }

        private int get_rnd()
        {
            return _random.Next(0 , 1000);
        }
    }
}
