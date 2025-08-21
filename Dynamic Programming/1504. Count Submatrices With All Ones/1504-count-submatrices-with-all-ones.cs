namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 1504. Count Submatrices With All Ones
 * Difficulty: Medium
 * Submission Time: 2025-08-21 12:24:26
 * Created by vahtyah on 2025-08-21 12:24:49
*/
 
public class Solution {
    public int NumSubmat(int[][] mat) {
        var m = mat.Length;
        var n = mat[0].Length;

        var dp = new int[m][];

        var total = 0;

        for (int i = 0; i < m; i++) {
            dp[i] = new int[n];
            for (int j = 0; j < n; j++) {
                if (mat[i][j] == 1) {
                    dp[i][j] = (j == 0 ? 0 : dp[i][j - 1]) + 1;

                    var minWidth = dp[i][j];

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