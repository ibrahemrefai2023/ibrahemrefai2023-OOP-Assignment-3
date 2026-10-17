using System;

public class StudentStore
{
    public List<Student> Students { get; set; }
    public void Add(Student student)
    {
        if(this.Students == null)
        {
            this.Students = new List<Student>();
        }
        Students.Add(student);
        Console.WriteLine($"Student added: {student.Name}");
    }

    public Student? GetById(int id)
    {
        return Students.FirstOrDefault(s => s.Id == id);
    }

    public void Remove(int id)
    {
        var student = Students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            Students.Remove(student);
            Console.WriteLine($"Student removed: {student.Name}");
        }
    }

    public List<Student> GetAll()
    {
        return Students;
    }

}
