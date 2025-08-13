namespace RPG
{
    class Mage : Character, ISpecialAbility
    {
        public Mage(string name, int health) : base(name, health) { }

        public override void Attack(Character target)
        {
            Console.WriteLine($"{Name} casts a fireball at {target.Name}.");
            target.TakeDamage(25);
        }

        public void UseSpecialAbility(Character target)
        {
            Console.WriteLine($"{Name} casts Heal!");
            this.Heal(30);
        }
    }
}
