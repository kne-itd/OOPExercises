using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Character warrior = new Warrior("Thorin", 100);
            Archer archer = new Archer("Legolas", 80);
            Mage mage = new Mage("Gandalf", 70);

            warrior.Attack(archer);
            archer.UseSpecialAbility(warrior);
            mage.UseSpecialAbility(warrior);
        }
    }
}
