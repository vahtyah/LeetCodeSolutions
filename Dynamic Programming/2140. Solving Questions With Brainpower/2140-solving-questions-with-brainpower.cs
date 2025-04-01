namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 2140. Solving Questions With Brainpower
 * Difficulty: Medium
 * Submission Time: 2025-04-01 05:39:24
 * Created by vahtyah on 2025-04-01 05:39:44
*/
 
public class Solution {
    public long MostPoints(int[][] questions) {
        int n = questions.Length;
        if(n == 1) return questions[0][0];

        long[] dp = new long[n + 1]; 

        for (int i = n - 1; i >= 0; i--) {
            var takeIndex = Math.Min(i + questions[i][1] + 1, n);        
            dp[i] = Math.Max(dp[takeIndex] + questions[i][0], dp[i + 1]);
        }
        
        return dp[0];
    }
}