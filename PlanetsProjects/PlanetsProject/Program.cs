namespace PlanetsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter planet number (1-8):");
            Console.WriteLine("1. Mercury");
            Console.WriteLine("2. Venus");
            Console.WriteLine("3. Earth");
            Console.WriteLine("4. Mars");
            Console.WriteLine("5. Jupiter");
            Console.WriteLine("6. Saturn");
            Console.WriteLine("7. Uranus");
            Console.WriteLine("8. Neptune");
            Console.Write("Input: ");
            int choice = int.Parse(Console.ReadLine());

            SolarSystem planet;

            switch (choice)
            {
                case 1:
                    planet = new Mercury();
                    break;

                case 2:
                    planet = new Venus();
                    break;

                case 3:
                    planet = new Earth();
                    break;

                case 4:
                    planet = new Mars();
                    break;

                case 5:
                    planet = new Jupiter();
                    break;

                case 6:
                    planet = new Saturn();
                    break;

                case 7:
                    planet = new Uranus();
                    break;

                case 8:
                    planet = new Neptune();
                    break;

                default:
                    Console.WriteLine("Invalid planet number!");
                    return;
            }
            
            IHabitable ir = (IHabitable)planet;
            
            planet.Disp();
            planet.RadiusPlanet();
            planet.DistanceSun();
            ir.IsHabitable();
           
        }
    }
}
