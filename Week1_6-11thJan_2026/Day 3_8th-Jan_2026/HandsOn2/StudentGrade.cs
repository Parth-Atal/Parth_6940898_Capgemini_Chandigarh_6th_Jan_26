using System;

namespace StudentGrade
{
    internal class StudentGrade
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Enter the marks of 1st Subject: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter the marks of 2nd Subject: ");
            y = int.Parse(Console.ReadLine());

            float avg = (x + y) / 2.0f;
            char grade;

            if (avg > 80)
                grade = 'A';
            else if (avg > 60)
                grade = 'B';
            else if (avg > 40)
                grade = 'C';
            else
                grade = 'F';

            Console.WriteLine("Average Marks: " + avg);
            Console.WriteLine("Grade: " + grade);
        }
    }
}
