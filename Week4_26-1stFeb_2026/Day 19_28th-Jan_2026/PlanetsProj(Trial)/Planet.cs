using System;
using System.Collections.Generic;

enum TerrainType
{
    Rocky,
    Solid,
    Gaseous
}

class Planet
{
    private string _name;
    private double _radius;
    private double _sunDistance;
    private TerrainType _terrain;
    private bool _hasWater;
    private List<string> _moons;

    public Planet()
    {
        _moons = new List<string>();
    }

    public Planet(string name, double radius, double sunDistance,
                  TerrainType terrain, bool hasWater, List<string> moons)
    {
        _name = name;
        _radius = radius;
        _sunDistance = sunDistance;
        _terrain = terrain;
        _hasWater = hasWater;
        _moons = moons;
    }

    public string Name { get { return _name; } set { _name = value; } }
    public double Radius { get { return _radius; } set { _radius = value; } }
    public double SunDistance { get { return _sunDistance; } set { _sunDistance = value; } }
    public TerrainType Terrain { get { return _terrain; } set { _terrain = value; } }
    public bool HasWater { get { return _hasWater; } set { _hasWater = value; } }
    public List<string> Moons { get { return _moons; } set { _moons = value; } }

    // CALCULATED GRAVITY (simplified)
    public double Gravity
    {
        get { return _radius / 650; }
    }

    // CALCULATED HABITABILITY INDEX
    public double HabitabilityIndex
    {
        get
        {
            double score = 100 - Math.Abs(_sunDistance - 150);
            if (_hasWater) score += 10;
            return score < 0 ? 0 : score;
        }
    }

    public void Display()
    {
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Size (Radius) : " + Radius + " km");
        Console.WriteLine("Distance from Sun : " + SunDistance + " million km");
        Console.WriteLine("Terrain : " + Terrain);
        Console.WriteLine("Water Exists : " + (HasWater ? "Yes" : "No"));
        Console.WriteLine("Gravity : " + Gravity.ToString("0.00"));
        Console.WriteLine("Habitability Index : " + HabitabilityIndex.ToString("0.00") + "/100");
        Console.WriteLine("Moons : " + (Moons.Count > 0 ? string.Join(",", Moons) : "None"));
        Console.WriteLine("----------------------------------------");
    }
}
