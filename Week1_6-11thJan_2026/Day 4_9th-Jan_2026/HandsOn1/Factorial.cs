using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Factorial
    {
        public int Fact(int x)
        {
            if (x == 1 || x == 0)
            {
                return 1;
            }

            else
            {
                return x * Fact(x - 1);
            }

        }

        static void Main(string[] args)
        {
            int number, output1;

            Factorial obj = new Factorial();

            Console.Write("Enter the number you need factorial of: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                output1 = -1;
            }

            else if (number <= 7)
            {
                output1 = obj.Fact(number);
            }

            else
            {
                output1 = -2;
            }

            Console.Write(output1);

        }

    }
}
