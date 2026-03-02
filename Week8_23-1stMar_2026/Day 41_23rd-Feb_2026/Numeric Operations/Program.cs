namespace Numeric_Operations
{
    class Source
    {
        public int Sum(List<int> ls)
        {
            int sum = 0;
            foreach (int i in ls)
            {

                sum += i;
            }

            return sum;

        }

        public int? GetItemAtIndex(List<int> ls, int index)
        {
            if(index >= ls.Count || index < 0)
            {
                return null;
            }
            else
            {
                return ls[index];
            }
        }

        public List<int> SplitAndReverse(List<int> ls)
        {
            List<int>first = new List<int>();
            List<int>second = new List<int>();

            int mid = ls.Count / 2;

            for(int i = 0; i < mid; i++)
            {
                first.Add(ls[i]);
            }

            for(int i = mid; i < ls.Count; i++)
            {
                second.Add(ls[i]);
            }
            
            first.Reverse();
            second.Reverse();

            List<int> res = new List<int>();

            foreach(var item in first)
            {
                res.Add(item);
            }

            foreach(var item in second)
            {
                res.Add(item);
            }

            return res;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Source source = new Source();

            // Create list
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5};

            // Test Sum
            Console.WriteLine("Sum of Elements:");
            Console.WriteLine(source.Sum(numbers));

            Console.WriteLine();

            // Test GetItemAtIndex (Valid Index)
            Console.WriteLine("Item at Index 2:");
            Console.WriteLine(source.GetItemAtIndex(numbers, 2));

            Console.WriteLine();

            // Test GetItemAtIndex (Invalid Index)
            Console.WriteLine("Item at Invalid Index 10:");
            var item = source.GetItemAtIndex(numbers, 10);
            Console.WriteLine(item == null ? "null" : item.ToString());

            Console.WriteLine();

            // Test SplitAndReverse
            Console.WriteLine("Split and Reverse Result:");
            var result = source.SplitAndReverse(numbers);
            foreach (var num in result)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}
