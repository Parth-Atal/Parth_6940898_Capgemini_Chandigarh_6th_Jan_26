using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrSearch
{
    internal class ArrSearch
    {
        static int Search(int[] arr, int size, int element)
        {
            int output = 1;

            if (size < 0)
            {
                output = -2;
                return output;
            }

            for(int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    output = -1;
                    return output;
                }

                

                if (arr[i] == element)
                {
                    output = i;                  
                }

                else
                {
                    continue;
                }

            }
            return output;

        }

        static void Main(string[] args)
        {
            int[] arr1 = {1, 2, 3, 4};
            int size = arr1.Length;
            int element;

            Console.Write("The array is: ");
            foreach(int x in arr1)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();

            Console.Write("Enter the element you wish to search: ");
            element = Convert.ToInt32(Console.ReadLine());
            int output1 = Search(arr1, size, element);

            Console.WriteLine("The position of the element is at index " + output1);

        }
    }
}
