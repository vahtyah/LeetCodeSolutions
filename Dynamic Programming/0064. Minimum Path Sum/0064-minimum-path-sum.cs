namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0064. Minimum Path Sum
 * Difficulty: Medium
 * Submission Time: 2025-09-21 02:54:20
 * Created by vahtyah on 2025-09-21 02:54:43
*/
 
public class Solution {
    public int MinPathSum(int[][] grid) {
        var m = grid.Length;
        var n = grid[0].Length;
        
        var dp = new int[m, n];
        dp[0, 0] = grid[0][0];
        
        for(int i = 1; i < n; i++) dp[0, i] = dp[0, i - 1] + grid[0][i];  
        for(int i = 1; i < m; i++) dp[i, 0] = dp[i - 1, 0] + grid[i][0];

        for(int i = 1; i < m; i++){
            for(int j = 1; j < n; j++){
                dp[i, j] = grid[i][j] + Math.Min(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        return dp[m - 1, n - 1];
    }
}