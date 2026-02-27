namespace FindFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 54;

            int count = 0;

            for(int i = 1; i <= n / 2; i++)
            {
                if(54 % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
