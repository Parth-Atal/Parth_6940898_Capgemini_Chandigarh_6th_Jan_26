using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Armstrong
        {
        static void Main(string[] args)
        {
            int number, output1, temp = 0, rem, sum = 0;
            Console.Write("Enter the number you wish to check Armstrong for: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                output1 = 1;
            }

            else if (number > 3)
            {
                output1 = -2;
            }

            else
            {
                while (number > 0)
                {
                    temp = number;
                    rem = number % 10;
                    sum += rem * rem * rem;
                    number = number / 10;

                }

                if (sum == temp)
                {
                    output1 = 1;
                }

                else
                {
                    output1 = 0;
                }

            }

            Console.WriteLine(output1);
        }

    }
}

