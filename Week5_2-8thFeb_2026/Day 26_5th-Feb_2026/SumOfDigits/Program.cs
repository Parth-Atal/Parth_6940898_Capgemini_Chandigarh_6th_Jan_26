namespace SumOfDigits
{
    internal class Program
    {
        public static int DigitSum(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DigitSum(input1));
        }
    }
}
