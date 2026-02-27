using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveMult
{
    internal class PositiveMult
    {
        public static int mult(int[] arr1, int size)
        {
            int output = 1;

            if(size < 0)
            {
                output = -2;
                return output;
            }

            for(int i = 0; i < size; i++)
            {
                if(arr1[i] > 0)
                {
                    output *= arr1[i];
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
            int[] arr1 = { 1, 3, 5, -7, 10, -19 };
            int size = arr1.Length;

            int output1 = mult(arr1, size);

            Console.Write("The input array is: ");
            for(int i = 0; i < size; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
             
            Console.WriteLine("Output: " + output1);
        }
    }
}
