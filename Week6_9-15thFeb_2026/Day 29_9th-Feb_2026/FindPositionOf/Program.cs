namespace FindPositionOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of strings you wish to input: ");
            int n = Convert.ToInt32 (Console.ReadLine());

            for(int i  = 0; i < n; i++)
            {
                Console.Write("Enter Line " + i + 1 + ": ");
                string str1 = Console.ReadLine();

                int indexthe = str1.IndexOf("the");
                int indexof = str1.IndexOf("of");

                Console.WriteLine("Position of 'the': " + indexthe);
                Console.WriteLine("Position of 'of': " + indexof);

            }

        }
    }
}
