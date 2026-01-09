namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0712. Minimum ASCII Delete Sum for Two Strings
 * Difficulty: Medium
 * Submission Time: 2026-01-10 14:37:02
 * Created by vahtyah on 2026-01-10 14:37:32
*/
 
public class Solution {
    public int MinimumDeleteSum(string s1, string s2) {
        int m = s1.Length, n = s2.Length;
        Span<int> dp = stackalloc int[n + 1];
        
        for(int j = 1; j <= n; j++) {
            dp[j] = dp[j - 1] + s2[j - 1];
        }
        
        for(int i = 1; i <= m; i++) {
            int prev = dp[0];
            dp[0] += s1[i - 1];
            
            for(int j = 1; j <= n; j++) {
                int temp = dp[j];
                
                if(s1[i - 1] == s2[j - 1]) {
                    dp[j] = prev;
                } else {
                    dp[j] = Math.Min(dp[j] + s1[i - 1], dp[j - 1] + s2[j - 1]);
                }
                
                prev = temp;
            }
        }
        
        return dp[n];
    }
}