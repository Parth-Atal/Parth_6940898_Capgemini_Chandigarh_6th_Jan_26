using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterElementArr
{
    internal class GreaterElement
    {
        public static int[] Compare(int[] arr1, int[] arr2, int size1, int size2)
        {
            int[] output = new int[size2];

            if (size1 < 0 || size2 < 0)
            {
                output[0] = -2;
                return output;
            }

            for (int i = 0; i < size1; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    output[i] = arr2[i];
                }
                else
                {
                    output[i] = arr1[i];
                }
            }

            return output;
        }


    static void Main(string[] args)
        {
            int[] arr1 = { 1, 7, 3, 9, 6 };
            int[] arr2 = { 2, 8, 7, 6, 5 };

            int size1 = arr1.Length;
            int size2 = arr2.Length;

            int[] output1 = Compare(arr1, arr2, size1, size2);

            Console.Write("The elements of first array are: ");
            for (int i = 0; i < size1; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            Console.Write("The elements of second array are: ");
            for (int i = 0; i < size2; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Output Array: ");
            for (int i = 0; i < size2; i++)
            {
                Console.Write(output1[i] + " ");
            }
        }
    }
}

