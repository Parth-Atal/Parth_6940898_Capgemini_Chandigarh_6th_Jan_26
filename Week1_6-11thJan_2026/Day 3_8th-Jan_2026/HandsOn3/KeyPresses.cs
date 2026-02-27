using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPresses
{
    internal class KeyPresses
    {
        static void Main(string[] args)
        {
            int x;
            int flag = 0;
            int y = 0;


            while (flag == 0)
            {

                x = int.Parse(Console.ReadLine());

                if (x >= 0 && x <= 9)
                {
                    Console.WriteLine("The number pressed is: " + x);

                }
                else
                {
                    Console.WriteLine("Not Allowed");
                    flag = 1;
                }

                y++;
            }

            Console.WriteLine("The number of keys pressed is: " + y);

        }

    }
}
