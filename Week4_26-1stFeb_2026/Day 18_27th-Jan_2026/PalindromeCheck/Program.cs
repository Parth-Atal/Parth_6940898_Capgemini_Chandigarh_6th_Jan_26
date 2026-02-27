namespace PalindromeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "levels";
            char[] char1 = str1.ToCharArray();

            Array.Reverse(char1);

            string str2 = new string(char1);

            Console.WriteLine("The given string is: " + str1);

            if(str1 == str2)
            {
                Console.WriteLine("Palindrome!");
            }
            else
            {
                Console.WriteLine("Not Palindrome!");
            }

        }
    }
}
