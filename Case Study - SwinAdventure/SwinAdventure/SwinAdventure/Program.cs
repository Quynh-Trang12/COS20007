namespace SwinAdventure
{
    public class program
    {
                    
        public static void Main()
        {
            Console.WriteLine("Enter player name:");
            string name = Console.ReadLine();

            Console.WriteLine($"\nEnter a description for {name}");
            string description = Console.ReadLine();

            Console.WriteLine($"\nYou are {name}, {description}");

            Player player = new Player(name , description);
            Item sword = new Item(new string[] { "sword" }, "bronze sword", "this is a bronze sword");
            Item shield = new Item(new string[] { "shield" }, "wooden shield", "this is a wooden shield");
            Item gem = new Item(new string[] { "gem" }, "red gem", "this is a red gem");
            Bag bag = new Bag(new string[] {"bag"}, "bag", "this is a bag");

            player.Inventory.Put(sword);
            player.Inventory.Put(shield);
            player.Inventory.Put(bag);
            bag.Inventory.Put(gem);

            Look_Command look = new Look_Command();

            string options = ($"\nOPTIONS:" +
            $"\nLook at (me/inventory): Reveals description of you and items you have." +
            $"\nLook at (item): Description of item" +
            $"\nLook at (bag): Description of container and its contents." +
            $"\nLook at (item) in (bag/inventory): Description of item in that container." +
            $"\nOptions: Show commands." +
            $"\nExit: Quit Game." +
            $"\nPlease select one of these options.\n");

            Console.WriteLine(options);

            bool game = true;
            do
            {
                string ask = Console.ReadLine().ToLower();
                string[] Input = ask.Split(' ');

                if (ask == "exit")
                {
                    Console.WriteLine("Game Over.");
                    break;

                }
                if (ask == "options")
                {
                    Console.WriteLine(options);
                    continue;
                }

                Console.WriteLine((look.Execute(player, Input)) + $"\n");

            }while (game == true);    
        }
    }
}





