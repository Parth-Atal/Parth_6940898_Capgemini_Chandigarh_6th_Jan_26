using System.Text.RegularExpressions;

namespace ValidatePassword
{
    internal class Program
    {
        public static int Validate(string input)
        {
            string pattern = @"^(?=[A-Za-z])(?=.*[A-Za-z])(?=.*\d)(?=.*[@#_])[A-Za-z\d@#_]{7,}[A-Za-z\d]$";
            return Regex.IsMatch(input, pattern) ? 1 : -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Validate("Parth@123*"));
        }
    }
}
