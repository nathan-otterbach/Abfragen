using System;
using Calculator;

internal class Program
{
    public static void Main(string[] args)
    {
        Calculate calc = new Calculate();
        UserInput input = new UserInput();

        Console.WriteLine("Gib eine Zahl ein:");
        calc.n1 = input.getValidUserInput_int();

        Console.WriteLine(calc.getMonth((uint)calc.n1));

        //if (calc.isPrime((uint)calc.n1))
        //{
        //    Console.WriteLine("prime");
        //}
        //else
        //{
        //    Console.WriteLine("not prime");
        //}

        //Console.WriteLine("Gib eine Zahl ein:");
        //calc.n1 = input.getValidUserInput();
        
        //Console.WriteLine("Gib noch eine Zahl ein:");
        //calc.n2 = input.getValidUserInput();

        //Console.WriteLine("Rechenoperator eingeben:");
        //calc.op = Console.ReadLine();

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