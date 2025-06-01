namespace LeetCodeSolutions.Math;

/*
 * 2929. Distribute Candies Among Children II
 * Difficulty: Medium
 * Submission Time: 2025-06-01 05:26:49
 * Created by vahtyah on 2025-06-01 05:27:07
*/
 
public class Solution {
    public long DistributeCandies(int n, int limit) {
        long totalWays = Combinations(n + 2, 2);
        
        // Subtract cases where at least one child gets > limit
        long invalidWays = 3 * Combinations(Math.Max(0, n - limit + 1), 2);
        // Add back cases where at least two children get > limit
        long doubleInvalidWays = 3 * Combinations(Math.Max(0, n - 2 * (limit + 1) + 2), 2);
        // Subtract cases where all three children get > limit
        long tripleInvalidWays = Combinations(Math.Max(0, n - 3 * (limit + 1) + 2), 2);
        
        return totalWays - invalidWays + doubleInvalidWays - tripleInvalidWays;
    }
    
    //C(n, k)
    private long Combinations(int n, int k) {
        if (n < k || k < 0) return 0;
        if (k == 0 || k == n) return 1;
        if (k == 2) return (long)n * (n - 1) / 2;
        if (k == 1) return n;
        
        long result = 1;
        for (int i = 0; i < k; i++) {
            result = result * (n - i) / (i + 1);
        }
        return result;
    }
}