using System.Text.RegularExpressions;

namespace ValidateHexCodes
{
    internal class Program
    {
        public static bool IsValidHexColor(string input)
        {
            string pattern = @"^#[A-Fa-f0-9]{6}$";
            return Regex.IsMatch(input, pattern);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidHexColor("#FF5733"));
        }
    }
}
