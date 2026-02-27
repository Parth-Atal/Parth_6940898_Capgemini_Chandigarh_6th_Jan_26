namespace ClosestRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = Convert.ToInt32(Console.ReadLine());

            int initial = Convert.ToInt32(Math.Sqrt(input1));
            Console.WriteLine(initial);

            int sqr1 = (initial + 1) * (initial + 1);

            int sqr2 = (initial) * (initial);

            int ans = 0;

            if((input1 - sqr2) < (sqr1 - input1))
            {
                ans = sqr2;
            }
            else
            {
                ans = sqr1;
            }

            Console.WriteLine(ans);
        }
    }
}
