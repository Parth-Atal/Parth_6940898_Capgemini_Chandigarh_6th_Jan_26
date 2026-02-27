using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingDigits
{
    internal class CountingDigits
    {
        static void Main(string[] args)
        {
            int number, output1, count = 0; ;
            Console.Write("Enter the number you wish to count the digits of: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                output1 = -1;
            }
            else
            {

                while (number > 0)
                {
                    number = number / 10;
                    count++;
                }
            }

            output1 = count;
            Console.WriteLine(output1);
        }
    }
}
