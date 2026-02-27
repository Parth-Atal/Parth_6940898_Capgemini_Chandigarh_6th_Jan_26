using System.Text.RegularExpressions;

namespace LocationCodeUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = "CAP-HYD-1234";
            string input2 = "BAN";

            Console.WriteLine("Original Input: " + input1);

            Match m1 = Regex.Match(input1, @"-\w+-");

            input1 = input1.Replace(m1.Value, "-" + input2 + "-");

            Console.WriteLine("Updated Input: " + input1);

        }
    }
}
