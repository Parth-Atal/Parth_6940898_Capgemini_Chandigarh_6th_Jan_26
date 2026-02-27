namespace InsertASubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C# Programming";
            string str2 = "ABC";
            int pos = 3;

            string sub1 = str1.Substring(0,pos);
            string sub2 = str1.Substring(pos);

            sub1 = sub1 + str2;

            str1 = sub1 + sub2;

            Console.WriteLine(str1);


        }
    }
}
