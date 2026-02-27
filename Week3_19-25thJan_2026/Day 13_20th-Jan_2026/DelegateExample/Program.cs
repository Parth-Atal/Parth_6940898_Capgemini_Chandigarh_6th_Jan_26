namespace DelegateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiClass obj1 = new MultiClass();

            Math m = new Math(obj1.Add);
            m += obj1.Sub;
            m += obj1.Mult;
            m += obj1.Div;

            m(100, 50);
            Console.WriteLine();

            m(120, 60);
            Console.WriteLine();

            m -= obj1.Div;

            

            m(120, 40);
            Console.WriteLine();
        }
    }
}
