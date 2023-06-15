using System.Threading;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dungeonRooms = Console.ReadLine()
                .Split('|')
                .ToList();
            int health = 100;
            int bitcoins = 0;
            for (int i = 0; i < dungeonRooms.Count; i++)
            {
                List<string> command = dungeonRooms[i].ToString()
                    .Split()
                    .ToList();
                int value = int.Parse(command[1]);
                switch (command[0])
                {
                    case "potion":
                        if (health <= 100)
                        {
                            int missingHealth = 100 - health;
                            health += value;
                            if (health > 100)
                            {
                                Console.WriteLine($"You healed for {missingHealth} hp.");
                                health = 100;
                                Console.WriteLine($"Current health: {health} hp.");
                                break;
                            }
                        Console.WriteLine($"You healed for {value} hp.");
                        }
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        bitcoins += value;
                        Console.WriteLine($"You found {value} bitcoins.");
                        break;
                    default:
                        string monster = command[0];
                        health -= value;
                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {i+1}");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {monster}."); 
                        }
                        break;
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}