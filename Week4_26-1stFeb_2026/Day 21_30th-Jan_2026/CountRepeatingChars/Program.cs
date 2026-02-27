using System.Text.RegularExpressions;

namespace CountRepeatingChars
{
    internal class Program
    {
        static int CountChars(string input)
        {
            MatchCollection match = Regex.Matches(input, @"(.)\1{2}");

            return match.Count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountChars("aaabbbcdddeeefffg"));
        }
    }
}
