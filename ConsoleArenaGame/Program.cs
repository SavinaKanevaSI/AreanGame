using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the arena! Here are the fighters you can choose from:");
            Console.WriteLine("Assassin, Knight, Fairy, Unicorn, Wizard");
            Console.Write("Please write down the first opponent: ");
            string firstHero = Console.ReadLine().ToLower();//to lower = всички написани букви ще бъдат прочетени като малки 
            Hero hero1;//първият герой 

            Console.Write("Please write down the second opponent: ");
            string secondHero = Console.ReadLine().ToLower();
            Hero hero2;//вторият герой

            switch (firstHero)
            {
                case "assassin": hero1 = new Assassin("Assassin", 50, 90, new Dagger("Dagger")); break;
                case "knight": hero1 = new Knight("Knight", 53, 77, new Sword("Sword")); break;
                case "fairy": hero1 = new Fairy("Fairy", 38, 76, new Wings("Wings")); break;
                case "unicorn": hero1 = new Unicorn("Unicorn", 63, 100, new Star("Star")); break;
                case "wizard": hero1 = new Wizard("Wizard", 47, 94, new Wand("Wand")); break;
                default: hero1 = new Unicorn("Unicorn", 53, 90, new Star("Star")); break; break;//ако не се изпълни никой друг случай, се изпълнява този
            }

            switch (secondHero)
            {
                case "assassin": hero2 = new Assassin("Assassin", 50, 90, new Dagger("Dagger")); break;
                case "knight": hero2 = new Knight("Knight", 53, 77, new Sword("Sword")); break;
                case "fairy": hero2 = new Fairy("Fairy", 38, 76, new Wings("Wings")); break;
                case "unicorn": hero2 = new Unicorn("Unicorn", 63, 100, new Star("Star")); break;
                case "wizard": hero2 = new Wizard("Wizard", 47, 94, new Wand("Wand")); break;
                default: hero2 = new Fairy("Fairy", 28, 66, new Wings("Wings")); break; break;//ако не се изпълни никой друг случай, се изпълнява този
            }

            GameEngine gameEngine = new GameEngine()
            {
                HeroA = hero1,
                HeroB = hero2,
                NotificationsCallBack = ConsoleNotification
                //NotificationsCallBack = args => Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack} and caused {args.Damage} damage.")
            };

            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
            Console.WriteLine("Thank you for playing!");
        }
    }
}