using System;

namespace TotalNumOfElements;

class Program
{
    static void Main()
    {
        string[] input = { "5", "10", "15" };

        int n = input.Length;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(input[i].Trim());
        }

        int count = 0;

        for (int i = 0; i < n; i++)
        {
            bool divisible = false;

            for (int j = 0; j < n; j++)
            {
                if (i != j)
                {
                    if (arr[i] % arr[j] == 0)
                    {
                        divisible = true;
                        break;
                    }
                }
            }

            if (!divisible)
            {
                count++;
            }
        }

        Console.WriteLine("Output: " + count);
    }
}