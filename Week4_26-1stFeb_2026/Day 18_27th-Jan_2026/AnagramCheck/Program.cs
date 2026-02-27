namespace AnagramCheck
{
    internal class Program
    {
        public static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            int[] counts = new int[256];

            for (int i = 0; i < str1.Length; i++)
            {
                counts[str1[i]]++;
                counts[str2[i]]--;
            }

            foreach (int count in counts)
            {
                if (count != 0)
                {
                    return false;
                }
            }

            return true;
             
        }

        public static void Main(string[] args)
        {
            string str1 = "parth";
            string str2 = "thrap";

            if(IsAnagram(str1, str2)){
                Console.WriteLine("Anagaram!!");
            }
            else
            {
                Console.WriteLine("Not an Anagram!!");
            }

        }

    }
}
