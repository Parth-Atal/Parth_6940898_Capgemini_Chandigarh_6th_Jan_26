using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BinaryConversion
{
    internal class BinaryToDec
    {
        static int ConvertDec(int num)
        {
            int count = 0;
            int sum = 0;
            while(num > 0)
            {
                sum += Convert.ToInt32((num % 10 * Math.Pow(2, count)));
                num /= 10;
                count++;

            }

            return sum;
        }

        static void Main(string[] args)
        {
            int input1, output1;
            bool binary = true;
            Console.Write("Enter the binary number you wish to convert to Decimal: ");
            input1 = Convert.ToInt32(Console.ReadLine());
            int temp = input1;

            while(input1 > 0)
            {
                if(input1 % 10 != 0 && input1 % 10 != 1)
                {
                    binary = false;
                    break;
                }
                input1 = input1 / 10;
            }

            if (binary == false)
            {
                output1 = -1;
            }

            else if (temp > 11111)
            {
                output1 = -2;
            }

            else
            {
                output1 = ConvertDec(temp);
            }

            Console.WriteLine("Decimal Value: " + output1);
        }

    }
}
