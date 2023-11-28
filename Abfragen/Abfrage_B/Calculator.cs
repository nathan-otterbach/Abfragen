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
    }
}
