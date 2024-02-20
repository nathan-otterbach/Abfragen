using Getraenke;

internal class Program
{
    private static void Main(string[] args)
    {
        Kasten kasten = new Kasten();

        Console.WriteLine($"Gewicht: {kasten.get_gesamt_gewicht()}");
    }
}