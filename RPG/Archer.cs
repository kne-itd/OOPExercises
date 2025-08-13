namespace RPG
{
    class Archer : Character, ISpecialAbility
    {
        public Archer(string name, int health) : base(name, health) { }

        public override void Attack(Character target)
        {
            Console.WriteLine($"{Name} shoots an arrow at {target.Name}.");
            target.TakeDamage(15);
        }

        public void UseSpecialAbility(Character target)
        {
            Console.WriteLine($"{Name} uses Double Shot!");
            target.TakeDamage(30);
        }
    }
}
