public class Program
{
    public static void Main(string[] args)
    {
        // Set the size of the triangle
        int n = 20;

        // Loop through the rows
        for (int i = 1; i <= n; i++)
        {
            // Loop through the columns
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{i * j, 4}"); // => ensure each number is printed in a 4-character wide space
            }
            // Move to the next line after completing a row
            Console.WriteLine();
        }
    }
}