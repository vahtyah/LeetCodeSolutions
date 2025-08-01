namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0120. Triangle
 * Difficulty: Medium
 * Submission Time: 2025-08-01 01:38:55
 * Created by vahtyah on 2025-08-01 01:40:52
*/
 
public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int n = triangle.Count;
        Span<int> dp = stackalloc int[n];
        
        for (int i = 0; i < n; i++) {
            dp[i] = triangle[n - 1][i];
        }
        
        for (int row = n - 2; row >= 0; row--) {
            for (int col = 0; col <= row; col++) {
                dp[col] = triangle[row][col] + Math.Min(dp[col], dp[col + 1]);
            }
        }
        
        return dp[0];
    }
}