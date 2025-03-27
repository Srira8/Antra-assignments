using System;

class Exercise03
{
    // FizzBuzz Game
    public static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }

    // Byte Overflow Demonstration
    public static void ByteOverflow()
    {
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);
            if (i == 255) // Prevent infinite loop due to overflow
            {
                Console.WriteLine("Warning: Byte will overflow and wrap around!");
                break;
            }
        }
    }

    // Number Guessing Game
    public static void GuessNumber()
    {
        Random random = new Random();
        int correctNumber = random.Next(3) + 1; // Generates a number between 1 and 3

        Console.WriteLine("Guess a number between 1 and 3:");
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
