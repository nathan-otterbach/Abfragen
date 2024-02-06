namespace Formen
{
    public class Rechteck : Point
    {
        private decimal _length;
        private decimal _width;

        public Rechteck(Point p1, Point p2) 
        {
            checked
            {
                _length = p2.X - p1.X;
                _width = p2.Y - p1.Y;
            }
        }

        public Point getUpperLeft()
        {
            return new Point(X, Y);
        }

        public Point getUpperRight()
        {
            return new Point(X + _length, Y);
        }

        public Point getLowerLeft()
        {
            return new Point(X, Y + _width);
        }

        public Point getLowerRight()
        {
            return new Point(X + _length, Y + _width);
        }

        public double getDiagonal()
        {
            return Math.Sqrt((double)(_length * _length + _width * _width));
        }
    }
}
