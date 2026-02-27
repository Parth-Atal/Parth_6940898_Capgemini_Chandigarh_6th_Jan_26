using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question
{
    internal class Question
    {
        static void Main(string[] args)
        {
            char x;
            Console.WriteLine("What is the correct way to declare a variable to store an integer value in C#?");
            Console.WriteLine("a. int 1x = 10");
            Console.WriteLine("b. int x = 10");
            Console.WriteLine("c. float x = 10.0f");
            Console.WriteLine("d. string x = '10'");

            Console.Write("Choose the answer letter: ");
            x = char.Parse(Console.ReadLine());

            if (x == 'b' || x == 'B')
            {
                Console.WriteLine("Correct Answer!!");
            }
            else
            {
                Console.WriteLine("Incorrect Answer!!");
            }
        }
    }
}