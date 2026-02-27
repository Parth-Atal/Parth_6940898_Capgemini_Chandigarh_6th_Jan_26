namespace PerfectShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            int[] arr1 = new int[256];

            foreach(var item in x)
            {
                arr1[item]++;
            }

            foreach(var item in y)
            {
                arr1[item]++;
            }

            foreach(var item in z)
            {
                arr1[item]--;
            }

            bool check = true;

            foreach(var count in arr1)
            {
                if(count != 0)
                {
                    check = false;
                }
            }

            Console.WriteLine(check ? "Perfect Shuffle" : "Invalid Shuffle");
        }
    }
}
