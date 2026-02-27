using UniversityEnrollmentSystem;

class Program
{
    static void Main()
    {
        Student s = new Student
        {
            Name = "Parth",
            Course = "AI",
            Department = "Computer Science"
        };
        s.Disp();

        Professor p = new Professor
        {
            Name = "Dr. Sharma",
            Course = "AI",
            Department = "Computer Science",
            Time = "10 AM - 12 PM"
        };
        p.Disp();

        Staff st = new Staff
        {
            Name = "Rahul",
            Department = "Administration",
            Time = "9 AM - 5 PM"
        };
        st.Disp();
    }
}
