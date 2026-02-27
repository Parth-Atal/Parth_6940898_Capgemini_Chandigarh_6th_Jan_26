using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SecondLargestArr
{
    internal class SecondLargest
    {
        static int SecLargest(int[] arr1, int size)
        {
            int output;
            int[] temp = new int[size];

            int k = 0;
            for (int i = 0; i < size; i++)
            {
                bool duplicate = false;

                if (arr1[i] < 0)
                {
                    output = -1;
                    return output;
                }

                for (int j = 0; j < k; j++)
                {
                    if (arr1[i] == temp[j])
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (duplicate == false)
                {
                    temp[k] = arr1[i];
                    k++;
                }
            }
            Array.Sort(temp, 0 ,k);
            output = temp[k - 2];
            return output;
        }

        static void Main(String[] args)
        {
            int x, output1 = 0;
            Console.Write("Enter the size of the array: ");
            x = Convert.ToInt32(Console.ReadLine());

            if(x < 0)
            {
                output1 = -2;
            }
            else
            {

                int[] input1 = new int[x];

                Console.WriteLine("Enter the elements of the array: ");
                for (int i = 0; i < x; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                }
                output1 = SecLargest(input1, x);

                Console.Write("The elements of the input array are: ");
                for (int i = 0; i < x; i++)
                {
                    Console.Write(input1[i] + " ");
                }

            }
            Console.WriteLine();

            Console.Write("The Second Largest element of the array is: " + output1);
            
        }
    }
}
