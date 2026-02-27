using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Q4_HandsOn
{
    internal class MultSum
    {
        static int Sum(int[] arr1, int size)
        {
            int output1;

            int sum = 0;
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr1[i] < 0)
                {
                    output1 = -1;
                    return output1;
                }

                else
                {
                    if (arr1[i] % 5 == 0)
                    {
                        sum += arr1[i];
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            output1 = sum / count;

            return output1;
        }

        static void Main(string[] args)
        {
            int size;
            int output1;
            Console.Write("Enter the size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());

            if (size < 0)
            {
                output1 = -2;
            }
            else
            {
                int[] input1 = new int[size];
                Console.WriteLine("Enter the elements of the array: ");
                for (int i = 0; i < input1.Length; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                }

                output1 = Sum(input1, input1.Length);

                Console.Write("Input array: ");
                for (int i = 0; i < input1.Length; i++)
                {
                    Console.Write(input1[i] + " ");
                }

                Console.WriteLine();

                Console.WriteLine("Avg of multiples of 5 in the given array are: " + output1);


            }
        }
    }

}