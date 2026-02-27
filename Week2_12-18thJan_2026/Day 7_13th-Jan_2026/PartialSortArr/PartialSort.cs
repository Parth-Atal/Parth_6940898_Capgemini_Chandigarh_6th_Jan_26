using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PartialSortArr
{
    internal class PartialSort
    {
        static int[] Sort(int[] arr, int size)
        {

            int mid = size / 2;
            
            Array.Sort(arr, 0, mid);
            
            Array.Sort(arr, mid, size - mid);

            Array.Reverse(arr, mid, size - mid);

            return arr;
        }

        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter the size of the array: ");
            x = Convert.ToInt32(Console.ReadLine());

            int[] output1;

            if (x < 0)
            {
                output1 = new int[1];
                output1[0] = -1;
            }
            else
            {

                int[] input = new int[x];

                Console.WriteLine("Enter the elements of the array: ");
                for (int i = 0; i < x; i++)
                {
                    input[i] = Convert.ToInt32(Console.ReadLine());
                }
                output1 = Sort(input, x);

                Console.Write("The elements of the input array are: ");
                for (int i = 0; i < x; i++)
                {
                    Console.Write(input[i] + " ");
                }

                Console.WriteLine();

                Console.Write("The output is: ");
                for (int i = 0; i < output1.Length; i++)
                {
                    Console.Write(output1[i] + " ");
                }
            }
        }
    }
}
