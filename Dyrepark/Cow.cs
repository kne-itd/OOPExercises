namespace Dyrepark
{
    class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age) { }

        public override void MakeSound() => Console.WriteLine("Moo!");
        public override string Describe() => base.Describe() + " It’s a cow.";
    }
}
