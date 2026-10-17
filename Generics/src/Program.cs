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

        }
    }
}
