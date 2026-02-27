using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceString
{
    internal class UserProgramCode
    {
        public static string ReplaceString(string str1, int input2 ,char str2)
        {
            if(Regex.IsMatch(str1, @"[^a-zA-Z ]"))
            {
                return "Invalid String";
            }
            if(input2 < 0)
            {
                return "Number not Positive";
            }
            if (char.IsLetterOrDigit(str2))
            {
                return "Character is Not Special";
            }

            string[] strarr = str1.Split(' ');

            strarr[input2 - 1] = new string(str2, strarr[input2 - 1].Length);

            string output = " ";

            for(int i = 0; i < strarr.Length; i++)
            {
                output += strarr[i];

                if(i <  strarr.Length - 1)
                {
                    output += " ";
                }
            }

            return output;
        }

    }
}
