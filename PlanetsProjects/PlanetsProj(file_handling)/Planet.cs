using System;
using System.Collections.Generic;
using System.IO;

namespace PlanetsProject
{
    // ENUM
    enum PlanetType
    {
        Terrestrial,
        GasGiant,
        IceGiant
    }

    // STRUCT
    struct Moon
    {
        public string Name;
        public int Radius;

        public Moon(string name, int radius)
        {
            Name = name;
            Radius = radius;
        }
    }

    // ABSTRACT CLASS
    abstract class Planet
    {
        public string Name;
        public int Radius;
        public int SunDistance;
        public PlanetType Type;
        public List<Moon> Moons = new List<Moon>();

        protected Planet(string name, int radius, int sunDistance, PlanetType type)
        {
            if (radius <= 0 || sunDistance <= 0)
                throw new ArgumentException("Invalid planet values");

            Name = name;
            Radius = radius;
            SunDistance = sunDistance;
            Type = type;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Planet: {Name}");
            Console.WriteLine($"Radius: {Radius} km");
            Console.WriteLine($"Distance from Sun: {SunDistance} million km");
            Console.WriteLine($"Type: {Type}");
        }
    }

    // CONCRETE PLANET
    class SimplePlanet : Planet
    {
        public SimplePlanet(string name, int radius, int sunDistance, PlanetType type)
            : base(name, radius, sunDistance, type)
        { }
    }

    // GENERIC MANAGER + FILE HANDLING
    class PlanetManager<T> where T : Planet
    {
        public List<T> Planets = new List<T>();
        private string filePath = "planets.txt";

        public void AddPlanet(T planet)
        {
            Planets.Add(planet);
            SaveToFile();
        }

        public void RemovePlanet(string name)
        {
            Planets.RemoveAll(p => p.Name == name);
            SaveToFile();
        }

        public T GetPlanet(string name)
        {
            return Planets.Find(p => p.Name == name);
        }

        public void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var p in Planets)
                {
                    sw.WriteLine($"{p.Name}|{p.Radius}|{p.SunDistance}|{p.Type}");
                    foreach (var m in p.Moons)
                        sw.WriteLine($"MOON|{m.Name}|{m.Radius}");
                    sw.WriteLine("END");
                }
            }
        }

        public void LoadFromFile()
        {
            if (!File.Exists(filePath))
                return;

            Planets.Clear();
            SimplePlanet current = null;

            foreach (var line in File.ReadAllLines(filePath))
            {
                if (line == "END")
                {
                    if (current != null)
                        Planets.Add((T)(Planet)current);
                    current = null;
                }
                else if (line.StartsWith("MOON"))
                {
                    var p = line.Split('|');
                    current.Moons.Add(new Moon(p[1], int.Parse(p[2])));
                }
                else
                {
                    var p = line.Split('|');
                    current = new SimplePlanet(
                        p[0],
                        int.Parse(p[1]),
                        int.Parse(p[2]),
                        (PlanetType)Enum.Parse(typeof(PlanetType), p[3])
                    );
                }
            }
        }
    }

    // EXTENSIONS
    static class PlanetExtensions
    {
        public static void ShowMoons(this Planet planet)
        {
            if (planet.Moons.Count == 0)
            {
                Console.WriteLine("No moons");
                return;
            }

            Console.WriteLine("Moons:");
            foreach (var m in planet.Moons)
                Console.WriteLine($"- {m.Name} ({m.Radius} km)");
        }

        public static void ComparePlanets(Planet a, Planet b)
        {
            Console.WriteLine("\n--- Comparison ---");
            Console.WriteLine($"{a.Name} | {b.Name}");
            Console.WriteLine($"{a.Radius} | {b.Radius}");
            Console.WriteLine($"{a.SunDistance} | {b.SunDistance}");
            Console.WriteLine($"{a.Type} | {b.Type}");
        }
    }
}
