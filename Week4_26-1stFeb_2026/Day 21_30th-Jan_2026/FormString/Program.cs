namespace FormString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = { "ABC", "XYZ", "EFG", "MN" };
            int input2 = 3;

            string temp = " ";

            for(int i  = 0; i < input1.Length; i++)
            {
                string s = input1[i];

                if(s.Length >= input2)
                {
                    temp += s[input2-1];
                }
                else
                {
                    temp += '$';
                }
            }

            Console.WriteLine(temp);
        }
    }
}
