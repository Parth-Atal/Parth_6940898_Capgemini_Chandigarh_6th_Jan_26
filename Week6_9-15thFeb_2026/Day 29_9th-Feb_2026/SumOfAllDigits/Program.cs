namespace SumOfAllDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32 (Console.ReadLine());

            int sum = 0;

            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
