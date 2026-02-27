using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinProduct
{
    internal class MaxMinProd
    {
        static int Product(int[] arr, int size)
        {
            int prod = 0;

            for(int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    prod = -1;
                    return prod;
                }
            }

            Array.Sort(arr);
            prod = arr[0] * arr[size-1];

            return prod;
        }

        static void Main(String[] args)
        {
            int input2;
            Console.Write("Enter the size of the array: ");
            input2 = Convert.ToInt32(Console.ReadLine());
            int[] input1 = new int[input2];
            int output = 0;
            if(input2 < 0)
            {
                output = -2;
            }

            else
            {
                Console.WriteLine("Enter the elements of the array: ");
                for(int i = 0; i < input2; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                }
                output = Product(input1, input2);
            }

            Console.Write("The elements of the input array are: ");
            for(int i = 0; i < input2; i++)
            {
                Console.Write(input1[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Output: " + output);
        }
    }
}
