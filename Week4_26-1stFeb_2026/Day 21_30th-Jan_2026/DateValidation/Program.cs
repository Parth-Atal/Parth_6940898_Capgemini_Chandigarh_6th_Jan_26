using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DateValidation
{
    internal class Program
    {
        public static string AddYears(string input, int years)
        {
            if(years < 0)
            {
                return "-2";
            }

            string pattern = @"^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-\d{4}$";

            if(!Regex.IsMatch(input, pattern))
            {
                return "-1";
            }

            DateTime dt;

            DateTime.TryParseExact(input, "dd-MM-yyyy", null,
            System.Globalization.DateTimeStyles.None, out dt);

            DateTime result = dt.AddYears(years);
            return result.ToString("dd-MM-yyyy");
        }

        static void Main(string[] args)
        {
            string date = "24-11-2020";
            int years = 5;

            Console.WriteLine(AddYears(date, years));
        }
    }
}


