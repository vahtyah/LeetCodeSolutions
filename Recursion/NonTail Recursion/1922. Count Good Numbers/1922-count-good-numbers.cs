namespace LeetCodeSolutions.Recursion/NonTailRecursion;

/*
 * 1922. Count Good Numbers
 * Difficulty: Medium
 * Submission Time: 2025-04-13 05:06:58
 * Created by vahtyah on 2025-04-13 05:09:32
*/
 
public class Solution {
    private const int MOD = 1_000_000_007;
    
    public int CountGoodNumbers(long n) {
        // For even indices (0-based), we can use 0,2,4,6,8 (5 options)
        // For odd indices, we can use prime numbers 2,3,5,7 (4 options)
        
        // Calculate how many even and odd positions we have
        long evenPositions = (n + 1) / 2; // Ceiling division for even positions (including 0th position)
        long oddPositions = n / 2;        // Floor division for odd positions
        
        // Result will be (5^evenPositions * 4^oddPositions) % MOD
        long result = (ModPow(5, evenPositions) * ModPow(4, oddPositions)) % MOD;
        
        return (int)result;
    }
    
    private long ModPow(long x, long n) {
        if (n == 0) return 1;
        
        long half = ModPow(x, n / 2);
        long result = (half * half) % MOD;
        
        if (n % 2 == 1) {
            result = (result * x) % MOD;
        }
        
        return result;
    }
}