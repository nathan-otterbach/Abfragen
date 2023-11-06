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
        public decimal a;
        public decimal b;
        public string op;

        public Calculate() 
        {
            a = 0;
            b = 0;
            op = string.Empty;
        }
         
        public decimal add(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal subtract(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal multiply(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal divide(decimal a, decimal b)
        {
            return a / b;
        }

        public int modulo(int a, int b)
        {
            return a % b;
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
