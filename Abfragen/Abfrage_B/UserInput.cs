using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class UserInput
    {
        private bool _bool;

        private sbyte _sbyte;

        private decimal _decimal;
        private double _double;
        private float _float;


        private int _int;
        private short _short;

        private byte _byte;
        private ushort _ushort;
        private uint _uint;
        private ulong _ulong;

        private string _string;

        public UserInput() { }

        public decimal getValidUserInput()
        {
            while (true)
            {
                try
                {
                    _decimal = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex) when
                (ex is FormatException || ex is ArgumentNullException || ex is OverflowException)
                {
                    Console.WriteLine(ex);
                }
            }
            return _decimal;
        }
    }
}
