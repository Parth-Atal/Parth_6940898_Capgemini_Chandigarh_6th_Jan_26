using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_CaseStudy
{
    class PatientBO
    {
        public void DisplayPatientDetails(List<Patient> patientList, string name)
        {
            List<Patient> result = (from p in patientList
                                    where p.Name == name
                                    select p).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("Patient named {0} not found", name);
            }
            else
            {
                Console.WriteLine("Name                 Age   Illness          City");
                foreach (Patient p in result)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }

        public void DisplayYoungestPatientDetails(List<Patient> patientList)
        {
            int minAge = (from p in patientList
                          select p.Age).Min();

            Patient youngest = (from p in patientList
                                where p.Age == minAge
                                select p).First();

            Console.WriteLine("The Youngest Patient Details");
            Console.WriteLine("Name                 Age   Illness          City");
            Console.WriteLine(youngest.ToString());
        }

        public void displayPatientsFromCity(List<Patient> patientList, string cname)
        {
            List<Patient> result = (from p in patientList
                                    where p.City == cname
                                    select p).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("City named {0} not found", cname);
            }
            else
            {
                Console.WriteLine("Name                 Age   Illness          City");
                foreach (Patient p in result)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }
    }

}
