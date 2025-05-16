namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 2901. Longest Unequal Adjacent Groups Subsequence II
 * Difficulty: Medium
 * Submission Time: 2025-05-16 06:44:12
 * Created by vahtyah on 2025-05-16 06:45:44
*/
 
public class Solution {
    public IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups) {
        var n = words.Length;
        var dp = new int[n];
        var prev = new int[n];
        
        for (int i = 0; i < n; i++) {
            dp[i] = 1;
            prev[i] = -1;
        }
        
        int maxIndex = 0;
        
        for (int i = 1; i < n; i++) {
            for (int j = 0; j < i; j++) {
                if (groups[j] != groups[i] && 
                    words[i].Length == words[j].Length && 
                    IsSatifiedHammingDistance(words[i], words[j])) {
                    
                    if (dp[j] + 1 > dp[i]) {
                        dp[i] = dp[j] + 1;
                        prev[i] = j;
                    }
                }
            }
            if (dp[i] > dp[maxIndex]) maxIndex = i;
        }
        
        var result = new List<string>();
        int currentIndex = maxIndex;
        
        while (currentIndex != -1) {
            result.Add(words[currentIndex]);
            currentIndex = prev[currentIndex];
        }
        
        result.Reverse();
        return result;
    }

    private bool IsSatifiedHammingDistance(string s1, string s2) {
        var hammingDistance = 0;
        for (int i = 0; i < s1.Length; i++) {
            if (s1[i] != s2[i]) {
                if (++hammingDistance > 1) return false;
            }
        }
        return hammingDistance == 1;
    }
}