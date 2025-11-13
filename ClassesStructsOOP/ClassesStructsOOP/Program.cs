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

    internal class Program
    {
        static void Main(string[] args)
        {
            Character hero = new Character();
            hero.PrintStatsInfo();

            Character heroine = new Character("Artoria");
            heroine.PrintStatsInfo();
        }
    }
}
