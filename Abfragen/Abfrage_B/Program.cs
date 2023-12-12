using System;

namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ICalculator calc = new Calculator(); // Creating an instance of the Calculator class

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Perform calculations");
                Console.WriteLine("2. Check if a number is prime");
                Console.WriteLine("3. Get month name based on a number");
                Console.WriteLine("4. Get discount based on costumer status");
                Console.WriteLine("0. Exit");
                Console.WriteLine(Environment.NewLine);

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 4)
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                }

                switch (choice)
                {
                    case 1:
                        PerformCalculations(calc);
                        break;
                    case 2:
                        CheckPrime(calc);
                        break;
                    case 3:
                        GetMonth(calc);
                        break;
                    case 4:
                        GetRabatt(calc);
                        break;
                    case 0:
                        return;
                }
            }
        }

        private static void PerformCalculations(ICalculator calculator)
        {
            string operationChoice = "";

            while (true)
            {
                Console.WriteLine("Enter an operator: ");
                operationChoice = Console.ReadLine()?.ToLower();
                if (IsValidOperation(operationChoice))
                {
                    break;
                }
                Console.WriteLine("Invalid choice. Please enter a valid operation.");
            }

            IUserInput<decimal> decimalInput = new UserInput<decimal>(
                () => decimal.Parse(Console.ReadLine()), // Parsing method for int input
                "Enter an decimal value: ",
                "Error while parsing integer input"
            );

            decimal number1 = decimalInput.GetValidInput();
            decimal number2 = decimalInput.GetValidInput();
            decimal result = 0;

            switch (operationChoice)
            {
                case "addieren":
                case "add":
                case "+":
                    result = calculator.Add(number1, number2);
                    break;
                case "subtrahieren":
                case "subtract":
                case "-":
                    result = calculator.Subtract(number1, number2);
                    break;
                case "multiplizieren":
                case "multiply":
                case "*":
                    result = calculator.Multiply(number1, number2);
                    break;
                case "dividieren":
                case "divide":
                case ":":
                case "/":
                    result = calculator.Divide(number1, number2);
                    break;
                case "modulo":
                case "%":
                    result = calculator.Modulo(number1, number2);
                    break;
                case "logarithmus":
                case "log":
                    result = calculator.Logarithm(number1, number2);
                    break;
                case "power":
                case "pow":
                case "^":
                    result = calculator.Power(number1, number2);
                    break;
            }

            Console.WriteLine($"Result of the operation: {result}");
            Console.WriteLine(Environment.NewLine);
        }

        // Additional helper method to validate the operation choice
        private static bool IsValidOperation(string operation)
        {
            switch (operation)
            {
                case "addieren":
                case "add":
                case "+":
                case "subtrahieren":
                case "subtract":
                case "-":
                case "multiplizieren":
                case "multiply":
                case "*":
                case "dividieren":
                case "divide":
                case ":":
                case "/":
                case "modulo":
                case "%":
                case "logarithmus":
                case "log":
                case "power":
                case "pow":
                case "^":
                    return true;
                default:
                    return false;
            }
        }

        private static void CheckPrime(ICalculator calculator)
        {
            // Check if a number is prime based on user input
            IUserInput<ulong> ulongInput = new UserInput<ulong>(
                () => ulong.Parse(Console.ReadLine()), // Parsing method for int input
                "Enter an ulong value: ",
                "Error while parsing integer input"
            );

            ulong number = ulongInput.GetValidInput();

            // Check if the number is prime using the calculator method
            // Example:
            bool isPrime = calculator.IsPrime(number);

            Console.WriteLine($"Is {number} a prime number? {isPrime}");
            Console.WriteLine(Environment.NewLine);
        }

        private static void GetMonth(ICalculator calculator)
        {
            // Get the month name based on user input
            // Example:
            IUserInput<byte> byteInput = new UserInput<byte>(
                () => byte.Parse(Console.ReadLine()), // Parsing method for uint input
                "Enter a byte value: ",
                "Error while parsing unsigned integer input"
            );

            byte number = byteInput.GetValidInput();

            // Get the month name using the calculator method
            // Example:
            string month = calculator.GetMonth(number);

            Console.WriteLine($"Month for number {number}: {month}");
            Console.WriteLine(Environment.NewLine);
        }

        private static void GetRabatt(ICalculator calculator)
        {
            // Get the costumer status based on user input
            // Example:
            IUserInput<byte> byteInput = new UserInput<byte>(
                () => byte.Parse(Console.ReadLine()), // Parsing method for uint input
                "Enter a byte value: ",
                "Error while parsing unsigned integer input"
            );

            byte number = byteInput.GetValidInput();

            double rabatt = calculator.GetRabatt(number);
            if (rabatt >= 0) 
            {
                Console.WriteLine($"With costumer status {number}: {rabatt}");
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}