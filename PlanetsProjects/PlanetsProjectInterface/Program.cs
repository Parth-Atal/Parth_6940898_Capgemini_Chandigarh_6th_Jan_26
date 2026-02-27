using System;
using PlanetsProjectInterface;

class Program
{
    static void Main(string[] args)
    {
        Planets earth = new Planets();

        earth.GetName();
        earth.GetType();
        earth.GetSize();
        earth.GetMass();
        earth.GetDistanceFromSun();

        earth.HasLife();
        earth.HasWater();
        earth.HasAtmosphere();
        earth.GravityLevel();
        earth.TemperatureRange();

        Console.ReadLine();
    }
}
