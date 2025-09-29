namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 1039. Minimum Score Triangulation of Polygon
 * Difficulty: Medium
 * Submission Time: 2025-09-29 13:30:10
 * Created by vahtyah on 2025-09-29 13:30:54
*/
 
public class Solution {
    public int MinScoreTriangulation(int[] values) {
        var n = values.Length;
        var dp = new int[n, n];
        
        for (int len = 3; len <= n; len++) {
            for (int i = 0; i <= n - len; i++) {
                var j = i + len - 1;
                
                dp[i, j] = int.MaxValue;
                
                for (int k = i + 1; k < j; k++) {
                    var cost = dp[i, k] + dp[k, j] + values[i] * values[k] * values[j];
                    if(dp[i, j] > cost) dp[i, j] = cost;
                }
            }
        }
        
        return dp[0, n - 1];
    }
}