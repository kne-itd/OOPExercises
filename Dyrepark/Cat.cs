namespace Dyrepark
{
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override void MakeSound() => Console.WriteLine("Meow!");
        public override string Describe() => base.Describe() + " It’s a cat.";
    }
}
