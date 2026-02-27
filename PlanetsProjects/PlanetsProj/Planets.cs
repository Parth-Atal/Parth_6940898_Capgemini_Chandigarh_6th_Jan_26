using System;
using System.Collections.Generic;

namespace PlanetsProj
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

    class SimplePlanet : Planet
    {
        public SimplePlanet(string name, int radius, int sunDistance, PlanetType type)
            : base(name, radius, sunDistance, type)
        { }
    }

    // GENERIC CLASS
    class PlanetManager<T> where T : Planet
    {
        public List<T> Planets = new List<T>();

        public void AddPlanet(T planet)
        {
            Planets.Add(planet);
        }

        public void RemovePlanet(string name)
        {
            Planets.RemoveAll(p => p.Name == name);
        }

        public T GetPlanet(string name)
        {
            return Planets.Find(p => p.Name == name);
        }
    }

    // EXTENSION METHODS
    static class PlanetExtensions
    {
        public static void ShowMoons(this Planet planet)
        {
            if (planet.Moons.Count == 0)
            {
                Console.WriteLine("No moons available");
                return;
            }

            Console.WriteLine("Moons:");
            foreach (var moon in planet.Moons)
                Console.WriteLine($"- {moon.Name} (Radius: {moon.Radius} km)");
        }

        public static void ComparePlanets(Planet p1, Planet p2)
        {
            Console.WriteLine("\n--- Planet Comparison ---");
            Console.WriteLine($"{p1.Name} vs {p2.Name}");
            Console.WriteLine($"Radius: {p1.Radius} km | {p2.Radius} km");
            Console.WriteLine($"Sun Distance: {p1.SunDistance} | {p2.SunDistance}");
            Console.WriteLine($"Type: {p1.Type} | {p2.Type}");
        }
    }
}
