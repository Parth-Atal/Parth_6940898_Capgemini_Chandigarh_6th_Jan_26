namespace FirstNonRepeatingChar
{
    internal class Program
    {
         public static char nonRep(string s)
        {
            int n = s.Length;
            for (int i = 0; i < n; ++i)
            {
                bool found = false;

                for (int j = 0; j < n; ++j)
                {
                    if (i != j && s[i] == s[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                    return s[i];
            }

            return '$';
        }

        static void Main(string[] args)
        {
            string s = "abracadabra";
            Console.WriteLine("The input string is: " + s);
            Console.WriteLine("First Non-Repeating character is : " + nonRep(s));
        }
    }
}
