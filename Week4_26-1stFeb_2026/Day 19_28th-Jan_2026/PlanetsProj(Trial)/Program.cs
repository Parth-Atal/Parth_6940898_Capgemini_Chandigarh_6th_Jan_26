using System;
using System.Collections.Generic;
using System.Numerics;

namespace PlanetsProj_Trial_
{
    class Program
    {
        static void Main()
        {
            PlanetBO bo = new PlanetBO();
            List<Planet> planetList = bo.LoadFromFile();

            int role;
            Console.WriteLine("Select Role:");
            Console.WriteLine("1) User");
            Console.WriteLine("2) Admin");
            role = int.Parse(Console.ReadLine());

            if (role == 1)
                UserMenu(bo, planetList);
            else
                AdminMenu(bo, planetList);
        }

        static void UserMenu(PlanetBO bo, List<Planet> planetList)
        {
            int ch;
            do
            {
                Console.WriteLine("\n1) View Planet");
                Console.WriteLine("2) Most Habitable Planet");
                Console.WriteLine("3) Compare Planets");
                Console.WriteLine("4) Exit");
                ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                {
                    Console.Write("Enter planet name: ");
                    bo.DisplayPlanetDetails(planetList, Console.ReadLine());
                }
                else if (ch == 2)
                {
                    bo.DisplayMostHabitablePlanet(planetList);
                }
                else if (ch == 3)
                {
                    Console.Write("Planet 1: ");
                    string p1 = Console.ReadLine();
                    Console.Write("Planet 2: ");
                    string p2 = Console.ReadLine();
                    bo.ComparePlanets(planetList, p1, p2);
                }
            } while (ch != 4);
        }

        static void AdminMenu(PlanetBO bo, List<Planet> planetList)
        {
            int ch;
            do
            {
                Console.WriteLine("\n1) Add Planet");
                Console.WriteLine("2) Remove Planet");
                Console.WriteLine("3) Exit");
                ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Radius: ");
                    double r = double.Parse(Console.ReadLine());

                    Console.Write("Distance from Sun: ");
                    double d = double.Parse(Console.ReadLine());

                    Console.Write("Terrain (Rocky/Solid/Gaseous): ");
                    TerrainType t = (TerrainType)Enum.Parse(typeof(TerrainType), Console.ReadLine());

                    Console.Write("Water exists (true/false): ");
                    bool w = bool.Parse(Console.ReadLine());

                    Console.Write("Number of moons: ");
                    int m = int.Parse(Console.ReadLine());

                    List<string> moons = new List<string>();
                    for (int i = 0; i < m; i++)
                    {
                        Console.Write("Moon name: ");
                        moons.Add(Console.ReadLine());
                    }

                    bo.AddPlanet(planetList, new Planet(name, r, d, t, w, moons));
                }
                else if (ch == 2)
                {
                    Console.Write("Enter planet name: ");
                    bo.RemovePlanet(planetList, Console.ReadLine());
                }

            } while (ch != 3);
        }
    }

}
