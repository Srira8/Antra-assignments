//using System;
/*
class Program
{
    static void Main()
    {
        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "Type", "Bytes", "Min Value", "Max Value");
        Console.WriteLine(new string('-', 90));

        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "short", sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "int", sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "long", sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "float", sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "double", sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
    }
}
*/

using System;

class Program
{
    static void Main()
    {
        CountUpTo24.CountWithIncrements();
        TimeGreeting.GreetUser();
        DaysOld.CalculateAgeInDays();
        GuessNumber.GuessTheNumber();
        TimeConverter.ConvertTime();

        Console.Write("Enter the number of rows for the pyramid: ");
        int rows = int.Parse(Console.ReadLine());

        PyramidPattern.PrintPyramid(rows);

        Console.WriteLine("Executing FizzBuzz...");
        Exercise03.FizzBuzz();

        Console.WriteLine("\nExecuting Byte Overflow Demonstration...");
        Exercise03.ByteOverflow();

        Console.WriteLine("\nExecuting Number Guessing Game...");
        Exercise03.GuessNumber();


        Console.WriteLine("Welcome to the Hacker Name Generator!");

        // Ask for user input
        Console.Write("Enter your favorite color: ");
        string color = Console.ReadLine();

        Console.Write("Enter your astrology sign: ");
        string sign = Console.ReadLine();

        Console.Write("Enter your street address number: ");
        int addressNumber;

        // Validate user input
        while (!int.TryParse(Console.ReadLine(), out addressNumber))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        // Generate hacker name
        string hackerName = color + sign + addressNumber;

        // Display the result
        Console.WriteLine("Your hacker name is: " + hackerName);
    }
  
      

}
