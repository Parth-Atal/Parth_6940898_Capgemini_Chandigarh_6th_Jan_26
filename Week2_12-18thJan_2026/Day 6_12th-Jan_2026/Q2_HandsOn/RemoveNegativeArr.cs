using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Q2_HandsOn
{
    internal class RemoveNegativeArr
    {
        static int[] RemoveNegative(int[] arr, int size)
        {
            int[] temp = new int[size];
            int k = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] >= 0)
                {
                    temp[k] = arr[i];
                    k++;
                }
            }

            int[] output = new int[k];
            for (int i = 0; i < k; i++)
            {
                output[i] = temp[i];
            }

            Array.Sort(output);
            return output;
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
                 output1 = RemoveNegative(input, x);

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
