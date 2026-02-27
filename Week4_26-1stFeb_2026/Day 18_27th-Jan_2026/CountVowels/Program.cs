namespace CountVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            char[] char1 = str1.ToCharArray();

            int count = 0;

            foreach(var v1 in char1)
            {
                if(v1 ==  'a' || v1 == 'e' || v1 == 'i' || v1 == 'o' || v1 == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine("The given string is  :" + str1);
            Console.WriteLine("The number of vowels in the given string is : " +  count);

        }
    }
}
