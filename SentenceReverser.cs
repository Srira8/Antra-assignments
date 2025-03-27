using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class SentenceReverser
{
    public static void ReverseWordsInSentence(string sentence)
    {
        // Define separators as punctuation and spaces
        string separators = @"[.,:;=()&\[\]\""'\\/!? ]+";

        // Extract words and separators
        string[] words = Regex.Split(sentence, separators);
        MatchCollection matches = Regex.Matches(sentence, separators);

        // Reverse the words (ignoring empty entries)
        List<string> wordList = new List<string>();
        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                wordList.Add(word);
            }
        }
        wordList.Reverse();

        // Reconstruct the sentence
        int wordIndex = 0;
        string result = "";
        foreach (Match match in matches)
        {
            result += (wordIndex < wordList.Count ? wordList[wordIndex++] : "") + match.Value;
        }

        Console.WriteLine(result);
    }
}
