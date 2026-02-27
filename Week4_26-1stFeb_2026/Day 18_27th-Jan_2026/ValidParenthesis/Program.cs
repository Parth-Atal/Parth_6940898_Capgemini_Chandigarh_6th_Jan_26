using System;
using System.Collections.Generic;

namespace ValidParenthesis
{
    internal class Program
    {
        public static bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{' || s[i] == '(' || s[i] == '[')
                {
                    st.Push(s[i]);
                }
                else if (s[i] == '}' || s[i] == ')' || s[i] == ']')
                {
                    if (st.Count == 0)
                        return false;

                    char top = st.Pop();

                    if ((s[i] == '}' && top != '{') ||
                        (s[i] == ')' && top != '(') ||
                        (s[i] == ']' && top != '['))
                        return false;
                }
            }

            return st.Count == 0;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            if (IsValid(s))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Not Valid");
        }
    }
}
