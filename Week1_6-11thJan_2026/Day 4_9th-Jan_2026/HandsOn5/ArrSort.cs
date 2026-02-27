using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrSort
{
    internal class ArrSort
    {
        public static int[] Sorting(int[] arr1, int[] arr2, int size1, int size2)
        {
            int[] output = new int[size1];

            if (size1 < 0 || size2 < 0)
            {
                output[0] = -2;
                return output;
            }

            for (int i = 0; i < size1; i++)
            {
                if (arr1[i] < 0 || arr2[i] < 0)
                {
                    output[0] = -1;
                    return output;
                }

                Array.Sort(arr1);
                Array.Sort(arr2);

                Array.Reverse(arr2);
            }


                for(int i = 0; i < size1; i++)
                {
                    output[i] = arr1[i] * arr2[size1 - 1 - i];
                }

                return output;
            }

        static void Main()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 9, 8, 7, 6, 5 };

            int size1 = arr1.Length;
            int size2 = arr2.Length;

            int[] output1 = Sorting(arr1, arr2, size1, size2);

            Console.Write("The elements of first array are: ");
            for (int i = 0;i < size1; i++)
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
