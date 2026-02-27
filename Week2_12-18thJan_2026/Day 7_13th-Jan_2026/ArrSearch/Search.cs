using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArrSearch
{
    internal class Search
    {
        static int SearchArr(int[] arr1, int num)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < 0)
                {
                    return -1;
                }
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == num)
                {
                    return 1;
                }
            }

            return -3;
        }

        static void Main(string[] args)
        {
            int input2, output;

            Console.Write("Enter the size of the array: ");
            input2 = Convert.ToInt32(Console.ReadLine());

            if (input2 < 0)
            {
                output = -2;
                Console.WriteLine("Output: " + output);
                return;
            }

            int[] input1 = new int[input2];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int input3;
            Console.Write("Enter the element you wish to search: ");
            input3 = Convert.ToInt32(Console.ReadLine());

            output = SearchArr(input1, input3);

            Console.WriteLine("The element " + input3 + " is at index: " + output);
        }
    }
}
