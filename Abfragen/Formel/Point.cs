using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formen
{
    public class Point
    {
        private decimal _x;
        private decimal _y;

        public Point(decimal x, decimal y)
        {
            checked
            {
                _x = x;
                _y = y;
            }
        }

        public Point() { }

        public decimal X
        {
            get { return _x; }
            set { checked { _x = value; } }
        }

        public decimal Y
        {
            get { return _y; }
            set { checked { _y = value; } }
        }

        public double getDistance(Point p)
        {
            checked
            {
                return Math.Sqrt((double)((p.X - _x) * (p.X - _x) + (p.Y - _y) * (p.Y - _y)));
            }
        }
    }
}
