using System.Text.RegularExpressions;

namespace InputPresent
{
    internal class Program
    {
        public static bool CheckOrder(string input1, string input2, string input3)
        {
            if (string.IsNullOrEmpty(input1) ||
                string.IsNullOrEmpty(input2) ||
                string.IsNullOrEmpty(input3))
                return false;

            string pattern = input2 + " " + input3;
            return Regex.IsMatch(input1, pattern);
        }
        static void Main(string[] args)
        {
            string input1 = "Hello I am Parth";
            string input2 = "am";
            string input3 = "Parth";

            Console.WriteLine(CheckOrder(input1, input2, input3));
            
        }
    }
}
