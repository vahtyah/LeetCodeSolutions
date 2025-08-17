namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0837. New 21 Game
 * Difficulty: Medium
 * Submission Time: 2025-08-17 13:44:19
 * Created by vahtyah on 2025-08-17 13:45:17
*/
 
public class Solution {
    public double New21Game(int n, int k, int maxPts) {
        if (k == 0 || n >= k - 1 + maxPts) return 1.0;
        
        Span<double> dp = stackalloc double[n + 1];
        dp[0] = 1.0;
        double windowSum = 1.0, result = 0.0;
        
        for (int i = 1; i <= n; i++) {
            dp[i] = windowSum / maxPts;
            if (i < k) windowSum += dp[i];
            else result += dp[i];
            if (i - maxPts >= 0) windowSum -= dp[i - maxPts];
        }
        
        return result;
    }
}