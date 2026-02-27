using Patient_CaseStudy;
using System;
using System.Collections.Generic;

namespace Patient_CaseStudy;
class Program
{
    static void Main(string[] args)
    {
        List<Patient> patientList = new List<Patient>();
        int noOfPatients;

        Console.WriteLine("Enter the number of patients");
        noOfPatients = int.Parse(Console.ReadLine());

        for (int i = 0; i < noOfPatients; i++)
        {
            Console.WriteLine("Enter patient " + (i + 1) + " details:");
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the illness");
            string illness = Console.ReadLine();

            Console.WriteLine("Enter the city");
            string city = Console.ReadLine();

            Patient patient = new Patient(name, age, illness, city);
            patientList.Add(patient);
        }

        PatientBO patientBO = new PatientBO();
        string opt;
        do
        {
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1)Display Patient Details");
            Console.WriteLine("2)Display Youngest Patient Details");
            Console.WriteLine("3)Display Patients from City");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter patient name:");
                    string pname = Console.ReadLine();
                    patientBO.DisplayPatientDetails(patientList, pname);
                    break;

                case 2:
                    patientBO.DisplayYoungestPatientDetails(patientList);
                    break;

                case 3:
                    Console.WriteLine("Enter city");
                    string cname = Console.ReadLine();
                    patientBO.displayPatientsFromCity(patientList, cname);
                    break;
            }

            Console.WriteLine("Do you want to continue(Yes/No)?");
            opt = Console.ReadLine();

        } while (opt.Equals("Yes"));
    }
}
