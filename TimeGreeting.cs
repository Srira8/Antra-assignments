using System;

class TimeGreeting
{
    public static void GreetUser()
    {
        // Define the current time (you can change this for testing purposes)
        DateTime currentTime = DateTime.Now;

        // Extract the hour from the current time
        int hour = currentTime.Hour;

        // Greet based on the time of day
        if (hour >= 5 && hour < 12)
        {
            Console.WriteLine("Good Morning");
        }

        if (hour >= 12 && hour < 17)
        {
            Console.WriteLine("Good Afternoon");
        }

        if (hour >= 17 && hour < 21)
        {
            Console.WriteLine("Good Evening");
        }

        if (hour >= 21 || hour < 5)
        {
            Console.WriteLine("Good Night");
        }
    }
}
