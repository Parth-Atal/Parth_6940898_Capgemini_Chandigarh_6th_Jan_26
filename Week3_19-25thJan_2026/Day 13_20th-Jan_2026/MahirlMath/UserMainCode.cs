using System;

namespace MahirlMath
{
    internal class UserMainCode
    {
        int count = 0;

        public int Count(int num, int curr)
        {
            if (num == curr)
            {
                return count;
            }

            if (curr < 0 || curr > num)
            {
                return count;
            }

            if ((curr * 3) <= num)
            {
                count++;
                return Count(num, curr * 3);
            }
            else if ((curr + 2) <= num)
            {
                count++;
                return Count(num, curr + 2);
            }
            else
            {
                count++;
                return Count(num, curr - 1);
            }
        }   
    }
}
