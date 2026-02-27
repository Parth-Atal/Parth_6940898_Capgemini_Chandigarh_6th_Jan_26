using System.Globalization;

namespace FindDay
{
    internal class Program
    {
        public static string DayFind(string input)
        {
            DateTime dt;
            DateTime.TryParseExact(
                input,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dt);

            dt = dt.AddYears(1);

            return dt.DayOfWeek.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DayFind("31/01/2025"));
        }
    }
}
