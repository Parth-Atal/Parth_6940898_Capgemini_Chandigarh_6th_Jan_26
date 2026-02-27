using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsCalculation
{
    internal class CalculateSavings
    {
        static float Calculate(int salary, int days)
        {
            if(days >= 31)
            {
                salary += 500;
            }

            int expense = 50 + 20;

            float savings = salary - ((salary * expense) / 100);

            return savings;
        }

        static void Main(String[] args)
        {
            int input1, input2;
            Console.Write("Enter the Salary of the person: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            float output1 = 0;

            if(input1 > 9000)
            {
                output1 = -1;
            }

            else if(input1 < 0)
            {
                output1 = -2;
            }

            else
            {
                Console.Write("Enter the number of days the person worked: ");
                input2 = Convert.ToInt32(Console.ReadLine());

                if(input2 < 0)
                {
                    output1 = -4;
                }

                else
                {
                    output1 = Calculate(input1, input2);
                }
            }

            Console.WriteLine("The savings of the Person are: " + output1);
        }
    }
}
