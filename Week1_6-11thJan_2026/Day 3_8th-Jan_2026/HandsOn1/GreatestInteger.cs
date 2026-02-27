using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestInteger
{
    internal class GreatestInteger
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            Console.Write("Enter the First Number: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second Number: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Enter the Third Number: ");
            z = int.Parse(Console.ReadLine());

            int greatest = (x > y ? x : y) > z ? y : z;

            Console.WriteLine("The greatest number of the three is: " + greatest);
        }


    }
}
