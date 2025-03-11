namespace LeetCodeSolutions.SlidingWindow;

/*
 * 1358. Number of Substrings Containing All Three Characters
 * Difficulty: Medium
 * Submission Time: 2025-03-11 07:17:48
 * Created by vahtyah on 2025-03-11 07:18:19
*/
 
public class Solution {
    public int NumberOfSubstrings(string s) {
        var count = 0;
        var charCount = new int[3];
        
        for (int right = 0, left = 0; right < s.Length; right++) {
            charCount[s[right] - 'a']++;
            
            while (charCount[0] > 0 && charCount[1] > 0 && charCount[2] > 0) {
                count += s.Length - right;
                charCount[s[left] - 'a']--;
                left++;
            }
        }
        
        return count;
    }
}