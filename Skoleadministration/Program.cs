using System;
using System.Collections.Generic;
using System.Linq;

namespace Skole
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Jens", 40, "Matematik");
            List<Student> students = new List<Student>
            {
                new Student("Mette", 16, 1),
                new Student("Peter", 17, 2),
                new Student("Lars", 16, 1)
            };

            SchoolClass schoolClass = new SchoolClass(teacher, students);

            schoolClass.PrintClassInfo();
            Console.WriteLine($"Gennemsnitsalder: {schoolClass.GetAverageAge()} år");
        }
    }
}
