using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_HandsOn
{
    internal class DigProd
    {
        static int Calculate(int number)
        {
            

            if(number < 0)
            {
                
                return -1;
            }

            if(number%5 ==0 ||  number%3 == 0)
            {
                return -2;
            }

            int prod = 1;
            while(number > 0)
            {
                prod *= number % 10;
                number /= 10;

            }

            if(prod % 5 == 0 ||  prod % 3 == 0)
            {
                return 1;
                
            }
            return 0;
        }

        static void Main(String[] args)
        {
            int input1;
            Console.Write("Enter a number: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            int output1 = Calculate(input1);
            Console.WriteLine("Output: " + output1);


        }
    }
}
