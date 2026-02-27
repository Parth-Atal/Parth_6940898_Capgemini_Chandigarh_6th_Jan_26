namespace HospitalManagementSystem
{
    class Program
    {
        static void Main()
        {
            Doctor d1 = new Doctor
            {
                Id = 1,
                Name = "Dr. Sharma",
                Specialization = "Cardiology"
            };

            Patient p1 = new Patient
            {
                Id = 101,
                Name = "Parth",
                Age = 21,
                Record = new MedicalRecord()
            };

            p1.Record.AddRecord("High Fever", "Paracetamol");

            Appointment appt = new Appointment
            {
                Patient = p1,
                Doctor = d1,
                Date = "20-01-2026"
            };

            appt.DisplayAppointment();
            p1.Record.ViewRecord();
        }
    }

}
