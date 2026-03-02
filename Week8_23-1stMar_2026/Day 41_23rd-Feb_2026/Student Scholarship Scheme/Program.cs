using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;


namespace Student_Scholarship_Scheme
{
    class Student
    {
        public string StudentName { get; set; }
        public int StudentId { get; set; }
        public int StudentScore { get; set; }
        public string ScholarshipScheme { get; set; }
    }

    class ScholarshipImpl
    {
        List<Student> Students = new List<Student>();




        public void AddStudents(Student student)
        {
            if (student.StudentScore > 90)
            {
                student.ScholarshipScheme = "Gold";
            }
            else if (student.StudentScore > 75)
            {
                student.ScholarshipScheme = "Silver";
            }
            else if (student.StudentScore > 60)
            {
                student.ScholarshipScheme = "Bronze";
            }
            else
            {
                student.ScholarshipScheme = "None";
            }

            Students.Add(student);
        }

        public List<Student> GetStudentDetails(string Name)
        {
            var res = Students.Where(item => item.ScholarshipScheme == Name).ToList();

            return res;
        }

        public string DeleteStudent(int id)
        {
            Student s = null;
            foreach (var item in Students)
            {
                if (item.StudentId == id)
                {
                    s = item;
                    break;
                }
            }
            if (s == null)
            {
                return "Invalid Id";
            }
            else
            {
                Students.Remove(s);
            }
            return "Student Removed Successfuully";

        }

    }
        internal class Program
        {
            static void Main(string[] args)
            {
                ScholarshipImpl impl = new ScholarshipImpl();

                // Adding Students
                impl.AddStudents(new Student
                {
                    StudentName = "Rahul",
                    StudentId = 1,
                    StudentScore = 95
                });

                impl.AddStudents(new Student
                {
                    StudentName = "Sneha",
                    StudentId = 2,
                    StudentScore = 80
                });

                impl.AddStudents(new Student
                {
                    StudentName = "Amit",
                    StudentId = 3,
                    StudentScore = 65
                });

                impl.AddStudents(new Student
                {
                    StudentName = "Neha",
                    StudentId = 4,
                    StudentScore = 50
                });

                Console.WriteLine("Students with Silver Scholarship:");
                var silverStudents = impl.GetStudentDetails("Silver");

                foreach (var s in silverStudents)
                {
                    Console.WriteLine($"{s.StudentName} - {s.StudentScore} - {s.ScholarshipScheme}");
                }

                Console.WriteLine();

                // Delete Student
                Console.WriteLine(impl.DeleteStudent(2));

                Console.WriteLine();

                Console.WriteLine("Students with Bronze Scholarship:");
                var bronzeStudents = impl.GetStudentDetails("Bronze");

                foreach (var s in bronzeStudents)
                {
                    Console.WriteLine($"{s.StudentName} - {s.StudentScore} - {s.ScholarshipScheme}");
                }

                Console.ReadLine();
            }
        }
    }


