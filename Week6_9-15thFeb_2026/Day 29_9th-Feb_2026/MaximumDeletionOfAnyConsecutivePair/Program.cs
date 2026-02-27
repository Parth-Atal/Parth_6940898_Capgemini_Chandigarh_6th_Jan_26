namespace MaximumDeletionOfAnyConsecutivePair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();

            int count = 0;

            for(int i = 1; i < str1.Length; i++)
            {
                if (str1[i] == str1[i - 1])
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}
