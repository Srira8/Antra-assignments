using System;

class GuessNumber
{
    public static void GuessTheNumber()
    {
        Random random = new Random();
        int correctNumber = random.Next(1, 4); // Generates a number between 1 and 3

        Console.WriteLine("Guess a number between 1 and 3:");

        // Read user's guess
        int guessedNumber = int.Parse(Console.ReadLine());

        if (guessedNumber < 1 || guessedNumber > 3)
        {
            Console.WriteLine("Your guess is out of range! Please enter a number between 1 and 3.");
        }
        else if (guessedNumber < correctNumber)
        {
            Console.WriteLine("Too low!");
        }
        else if (guessedNumber > correctNumber)
        {
            Console.WriteLine("Too high!");
        }
        else
        {
            Console.WriteLine("Correct! You guessed the right number.");
        }
    }
}
