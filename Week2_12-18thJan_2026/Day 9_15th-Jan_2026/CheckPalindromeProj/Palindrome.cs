using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindromeProj
{
    internal class Palindrome
    {
        static bool Check(int num)
        {
            int temp2 = num, k = 1, rev = 0;

            while (num > 0)
            {
                int temp = num % 10;
                rev = rev * 10 + temp;
                num = num / 10;
            }

            if(temp2 == rev)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
            int input1;
            Console.Write("Enter a number you wish to check for Palindrome: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            if(input1 < 0)
            {
                Console.WriteLine("Output: -1");
                return;
            }

            if (Check(input1))
            {
                Console.WriteLine("Output: 1");
            }
            else
            {
                Console.WriteLine("Output: -2");
            }
            
        }
    }
}
