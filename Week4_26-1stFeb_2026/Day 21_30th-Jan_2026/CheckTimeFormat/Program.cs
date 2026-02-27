using System.Text.RegularExpressions;

namespace CheckTimeFormat
{
    internal class Program
    {
        public static bool IsValidTime(string input)
        {
            string pattern = @"^(0[1-9]|1[0-2]):[0-5][0-9]\s(am|pm)$";
            return Regex.IsMatch(input, pattern);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidTime("12:05 am")?"Valid":"Invalid");
        }
    }
}
