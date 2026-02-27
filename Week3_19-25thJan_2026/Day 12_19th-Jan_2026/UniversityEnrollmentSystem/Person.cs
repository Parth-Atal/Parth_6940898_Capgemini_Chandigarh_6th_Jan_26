using System;

namespace UniversityEnrollmentSystem
{
    interface ICourses
    {
        string Course { get; set; }
    }

    interface IDepartment
    {
        string Department { get; set; }
    }

    internal class Person
    {
        public string Name { get; set; }
    }

    class Student : Person, ICourses, IDepartment
    {
        public string Course { get; set; }
        public string Department { get; set; }

        public void Disp()
        {
            Console.WriteLine("Student Profile - ");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("Department: " + Department);
        }
    }

    class Professor : Person, ICourses, IDepartment
    {
        public string Course { get; set; }
        public string Department { get; set; }
        public string Time { get; set; }

        public void Disp()
        {
            Console.WriteLine();
            Console.WriteLine("Professor Profile - ");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Available Time: " + Time);
        }
    }

    class Staff : Person, IDepartment
    {
        public string Department { get; set; }
        public string Time { get; set; }

        public void Disp()
        {
            Console.WriteLine();
            Console.WriteLine("Staff Profile - ");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Available Time: " + Time);
        }
    }
}
