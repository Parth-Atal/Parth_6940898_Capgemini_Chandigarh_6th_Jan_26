using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8_HandsOn
{
    internal class PerfectNumber
    {
        static int CheckPerfect(int num)
        {
            if(num < 0)
            {
                return -2;
            }

            int sum = 0;

            for(int i = 1; i <= num/2; i++)
            {
                if(num % i == 0)
                {
                    sum += i;
                }
            }

            if(sum == num || num != 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }


        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number you wish to check for Perfect Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            int output1 = CheckPerfect(num);
            Console.WriteLine("Output: " + output1);
        }
    }
}
