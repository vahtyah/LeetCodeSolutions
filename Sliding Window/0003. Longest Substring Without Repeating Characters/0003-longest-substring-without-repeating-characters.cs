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

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var letters = new bool[128];
        var left = 0;
        var right = 0;
        var answer = 0;
        while(right < s.Length){
            while(letters[s[right]]){
                letters[s[left]] = false;
                left++;
            }
            letters[s[right]] = true;
            right++;
            answer = Math.Max(answer, right - left);
        }

        return answer;
    }
}