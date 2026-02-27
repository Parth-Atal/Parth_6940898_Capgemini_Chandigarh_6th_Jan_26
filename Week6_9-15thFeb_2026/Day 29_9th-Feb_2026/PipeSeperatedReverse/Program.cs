namespace PipeSeperatedReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello|World|Orange";

            string[] str2 = str1.Split('|');
      
            for(int i = str2.Length - 1; i >= 0; i--)
            {
                Console.Write(str2[i] + "|");
            }
        }
    }
}
