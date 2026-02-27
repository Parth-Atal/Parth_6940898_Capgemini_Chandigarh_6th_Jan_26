using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqMiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seed Data
            var departments = new List<Department>
            {
                new Department { DepartmentID = 1, DepartmentName = "Computer Science" },
                new Department { DepartmentID = 2, DepartmentName = "Electronics" },
                new Department { DepartmentID = 3, DepartmentName = "Mechanical" }
            };

            var students = new List<Student>
            {
                new Student { StudentID = 1, Name = "Alice", Age = 22, DepartmentID = 1 },
                new Student { StudentID = 2, Name = "Bob", Age = 20, DepartmentID = 1 },
                new Student { StudentID = 3, Name = "Charlie", Age = 23, DepartmentID = 2 },
                new Student { StudentID = 4, Name = "David", Age = 21, DepartmentID = 3 },
                new Student { StudentID = 5, Name = "Eva", Age = 19, DepartmentID = 1 }
            };

            var courses = new List<Course>
            {
                new Course { CourseID = 1, CourseName = "Databases", DepartmentID = 1 },
                new Course { CourseID = 2, CourseName = "Algorithms", DepartmentID = 1 },
                new Course { CourseID = 3, CourseName = "Circuits", DepartmentID = 2 }
            };

            var enrollments = new List<Enrollment>
            {
                new Enrollment { EnrollmentID = 1, StudentID = 1, CourseID = 1, Grade = "A" },
                new Enrollment { EnrollmentID = 2, StudentID = 1, CourseID = 2, Grade = "B" },
                new Enrollment { EnrollmentID = 3, StudentID = 2, CourseID = 1, Grade = "C" },
                new Enrollment { EnrollmentID = 4, StudentID = 3, CourseID = 3, Grade = "A" }
            };

            GetStudentsOlderThan21(students);
            Console.WriteLine("--------------------------------");
            GetCoursesByDepartment(courses, 1);
            Console.WriteLine("--------------------------------");
            NamesOfStudentsEnrolledInDatabasesCourse(students, courses);
            Console.WriteLine("--------------------------------");
            GetStudentEnrollments(students, courses, enrollments);
            Console.WriteLine("--------------------------------");
            StudentsWhoScoredA(students, enrollments);
            Console.WriteLine("--------------------------------");
            GroupStudentsByDepartment(students, departments);
            Console.WriteLine("--------------------------------");
            StudentsEnrolledInEachCourse(students, courses, enrollments);
            Console.WriteLine("--------------------------------");

        }

        // Basic Query
        static void GetStudentsOlderThan21(List<Student> students)
        {
            var res = students.Where(item => item.Age > 21).ToList();

            Console.WriteLine("Students who are older than 21.");
            foreach(var item in res)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }

        // Filter by Department
        static void GetCoursesByDepartment(List<Course> courses, int deptId)
        {
            var res = courses.Where(item => item.DepartmentID == deptId).ToList();

            Console.WriteLine($"Courses who have {deptId} as their department ID");
            foreach(var item in res)
            {
                Console.WriteLine($"{item.CourseName}"); 
            }
        }

        // Names of students enrolled in database course
        static void NamesOfStudentsEnrolledInDatabasesCourse(List<Student> students, List<Course> courses)
        {
            var dept = courses.Where(item => item.CourseName == "Databases").ToList();
            var deptId = Convert.ToInt32(dept[0].DepartmentID);

            var res = students.Where(item => item.DepartmentID == deptId).ToList();

            Console.WriteLine($"Students who have enrolled in database course.");
            foreach(var item in res)
            {
                Console.WriteLine($"{item.Name}"); 
            }
        }

        // Join Example
        static void GetStudentEnrollments(List<Student> students, List<Course> courses, List<Enrollment> enrollments)
        {
            var res = from s in students
                        join e in enrollments on s.StudentID equals e.StudentID
                        join c in courses on e.CourseID equals c.CourseID
                        select new
                        {
                            s.Name,
                            c.CourseName,
                            e.Grade
                        };

            foreach(var item in res){
                Console.WriteLine($"{item.Name} - {item.CourseName} - {item.Grade}");
            }
        }

        static void StudentsWhoScoredA(List<Student> students, List<Enrollment> enrollments){
            var res = from s in students
                        join e in enrollments on s.StudentID equals e.StudentID
                        where e.Grade == "A"
                        select new {
                            s.Name,
                            e.Grade
                        };
            
            foreach(var item in res){
                Console.WriteLine($"{item.Name} - {item.Grade}");
            }
        }

        // Grouping
        static void GroupStudentsByDepartment(List<Student> students, List<Department> departments)
        {
            var res = from s in students
                        join d in departments on s.DepartmentID equals d.DepartmentID
                        group s by d.DepartmentName into g
                        select g;

            foreach(var item in res){
                Console.WriteLine($"Department: {item.Key}");

                foreach(var e in item){
                    Console.WriteLine(e.Name);
                }
            }
        }

        static void StudentsEnrolledInEachCourse(
            List<Student> students,
            List<Course> courses,
            List<Enrollment> enrollments)
        {
            var res = from c in courses
                        join e in enrollments on c.CourseID equals e.CourseID into ce
                        select new
                        {
                            CourseName = c.CourseName,
                            StudentCount = ce.Count()
                        };

            foreach (var item in res)
            {
                Console.WriteLine($"{item.CourseName} - {item.StudentCount}");
            }
        }

        

    }

    // Entities
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentID { get; set; }
    }

    class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }

    class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int DepartmentID { get; set; }
    }

    class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public string Grade { get; set; }
    }
}