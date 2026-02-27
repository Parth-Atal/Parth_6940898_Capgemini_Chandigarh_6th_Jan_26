namespace RemoveDuplicateConsecutiveCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            bool dup = true;

           for(int i = 1; i < str1.Length; i++)
            {
                while (dup)
                {
                    if (str1[i] == str1[i - 1])
                    {
                        char c1 = str1[i];
                        char c2 = str1[i - 1];

                        str1.Remove(i - 1, i);
                    }
                }
            }

            Console.WriteLine(str1);
        }
    }
}
