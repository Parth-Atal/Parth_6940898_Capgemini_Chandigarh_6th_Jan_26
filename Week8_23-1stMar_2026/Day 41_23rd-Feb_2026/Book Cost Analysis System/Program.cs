namespace Book_Cost_Analysis_System
{
    class Book
    {
        public string BookName { get; set; }
        public int Cost { get; set; }
    }

    class BookImplementation
    {
        public string GetNameOfBooks(List<Book> ls)
        {
            string Name = null;
            foreach(var item in ls)
            {
                Name += item.BookName;
                Name += "\n";
            }

            return Name;
        }

        public int SumCost(List<Book> ls)
        {
            int Sum = 0;

            foreach(var item in ls)
            {
                Sum += item.Cost;   
            }

            return Sum;
        }

        public int GetMax(List<Book> ls)
        {
            var res = ls.OrderBy(item => item.Cost).ToList();

            res.Reverse();

            return res[0].Cost;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            BookImplementation impl = new BookImplementation();

            // Create book list
            List<Book> books = new List<Book>
        {
            new Book { BookName = "C# Basics", Cost = 500 },
            new Book { BookName = "Data Structures", Cost = 750 },
            new Book { BookName = "Algorithms", Cost = 900 },
            new Book { BookName = "Database Systems", Cost = 650 }
        };

            // Get all book names
            Console.WriteLine("Book Names:");
            Console.WriteLine(impl.GetNameOfBooks(books));

            Console.WriteLine();

            // Get total cost
            Console.WriteLine("Total Cost:");
            Console.WriteLine(impl.SumCost(books));

            Console.WriteLine();

            // Get maximum cost
            Console.WriteLine("Maximum Cost:");
            Console.WriteLine(impl.GetMax(books));

            Console.ReadLine();
        }
    }
}
