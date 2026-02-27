namespace AlphabetsAndVowels
{
    internal class Program
    {

        static bool IsVowel(char c)
        {
            c = char.ToLower(c);
            if (c == 'a' || c == 'o' || c == 'i' || c == 'o' || c == 'u')
            {
                return true;
            }
            return false;
        }

        static bool IsPresent(char c, string s)
        {
            c = char.ToLower(c);
            for(int i = 0; i <  s.Length; i++)
            {
                char.ToLower(s[i]);
                if (c == s[i]) return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            string temp = "";

            for(int i = 0; i < first.Length; i++)
            {
                if (IsVowel(first[i]) || !IsPresent(first[i], second)){
                    temp += first[i];
                }
            }

            string result = "";
            result += temp[0];

            for(int i = 1; i < temp.Length; i++)
            {
                if (char.ToLower(temp[i]) != char.ToLower(temp[i - 1]))
                {
                    result += temp[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
