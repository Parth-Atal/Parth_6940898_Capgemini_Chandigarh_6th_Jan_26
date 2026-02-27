namespace CountCouple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = 4;
            int Count = 0;
            int[] arr1 = [2, 2, 4, 0];

            for(int i = 1; i < arr1.Length; i++)
            {
                int temp = arr1[i - 1];
                if((temp + arr1[i])%input1 == 0)
                {
                    Count++;
                }
            }

            Console.WriteLine(Count);
        }
    }
}
