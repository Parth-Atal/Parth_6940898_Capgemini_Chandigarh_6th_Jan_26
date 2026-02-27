namespace AnagramCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] strarr = ["dusty", "study"];
            bool check = true;

            int[] arr1 = new int[256];

            foreach(var str in strarr)
            {
                foreach(var s in str)
                {
                    arr1[s]++;
                    arr1[s]--;
                }
            }

            foreach(var count in arr1)
            {
                if(count != 0)
                {
                    check = false;
                }
            }

            Console.WriteLine(check ? "Anagram" : "Not an Anagram");

        }
    }
}
