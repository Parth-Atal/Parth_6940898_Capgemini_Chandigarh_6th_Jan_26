using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofOddDigit
{
    internal class OddDigSum
    {
        public static int Calculate(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                if((num%10) % 2 != 0)
                {
                    sum += (num % 10) * (num % 10);
                    
                }

                num = num / 10;
            }

            return sum;
        }

        static void Main(String[] args)
        {
            int num, output;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num < 0)
            {
                output = -1;
            }
            else
            {
                output = Calculate(num);
            }

            Console.WriteLine("Output: " + output);
        }
    }
}
