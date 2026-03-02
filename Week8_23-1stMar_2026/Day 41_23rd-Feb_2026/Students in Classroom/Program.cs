namespace Students_in_Classroom
{

    class MainClass
    {
        public List<string> ChangeOccurence(List<string> ls, string m, string n)
        {
            for(int i = 0; i <  ls.Count; i++)
            {
                if (ls[i] == m)
                {
                    ls[i] = n;
                }
            }

            return ls;
        }


        public string ListIndex(List<string> ls)
        {
            return ls[0];
        }

        public List<string> ListAfter(List<string> ls, string m, string n)
        {
            for(int i = 0; i < ls.Count; i++)
            {
                if (ls[i] == m)
                {
                    ls.Insert(i + 1, n);
                    i++;
                }
            }

            return ls;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MainClass obj = new MainClass();

            // Create initial list
            List<string> students = new List<string>
        {
            "Amit", "Rahul", "Amit", "Sneha"
        };

            Console.WriteLine("Original List:");
            foreach (var s in students)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine("\n");

            // Test ChangeOccurence
            var changedList = obj.ChangeOccurence(new List<string>(students), "Amit", "Arjun");
            Console.WriteLine("After ChangeOccurence (Amit -> Arjun):");
            foreach (var s in changedList)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine("\n");

            // Test ListIndex
            Console.WriteLine("Element at Index 0:");
            Console.WriteLine(obj.ListIndex(students));

            Console.WriteLine();

            // Test ListAfter
            var afterList = obj.ListAfter(new List<string>(students), "Amit", "NewStudent");
            Console.WriteLine("After ListAfter (Insert after Amit):");
            foreach (var s in afterList)
            {
                Console.Write(s + " ");
            }

            Console.ReadLine();
        }
    }
}
