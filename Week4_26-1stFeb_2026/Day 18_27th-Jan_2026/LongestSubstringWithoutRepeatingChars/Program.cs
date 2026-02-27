namespace LongestSubstringWithoutRepeatingChars
{
    internal class Program
    {
        public static bool IsFound(char c, string s)
        {
            char.ToLower(c);

            for (int i = 0; i < s.Length; i++)
            {
                if (c == char.ToLower(s[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string temp = "";
            temp += s[0];

            for (int i = 0; i < s.Length; i++)
            {
                if ((!IsFound(s[i], temp)))
                {
                    temp += s[i];
                }
            }

            Console.WriteLine(temp);
        }
    }

}