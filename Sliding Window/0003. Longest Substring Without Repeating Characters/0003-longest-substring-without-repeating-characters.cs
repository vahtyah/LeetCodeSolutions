namespace LeetCodeSolutions.SlidingWindow;

/*
 * 0003. Longest Substring Without Repeating Characters
 * Difficulty: Medium
 * Submission Time: 2025-02-07 13:22:45
 * Created by vahtyah on 2025-02-07 13:23:14
*/
 
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        var lastIndex = new int[128];
        var maxLength = 0;
        var start = 0;
        
        for (var i = 0; i < s.Length; i++) {
            var currentChar = s[i];
            start = Math.Max(start, lastIndex[currentChar]);
            
            var currentLength = i - start + 1;
            maxLength = Math.Max(maxLength, currentLength);
            lastIndex[currentChar] = i + 1;
        }
        
        return maxLength;
    }
}