using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndAddElementArr
{
    internal class SortAndAdd
    {
        static int[] SortAdd(int[] arr, int size, int num)
        {
            int[] result;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    result = new int[1];
                    result[0] = -1;
                    return result;
                }
            }

            result = new int[size + 1];
            Array.Copy(arr, result, size);
            result[result.Length - 1] = num;
            Array.Sort(result);

            return result;
        }

        static void Main(string[] args)
        {
            {
                int x, num; 
                int[] output1;
                Console.Write("Enter the size of the array: ");
                x = Convert.ToInt32(Console.ReadLine());

                if (x < 0)
                {
                    output1 = new int[1];
                    output1[0] = -2;
                }
                else
                {

                    int[] input1 = new int[x];

                    Console.WriteLine("Enter the elements of the array: ");
                    for (int i = 0; i < x; i++)
                    {
                        input1[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.Write("Enter the element you wish to add to the array: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    

                    Console.Write("The elements of the input array are: ");
                    for (int i = 0; i < x; i++)
                    {
                        Console.Write(input1[i] + " ");
                    }
                    Console.WriteLine();

                    output1 = SortAdd(input1, x, num);

                    Console.Write("The output array is: ");
                    for(int i = 0; i < output1.Length; i++)
                    {
                        Console.Write(output1[i] + " ");
                    }
                }
                Console.WriteLine();


            }
        }

    }
}
