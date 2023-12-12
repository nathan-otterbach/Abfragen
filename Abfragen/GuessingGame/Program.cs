internal class Program
{
    private static double beitrag = 0;
    private static byte zinssatz = 0;

    private static double k = 0;
    private static byte p = 0;
    private static double z = 0;

    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bitte Betrag eingeben: ");
            beitrag = double.Parse(Console.ReadLine());

            Console.WriteLine("Bitte Zinssatz eingeben: ");
            zinssatz = byte.Parse(Console.ReadLine());

            if (CalculateZins(zinssatz) <= 0)
            {
                Console.WriteLine("Bitte validen Zinssatz eingeben!");
                Console.WriteLine(Environment.NewLine);
                break;
            }
            Console.WriteLine($"Die Jahreszinsen bei einem Beitrag von: {beitrag} betragen: {CalculateZins(zinssatz) * beitrag}");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Bitte Zielbetrag eingeben: ");

            k = CalculateZins(zinssatz) * beitrag + beitrag;
            z = double.Parse(Console.ReadLine());

            Console.WriteLine($"Es dauert {CalculateJahre(k, CalculateZins(zinssatz), z)} Jahre um ihren Wunschbetrag von {z} zu erreichen.");

            CalculateFrau();
        }
    }

    private static double CalculateZins(byte zinssatz)
    {
        switch (zinssatz)
        {
            case 0: return 0;
            case 1: return 0.01;
            case 2: return 0.02;
            case 3: return 0.03;
            case 4: return 0.04;
            case 5: return 0.05;
            default: return 0;
        }
    }

    private static int CalculateJahre(double k ,double p, double z)
    {
        double n = 0;
        n = (Math.Log(z / k)) / (Math.Log(1 + (p / 100)));

        return (int)n;
    }

    private static void CalculateFrau()
    {
        double k = 1000000;
        double p = 0.04;
        double rate = 60000;
        int n = 1;

        while(!(k <= 0))
        {
            k = k * Math.Pow((1 + p / 100), n);
            k = k - rate;
            n++;
        }
        Console.WriteLine(n);
    }
}