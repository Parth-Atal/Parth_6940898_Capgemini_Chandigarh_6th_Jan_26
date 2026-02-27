using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Q1_HandsOn
{
    internal class RemoveDuplicates
    {
        static int[] RemDup(int[] arr1, int size)
        {
            int[] output;
            int[] temp = new int[size];
            
            int k = 0;
            for(int i = 0;i < size; i++)
            {
                bool duplicate = false;

                if (arr1[i] < 0)
                {
                    output = new int[1];
                    output[0] = -1;
                    return output;
                }

                for(int j = 0; j < k; j++)
                {
                    if (arr1[i] == temp[j])
                    {
                        duplicate = true;
                        break;
                    }
                }

                if(duplicate == false)
                {
                    temp[k] = arr1[i];
                    k++;
                }
            }

            output = new int[k];
            for (int i = 0; i < k; i++)
            {
                output[i] = temp[i];
            }

            return output;
        }

        static void Main(String[] args)
        {
            int x;
            Console.Write("Enter the size of the array: ");
            x = Convert.ToInt32(Console.ReadLine());

            int[] input = new int[x];

            Console.WriteLine("Enter the elements of the array: ");
            for(int i = 0; i < x; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] output1 = RemDup(input, x);

            Console.Write("The elements of the input array are: ");
            for(int i = 0; i < x; i++)
            {
                Console.Write(input[i] + " ");
            }

            Console.WriteLine();

            Console.Write("The output is: ");
            for(int i = 0; i < output1.Length; i++)
            {
                Console.Write(output1[i] + " ");
            }
        }
    }
}
