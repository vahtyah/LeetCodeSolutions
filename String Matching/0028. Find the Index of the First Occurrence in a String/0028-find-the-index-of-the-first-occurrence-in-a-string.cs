namespace LeetCodeSolutions.StringMatching;

/*
 * 0028. Find the Index of the First Occurrence in a String
 * Difficulty: Easy
 * Submission Time: 2025-02-03 21:15:19
 * Created by vahtyah on 2025-02-03 21:15:32
 */
 
public class Solution {
    public int StrStr(string haystack, string needle) {
        return KMPSearch(haystack, needle);
    }

    public int KMPSearch(string text, string pattern)
    {
        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern))
            return -1;

        int[] lps = ComputeLPSArray(pattern);
        int i = 0, j = 0;

        while (i < text.Length)
        {
            if (pattern[j] == text[i])
            {
                j++;
                i++;
            }

            if (j == pattern.Length)
            {
                return i - j;
            }
            else if (i < text.Length && pattern[j] != text[i])
            {
                if (j != 0)
                    j = lps[j - 1];
                else
                    i++;
            }
        }
        return -1;
    }

    private int[] ComputeLPSArray(string pattern)
    {
        int[] lps = new int[pattern.Length];
        int len = 0;
        
        lps[0] = 0;
        
        int i = 1;
        while (i < pattern.Length)
        {
            if (pattern[i] == pattern[len])
            {
                len++;
                lps[i] = len;
                i++;
            }
            else
            {
                if (len != 0)
                {
                    len = lps[len - 1];
                }
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }
        }
        return lps;
    }

}