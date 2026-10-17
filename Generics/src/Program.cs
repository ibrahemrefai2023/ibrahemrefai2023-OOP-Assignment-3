namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Store<Course> courseStore = new Store<Course>();
            var course1 = new Course { Id = 1, Title = "C# Basics", Price = 49.99m };
            var course2 = new Course { Id = 2, Title = "Advanced C#", Price = 99.99m };
            var course3 = new Course { Id = 3, Title = "C# Advanced Topics", Price = 149.99m };
            courseStore.Add(course1);
            courseStore.Add(course2);
            courseStore.Add(course3);
            var retrievedCourse = courseStore.GetById(1);
            Console.WriteLine($"Retrieved Course: {retrievedCourse?.Title}");
            Console.WriteLine("");
            Console.WriteLine(" call FindById on a plain List<Course>");
            var courses = courseStore.GetAll();
            var (course, id) = courses.FindById(2);
            Console.WriteLine($"Found Course: {course.Title} with ID: {id}");

            Console.WriteLine("------------------------------------------------------------------------------");
            Store<Student> studentStore = new Store<Student>();
            var student1 = new Student { Id = 1, Name = "John Doe" };
            var student2 = new Student { Id = 2, Name = "Jane Smith" };
            var student3 = new Student { Id = 3, Name = "Bob Johnson" };
            var student4 = new Student { Id = 4, Name = "Alice Brown" };
            var student5 = new Student { Id = 4, Name = "Charlie Davis" };
            studentStore.Add(student1);
            studentStore.Add(student2);
            studentStore.Add(student3);
            studentStore.Add(student4);
            //studentStore.Add(student5);
            var retrievedStudent = studentStore.GetById(1);
            Console.WriteLine($"Retrieved Student: {retrievedStudent?.Name}");
            Console.WriteLine("");
            var students = studentStore.GetAll();
            var paginationResult = students.Page(2, 2);
            Console.WriteLine("page 2 (size 2) of the students");
            foreach (var s in paginationResult)
            {
                Console.WriteLine($" student: {s.Name}");
            }

            // var store = new Store<string>();        Must NOT compile:
        }
    }
}
