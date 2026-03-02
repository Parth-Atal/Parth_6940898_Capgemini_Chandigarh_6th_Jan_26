using System.Security.AccessControl;

namespace What_is_an_Age
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
       
    }

    class StreamImplementation
    {
        public int SumAge(List<Person>ls)
        {
            var res = ls.Where(item => item.Age > 50).ToList();

            int ans = res.Sum(item => item.Age);

            return ans;
        }

        public List<string> PrintName(List<Person> ls)
        {
            var res = ls.Select(item => item.Name).ToList();
            return res;
        }

        public List<int> PrintAge(List<Person> ls)
        {
            var res = ls.Select(item => item.Age).ToList();
            return res;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            StreamImplementation impl = new StreamImplementation();

            // Create list of persons
            List<Person> people = new List<Person>
        {
            new Person { Name = "Rahul", Age = 55 },
            new Person { Name = "Sneha", Age = 45 },
            new Person { Name = "Amit", Age = 60 },
            new Person { Name = "Neha", Age = 30 }
        };

            // Test SumAge (Age > 50)
            Console.WriteLine("Sum of Ages greater than 50:");
            Console.WriteLine(impl.SumAge(people));

            Console.WriteLine();

            // Test PrintName
            Console.WriteLine("All Names:");
            var names = impl.PrintName(people);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            // Test PrintAge
            Console.WriteLine("All Ages:");
            var ages = impl.PrintAge(people);
            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }

            Console.ReadLine();
        }
    }
}
