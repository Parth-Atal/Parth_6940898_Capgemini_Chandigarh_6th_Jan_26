using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern
{
    internal class StarPattern
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter the number of stars for the First Row: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}
