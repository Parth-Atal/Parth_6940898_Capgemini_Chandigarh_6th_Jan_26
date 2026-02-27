using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsProjectInterface
{
    interface IPlanetInfo
    {
        abstract void GetName();
        abstract void GetType();
        abstract void GetSize();
        abstract void GetMass();
        abstract void GetDistanceFromSun();
    }

    interface IPlanetLife
    {
        abstract void HasLife();
        abstract void HasWater();
        abstract void HasAtmosphere();
        abstract void GravityLevel();
        abstract void TemperatureRange();
    }
    class Planets: IPlanetInfo, IPlanetLife
    {
         
        public void GetName()
        {
            Console.WriteLine("Planet Name: Earth");
        }

        public void GetType()
        {
            Console.WriteLine("Planet Type: Terrestrial");
        }

        public void GetSize()
        {
            Console.WriteLine("Planet Size: Medium");
        }

        public void GetMass()
        {
            Console.WriteLine("Planet Mass: 5.97 × 10^24 kg");
        }

        public void GetDistanceFromSun()
        {
            Console.WriteLine("Distance from Sun: 149.6 million km");
        }

        public void HasLife()
        {
            Console.WriteLine("Life Present: Yes");
        }

        public void HasWater()
        {
            Console.WriteLine("Water Present: Yes");
        }

        public void HasAtmosphere()
        {
            Console.WriteLine("Atmosphere: Yes");
        }

        public void GravityLevel()
        {
            Console.WriteLine("Gravity Level: 9.8 m/s²");
        }

        public void TemperatureRange()
        {
            Console.WriteLine("Temperature Range: -88°C to 58°C");
        }
    
    }
}
