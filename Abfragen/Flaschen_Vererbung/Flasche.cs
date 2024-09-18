

namespace Flaschen_Vererbung
{
    public class Flasche
    {
        private int maxmenge;
        private int fuellmenge;
        private int leergewicht;

        public Flasche() { }

        public Flasche(int maxmenge, int fuellmenge, int leergewicht) : this()
        {
            this.maxmenge = maxmenge;
            this.fuellmenge = fuellmenge;
            this.leergewicht = leergewicht;
        }

        public virtual int Maxmenge
        {
            get { return maxmenge; }
            set { maxmenge = value; }
        }

        public virtual int Fuellmenge
        {
            get { return fuellmenge; }
            set { fuellmenge = value; }
        }

        public virtual int Leergewicht
        {
            get { return leergewicht; }
            set { leergewicht = value; }
        }

        public virtual int getGewicht()
        {
            return leergewicht + fuellmenge;
        }

        public virtual void trinken(int menge)
        {
            if (menge > fuellmenge)
            {
                fuellmenge = 0;
            }
            else
            {
                fuellmenge -= menge;
            }
        }

        public virtual bool speichern(string fileName, int index = 0, int zuckergehalt = 0)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"[{this.GetType().Name}_{index}]");
                    sw.WriteLine($"maxmenge={maxmenge}");
                    sw.WriteLine($"fuellmenge={fuellmenge}");
                    sw.WriteLine($"leergewicht={leergewicht}");
                    if (zuckergehalt != 0)
                    {
                        sw.WriteLine($"zuckergehalt={zuckergehalt}");            
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        public virtual bool laden(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
    }
}
