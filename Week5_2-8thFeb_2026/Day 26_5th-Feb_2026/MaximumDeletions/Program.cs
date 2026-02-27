using System.IO.Pipelines;

namespace MaximumDeletions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            int count = 0;

            for(int i = 1; i < str1.Length; i++)
            {
                char temp = str1[i-1];

                if (temp == str1[i])
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }

    }
}
