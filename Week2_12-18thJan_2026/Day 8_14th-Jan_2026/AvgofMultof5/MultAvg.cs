using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvgofMultof5
{
    internal class MultAvg
    {
        public static float Calculate(int num)
        {
            float avg = 0, count = 0, sum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 5 == 0)
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
            int input1;
            float output;
            Console.Write("Enter the limit: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            if (input1 < 0)
            {
                output = -1;
            }
            else if (input1 > 500)
            {
                output = -2;
            }
            else
            {
                output = Calculate(input1);
            }

            Console.WriteLine("Output: " + output);
        }
    }
}
