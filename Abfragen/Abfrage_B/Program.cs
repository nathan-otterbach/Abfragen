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
        calc.n1 = GetValidInpt();
        
        Console.WriteLine("Gib noch eine Zahl ein:");
        calc.n2 = GetValidInpt();

        Console.WriteLine("Rechenoperator eingeben:");
        calc.op = Console.ReadLine();

        if (!string.IsNullOrEmpty(calc.op))
        {
            switch (calc.op.ToLower())
            {
                case "addieren":
                case "add":
                case "+":
                    Console.WriteLine($"Ergebnis: {calc.add(calc.n1, calc.n2)}");
                    break;

                case "subtrahieren":
                case "subtract":
                case "-":
                    Console.WriteLine($"Ergebnis: {calc.subtract(calc.n1, calc.n2)}");
                    break;

                case "multiplizieren":
                case "multiply":
                case "*":
                    Console.WriteLine($"Ergebnis: {calc.multiply(calc.n1, calc.n2)}");
                    break;

                case "dividieren":
                case "divide":
                case ":":
                case "/":
                    Console.WriteLine($"Ergebnis: {calc.divide(calc.n1, calc.n2)}");
                    break;

                case "modulo":
                case "%":
                    Console.WriteLine($"Ergebnis: {calc.modulo(calc.n1, calc.n2)}");
                    break;

                case "logarithmus":
                case "log":
                    Console.WriteLine($"Ergebnis: {calc.logarithmus(calc.n1, calc.n2)}");
                    break;

                case "power":
                case "pow":
                case "^":
                    Console.WriteLine($"Ergebnis: {calc.power(calc.n1, calc.n2)}");
                    break;

                default: Console.WriteLine($"Invalid operator");
                    break;
            }
        }
    }
}