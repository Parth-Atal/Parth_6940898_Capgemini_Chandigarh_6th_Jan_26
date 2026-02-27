using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_HandsOn
{
    internal class CurrencyCount
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 500, 100, 50, 10, 1 };
            int output = 0;
            int count = 0;
            int input = 689;

            for(int i = 0; i < arr1.Length; i++)
            {
                while (arr1[i] <= input)
                {
                    input = input - arr1[i];
                    count++;
                }

            }

            output = count;
            Console.WriteLine(output);
        }
    }
}
