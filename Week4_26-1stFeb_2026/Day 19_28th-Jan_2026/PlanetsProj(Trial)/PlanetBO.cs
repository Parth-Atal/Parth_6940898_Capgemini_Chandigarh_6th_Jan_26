using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class PlanetBO
{
    private const string fileName = "planets.txt";

    // -------- FILE HANDLING --------
    public List<Planet> LoadFromFile()
    {
        List<Planet> list = new List<Planet>();

        if (!File.Exists(fileName))
            return list;

        foreach (string line in File.ReadAllLines(fileName))
        {
            string[] parts = line.Split('|');

            List<string> moons = parts[5] == ""
                ? new List<string>()
                : parts[5].Split(',').ToList();

            list.Add(new Planet(
                parts[0],
                double.Parse(parts[1]),
                double.Parse(parts[2]),
                (TerrainType)Enum.Parse(typeof(TerrainType), parts[3]),
                bool.Parse(parts[4]),
                moons
            ));
        }
        return list;
    }

    public void SaveToFile(List<Planet> planetList)
    {
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            foreach (var p in planetList)
            {
                sw.WriteLine($"{p.Name}|{p.Radius}|{p.SunDistance}|{p.Terrain}|{p.HasWater}|{string.Join(",", p.Moons)}");
            }
        }
    }

    // -------- USER FUNCTIONS --------
    public void DisplayPlanetDetails(List<Planet> planetList, string name)
    {
        var result = planetList.Where(p => p.Name == name).ToList();

        if (result.Count == 0)
            Console.WriteLine("Planet not found");
        else
            result.ForEach(p => p.Display());
    }

    public void DisplayMostHabitablePlanet(List<Planet> planetList)
    {
        double max = planetList.Max(p => p.HabitabilityIndex);
        planetList.Where(p => p.HabitabilityIndex == max)
                  .ToList()
                  .ForEach(p => p.Display());
    }

    public void ComparePlanets(List<Planet> planetList, string p1, string p2)
    {
        Planet a = planetList.FirstOrDefault(p => p.Name == p1);
        Planet b = planetList.FirstOrDefault(p => p.Name == p2);

        if (a == null || b == null)
        {
            Console.WriteLine("Planet not found");
            return;
        }

        Console.WriteLine("\n----- COMPARISON -----");
        Console.WriteLine("Name : {0} | {1}", a.Name, b.Name);
        Console.WriteLine("Size : {0} | {1}", a.Radius, b.Radius);
        Console.WriteLine("Terrain : {0} | {1}", a.Terrain, b.Terrain);
        Console.WriteLine("Water : {0} | {1}", a.HasWater, b.HasWater);
        Console.WriteLine("Gravity : {0:0.00} | {1:0.00}", a.Gravity, b.Gravity);
        Console.WriteLine("Habitability : {0:0.00} | {1:0.00}", a.HabitabilityIndex, b.HabitabilityIndex);
        Console.WriteLine("Moons : {0} | {1}", string.Join(",", a.Moons), string.Join(",", b.Moons));
    }

    // -------- ADMIN FUNCTIONS --------
    public void AddPlanet(List<Planet> planetList, Planet planet)
    {
        planetList.Add(planet);
        SaveToFile(planetList);
    }

    public void RemovePlanet(List<Planet> planetList, string name)
    {
        planetList.RemoveAll(p => p.Name == name);
        SaveToFile(planetList);
    }
}
