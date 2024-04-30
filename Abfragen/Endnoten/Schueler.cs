namespace Endnoten
{
    public class Schueler
    {
        private Fach[] faecher = new Fach[4];

        public Schueler() { }

        public Schueler(Fach[] faecher)
        {
            this.faecher = faecher;
        }

        public Fach[] Faecher
        {
            get { return faecher; }
            set { faecher = value; }
        }

        public void makeSchuljahr()
        {
            Faecher[0] = new Fach(Belegungsplan.faecher[0], 1.2f, 2.1f, 3.5f);
            Faecher[1] = new Fach(Belegungsplan.faecher[1], 4, 5, 6);
            Faecher[2] = new Fach(Belegungsplan.faecher[2], 1, 1.8f, 1.9f);
            Faecher[3] = new Fach(Belegungsplan.faecher[3], 1, 1.1f, 1.2f);

            float sum = 0;
            uint count = 0;
            for (int i = 0; i < Faecher.Length; i++)
            {
                Console.WriteLine(Faecher[i].Name + ": " + Faecher[i].getDSN());
                sum += Faecher[i].getDSN();

                if (Faecher[i].getDSN() > 4)
                {
                    count++;
                }
            }

            Console.WriteLine("Durchschnittsnote: " + (int)(sum / Faecher.Length));

            if ((int)(sum / Faecher.Length) > 4 || count > 2)
            {
                Console.WriteLine("Nicht versetzt");
            }
            else
            {
                Console.WriteLine("Versetzt");
            }
        }
    }
}
