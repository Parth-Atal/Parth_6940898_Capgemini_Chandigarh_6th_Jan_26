using System.Transactions;

namespace SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = Convert.ToInt32(Console.ReadLine());
            int root = (int)Math.Sqrt(input1);

            Console.WriteLine(root);

            int lower = root * root;
            int upper = (root + 1) * (root + 1);


            if(input1 - lower <= upper - input1)
            {
                Console.WriteLine(lower);
            }
            else
            {
                Console.WriteLine(upper);
            }

        }
    }
}
