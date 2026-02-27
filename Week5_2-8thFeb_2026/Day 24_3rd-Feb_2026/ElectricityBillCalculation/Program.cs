using System.Text.RegularExpressions;

namespace ElectricityBillCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = "AAAAA12345";
            string input2 = "AAAAA23456";
            int input3 = 4;

            Match m1 = Regex.Match(input1, @"\d+");

            Match m2 = Regex.Match(input2, @"\d+");

            int bill = Math.Abs((Convert.ToInt32(m1.Value) - Convert.ToInt32(m2.Value))) * input3;

            Console.WriteLine("Electricity Bill: " + bill);

        }
    }
}
