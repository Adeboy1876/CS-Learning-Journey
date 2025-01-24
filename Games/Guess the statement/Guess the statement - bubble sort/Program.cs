using System;


class GuessTheStatement
{
    static void Main()
    {

        bool isCorrect = true;
        //terms to guess#
        string[] terms = { "Flowchart", "Pseudocode", "Algorithm", "sorting" };

        //Statement describing the terms
        string[] statements = {
            "I use symbols to represent algorithms",
            "I represent algorithms in language close to plain english",
            "A set of instructions that solve a problem",
            "I am used to order data from low to high"
        };

        //Correct answer corresponding to each statement
        string[] answers = { "Flowchart", "Pseudocode", "Algorithm", "sorting" };

        int score = 0;

        Console.WriteLine("Welcome to the 'Guess the statement' game!");
        Console.WriteLine("Which statement matches the correct terms");

        for (int i = 0; i < statements.Length; i++) 
        {
            Console.WriteLine($"Statement {i + 1}: {statements[i]}");
            Console.WriteLine("Choose an answer");


            //Display options
            for (int j=0; j < terms.Length; j++)
            {
                Console.WriteLine($"{j + 1}.{terms[j]}");
            }

            Console.Write("Your answer (1-4): ");
            int choice = int.Parse( Console.ReadLine() ) -1;

            //check the answer is corerct

            if (terms[choice] == answers[i])
            {
                Console.WriteLine("Correct\n");
                score++;
                isCorrect = true;
            }
            else 
            {
                isCorrect = false;
            }

            if (isCorrect == true)
            {
                Console.WriteLine($"Nice Your Score: {score} / {statements.Length}");
            }
            else
            {
                Console.WriteLine($"Game Over! Your Score: {score} / {statements.Length}");
                Console.WriteLine($"Incorrect! The answer was {answers[i]}\n");
            }
        }
    }
}