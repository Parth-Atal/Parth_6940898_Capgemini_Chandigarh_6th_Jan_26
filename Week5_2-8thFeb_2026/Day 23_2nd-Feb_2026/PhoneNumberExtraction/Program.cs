using System;
using System.Text.RegularExpressions;

namespace PhoneNumberExtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b\d{10}\b";

            Match match = Regex.Match(input, pattern);

            if (match.Success)
                Console.WriteLine("Valid Number: " + match.Value);
            else
                Console.WriteLine("No valid number found");
        }
    }
}
