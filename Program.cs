namespace Challenge
{
    class Program
    {
        static void Main()
        {
            Pack pack = new Pack(10, 20, 15);

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Arrow");
                Console.WriteLine("2. Add Bow");
                Console.WriteLine("3. Add Rope");
                Console.WriteLine("4. Add Water");
                Console.WriteLine("5. Add Food Rations");
                Console.WriteLine("6. Add Sword");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        if (pack.Add(new Arrow()))
                        {
                            Console.WriteLine("Arrow added to the pack.");
                        }
                        else
                        {
                            Console.WriteLine("Cannot add Arrow to the pack. Limit reached.");
                        }
                        break;

                    case "2":
                        if (pack.Add(new Bow()))
                        {
                            Console.WriteLine("Bow added to the pack.");
                        }
                        else
                        {
                            Console.WriteLine("Cannot add Bow to the pack. Limit reached.");
                        }
                        break;

                    case "3":
                        if (pack.Add(new Rope()))
                        {
                            Console.WriteLine("Rope added to the pack.");
                        }
                        else
                        {
                            Console.WriteLine("Cannot add Rope to the pack. Limit reached.");
                        }
                        break;

                    case "4":
                        if (pack.Add(new Water()))
                        {
                            Console.WriteLine("Water added to the pack.");
                        }
                        else
                        {
                            Console.WriteLine("Cannot add Water to the pack. Limit reached.");
                        }
                        break;

                    case "5":
                        if (pack.Add(new FoodRations()))
                        {
                            Console.WriteLine("Food Rations added to the pack.");
                        }
                        else
                        {
                            Console.WriteLine("Cannot add Food Rations to the pack. Limit reached.");
                        }
                        break;

                    case "6":
                        if (pack.Add(new Sword()))
                        {
                            Console.WriteLine("Sword added to the pack.");
                        }
                        else
                        {
                            Console.WriteLine("Cannot add Sword to the pack. Limit reached.");
                        }
                        break;

                    case "7":
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine($"Current items in pack: {pack.ItemCount}");
                Console.WriteLine($"Current weight: {pack.CurrentWeight}");
                Console.WriteLine($"Current volume: {pack.CurrentVolume}");
                Console.WriteLine($"Max items: {pack.MaxItemCount}");
                Console.WriteLine($"Max weight: {pack.MaxWeight}");
                Console.WriteLine($"Max volume: {pack.MaxVolume}");
                Console.WriteLine();
            }
        }
    }
}