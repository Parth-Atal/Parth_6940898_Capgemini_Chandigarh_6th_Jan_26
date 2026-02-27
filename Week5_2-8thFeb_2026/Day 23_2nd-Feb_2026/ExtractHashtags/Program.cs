using System.Text.RegularExpressions;

namespace ExtractHashtags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"#\w+";

            MatchCollection match = Regex.Matches(input, pattern);

            Console.WriteLine("Hastags: ");

            foreach (Match m in match)
            {
                if (m.Success)
                {
                    Console.WriteLine(m.Value);
                }
                else
                {
                    Console.WriteLine("No Hashtag Available");
                }

            }
        }
    }
}
