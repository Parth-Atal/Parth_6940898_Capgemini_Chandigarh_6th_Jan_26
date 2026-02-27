using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class UserProgramCode
{
    public static string[] getEmployee(string[] input1, string input2)
    {
        if (Regex.IsMatch(input2, @"[^A-Za-z ]"))
            return new string[] { "Invalid Input" };

        foreach (string s in input1)
        {
            if (Regex.IsMatch(s, @"[^A-Za-z ]"))
                return new string[] { "Invalid Input" };
        }

        List<string> result = new List<string>();
        bool allSame = true;
        string firstDesignation = input1[1];

        for (int i = 1; i < input1.Length; i += 2)
        {
            if (!input1[i].Equals(firstDesignation))
                allSame = false;

            if (input1[i].Equals(input2))
                result.Add(input1[i - 1]);
        }

        if (allSame && firstDesignation.Equals(input2))
        {
            return new string[] { "All employees belong to same " + input2 + " designation" };
        }

        if (result.Count == 0)
        {
            return new string[] { "No employee for " + input2 + " designation" };
        }

        return result.ToArray();
    }
}
