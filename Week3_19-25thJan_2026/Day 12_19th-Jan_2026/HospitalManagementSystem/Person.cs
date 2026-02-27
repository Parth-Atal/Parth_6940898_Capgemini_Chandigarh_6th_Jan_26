using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void DisplayProfile()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
        }
    }

    class Patient : Person
    {
        public int Age { get; set; }
        public MedicalRecord Record { get; set; }
    }

    class Doctor : Person
    {
        public string Specialization { get; set; }
    }

    class Nurse : Person
    {
        public string Shift { get; set; }
    }

    class MedicalRecord
    {
        private string diagnosis;
        private string treatment;

        public void AddRecord(string diag, string treat)
        {
            diagnosis = diag;
            treatment = treat;
        }

        public void ViewRecord()
        {
            Console.WriteLine("\n--- Medical Record ---");
            Console.WriteLine("Diagnosis: " + diagnosis);
            Console.WriteLine("Treatment: " + treatment);
        }
    }

    class Appointment
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public string Date { get; set; }

        public void DisplayAppointment()
        {
            Console.WriteLine("\n--- Appointment Details ---");
            Console.WriteLine("Patient: " + Patient.Name);
            Console.WriteLine("Doctor: " + Doctor.Name);
            Console.WriteLine("Date: " + Date);
        }
    }

}
