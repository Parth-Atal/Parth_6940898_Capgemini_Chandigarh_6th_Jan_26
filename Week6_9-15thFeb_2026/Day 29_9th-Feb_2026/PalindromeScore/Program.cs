using System;

namespace PalindromeScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            int score = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                
                if (i + 3 < str1.Length)
                {
                    if (str1[i] == str1[i + 3] &&
                        str1[i + 1] == str1[i + 2])
                    {
                        score += 5;
                    }
                }

                // Check palindrome of length 5
                if (i + 4 < str1.Length)
                {
                    if (str1[i] == str1[i + 4] &&
                        str1[i + 1] == str1[i + 3])
                    {
                        score += 10;
                    }
                }
            }

            Console.WriteLine(score);
        }
    }
}
