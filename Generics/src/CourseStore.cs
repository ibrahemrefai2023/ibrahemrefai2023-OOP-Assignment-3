using System;

public class CourseStore
{
    public List<Course> Courses { get; set; }
    public void Add(Course course)
    {
        if (this.Courses == null)
        {
            this.Courses = new List<Course>();
        }
        Courses.Add(course);
        Console.WriteLine($"Course added: {course.Title}");
    }

    public Course? GetById(int id)
    {
        return Courses.FirstOrDefault(c => c.Id == id);
    }

    public void Remove(int id)
    {
        var course = Courses.FirstOrDefault(c => c.Id == id);
        if (course != null)
        {
            Courses.Remove(course);
            Console.WriteLine($"Course removed: {course.Title}");
        }
    }

    public List<Course> GetAll()
    {
        return Courses;
    }
}
