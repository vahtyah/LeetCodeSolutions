namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0097. Interleaving String
 * Difficulty: Medium
 * Submission Time: 2025-09-28 08:02:31
 * Created by vahtyah on 2025-09-29 13:33:35
*/
 
public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        int n1 = s1.Length, n2 = s2.Length, n3 = s3.Length;
        if (n1 + n2 != n3) return false;

        Span<bool> dp = stackalloc bool[n2 + 1];
        dp[0] = true;

        for (int j = 1; j <= n2; j++) {
            dp[j] = dp[j - 1] && s2[j - 1] == s3[j - 1];
        }

        for (int i = 1; i <= n1; i++) {
            dp[0] = dp[0] && s1[i - 1] == s3[i - 1];
            
            for (int j = 1; j <= n2; j++) {
                dp[j] = (dp[j] && s1[i - 1] == s3[i + j - 1]) || 
                        (dp[j - 1] && s2[j - 1] == s3[i + j - 1]);
            }
        }

        return dp[n2];
    }
}