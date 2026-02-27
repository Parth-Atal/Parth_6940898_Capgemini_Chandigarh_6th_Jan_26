namespace RegExPractice
{
    
   public static class StringExtensions
      {
         public static int WordCount(this string str)
            {
                return str.Split(' ').Length;
            }
        }

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(text.WordCount());


        }
    }
}
