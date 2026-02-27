namespace RemoveLastOccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "I am a programmer. I learn at Codeforwin.";
            string str2 = "Codeforwin";

            str1 = str1.Remove(str1.LastIndexOf(str2), str2.Length);
            Console.WriteLine(str1);

        }
    }
}
