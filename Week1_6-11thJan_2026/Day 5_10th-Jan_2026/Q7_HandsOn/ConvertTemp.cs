using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7_HandsOn
{
    internal class ConvertTemp
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius = 0, output = 0;
            Console.Write("Enter the temperature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            if (fahrenheit < 0)
            {
                output = -1;
            }

            else
            {
                celsius = (fahrenheit - 32) * 5.0 / 9.0;
            }

            output = Math.Round(celsius,2);
            Console.WriteLine("The temperature in Celsius is: " +  output);
        }
    }
}
