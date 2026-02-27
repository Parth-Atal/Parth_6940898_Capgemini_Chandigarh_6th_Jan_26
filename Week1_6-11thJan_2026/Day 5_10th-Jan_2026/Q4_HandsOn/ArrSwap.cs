using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_HandsOn
{
    internal class ArrSwap
    {
        static int[] Swap(int[] arr1)
        {
            int size = arr1.Length;
            int[] output = new int[1];
            if (size < 0)
            {
                output[0] = -2;
                return output;
            }

            if(size % 2 == 0)
            {
                output[0] = -3;
                return output;
            }

            int mid = size / 2;
            for(int i = 0; i < mid; i++)
            {
                if (arr1[i] < 0)
                {
                    output[0] = -1;
                    return output;
                }

                int temp = 0;
                temp = arr1[i];
                arr1[i] = arr1[size - 1 - i];
                arr1[size - 1 - i] = temp;
            }

            return arr1;

        }

        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            int[] input1 = new int[input2];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] output1 = Swap(input1);

            Console.Write("Output array: ");
            for (int i = 0; i < output1.Length; i++)
            {
                Console.Write(output1[i] + " ");
            }
        }

    }
}
