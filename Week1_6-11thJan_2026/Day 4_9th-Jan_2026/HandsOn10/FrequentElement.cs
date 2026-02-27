using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentElement
{
    internal class FrequentElement
    {
        static int[] MostRepeated(int[] input)
        {
            int n = input.Length;
            int maxCount = 0;

            
            for (int i = 0; i < n; i++)
            {
                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (input[i] == input[j])
                        count++;
                }

                if (count > maxCount)
                    maxCount = count;
            }

            
            int[] output = new int[n];
            for (int i = 0; i < n; i++)
                output[i] = -1;

            int index = 0;

            
            for (int i = 0; i < n; i++)
            {
                int count = 1;
                bool alreadyadded = false;

                
                for (int k = 0; k < i; k++)
                {
                    if (input[i] == input[k])
                    {
                        alreadyadded = true;
                        break;
                    }
                }

                if (alreadyadded)
                    continue;

                for (int j = i + 1; j < n; j++)
                {
                    if (input[i] == input[j])
                        count++;
                }

                if (count == maxCount)
                {
                    output[index] = input[i];
                    index++;
                }
            }

            return output;
        }

        static void Main()
        {
            int[] input = { 2, 2, 2, 2, 3, 3, 3, 3, 4 };
            int size = input.Length;

            int[] output = MostRepeated(input);

            Console.Write("The given array is: ");
            for(int i = 0; i < size; i++)
            {
                Console.Write(input[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Output:");
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] != -1)
                    Console.Write(output[i] + " ");
            }
        }
    }
}
