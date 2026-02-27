using System.Text.RegularExpressions;

namespace RemoveRepeatingChar
{
    internal class Program
    {
        public static string RemoveRepeatedChars(string input)
        {
            HashSet<char> seen = new HashSet<char>();

            return Regex.Replace(input, ".", match =>
            {
                char c = match.Value[0];
                if (seen.Contains(c))
                    return "";
                seen.Add(c);
                return c.ToString();
            });
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveRepeatedChars("Hi This Is My Book"));
        }
    }
}
