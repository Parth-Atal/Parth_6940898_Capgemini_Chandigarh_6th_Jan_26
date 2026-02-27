using System.Text.RegularExpressions;

namespace InvoiceNumUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = "CAP-123";
            int inc = 7;

            Match m1 = Regex.Match(input1, @"\d+");

            input1 = input1.Substring(0, 4);

            int new_num = Convert.ToInt32(m1.Value) + inc;

            input1 = input1 + Convert.ToString(new_num);

            Console.WriteLine(input1);

        }
    }
}
