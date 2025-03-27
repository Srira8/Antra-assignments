using System;

class ArrayRotation
{
    // Method to rotate an array right k times and calculate the sum after each rotation
    public static void RotateAndSum(int[] array, int k)
    {
        int n = array.Length;
        int[] sum = new int[n];

        // Perform the rotations
        for (int r = 1; r <= k; r++)
        {
            // Create a temporary array to store the rotated version of the original array
            int[] rotated = new int[n];

            // Rotate the array right by r positions
            for (int i = 0; i < n; i++)
            {
                rotated[(i + r) % n] = array[i];
            }

            // Print the rotated array
            Console.WriteLine($"rotated{r}[] = " + string.Join(" ", rotated));

            // Add the rotated array elements to the sum array
            for (int i = 0; i < n; i++)
            {
                sum[i] += rotated[i];
            }
        }

        // Print the final sum array after all rotations
        Console.WriteLine("sum[] = " + string.Join(" ", sum));
    }
}
