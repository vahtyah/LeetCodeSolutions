namespace LeetCodeSolutions.Greedy;

/*
 * 2900. Longest Unequal Adjacent Groups Subsequence I
 * Difficulty: Easy
 * Submission Time: 2025-05-15 06:49:43
 * Created by vahtyah on 2025-05-15 06:50:13
*/
 
public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        if(words.Length == 1) return words;
        
        var n = words.Length;
        var index = 1;

        for(int i = 1; i < n; i++){
            if(groups[i] == groups[i - 1]) continue;
            words[index++] = words[i];
        }

        return words.Take(index).ToArray();
    }
}