using System;

class PyramidPattern
{
    public static void PrintPyramid(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            // Print spaces
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); // Move to the next line
        }
    }
}
