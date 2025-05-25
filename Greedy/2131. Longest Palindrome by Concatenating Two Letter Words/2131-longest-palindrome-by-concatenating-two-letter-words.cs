namespace LeetCodeSolutions.Greedy;

/*
 * 2131. Longest Palindrome by Concatenating Two Letter Words
 * Difficulty: Medium
 * Submission Time: 2025-05-25 07:22:31
 * Created by vahtyah on 2025-05-25 07:22:54
*/
 
public class Solution 
{
    public int LongestPalindrome(string[] words) 
    {
        var letterPairCounts = new int[26, 26];
        
        foreach (var word in words)
        {
            letterPairCounts[word[0] - 'a', word[1] - 'a']++;
        }
        
        int palindromePairs = 0;
        bool hasOddPalindromicWord = false;
        
        for (int i = 0; i < 26; i++)
        {
            var palindromicWordCount = letterPairCounts[i, i];
            palindromePairs += palindromicWordCount / 2;
            
            if (palindromicWordCount % 2 == 1)
            {
                hasOddPalindromicWord = true;
            }
            
            for (int j = i + 1; j < 26; j++)
            {
                palindromePairs += Math.Min(letterPairCounts[i, j], letterPairCounts[j, i]);
            }
        }

        return palindromePairs * 4 + (hasOddPalindromicWord ? 2 : 0);
    }
}