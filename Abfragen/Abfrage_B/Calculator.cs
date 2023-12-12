namespace Calculator
{
    // Interface defining the calculator operations
    public interface ICalculator
    {
        decimal Add(decimal a, decimal b);          // Addition operation
        decimal Subtract(decimal a, decimal b);     // Subtraction operation
        decimal Multiply(decimal a, decimal b);     // Multiplication operation
        decimal Divide(decimal a, decimal b);       // Division operation
        int Modulo(decimal a, decimal b);           // Modulo operation
        decimal Logarithm(decimal a, decimal b);    // Logarithm operation
        decimal Power(decimal a, decimal b);        // Exponentiation operation
        bool IsPrime(ulong number);                 // Check if number is prime
        string GetMonth(byte number);               // Get month name based on number
        double GetRabatt(byte number);              // Get costumer discount based on costumer status
    }

    // Class implementing the calculator operations
    public class Calculator : ICalculator
    {
        // Addition operation
        public decimal Add(decimal a, decimal b)
        {
            checked
            {
                return a + b;
            }
        }

        // Subtraction operation
        public decimal Subtract(decimal a, decimal b)
        {
            checked
            {
                return a - b;
            }
        }

        // Multiplication operation
        public decimal Multiply(decimal a, decimal b)
        {
            checked
            {
                return a * b;
            }
        }

        // Division operation
        public decimal Divide(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero.");
            }

            checked
            {
                return a / b;
            }
        }

        // Modulo operation
        public int Modulo(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Divisor cannot be zero.");
            }

            checked
            {
                return (int)a % (int)b;
            }
        }

        // Logarithm operation
        public decimal Logarithm(decimal a, decimal b)
        {
            if (a <= 0 || b <= 0 || a == 1)
            {
                throw new ArgumentException("Logarithm base and number must be positive and not equal to 1.");
            }

            return (decimal)Math.Log((double)a, (double)b);
        }

        // Exponentiation operation
        public decimal Power(decimal a, decimal b)
        {
            if ((a == 0 && b <= 0) || (a < 0 && b != Math.Truncate(b)))
            {
                throw new ArgumentException("Invalid operation: base cannot be zero when exponent is zero or negative, and negative base cannot have a non-integer exponent.");
            }

            return (decimal)Math.Pow((double)a, (double)b);
        }

        // Check if number is prime
        public bool IsPrime(ulong number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number <= 3)
            {
                return true;
            }
            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            // Prime checking for numbers of the form 6k ± 1 up to square root of the number
            for (uint i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Get month name based on number
        public string GetMonth(byte number)
        {
            switch (number)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "Error";
            }
        }

        public double GetRabatt(byte costumer_status)
        {
            switch (costumer_status)
            {
                case 1: return 0.09;
                case 2: return 0.05;
                case 3: 
                case 4: return 0;
                default: Console.WriteLine("Invalid costumer status");
                         Console.WriteLine(Environment.NewLine);
                         return -1;
            }
        }
    }
}