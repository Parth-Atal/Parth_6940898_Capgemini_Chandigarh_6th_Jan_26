using PlanetsProj;
using System;

class Program
{
    static PlanetManager<SimplePlanet> manager = new PlanetManager<SimplePlanet>();

    static void Main()
    {
        SeedData();

        while (true)
        {
            Console.WriteLine("\n1. User");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Exit");
            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: UserMenu(); break;
                case 2: AdminMenu(); break;
                case 3: return;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
    }

    // ---------- USER ----------
    static void UserMenu()
    {
        Console.WriteLine("\n1. View Planets & Moons");
        Console.WriteLine("2. Compare Planets");
        Console.Write("Choice: ");
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
            Console.Write("Enter first planet name: ");
            var p1 = manager.GetPlanet(Console.ReadLine());

            Console.Write("Enter second planet name: ");
            var p2 = manager.GetPlanet(Console.ReadLine());

            if (p1 != null && p2 != null)
                PlanetExtensions.ComparePlanets(p1, p2);
            else
                Console.WriteLine("Planet not found");
        }
    }

    // ---------- ADMIN ----------
    static void AdminMenu()
    {
        Console.WriteLine("\n1. Add Planet");
        Console.WriteLine("2. Remove Planet");
        Console.WriteLine("3. Add Moon");
        Console.Write("Choice: ");
        int ch = int.Parse(Console.ReadLine());

        try
        {
            if (ch == 1)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Radius: ");
                int radius = int.Parse(Console.ReadLine());

                Console.Write("Sun Distance: ");
                int dist = int.Parse(Console.ReadLine());

                SimplePlanet p = new SimplePlanet(name, radius, dist, PlanetType.Terrestrial);
                manager.AddPlanet(p);
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
                string mname = Console.ReadLine();

                Console.Write("Moon radius: ");
                int mr = int.Parse(Console.ReadLine());

                p.Moons.Add(new Moon(mname, mr));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    // ---------- INITIAL DATA ----------
    static void SeedData()
    {
        var earth = new SimplePlanet("Earth", 6700, 150, PlanetType.Terrestrial);
        earth.Moons.Add(new Moon("Moon", 1737));

        var mars = new SimplePlanet("Mars", 3400, 227, PlanetType.Terrestrial);
        mars.Moons.Add(new Moon("Phobos", 11));
        mars.Moons.Add(new Moon("Deimos", 6));

        manager.AddPlanet(earth);
        manager.AddPlanet(mars);
    }
}
 
