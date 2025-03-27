using System;
using System.Collections.Generic;

public static class PrimeMethods
{
    // FindPrimesInRange method that calculates all prime numbers in the given range
    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        // List to store prime numbers
        List<int> primes = new List<int>();

        // Loop through the range and check for primes
        for (int num = startNum; num <= endNum; num++)
        {
            if (IsPrime(num))
            {
                primes.Add(num);
            }
        }

        // Return the list as an array
        return primes.ToArray();
    }

    // Helper method to check if a number is prime
    private static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
