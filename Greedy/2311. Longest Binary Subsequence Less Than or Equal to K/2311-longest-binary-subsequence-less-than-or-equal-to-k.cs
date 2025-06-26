namespace LeetCodeSolutions.Greedy;

/*
 * 2311. Longest Binary Subsequence Less Than or Equal to K
 * Difficulty: Medium
 * Submission Time: 2025-06-26 07:08:01
 * Created by vahtyah on 2025-06-26 07:08:37
*/
 
public class Solution {
    public int LongestSubsequence(string s, int k) {
        int n = s.Length;
        
        int zeros = 0;
        for (int i = 0; i < n; i++) {
            if (s[i] == '0') zeros++;
        }
        
        int ones = 0;
        long value = 0;
        long power = 1;
        
        for (int i = n - 1; i >= 0 && power <= k; i--) {
            if (s[i] == '1') {
                if (value + power <= k) {
                    value += power;
                    ones++;
                }
            }
            power <<= 1;
        }
        
        return zeros + ones;
    }
}