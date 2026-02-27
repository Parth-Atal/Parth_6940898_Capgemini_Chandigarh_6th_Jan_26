using System;
using System.IO;
using System.Text.Json;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new Student { Id = 1, Name = "John Doe" };

        string jsonString = JsonSerializer.Serialize(s);

        using (StreamWriter writer = new StreamWriter("student.json"))
        {
            writer.Write(jsonString);
        }

        string readJson;
        using (StreamReader reader = new StreamReader("student.json"))
        {
            readJson = reader.ReadToEnd();
        }

        Student deserialized = JsonSerializer.Deserialize<Student>(readJson);

        Console.WriteLine($"Id: {deserialized.Id}, Name: {deserialized.Name}");
    }
}
