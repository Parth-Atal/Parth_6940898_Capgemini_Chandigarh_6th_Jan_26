using System;

namespace EmployeeDesignation;
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of inputs: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] arr = new string[n];

        Console.WriteLine("Enter the input strings:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
        }

        Console.Write("Enter the designation: ");
        string designation = Console.ReadLine();

        Console.Write("The input array is: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();    

        string[] result = UserProgramCode.getEmployee(arr, designation);

        Console.WriteLine("Output:");
        foreach (string s in result)
        {
            Console.WriteLine(s);
        }
    }
}
