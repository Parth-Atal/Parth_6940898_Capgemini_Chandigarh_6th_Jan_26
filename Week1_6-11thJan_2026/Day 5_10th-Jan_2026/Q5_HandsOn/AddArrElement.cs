using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_HandsOn
{
    internal class AddArrElement
    {
        static int[] Sum(int[] arr1, int[] arr2)
        {
            if(arr1.Length < 0 || arr2.Length < 0)
            {
                return new int[] { -2 };
            }

            int[] output = new int[arr1.Length];
            for(int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < 0 || arr2[i] < 0)
                {
                    return new int[] { -3 };
                }

                output[i] = arr1[i] + arr2[arr2.Length -1 -i];
            }

            return output;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int input3 = Convert.ToInt32(Console.ReadLine());

            if (input3 < 0)
            {
                Console.WriteLine("-2");
                return;
            }

            int[] input1 = new int[input3];
            int[] input2 = new int[input3];

            Console.WriteLine("Enter elements of first array:");
            for (int i = 0; i < input3; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter elements of second array:");
            for (int i = 0; i < input3; i++)
            {
                input2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] output = Sum(input1, input2);

            Console.Write("Output array: ");
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i] + " ");
            }
        }

    }
}
