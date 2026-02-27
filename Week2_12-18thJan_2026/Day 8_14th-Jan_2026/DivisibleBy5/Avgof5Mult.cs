using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy5
{
    internal class Avgof5Mult
    {
        public static float Calculate(int num)
        {
            float avg = 0, count = 0, sum = 0;

            for(int i=1; i<=num; i++)
            {
                if(i%5 == 0)
                {
                    sum += i;
                    count++;
                }
            }

            avg = sum / count;

            return avg;
        }

        static void Main(string[] args)
        {
            int num; 
            float output;
            Console.Write("Enter the limit: ");
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
