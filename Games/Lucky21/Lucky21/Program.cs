using System;
using System.Text;
using System.Threading;

public class DiceRollerGame
{
    private static Random random = new Random(); // Generate random variable to use for dice roll

    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        StartGame();
    }

    // Start the game
    private static void StartGame()
    {
        Console.Clear(); // Clear the console at the beginning of the game

        Console.WriteLine("🎲 Welcome to Lucky 21! 🎲");
        Console.WriteLine("       ---------------------------------");
        Console.WriteLine("The Player vs Computer Virtual Dice Roller Game!");
        Console.WriteLine("       ---------------------------------\n\n");

        Player player1 = new Player(GetPlayerName(1));
        Player computer = new Player("Computer");

        PlayGame(player1, computer);

        // Ask if the player wants to play again after 3 rounds
        PlayAgain();
    }

    private static string GetPlayerName(int playerNumber)
    {
        Console.Write($"Enter name for Player {playerNumber}: ");
        return Console.ReadLine();
    }

    private static void PlayGame(Player player1, Player computer)
    {
        int maxRounds = 1;
        int attemptsPerRound = 3;
        int targetScore = 21;

        Console.WriteLine($"\n🎯 Objective: Roll the dice to get as close to 21 as possible without going over.");
        Console.WriteLine($"\n📜 Rule: First to reach exactly {targetScore} points wins the round. If a player exceeds {targetScore}, their turn ends but the round continues.");

        int playerRoundCount = 0;
        int computerRoundCount = 0;

        for (int round = 1; round <= maxRounds; round++)
        {
            Console.WriteLine($"\n--- 🏁 Starting Round {round} 🏁 ---");

            // Reset scores for each player at the beginning of each round
            player1.Score = 0;
            computer.Score = 0;

            // Player 1's turn for the entire round
            PlayerTurn(player1, attemptsPerRound, targetScore);

            // Computer's turn for the entire round
            ComputerTurn(computer, targetScore);

            // Determine the round winner and update scores accordingly
            DetermineRoundWinner(player1, computer, targetScore, ref playerRoundCount, ref computerRoundCount);

            // After the third round, determine the overall winner
            if (round == maxRounds)
            {
                DetermineOverallWinner(player1, playerRoundCount, computerRoundCount);
            }
        }
    }

    private static void PlayerTurn(Player player, int attemptsPerRound, int targetScore)
    {
        Console.WriteLine($"\n🎲 🧑{player.Name}'s turn!\n");

        for (int attempt = 1; attempt <= attemptsPerRound; attempt++)
        {
            Console.WriteLine($"\nAttempt {attempt}: Press Enter to roll the dice.");
            Console.ReadLine();

            // Display "Rolling..." with a little delay for effect
            Console.WriteLine("Rolling...\n");
            Thread.Sleep(1200); // 1.2 seconds delay for effect

            int roll = RollDice();
            Console.WriteLine($"🧑{player.Name} rolled: {GetDiceFace(roll)} ({roll})\n");

            player.Score += roll;
            Console.WriteLine($"🧑{player.Name}'s current score: {player.Score}");

            // If the player goes over 21, their turn ends immediately
            if (player.Score == targetScore)
            {
                Console.WriteLine($"🎉 Congrats {player.Name}!!! You hit the perfect score with {targetScore} points!");
                break;
            }
            else if (player.Score > targetScore)
            {
                Console.WriteLine($"🤡 Oops {player.Name} you exceeded {targetScore} and your turn ends.");
                break;
            }
        }
    }

    private static void ComputerTurn(Player computer, int targetScore)
    {
        Console.WriteLine($"\n🎲 🤖{computer.Name}'s turn!\n");

        // Simulate the computer's decision-making for rolling the dice
        // The computer will roll until it reaches 18 or exceeds the target score
        while (computer.Score < 18)
        {
            Console.WriteLine("Rolling...\n");
            Thread.Sleep(1200);  // Simulate delay for effect

            int roll = RollDice();
            Console.WriteLine($"🤖{computer.Name} rolled: {GetDiceFace(roll)} ({roll})");

            computer.Score += roll;
            Console.WriteLine($"🤖{computer.Name}'s current score: {computer.Score}");

            // If the computer goes over 21, its turn ends
            if (computer.Score > targetScore)
            {
                Console.WriteLine($"😞 Oops 🤖{computer.Name}, you exceeded {targetScore} and your turn ends!");
                break;
            }
            else if (computer.Score == targetScore)
            {
                Console.WriteLine($"🎉 Congrats 🤖{computer.Name}!!! They hit the perfect score with {targetScore} points!");
                break;
            }
        }
    }

    private static int RollDice()
    {
        return random.Next(1, 7); // Roll a 6-sided dice (1 to 6)
    }

    private static string GetDiceFace(int roll)
    {
        // Use a switch statement to display the corresponding dice face emoji
        switch (roll)
        {
            case 1: return "⚀";
            case 2: return "⚁";
            case 3: return "⚂";
            case 4: return "⚃";
            case 5: return "⚄";
            case 6: return "⚅";
            default: return "❓";  // In case something goes wrong
        }
    }

    private static void DetermineRoundWinner(Player player1, Player computer, int targetScore, ref int playerRoundCount, ref int computerRoundCount)
    {
        Console.WriteLine($"\nRound over! Final scores:");
        Console.WriteLine($"🧑{player1.Name}: {player1.Score} points");
        Console.WriteLine($"🤖{computer.Name}: {computer.Score} points");

        // Determine who is closest to 21
        int difference1 = Math.Abs(targetScore - player1.Score);
        int difference2 = Math.Abs(targetScore - computer.Score);

        if (difference1 < difference2)
        {
            Console.WriteLine($"🧑{player1.Name} wins this round as they are closer to {targetScore}!🎉");
            playerRoundCount++;  // Player wins this round, so increment their score
        }
        else if (difference2 < difference1)
        {
            Console.WriteLine($"🤖{computer.Name} wins this round as they are closer to {targetScore}!🎉");
            computerRoundCount++;  // Computer wins this round, so increment their score
        }
        else
        {
            Console.WriteLine("🤝 It's a tie for this round!");
            // No one gets a point for the round
        }
    }

    private static void DetermineOverallWinner(Player player1, int playerRoundCount, int computerRoundCount)
    {
        Console.WriteLine("\n\n🎮 Game Over!!! 🎮\n\n");
        Console.WriteLine($"Total Round points -- {player1.Name}🧑: {playerRoundCount} Computer🤖: {computerRoundCount}");

        if (playerRoundCount > computerRoundCount)
        {
            Console.WriteLine($"🎉 🧑{player1.Name} wins the game! 🏆");
        }
        else if (computerRoundCount > playerRoundCount)
        {
            Console.WriteLine("🎉 🤖Computer wins the game! 🏆");
        }
        else
        {
            Console.WriteLine("🤝 It's a tie! No winner.");
        }
    }

    private static void PlayAgain()
    {
        Console.WriteLine("\nDo you want to play again? Y for Yes, N for No");
        string input = Console.ReadLine()?.ToUpper();  // Get user input and make it uppercase

        if (input == "Y")
        {
            // Clear the console and restart the game
            StartGame();
        }
        else if (input == "N")
        {
            Console.WriteLine("Thanks for playing! Goodbye! 👋");
            Environment.Exit(0);  // Exit the game
        }
        else
        {
            Console.WriteLine("Invalid input. Please press Y for Yes or N for No.");
            PlayAgain();  // Ask again if the input is invalid
        }
    }
}

public class Player
{
    public string Name { get; }
    public int Score { get; set; }

    public Player(string name)
    {
        Name = name;
        Score = 0;
    }
}
