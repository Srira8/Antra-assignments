using System;

class StringReverser
{
    public static void ReverseString(string input)
    {
        // Method 1: Using Char Array
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedUsingArray = new string(charArray);

        // Method 2: Using a Loop
        string reversedUsingLoop = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedUsingLoop += input[i];
        }

        // Display results
        Console.WriteLine("Reversed using Char Array: " + reversedUsingArray);
        Console.WriteLine("Reversed using Loop: " + reversedUsingLoop);
    }
}
