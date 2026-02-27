using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenAvg
{
    internal class Password
    {
        static float AvgOddEven(int[] arr, int size)
        {
            int oddsum = 0, evensum = 0;
            for(int i = 0; i < size; i++)
            {

                if (arr[i] < 0)
                {
                    return -1;
                }


                if (arr[i] % 2 == 0)
                {
                    evensum += arr[i];
                }

                else
                {
                    oddsum += arr[i];
                }
            }

            float avg = (evensum + oddsum) / 2.0f;

            return avg;
        }

        static void Main(string[] args) 
        {
            int x;
            float output1 = 0;
            Console.Write("Enter the size of the array: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x < 0)
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
                output1 = AvgOddEven(input1, x);

                Console.Write("The elements of the input array are: ");
                for (int i = 0; i < x; i++)
                {
                    Console.Write(input1[i] + " ");
                }

            }
            Console.WriteLine();

            Console.Write("The Password is: " + output1);
        }

    }
}
