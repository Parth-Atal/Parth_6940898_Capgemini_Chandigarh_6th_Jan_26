namespace VoteEligibility
{
    internal class Program
    {
        public static string CheckEligibility(int age)
        {
            if (age < 0)
                return "Invalid Age";

            if (age >= 18)
                return "Eligible to vote";

            return "Not eligible to vote";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CheckEligibility(19));
        }
    }
}
