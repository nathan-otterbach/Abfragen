using System;
using Calculator;

internal class Program
{
    private static decimal GetValidInpt()
    {
        decimal number = 0;
        while (true)
        {
            try
            {
                number = decimal.Parse(Console.ReadLine());
                break;
            }
            catch (Exception ex) when
            (ex is FormatException || ex is ArgumentNullException || ex is OverflowException)
            {
                Console.WriteLine(ex);
            }
        }
        return number;
    }
    public static void Main(string[] args)
    {
        Calculate calc = new Calculate();

        Console.WriteLine("Gib eine Zahl ein:");
        calc.a = GetValidInpt();
        
        Console.WriteLine("Gib noch eine Zahl ein:");
        calc.b = GetValidInpt();

        Console.WriteLine("Rechenoperator eingeben:");
        calc.op = Console.ReadLine();

        if (!string.IsNullOrEmpty(calc.op))
        {
            switch (calc.op.ToLower())
            {
                case "addieren":
                case "add":
                case "+":
                    Console.WriteLine($"Ergebnis: {calc.add(calc.a, calc.b)}");
                    break;

                case "subtrahieren":
                case "subtract":
                case "-":
                    Console.WriteLine($"Ergebnis: {calc.subtract(calc.a, calc.b)}");
                    break;

                case "multiplizieren":
                case "multiply":
                case "*":
                    Console.WriteLine($"Ergebnis: {calc.multiply(calc.a, calc.b)}");
                    break;

                case "dividieren":
                case "divide":
                case ":":
                case "/":
                    if (calc.b == 0)
                    {
                        Console.WriteLine("Division durch 0 nicht möglich!");
                        return;
                    }

                    Console.WriteLine($"Ergebnis: {calc.divide(calc.a, calc.b)}");
                    break;

                case "modulo":
                case "%":
                    Console.WriteLine($"Ergebnis: {calc.modulo((int)calc.a, (int)calc.b)}");
                    break;

                case "logarithmus":
                case "log":
                    Console.WriteLine($"Ergebnis: {calc.logarithmus(calc.a, calc.b)}");
                    break;

                case "power":
                case "pow":
                case "^":
                    Console.WriteLine($"Ergebnis: {calc.power(calc.a, calc.b)}");
                    break;
            }
        }
    }
}