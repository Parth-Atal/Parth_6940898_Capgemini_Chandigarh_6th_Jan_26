namespace TotalCouplesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = 5;
            int[] input2 = [1,2,3,4,5];
            int count = 0;

            for(int i = 1; i < 4; i++)
            {
                if (((input2[i] + input2[i-1]) % input1) == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);   
        }
    }
}
