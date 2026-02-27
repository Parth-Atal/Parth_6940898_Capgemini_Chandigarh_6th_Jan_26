using System;

namespace Couple;

class Program
{
    static void Main()
    {
        string[] input = { "1", "2", "3", "4" };

        int n = input.Length;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(input[i].Trim());
        }

        int score = 0;

        // Check couples
        for (int i = 0; i < n - 1; i++)
        {
            int sum = arr[i] + arr[i + 1];

            if (sum % 2 == 0)   // Even sum
            {
                score += 5;
            }
        }

        // Check triplets
        for (int i = 0; i < n - 2; i++)
        {
            int sum = arr[i] + arr[i + 1] + arr[i + 2];
            int product = arr[i] * arr[i + 1] * arr[i + 2];

            if (sum % 2 != 0 && product % 2 == 0)  // Odd sum AND even product
            {
                score += 10;
            }
        }

        Console.WriteLine("Final Score: " + score);
    }
}