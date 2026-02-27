using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOccurences
{
    internal class CountOccurence
    {
        static int Count(int[] arr1, int num)
        {
            int count = 0;
            for(int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < 0)
                {
                    return -1;
                } 
                if(arr1[i] == num)
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int input2, output;
            Console.Write("Enter the size of the array: ");
            input2 = Convert.ToInt32(Console.ReadLine());

            if(input2 < 0)
            {
                output = -2;
                Console.WriteLine("Output: " + output);
                return;
            }

            int[] input1 = new int[input2];

            Console.WriteLine("Enter the elements of the array: ");
            for(int i = 0; i < input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int input3;
            Console.WriteLine("Enter the element you wish to check occurences of: ");
            input3 = Convert.ToInt32(Console.ReadLine());

            if( input3 < 0)
            {
                output = -3;
                Console.WriteLine("Output: " + output);
                return;
            }

            output = Count(input1, input3);

            Console.WriteLine("No of occurences of " +  input3 +  " in the given array is: " + output);
        }
    }
}
