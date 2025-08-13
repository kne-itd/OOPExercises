namespace Skole
{
    class Student : Person
    {
        public int GradeLevel { get; set; }

        public Student(string name, int age, int gradeLevel) : base(name, age)
        {
            GradeLevel = gradeLevel;
        }
    }
}
