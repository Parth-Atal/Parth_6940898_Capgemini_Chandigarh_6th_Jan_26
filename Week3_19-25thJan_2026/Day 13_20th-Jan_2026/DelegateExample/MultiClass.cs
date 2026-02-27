using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate void Math(int x, int y);
    internal class MultiClass
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Add: " + (x + y));
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine("Sub: " + (x - y));
        }

        public void Mult(int x, int y)
        {
            Console.WriteLine("Mult: " + (x * y));
        }

        public void Div(int x, int y)
        {
            Console.WriteLine("Div: " + (x / y));
        }

    }
}
