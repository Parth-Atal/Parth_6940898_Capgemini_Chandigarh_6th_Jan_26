namespace DeleteAlternatingCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();

            string temp = "";

            for(int i = 0; i < str1.Length; i++)
            {
                if(i % 2 == 0)
                {
                    temp += str1[i];   
                }
            }

            Console.WriteLine(temp);
            
        }
    }
}
