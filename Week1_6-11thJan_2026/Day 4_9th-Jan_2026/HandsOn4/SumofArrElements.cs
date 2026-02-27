using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofArrElements
{
    internal class SumofArrElements
    {
        static int Calculate(int[]arr, int size)
        {
            if(size < 0)
            {
                return -1;
            }

            int evensum = 0;
            int oddsum = 0;

            for(int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    return -2;
                }

                if (arr[i] %2 == 0)
                {
                    evensum += arr[i];
                }
                else
                {
                    oddsum += arr[i];
                }
            }

            int avg = 0;
            avg = (evensum + oddsum) / 2;

            return avg;
        }
        static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int size = arr.Length;

            int output1 = Calculate(arr, size);

            Console.WriteLine("Output: " + output1);
        }
    }
}
