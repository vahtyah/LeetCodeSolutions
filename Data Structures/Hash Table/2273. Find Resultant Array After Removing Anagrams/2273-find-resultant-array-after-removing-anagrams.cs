namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 2273. Find Resultant Array After Removing Anagrams
 * Difficulty: Easy
 * Submission Time: 2025-10-13 13:18:24
 * Created by vahtyah on 2025-10-13 13:19:43
*/
 
public class Solution 
{
    public IList<string> RemoveAnagrams(string[] words)
    {
        var result = new List<string> { words[0] };
        
        for (int i = 1; i < words.Length; i++)
        {
            if (!AreAnagrams(words[i - 1], words[i]))
            {
                result.Add(words[i]);
            }
        }

        return result;
    }

    private bool AreAnagrams(string word1, string word2)
    {
        if (word1 == word2) 
            return true;
            
        if (word1.Length != word2.Length) 
            return false;

        var charCount = new int[26];

        foreach (char c in word1)
        {
            charCount[c - 'a']++;
        }

        foreach (char c in word2)
        {
            if (--charCount[c - 'a'] < 0)
                return false;
        }

        return true;
    }
}