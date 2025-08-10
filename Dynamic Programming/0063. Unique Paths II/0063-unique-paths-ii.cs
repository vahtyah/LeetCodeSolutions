namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0063. Unique Paths II
 * Difficulty: Medium
 * Submission Time: 2025-09-21 03:29:54
 * Created by vahtyah on 2025-09-21 03:30:20
*/
 
public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var rows = obstacleGrid.Length;
        var cols = obstacleGrid[0].Length;

        if(obstacleGrid[0][0] == 1 || obstacleGrid[rows - 1][cols - 1] == 1) return 0;

        var dp = new int[rows, cols];
        dp[0, 0] = 1;

        for(int row = 1; row < rows; row++) dp[row, 0] = obstacleGrid[row][0] == 1 ? 0 : dp[row - 1, 0];
        for(int col = 1; col < cols; col++) dp[0, col] = obstacleGrid[0][col] == 1 ? 0 : dp[0, col - 1];

        for(int row = 1; row < rows; row++){
            for(int col = 1; col < cols; col++){
                if(obstacleGrid[row][col] == 1) continue;
                var left = obstacleGrid[row][col - 1] == 1 ? 0 : dp[row, col - 1];
                var top = obstacleGrid[row - 1][col] == 1 ? 0 : dp[row - 1, col];

                dp[row, col] = left + top;
            }
        }

        return dp[rows - 1, cols - 1];
    }
}