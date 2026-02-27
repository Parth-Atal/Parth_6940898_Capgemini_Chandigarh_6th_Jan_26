namespace TotalMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, n1, n2, m;

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            UserMainCode obj1 = new UserMainCode();

            obj1.ValidMarks(x, y, n1, n2, m);
        }

    }
}
