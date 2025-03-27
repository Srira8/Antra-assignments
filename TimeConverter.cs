using System;
using System.Numerics; // Required for handling large numbers

public class TimeConverter
{
    public static void ConvertTime()
    {
        Console.Write("Enter number of centuries: ");
        int centuries;

        while (!int.TryParse(Console.ReadLine(), out centuries) || centuries < 0)
        {
            Console.Write("Invalid input. Please enter a positive integer: ");
        }

        int years = centuries * 100;
        int days = (int)(years * 365.2425); // Accounting for leap years
        long hours = days * 24L;
        long minutes = hours * 60L;
        long seconds = minutes * 60L;
        long milliseconds = seconds * 1000L;
        BigInteger microseconds = milliseconds * 1000L;
        BigInteger nanoseconds = microseconds * 1000L;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        Console.WriteLine($"= {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}
