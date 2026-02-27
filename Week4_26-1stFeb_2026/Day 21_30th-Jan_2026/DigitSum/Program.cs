using System;
using System.Text.RegularExpressions;

namespace DigitSum
{
    public class Program
    {
        public static int SumOfDigits(string[] input1)
        {
            int sum = 0;

            for (int i = 0; i < input1.Length; i++)
            {
                if (Regex.IsMatch(input1[i], @"[^a-zA-Z0-9]"))
                {
                    return -1; 
                }

                MatchCollection matches = Regex.Matches(input1[i], @"\d");

                foreach (Match m in matches)
                {
                    sum += int.Parse(m.Value);
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int input1;
            Console.Write("Enter the size of the string array you wish to enter: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            string[] input2 = new string[input1];

            Console.WriteLine("Enter the elements of the String Array: ");
            for(int i =0 ; i < input1 ; i++)
            {
                input2[i] = Console.ReadLine();
            }

            Console.Write("The input array is: ");
            for(int i  = 0; i < input1; i++)
            {
                Console.Write(input2[i] + " ");
            }

            Console.WriteLine();

            Console.Write("The sum of digits is: ");
            Console.WriteLine(SumOfDigits(input2)); 
        }
    }
}
