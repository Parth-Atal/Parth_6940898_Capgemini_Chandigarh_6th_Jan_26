using System.Text.RegularExpressions;

namespace EmailValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string pattern = @"^\w+@\w+\.\w+$";

            Console.WriteLine(Regex.IsMatch(email, pattern)?"Valid":"Invalid");
        }
    }
}
