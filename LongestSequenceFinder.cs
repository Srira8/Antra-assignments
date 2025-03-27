using System;

class LongestSequenceFinder
{
    public static void FindLongestSequence(int[] array)
    {
        int maxLength = 1, maxStartIndex = 0;
        int currentLength = 1, currentStartIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;
                currentStartIndex = i;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxStartIndex = currentStartIndex;
            }
        }

        // Print the longest sequence
        for (int i = maxStartIndex; i < maxStartIndex + maxLength; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
