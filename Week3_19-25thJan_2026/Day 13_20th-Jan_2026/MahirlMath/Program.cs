namespace MahirlMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserMainCode obj1 = new UserMainCode();
            int input1;
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(obj1.Count(input1, 10));
        }
    }
}
