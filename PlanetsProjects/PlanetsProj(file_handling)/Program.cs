using System;
using PlanetsProject;

class Program
{
    static PlanetManager<SimplePlanet> manager = new PlanetManager<SimplePlanet>();

    static void Main()
    {
        manager.LoadFromFile();

        while (true)
        {
            Console.WriteLine("\n1. User");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) UserMenu();
            else if (choice == 2) AdminMenu();
            else break;
        }
    }

    static void UserMenu()
    {
        Console.WriteLine("\n1. View Planets");
        Console.WriteLine("2. Compare Planets");
        int ch = int.Parse(Console.ReadLine());

        if (ch == 1)
        {
            foreach (var p in manager.Planets)
            {
                p.Display();
                p.ShowMoons();
                Console.WriteLine();
            }
        }
        else if (ch == 2)
        {
            Console.Write("Planet 1: ");
            var p1 = manager.GetPlanet(Console.ReadLine());

            Console.Write("Planet 2: ");
            var p2 = manager.GetPlanet(Console.ReadLine());

            if (p1 != null && p2 != null)
                PlanetExtensions.ComparePlanets(p1, p2);
        }
    }

    static void AdminMenu()
    {
        try
        {
            Console.WriteLine("\n1. Add Planet");
            Console.WriteLine("2. Remove Planet");
            Console.WriteLine("3. Add Moon");
            int ch = int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                Console.Write("Name: ");
                string n = Console.ReadLine();

                Console.Write("Radius: ");
                int r = int.Parse(Console.ReadLine());

                Console.Write("Sun Distance: ");
                int d = int.Parse(Console.ReadLine());

                manager.AddPlanet(new SimplePlanet(n, r, d, PlanetType.Terrestrial));
            }
            else if (ch == 2)
            {
                Console.Write("Planet name: ");
                manager.RemovePlanet(Console.ReadLine());
            }
            else if (ch == 3)
            {
                Console.Write("Planet name: ");
                var p = manager.GetPlanet(Console.ReadLine());

                Console.Write("Moon name: ");
                string mn = Console.ReadLine();

                Console.Write("Moon radius: ");
                int mr = int.Parse(Console.ReadLine());

                p.Moons.Add(new Moon(mn, mr));
                manager.SaveToFile();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
