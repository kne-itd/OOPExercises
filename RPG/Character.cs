namespace RPG
{
    abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public abstract void Attack(Character target);

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} takes {amount} damage. Health now {Health}.");
        }

        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} heals {amount}. Health now {Health}.");
        }
    }
}
