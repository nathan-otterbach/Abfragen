using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        public decimal n1 { get; set;}
        public decimal n2 { get; set;}
        public string op { get; set;}

        public Calculate() { op = string.Empty; }

        public Calculate(decimal a, decimal b, string op)
        {
            this.n1 = a;
            this.n2 = b;
            this.op = op;
        }   
         
        public decimal add(decimal a, decimal b)
        {
            if (decimal.MaxValue < a + b) { throw new OverflowException(); }

            return a + b;
        }

        public decimal subtract(decimal a, decimal b)
        {
            if (decimal.MaxValue < a - b) { throw new OverflowException(); }

            return a - b;
        }

        public decimal multiply(decimal a, decimal b)
        {
            if (decimal.MaxValue < a * b) { throw new OverflowException(); }

            return a * b;
        }

        public decimal divide(decimal a, decimal b)
        {
            if (b == 0) { throw new DivideByZeroException(); }
            if (decimal.MaxValue < a / b) { throw new OverflowException(); }

            return Math.Round(a / b, 4);
        }

        public int modulo(decimal a, decimal b)
        {
            return (int)a % (int)b;
        }

        public decimal logarithmus(decimal a, decimal b)
        {
            return (decimal)Math.Log((double)a, (double)b);
        }   

        public decimal power(decimal a, decimal b)
        {
            return (decimal)Math.Pow((double)a, (double)b);
        }

        public bool isPrime(uint number)
        {
            if (number <= 1) { return false; }
            if (number == 2) { return true; }
            if (number % 2 == 0) { return false; }

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) { return false; }
            }

            return true;
        }

        public string getMonth(uint number)
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

        public string getName(string a)
        {
            switch (a)
            {
                case "d": 
                case "D": return "Daniel";
                default: return "Error";
            }
        }
    }
}
