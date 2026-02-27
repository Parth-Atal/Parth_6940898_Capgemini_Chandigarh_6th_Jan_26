using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossSalaryCalculation
{
    internal class Salary
    {
        static float GrossCalc(int basic)
        {
            float gross = 0;
            float HRA = 0;
            float DA = 0;

            HRA = (basic * 50) / 100;
            DA = (basic * 75) / 100;

            gross = basic + HRA + DA;

            return gross;
        }

        static void Main(string[] args)
        {
            int input1, days;
            float output;

            Console.Write("Enter the Basic Pay: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the No of Days the Person worked: ");
            days = Convert.ToInt32(Console.ReadLine());

            if( input1 < 0)
            {
                output = -1;
            }
            else if(input1 > 10000)
            {
                output = -2;
            }
            else if(days > 31)
            {
                output = -3;
            }
            else
            {
                output = GrossCalc(input1);
            }

            Console.WriteLine("Gross Pay: " + output);

        }
    }
}
