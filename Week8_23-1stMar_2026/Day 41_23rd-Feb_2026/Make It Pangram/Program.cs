namespace Make_It_Pangram
{

    class Pangram
    {
        public int MinimumAlphabet(string str)
        {
            str = str.ToLower();

            HashSet<char> hs = new HashSet<char>();

            char[] ch = str.ToCharArray();

            for(int i = 0; i < ch.Length; i++)
            {
                if(ch[i] >= 'a' && ch[i] <= 'z')
                {
                    hs.Add(ch[i]);
                } 
            }

            return 26 - hs.Count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pangram pangram = new Pangram();

            // Test Case 1: Complete Pangram
            string str1 = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine("Missing Alphabets: " + pangram.MinimumAlphabet(str1));

            Console.WriteLine();

            // Test Case 2: Partial Pangram
            string str2 = "Hello World";
            Console.WriteLine("Missing Alphabets: " + pangram.MinimumAlphabet(str2));

            Console.WriteLine();

            // Test Case 3: Only Numbers and Symbols
            string str3 = "12345 !@#$%";
            Console.WriteLine("Missing Alphabets: " + pangram.MinimumAlphabet(str3));

            Console.WriteLine();

            // Test Case 4: Random String
            string str4 = "abcdefg";
            Console.WriteLine("Missing Alphabets: " + pangram.MinimumAlphabet(str4));

            Console.ReadLine();
        }
    }
}
