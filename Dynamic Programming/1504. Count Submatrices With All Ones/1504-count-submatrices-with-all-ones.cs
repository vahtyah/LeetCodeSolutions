namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 1504. Count Submatrices With All Ones
 * Difficulty: Medium
 * Submission Time: 2025-08-21 12:17:56
 * Created by vahtyah on 2025-08-21 12:18:43
*/
 
public class Solution {
    public int NumSubmat(int[][] mat) {
        int m = mat.Length;
        int n = mat[0].Length;

        // dp[i][j]: number of continuous 1s ending at (i,j) in the current row
        int[][] dp = new int[m][];
        for (int i = 0; i < m; i++) {
            dp[i] = new int[n];
        }

        int total = 0;

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (mat[i][j] == 1) {
                    // count how many continuous 1s in row ending at (i,j)
                    dp[i][j] = (j == 0 ? 0 : dp[i][j - 1]) + 1;

                    int minWidth = dp[i][j];

                    // go upwards to count submatrices ending at (i,j)
                    for (int k = i; k >= 0 && dp[k][j] > 0; k--) {
                        minWidth = Math.Min(minWidth, dp[k][j]);
                        total += minWidth;
                    }
                }
            }
        }

        return total;
        
    }
}