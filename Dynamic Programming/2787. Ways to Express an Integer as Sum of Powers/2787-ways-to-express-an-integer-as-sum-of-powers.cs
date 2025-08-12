namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 2787. Ways to Express an Integer as Sum of Powers
 * Difficulty: Medium
 * Submission Time: 2025-08-12 13:47:27
 * Created by vahtyah on 2025-08-12 13:48:40
*/
 
public class Solution {
    private const int MOD = 1_000_000_007;

    public int NumberOfWays(int n, int x) {
        var dp = new long[n + 1];
        dp[0] = 1;

        for (int i = 1; i <= n; i++) {
            var val = (int)Math.Pow(i, x);
            if (val > n) break;

            for (int j = n; j >= val; j--) {
                dp[j] = (dp[j] + dp[j - val]) % MOD;
            }
        }

        return (int)dp[n];
    }
}