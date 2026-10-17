namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student { Id = 1, Name = "John Doe" };
            Student student2 = new Student { Id = 2, Name = "Jane Smith" };
            StudentStore store = new StudentStore();
            store.Add(student1);
            store.Add(student2);
            var retrievedStudent = store.GetById(1);
            Console.WriteLine($"Retrieved Student: {retrievedStudent?.Name}");
            store.Remove(1);
            var allStudents = store.GetAll();
            Console.WriteLine("All Students:");
            foreach (var s in allStudents)
            {
                Console.WriteLine($" - {s.Name}");
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            Course course1 = new Course { Id = 1, Title = "Introduction to Programming", Price = 100.00m };
            Course course2 = new Course { Id = 2, Title = "Advanced C# Programming", Price = 150.00m };
            CourseStore courseStore = new CourseStore();
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

        }
    }
}
