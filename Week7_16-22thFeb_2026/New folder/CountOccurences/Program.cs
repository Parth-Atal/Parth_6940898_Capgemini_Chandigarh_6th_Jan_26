namespace CountOccurences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = [1, 2, 3, 4, 1, 4, 5, 1, 2];

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i = 0; i < input1.Length; i++)
            {
                if (dict.ContainsKey(input1[i]))
                {
                    dict[input1 [i]]++;
                }
                else
                {
                    dict.Add(input1[i], 1);
                }
            }

            foreach(var item in dict)
            {
                Console.WriteLine(item.Key + " occures " +  item.Value + " times.");
            }
        }
    }
}
