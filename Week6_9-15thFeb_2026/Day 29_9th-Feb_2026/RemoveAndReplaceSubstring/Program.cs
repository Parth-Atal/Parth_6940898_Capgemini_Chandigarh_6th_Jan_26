namespace RemoveAndReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "HelloWorld";
            string str2 = "World";
            string str3 = "Universe";

            str1 = str1.Replace(str2, str3);

            Console.Write(str1);
            
        }
    }
}
