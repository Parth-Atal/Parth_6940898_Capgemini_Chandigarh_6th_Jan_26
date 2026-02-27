using System.Text.RegularExpressions;

namespace ContainsNumericOnly
{
    internal class Program
    {
        public static int CheckNumeric(string[] input)
        {
            string pattern = @"^-?\d+(\.\d+)?$";

            foreach (string s in input)
            {
                if (!Regex.IsMatch(s, pattern))
                    return -1;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CheckNumeric(["24", "Hello"]));
        }
    }
}
