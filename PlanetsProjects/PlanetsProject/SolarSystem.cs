using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsProject
{

    interface IHabitable
    {
        public abstract void IsHabitable();
    }

    abstract class SolarSystem
    {
        public int Radius;
        public int Sundist;

        public abstract void Disp();

        protected SolarSystem(int radius, int sundist)
        {
            this.Radius = radius;
            this.Sundist = sundist;
            
        }

        public void RadiusPlanet()
        {
            Console.WriteLine("The radius of the planet is: " +  Radius + "km");
        }
        public void DistanceSun()
        {
            Console.WriteLine("Distance from the sun: " + Sundist + " million kms");
        }

    }

    class Earth : SolarSystem, IHabitable
    {
        public Earth() : base(6700, 150)
        {
        }

        public override void Disp()
        {
            Console.WriteLine("Name of the planet: Earth");
        }

         void IHabitable.IsHabitable()
        {
            Console.WriteLine("Habitable: " + true);
        }

    }

    class Mercury : SolarSystem, IHabitable
    {
        public Mercury() : base(2400, 58)
        {
        }

        public override void Disp()
        {
            Console.WriteLine("Name of the planet: Mercury");
        }

        void IHabitable.IsHabitable()
        {
            Console.WriteLine("Habitable: " + false);
        }

    }

    class Venus : SolarSystem, IHabitable
    {
        public Venus() : base(6000, 108)
        {
        }

        public override void Disp()
        {
            Console.WriteLine("Name of the planet: Venus");
        }

        void IHabitable.IsHabitable()
        {
            Console.WriteLine("Habitable: " + false);
        }

    }

    class Mars : SolarSystem, IHabitable
    {
        public Mars() : base(3400,227)
        {
        }

        public override void Disp()
        {
            Console.WriteLine("Name of the planet: Mars");
        }

        void IHabitable.IsHabitable()
        {
            Console.WriteLine("Habitable: " + false);
        }

    }

    class Jupiter : SolarSystem, IHabitable
    {
        public Jupiter() : base(69000, 778)
        {
        }

        public override void Disp()
        {
            Console.WriteLine("Name of the planet: Jupiter");
        }

        void IHabitable.IsHabitable()
        {
            Console.WriteLine("Habitable: " + false);
        }

    }

    class Saturn : SolarSystem, IHabitable
    {
        public Saturn() : base(58000, 1433)
        {
        }

        public override void Disp()
        {
            Console.WriteLine("Name of the planet: Saturn");
        }

        void IHabitable.IsHabitable()
        {
            Console.WriteLine("Habitable: " + false);
        }

    }

    class Uranus : SolarSystem, IHabitable
    {
        public Uranus() : base(25000, 2872)
        {
        }

        public override void Disp()
        {
            Console.WriteLine("Name of the planet: Uranus");
        }

        void IHabitable.IsHabitable()
        {
            Console.WriteLine("Habitable: " + false);
        }

    }

    class Neptune : SolarSystem, IHabitable
    {
        public Neptune() : base(2400, 4500)
        {
        }

        public override void Disp()
        {
            Console.WriteLine("Name of the planet: Neptune");
        }

        void IHabitable.IsHabitable()
        {
            Console.WriteLine("Habitable: " + false);
        }

    }



}
