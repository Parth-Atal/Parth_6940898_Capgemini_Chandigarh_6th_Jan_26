namespace FindUniqueWords
{
    internal class Program
    {

        public static bool AnagramCheck(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;

            int[] count = new int[256];

            foreach (char c in s1) count[c]++;
            foreach (char c in s2) count[c]--;

            foreach (int c in count)
                if (c != 0)
                    return false;

            return true;
        }



        public static List<string> AddToList(string[] str1)
        {
            
            List<string> res = new List<string>();
            for(int i = 0; i < str1.Length; i++)
            {
                bool flag = true;

                for (int j = 0; j < str1.Length; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }

                    if (AnagramCheck(str1[i], str1[j])){
                        flag = false;
                    }
                }

                if (flag)
                {
                    res.Add(str1[i]);
                }
            }

            return res;
        }


        static void Main(string[] args)
        {
            string[] str1 = ["listen", "silent", "hello", "world", "abc", "cba"];

            List<string> res = AddToList(str1);

            foreach(var item in res)
            {
                Console.Write(item + " ");
            }
            
        }
    }
}
