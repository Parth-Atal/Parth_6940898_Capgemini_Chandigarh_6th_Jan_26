using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLeapYear
{
    internal class LeapYear
    {
        static bool CheckLeap(int year)
        {
            if((year % 100 != 0) && (year % 4 == 0) || (year % 400 == 0))
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            int input1;
            Console.Write("Enter the year: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            if(input1 < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                if (CheckLeap(input1))
                {
                    Console.Write(true);
                }

                else
                {
                    Console.Write(false);
                }
            }
        }
    }
}
