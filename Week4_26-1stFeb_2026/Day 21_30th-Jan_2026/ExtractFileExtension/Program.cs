using System.Text.RegularExpressions;

namespace ExtractFileExtension
{
    internal class Program
    {
        public static string GetExtension(string input)
        {
            Match m = Regex.Match(input, @"\.([^.]+)$");
            return m.Success ? m.Groups[1].Value : "";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetExtension("Hello.pdf"));
        }
    }
}
