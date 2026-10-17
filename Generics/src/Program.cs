namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Store<Course> courseStore = new Store<Course>();
            var course1 = new Course { Id = 1, Title = "C# Basics", Price = 49.99m };
            var course2 = new Course { Id = 2, Title = "Advanced C#", Price = 99.99m };
            courseStore.Add(course1);
            courseStore.Add(course2);
            var retrievedCourse = courseStore.GetById(1);
            Console.WriteLine($"Retrieved Course: {retrievedCourse?.Title}");
            courseStore.Remove(1);
            var allCourses = courseStore.GetAll();
            Console.WriteLine("All Courses:");
            foreach (var c in allCourses)
            {
                Console.WriteLine($" - {c.Title}");
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            Store<Student> studentStore = new Store<Student>();
            var student1 = new Student { Id = 1, Name = "John Doe" };
            var student2 = new Student { Id = 1, Name = "Jane Smith" };
            studentStore.Add(student1);
            studentStore.Add(student2);
            var retrievedStudent = studentStore.GetById(1);
            Console.WriteLine($"Retrieved Student: {retrievedStudent?.Name}");
            studentStore.Remove(1);
            var allStudents = studentStore.GetAll();
            Console.WriteLine("All Students:");
            foreach (var s in allStudents)
            {
                Console.WriteLine($" - {s.Name}");
            }
        }
    }
}
