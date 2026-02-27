using System;
using System.Collections.Generic;

namespace CommaSeperatedLists;

class Program
{
    static void Main()
    {
        // string[] firstInput = Console.ReadLine().Split(',');
        // string[] secondInput = Console.ReadLine().Split(',');

        string[] firstInput = { "5", "3", "4", "6" };
        string[] secondInput = { "5", "4", "2", "1", "4", "3", "3", "2", "5", "3" };

        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();

        // Convert first input to integer list
        for (int i = 0; i < firstInput.Length; i++)
        {
            firstList.Add(int.Parse(firstInput[i].Trim()));
        }

        // Convert second input to integer list
        for (int i = 0; i < secondInput.Length; i++)
        {
            secondList.Add(int.Parse(secondInput[i].Trim()));
        }

        // To avoid duplicate processing
        List<int> processed = new List<int>();

        for (int i = 0; i < firstList.Count; i++)
        {
            int n = firstList[i];

            // Skip if already processed
            bool alreadyProcessed = false;
            for (int k = 0; k < processed.Count; k++)
            {
                if (processed[k] == n)
                {
                    alreadyProcessed = true;
                    break;
                }
            }

            if (alreadyProcessed)
                continue;

            processed.Add(n);

            int sum = 0;

            // Calculate sum of occurrences in second list
            for (int j = 0; j < secondList.Count; j++)
            {
                if (secondList[j] == n)
                {
                    sum += secondList[j];
                }
            }

            Console.WriteLine(n + "-" + sum);
        }
    }
}