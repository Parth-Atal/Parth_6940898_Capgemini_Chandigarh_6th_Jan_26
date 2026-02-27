using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_HandsOn
{
    internal class CountMultiples
    {
        static int MultCount(int[] arr1, int size)
        {
            int output = 0;
            if(size < 0)
            {
                output = -2;
                return output;
            }

            int count = 0;
            for(int i = 0; i < size; i++)
            {
                if (arr1[i] < 0)
                {
                    output = -1;
                    return output;
                }

                else
                {
                    if (arr1[i]%3  == 0)
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            output = count;

            return output;
        }

        static void Main(string[] args)
        {
            int input2;
            Console.Write("Enter the size of the array: ");
            input2 = Convert.ToInt32(Console.ReadLine());

            int[] input1 = new int[input2];
            Console.Write("Enter the elements of the array: ");
            for (int i = 0; i < input1.Length; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int output1 = MultCount(input1, input1.Length);

            Console.Write("Input array: ");
            for(int i = 0; i < input1.Length; i++)
            {
                Console.Write(input1[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("No of multiples of 3 in the given array are: " + output1);
            

        }
    }
}
