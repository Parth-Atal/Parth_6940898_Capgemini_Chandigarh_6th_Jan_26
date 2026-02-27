namespace CharacterInsertAtSpecificPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            char c1 = Convert.ToChar(Console.ReadLine());
            int pos = Convert.ToInt32(Console.ReadLine());
            pos = pos - 1;

            string subs1 = str1.Substring(0, pos);
            subs1 = subs1 + c1;
            string subs2 = str1.Substring(pos);

            Console.WriteLine(subs1 + subs2);

        }
    }
}
