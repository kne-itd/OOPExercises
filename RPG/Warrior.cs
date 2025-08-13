namespace RPG
{
    class Warrior : Character, ISpecialAbility
    {
        public Warrior(string name, int health) : base(name, health) { }

        public override void Attack(Character target)
        {
            Console.WriteLine($"{Name} swings a sword at {target.Name}.");
            target.TakeDamage(20);
        }

        public void UseSpecialAbility(Character target)
        {
            Console.WriteLine($"{Name} uses Power Strike!");
            target.TakeDamage(40);
        }
    }
}
