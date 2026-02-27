using System;

namespace SearchAndRem
{
    internal class Search
    {
        static int[] SearchAndRemove(int[] arr, int size, int num)
        {

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    return new int[] { -1 };
                }
            }

            bool found = false;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == num)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                return new int[] { -3 };
            }

            int[] temp = new int[size - 1];
            int k = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] != num)
                {
                    temp[k++] = arr[i];
                }
            }

            Array.Sort(temp);
            return temp;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            int[] output1;

            if (input2 < 0)
            {
                output1 = new int[] { -2 };
            }
            else
            {
                int[] input1 = new int[input2];

                Console.WriteLine("Enter the elements of the array:");
                for (int i = 0; i < input2; i++)
                {
                    input1[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Enter the search element: ");
                int input3 = Convert.ToInt32(Console.ReadLine());

                output1 = SearchAndRemove(input1, input2, input3);
            }

            Console.Write("Output: ");
            for (int i = 0; i < output1.Length; i++)
            {
                Console.Write(output1[i] + " ");
            }
        }
    }
}
