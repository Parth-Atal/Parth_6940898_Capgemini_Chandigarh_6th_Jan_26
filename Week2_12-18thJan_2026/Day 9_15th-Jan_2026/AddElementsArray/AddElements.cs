using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElementsArray
{
    internal class AddElements
    {
        public static int[] AddArr(int[] arr1, int[] arr2, int size)
        {
            int[] output = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (arr1[i] < 0 || arr2[i] < 0)
                {
                    return new int[] { -1 };
                }

                output[i] = arr1[i] + arr2[size - 1 - i];
            }

            return output;
        }


        static void Main(string[] args)
        {
            int input3;
            int[] output1 = new int[1];
            Console.Write("Enter the size of the array: ");
            input3 = Convert.ToInt32(Console.ReadLine());

            if (input3 < 0)
            {
                output1[0] = -1;
                Console.WriteLine("Output: " + output1[0]);
                return;
            }

            int[] input1 = new int[input3];
            Console.WriteLine("Enter the elements of first array: ");
            for (int i = 0; i < input3; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] input2 = new int[input3];
            Console.WriteLine("Enter the elements of second array: ");
            for (int i = 0; i < input3; i++)
            {
                input2[i] = Convert.ToInt32(Console.ReadLine());
            }

            output1 = new int[input3];

            output1 = AddArr(input1, input2, input3);


            Console.Write("The elements of first array are: ");
            for (int i = 0; i < input3; i++)
            {
                Console.Write(input1[i] + " ");
            }

            Console.WriteLine();

            Console.Write("The elements of second array are: ");
            for (int i = 0; i < input3; i++)
            {
                Console.Write(input2[i] + " ");
            }

            Console.WriteLine();

            Console.Write("The output array is: ");
            for (int i = 0; i < input3; i++)
            {
                Console.Write(output1[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
