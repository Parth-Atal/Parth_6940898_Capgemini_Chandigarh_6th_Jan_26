namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello, I am Parth";
            char[] char1 = str1.ToCharArray();

            Array.Reverse(char1);   

            str1 = new string(char1);
            
            Console.Write(str1);
        }
    }
}
