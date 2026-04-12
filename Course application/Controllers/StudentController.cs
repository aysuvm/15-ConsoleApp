using DomainLayer.Entities;
using ServiceLayer.Services.Implementations;

public class StudentController
{
    private StudentService _studentService = new();

    public void CreateStudent()
    {
        Console.WriteLine("Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Surname:");
        string surname = Console.ReadLine();

        Console.WriteLine("Age:");
        int age = int.Parse(Console.ReadLine());

        Student student = new()
        {
            Name = name,
            Surname = surname,
            Age = age
        };

        _studentService.Create(student);

        Console.WriteLine("Student created");
    }

    public void GetStudentById()
    {
        int id = int.Parse(Console.ReadLine());

        var student = _studentService.GetById(id);

        if (student != null)
            Console.WriteLine($"{student.Name} {student.Surname}");
        else
            Console.WriteLine("Not found");
    }
}
