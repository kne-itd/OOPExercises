namespace Dyrepark
{
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void MakeSound() => Console.WriteLine("Woof!");
        public override string Describe() => base.Describe() + " It’s a dog.";
    }
}
