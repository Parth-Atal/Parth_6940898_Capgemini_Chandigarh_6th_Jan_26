using System.Text.RegularExpressions;

namespace PasswordValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$";

            Console.WriteLine(Regex.IsMatch(input, pattern)?"Valid Password":"Invalid Password");
        }
    }
}
