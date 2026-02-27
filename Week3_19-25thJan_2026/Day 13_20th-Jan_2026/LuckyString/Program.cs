namespace LuckyString
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int len = s.Length;

            if (n > len)
            {
                Console.WriteLine("Invalid");
                return;
            }

            for (int i = 0; i <= len - n; i++)
            {
                bool validChars = true;
                int maxConsecutive = 1;
                int currentCount = 1;

                for (int j = i; j < i + n; j++)
                {
                    char c = s[j];

                    if (c != 'P' && c != 'S' && c != 'G')
                    {
                        validChars = false;
                        break;
                    }

                    if (j > i && s[j] == s[j - 1])
                    {
                        currentCount++;
                        maxConsecutive = Math.Max(maxConsecutive, currentCount);
                    }
                    else
                    {
                        currentCount = 1;
                    }
                }

                if (validChars && maxConsecutive >= n / 2)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }

            Console.WriteLine("No");
        }
    }
}
 