using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_HandsOn
{
    internal class ArrPrimeSum
    {
        static int SumPrime(int[] arr1)
        {
            int size = arr1.Length;
            if(size < 0)
            {
                return -2;
            }

            int sum = 0;
            bool prime = false;
            for(int i = 0; i < size; i++)
            {
                if (arr1[i] < 0)
                {
                    return -1;
                }

                if (IsPrime(arr1[i]))
                {
                    sum += arr1[i];
                    prime = true;
                }
            }

            if(prime == false)
            {
                return -3;
            }

            return sum;

        }

        static bool IsPrime(int num)
        {
            if(num <= 1)
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
            Console.Write("Enter the size of the array: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            int[] input1 = new int[input2];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < input1.Length; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int output1 = SumPrime(input1);

            Console.WriteLine("Output = " + output1);
        }

    }
}
