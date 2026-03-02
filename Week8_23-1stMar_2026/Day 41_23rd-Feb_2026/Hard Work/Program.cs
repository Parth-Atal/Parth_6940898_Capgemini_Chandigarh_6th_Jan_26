namespace Hard_Work
{
    class Employee
    {
        public string Name { get; set; }
        public string ProjectName {  get; set; }
        public int WorkingHours {  get; set; }
        public int Bonus { get; set; }

        public string SetBonus()
        {
            if(ProjectName == "Web Api" &&  WorkingHours > 50)
            {
                Bonus = 5000;
            }
            else if(ProjectName == "FrontEnd" && WorkingHours > 40)
            {
                Bonus = 4000;
            }
            else
            {
                Bonus = 0;
            }

            return "Bonus Calculated Successfully, Bonus Amount: " + Bonus;

        }

        public string CheckName()
        {
            if (!String.IsNullOrEmpty(Name))
            {
                return Name + " Verified Employee \n" + "Bonus Calculated: " + Bonus;
            }

            return "Invalid Name";
            
        }

    }

class Program
    {
        static void Main(string[] args)
        {
            // Employee 1
            Employee emp1 = new Employee
            {
                Name = "Rahul",
                ProjectName = "Web Api",
                WorkingHours = 55
            };

            Console.WriteLine(emp1.SetBonus());
            Console.WriteLine(emp1.CheckName());

            Console.WriteLine();

            // Employee 2
            Employee emp2 = new Employee
            {
                Name = "Sneha",
                ProjectName = "FrontEnd",
                WorkingHours = 38
            };

            Console.WriteLine(emp2.SetBonus());
            Console.WriteLine(emp2.CheckName());

            Console.WriteLine();

            // Employee 3 (Invalid name case)
            Employee emp3 = new Employee
            {
                Name = "",
                ProjectName = "Web Api",
                WorkingHours = 60
            };

            Console.WriteLine(emp3.SetBonus());
            Console.WriteLine(emp3.CheckName());

            Console.ReadLine();
        }
    }
}
