namespace Skole
{
    class SchoolClass
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public SchoolClass(Teacher teacher, List<Student> students)
        {
            Teacher = teacher;
            Students = students;
        }

        public void PrintClassInfo()
        {
            Console.WriteLine($"Teacher: {Teacher.Name} teaches {Teacher.Subject}");
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                Console.WriteLine($" - {student.Name} ({student.GradeLevel}. grade)");
            }
        }

        public double GetAverageAge()
        {
            return Students.Average(s => s.Age);
        }
    }
}
