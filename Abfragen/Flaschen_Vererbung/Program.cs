using Flaschen_Vererbung;

internal class Program
{
    private static void Main(string[] args)
    {
        //makeParty();
    }

    private static void makeParty()
    {
        Flasche[] arrFlasche = new Flasche[30];
        var rand = new Random();
        int gesamtgewicht = 0, gesamtGetrunken = 0;

        for (int i = 0; i < arrFlasche.Length; i++)
        {
            switch (i)
            {
                case < 10:
                    arrFlasche[i] = new Wasser
                    {
                        Maxmenge = 1500,
                        Fuellmenge = 1500,
                        Leergewicht = 200
                    };
                    break;
                case < 20:
                    arrFlasche[i] = new Bier
                    {
                        Maxmenge = 500,
                        Fuellmenge = 500,
                        Leergewicht = 150,
                        Zuckergehalt = 50
                    };
                    break;
                case < 30:
                    arrFlasche[i] = new Saft
                    {
                        Maxmenge = 1000,
                        Fuellmenge = 1000,
                        Leergewicht = 175,
                        Zuckergehalt = 30
                    };
                    break;
            }

            int getrunken = rand.Next(0, arrFlasche[i].Maxmenge);
            arrFlasche[i].trinken(getrunken);

            Console.WriteLine($"dieFlasche[{i}] - {arrFlasche[i].GetType().Name}, Maxmenge: {arrFlasche[i].Maxmenge} g, Fuellmenge: {arrFlasche[i].Fuellmenge} ml getrunken");

            gesamtgewicht += arrFlasche[i].getGewicht();
            gesamtGetrunken += getrunken;
        }

        arrFlasche.ToList().ForEach(flasche => flasche.speichern("flaschen.ini"));
        Console.WriteLine($"Gesamtgewicht: {gesamtgewicht} g, gesamt getrunkene Menge: {gesamtGetrunken} ml");
    }
}