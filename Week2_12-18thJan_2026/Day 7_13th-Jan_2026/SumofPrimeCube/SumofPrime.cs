using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofPrimeCube
{
    internal class SumofPrime
    {
        static int Sum(int n)
        {
           
            if (n < 0)
            {
                return -1;
            }

            
            if (n > 32767)
            {
                return -2;
            }

            int i = 1;
            int sum = 0;
            while (i <= n)
            {
                if (IsPrime(i))
                {
                    sum += i * i * i;
                }

                i++;
            }

            return sum;
        }
        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the limit n: ");
            n = Convert.ToInt32(Console.ReadLine());

            int output1 = Sum(n);
            Console.WriteLine("Output: " + output1);
        }


    }
}
