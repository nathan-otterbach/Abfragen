using Formen;

public class Program
{
    public static List<Form> list = new List<Form>();

    public static void Main(string[] args)
    {
        Rechteck r1 = new Rechteck(101.15f, 50.24f);
        list.Add(r1);

        Dreieck d1 = new Dreieck(10.5f, 20.5f, 30.5f);
        list.Add(d1);

        Console.WriteLine("Umfang: " + list[0].berechne_umfang());
        Console.WriteLine("Fläche: " + list[0].berechne_flaeche());

        Console.WriteLine("Umfang: " + list[1].berechne_umfang());
        Console.WriteLine("Fläche: " + list[1].berechne_flaeche());
    }
}