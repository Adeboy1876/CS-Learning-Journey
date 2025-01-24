Random random = new Random();

int correctNumber = random.Next(1, 11);
int attempts = 3;
Console.WriteLine("Guess the number between 1 and 10");
Console.WriteLine("You have 3 attempts!");
bool isGuessedCorrectly = false;
for (int i = 1; i <= attempts; i++)
{
    Console.Write($"\nAttempt {i}: ");
    int guess;

    if (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 10)
    {
        Console.WriteLine("Please enter a valid number between 1 & 10.");
        i--;
        continue;
    }

    if (guess == correctNumber)
    {
        Console.WriteLine("You Guesed Correctly! You're a Winner!!!");
        isGuessedCorrectly = true;
        break;
    }
    else if (guess > correctNumber)
        {
            Console.WriteLine("Too High");
        }
    else 
        {

            Console.WriteLine("Too Low");
        }
}
if (isGuessedCorrectly)
{
    Console.WriteLine("\nThank You For Playing.");
}
else
{
    Console.WriteLine($"\n\nOut of attempts! The correct number was {correctNumber}");
}