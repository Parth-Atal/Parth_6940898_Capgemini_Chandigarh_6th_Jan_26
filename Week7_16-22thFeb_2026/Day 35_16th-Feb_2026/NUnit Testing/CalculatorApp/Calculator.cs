using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return (x - y);
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        public int div(int x, int y)
        {
            return (x / y);
        }
    }
}
