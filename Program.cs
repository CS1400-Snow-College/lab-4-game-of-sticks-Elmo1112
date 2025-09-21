
class SticksGame
{
    static void Main()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("- Welcome to the game of sticks! -");
        Console.WriteLine("----------------------------------\n");
        Console.WriteLine("Players will take turns removing between 1 and 3 of the remaining sticks.");
        Console.WriteLine("The player that removes the last stick loses.\n");

        int numberOfSticks = 20;
        int currentPlayer = 1;

        while (numberOfSticks > 0)
        {
            Console.WriteLine($"Sticks left: {numberOfSticks}");
            Console.Write($"Player {currentPlayer}, how many sticks would you like to take? ");

            string input = Console.ReadLine();
            int sticksTaken;

            if (!int.TryParse(input, out sticksTaken))
            {
                Console.WriteLine("Please enter a number.\n");
                continue;
            }

            if (sticksTaken < 1)
            {
                Console.WriteLine("Please choose at least 1 stick.\n");
                continue;
            }
            if (sticksTaken > 3)
            {
                Console.WriteLine("You cannot take more than 3 sticks.\n");
                continue;
            }
            if (sticksTaken > numberOfSticks)
            {
                Console.WriteLine("Sorry, there are not {sticksTaken} sticks left.\n");
                continue;
            }

            numberOfSticks -= sticksTaken;

            if (numberOfSticks == 0)
            {
                int otherPlayer = (currentPlayer == 1) ? 2 : 1;
                Console.WriteLine("\n/---------------\\");
                Console.WriteLine("| Player {otherPlayer} won! |");
                Console.WriteLine("\\---------------/");
                break;
            }

            currentPlayer = (currentPlayer == 1) ? 2 : 1;
        }
    }
}

