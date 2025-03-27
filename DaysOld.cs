using System;

class DaysOld
{
    public static void CalculateAgeInDays()
    {
        // Define the birth date (example: January 1, 1990)
        DateTime birthDate = new DateTime(1990, 1, 1);

        // Get the current date
        DateTime currentDate = DateTime.Now;

        // Calculate the total number of days old
        TimeSpan age = currentDate - birthDate;
        int daysOld = age.Days;

        // Output the current age in days
        Console.WriteLine($"You are {daysOld} days old.");

        // Calculate the number of days until the next 10,000-day anniversary
        int daysToNextAnniversary = 10000 - (daysOld % 10000);

        // Calculate the date of the next 10,000-day anniversary
        DateTime nextAnniversary = currentDate.AddDays(daysToNextAnniversary);

        // Output the date of the next 10,000-day anniversary
        Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversary.ToShortDateString()}.");
    }
}
