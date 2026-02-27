namespace RemoveFirstOccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();

            char ch = '.';

            char ch2 = '!';

            int rep = str1.IndexOf(ch);

            string sub1 = str1.Substring(0, rep);

            sub1 = sub1 + ch2;

            string sub2 = str1.Substring(rep + 1);

            Console.WriteLine(sub1 + sub2);



        }
    }
}
