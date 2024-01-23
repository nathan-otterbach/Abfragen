internal class Program
{
    private static void Main(string[] args)
    {
        int n = 20;
        int[,] zahlen_dreieck = new int[n+1, n+1];

        for (int i = 1; i < zahlen_dreieck.GetLength(0); i++)
        {
            for (int j = 1; j < zahlen_dreieck.GetLength(1); j++)
            {
                zahlen_dreieck[i, j] = i * j;
                Console.WriteLine($"{zahlen_dreieck[i, j]}");
            }
            Console.WriteLine();
        }
    }
}