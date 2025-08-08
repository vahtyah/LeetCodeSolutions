namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0808. Soup Servings
 * Difficulty: Medium
 * Submission Time: 2025-08-08 07:42:43
 * Created by vahtyah on 2025-08-08 07:43:20
*/
 
public class Solution {
    private static double[,] dp;
    private static int size = 0;

    public Solution(){
        if(dp != null) return;
        dp = new double[193, 193]; //4800/25
        dp[0, 0] = 0.5; // Both empty simultaneously
        
        // When A empties first
        for (int j = 1; j < 193; j++) {
            dp[0, j] = 1.0;
        }
        // When B empties first the probability is 0 (already initialized to 0)

        for (int i = 1; i < 193; i++) {
            for (int j = 1; j < 193; j++) {
                dp[i, j] = 0.25 * (
                    GetDP(i - 4, j) +      // Serve 100ml A, 0ml B
                    GetDP(i - 3, j - 1) +  // Serve 75ml A, 25ml B
                    GetDP(i - 2, j - 2) +  // Serve 50ml A, 50ml B
                    GetDP(i - 1, j - 3)    // Serve 25ml A, 75ml B
                );
            }
        }
    }
    
    public double SoupServings(int n) {
        if (n >= 4800) return 1.0;

        n = (n + 24) / 25;
        if (n == 0) return 0.5;

        return dp[n, n];
    }

    private double GetDP(int i, int j) {
        if (i <= 0 && j <= 0) return 0.5;
        if (i <= 0) return 1.0;
        if (j <= 0) return 0.0;
        return dp[i, j];
    }
}