using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EvenSum
{
    internal class EvenSum
    {
        static int CalculateSum(int number)
        {
            int output = 0;
            if(number < 0)
            {
                output = -1;
                return output;
            }
            if(number >= 32767)
            {
                output = -2;
                return output;
            }

            while(number > 0)
            {
                if((number%10)%2 == 0)
                {
                    output += number % 10;
                    number = number / 10;
                }
                else
                {
                    number = number / 10;
                }
            }
            return output;
        }

        static void Main(string[] args)
        {
            int number, output1;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            output1 = CalculateSum(number);

            Console.WriteLine("The sum of Even Digits of the number is: " + output1);
        }

    }
}
