namespace Endnoten
{
    public class Fach
    {
        private string name;
        private float n1;
        private float n2;
        private float n3;

        public Fach() { }

        public Fach(string name)
        {
            this.name = name;
        }

        public Fach(string name, float n1, float n2, float n3)
        {
            this.name = name;
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float N1
        {
            get { return n1; }
            set { n1 = value; }
        }

        public float N2
        {
            get { return n2; }
            set { n2 = value; }
        }

        public float N3
        {
            get { return n3; }
            set { n3 = value; }
        }

        public float getDSN()
        {
            return (n1 + n2 + n3) / 3;
        }
    }
}
