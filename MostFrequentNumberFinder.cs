using System;
using System.Collections.Generic;
using System.Linq;

class MostFrequentNumberFinder
{
    public static void FindMostFrequentNumber(int[] array)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        // Count occurrences of each number
        foreach (int num in array)
        {
            if (frequencyMap.ContainsKey(num))
                frequencyMap[num]++;
            else
                frequencyMap[num] = 1;
        }

        // Find the maximum frequency
        int maxFrequency = frequencyMap.Values.Max();

        // Find the leftmost number with max frequency
        int mostFrequent = array.First(num => frequencyMap[num] == maxFrequency);

        // Print the result
        Console.WriteLine($"The number {mostFrequent} is the most frequent (occurs {maxFrequency} times)");
    }
}
