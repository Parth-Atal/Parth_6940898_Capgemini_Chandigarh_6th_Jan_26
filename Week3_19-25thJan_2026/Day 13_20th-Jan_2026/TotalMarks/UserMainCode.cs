using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TotalMarks
{
    internal class UserMainCode
    {
       public void ValidMarks(int x, int y, int n1, int n2, int total)
        {
            int temp = 0;
            bool flag = false;
            while(n1 > 0)
            {
                temp = total - (n1 * x);
                if(temp % y == 0)
                {
                    flag = true;
                    break;
                }

                else
                {
                    n1--;
                    continue;
                }

            }

            if (flag)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(n1 * x);
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
