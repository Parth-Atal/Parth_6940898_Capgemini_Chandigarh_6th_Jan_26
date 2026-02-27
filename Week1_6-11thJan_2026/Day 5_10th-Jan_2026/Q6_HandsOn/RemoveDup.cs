using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_HandsOn
{
    internal class RemoveDup
    {
        static int[] RemDup(int[] arr, int size)
        {
            int[] output;
            int[] temp = new int[size];
            int k = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    output = new int[1];
                    output[0] = -1;
                    return output;
                }

                bool duplicate = false;
                for(int j = 0; j < k; j++)
                {
                    if (temp[j] == arr[i])
                    {
                        duplicate = true;
                        break;
                    }
                }

                if(duplicate == false)
                {
                    temp[k] = arr[i];
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

        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            int[] output;

            if (input2 < 0)
            {   
                output = new int[1];
                output[0] = -2;
                Console.WriteLine(output[0]);
                return;
            }

            int[] input1 = new int[input2];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }

             output = RemDup(input1, input2);

            Console.Write("Output array: ");
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i] + " ");
            }
        }
    }
}
