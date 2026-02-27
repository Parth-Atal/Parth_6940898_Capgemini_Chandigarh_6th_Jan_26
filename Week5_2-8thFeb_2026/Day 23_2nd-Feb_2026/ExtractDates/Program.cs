using System.Text.RegularExpressions;

namespace ExtractDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\d{2}/\d{2}/\d{4}";

            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                Console.WriteLine("Valid Date: " + match.Value);
            }
            else
            {
                Console.WriteLine("No Valid Date Found");
            }

        }
    }
}
