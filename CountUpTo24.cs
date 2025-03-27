using System;

class CountUpTo24
{
    public static void CountWithIncrements()
    {
        // Outer loop: counts from 1 to 4 (for different increments)
        for (int increment = 1; increment <= 4; increment++)
        {
            // Inner loop: counts from 0 to 24, increasing by 'increment'
            for (int i = 0; i <= 24; i += increment)
            {
                Console.Write(i); // Print the current value of i

                // Print a comma and space, except for the last number in the sequence
                if (i + increment <= 24)
                    Console.Write(",");
            }
            // Move to the next line after each sequence
            Console.WriteLine();
        }
    }
}
