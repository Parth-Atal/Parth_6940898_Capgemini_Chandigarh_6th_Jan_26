using System;

namespace FactorSum
{
    internal class Factors
    {
        public static int Calculate(int input1, int input2)
        {
            int sum = 0;

            for (int i = input1; i <= input2; i += input1)
            {
                sum += i;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int input1, input2;
            int output;

            Console.Write("Enter input1 (factor): ");
            input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter input2 (limit): ");
            input2 = Convert.ToInt32(Console.ReadLine());

            
            if (input1 < 0)
            {
                output = -1;
            }
            else if (input2 > 32627)
            {
                output = -2;
            }
            else
            {
                output = Calculate(input1, input2);
            }

            Console.WriteLine("Output: " + output);
        }
    }
}
