using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

[DataContract]  // Use DataContract instead of Serializable
public class Student
{
    [DataMember] public int Id { get; set; }
    [DataMember] public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new Student { Id = 3, Name = "Bob" };

        // Step 1: Serialize to SOAP-like XML
        DataContractSerializer serializer = new DataContractSerializer(typeof(Student));
        using (FileStream fs = new FileStream("student.xml", FileMode.Create))
        {
            serializer.WriteObject(fs, s);
        }

        // Step 2: Deserialize back
        using (FileStream fs = new FileStream("student.xml", FileMode.Open))
        {
            Student deserialized = (Student)serializer.ReadObject(fs);
            Console.WriteLine($"Id: {deserialized.Id}, Name: {deserialized.Name}");
        }
    }
}
