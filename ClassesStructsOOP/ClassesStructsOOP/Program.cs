namespace ClassesStructsOOP
{
    public class Character
    {
        public string name;
        public int exp = 0;

        public Character()
        {
            name = "Not assigned";
        }

        public Character (string name)
        {
            this.name = name;
        }

        public void PrintStatsInfo()
        {
            Console.WriteLine($"Hero: {this.name} - {this.exp} EXP");
        }
    }

    public struct Weapon
    {
        public string name;
        public int damage;

        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public void PrintWeaponStats()
        {
            Console.WriteLine($"Weapon: {this.name} - {this.damage} DMG");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Character class instances
            Character hero = new Character();
            hero.PrintStatsInfo();

            Character heroine = new Character("Artoria");
            heroine.PrintStatsInfo();

            //Weapon struct instance
            Weapon huntingBow = new Weapon("Hunting Bow", 105);
            huntingBow.PrintWeaponStats();

            //Testing reference types
            Character villain = hero;
            hero.PrintStatsInfo();
            villain.PrintStatsInfo();

            villain.name = "Gilgamesh";
            hero.PrintStatsInfo();
            villain.PrintStatsInfo();
        }
    }
}
