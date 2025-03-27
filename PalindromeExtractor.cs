using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class PalindromeExtractor
{
    public static void ExtractPalindromes(string text)
    {
        // Use a regular expression to match all words
        string pattern = @"\b[a-zA-Z]+\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        // Create a HashSet to store unique palindromes (case-insensitive)
        HashSet<string> palindromes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (Match match in matches)
        {
            string word = match.Value;

            // Check if the word is a palindrome
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        // Sort the palindromes and join them into a single string, separated by comma and space
        var sortedPalindromes = palindromes.OrderBy(p => p).ToArray();
        Console.WriteLine(string.Join(", ", sortedPalindromes));
    }

    // Helper method to check if a word is a palindrome
    private static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (char.ToLower(word[left]) != char.ToLower(word[right]))
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
