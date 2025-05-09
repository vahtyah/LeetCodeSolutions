namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 3343. Count Number of Balanced Permutations
 * Difficulty: Hard
 * Submission Time: 2025-05-09 16:37:02
 * Created by vahtyah on 2025-05-09 16:37:27
*/
 
public class Solution {
    private const long MOD = 1000000007;
    private static long[] factorial = new long[101];
    private static long[] invFactorial = new long[101];
    
    static Solution() {
        factorial[0] = factorial[1] = 1;
        invFactorial[0] = invFactorial[1] = 1;
        for (int i = 2; i <= 100; i++) {
            factorial[i] = (i * factorial[i - 1]) % MOD;
            invFactorial[i] = ModExp(factorial[i], MOD - 2);
        }
    }
    
    public int CountBalancedPermutations(string numStr) {
        int n = numStr.Length;
        int[] freq = new int[10];
        int targetSum = 0;
        
        foreach (char c in numStr) {
            freq[c - '0']++;
            targetSum += (c - '0');
        }
        
        if (targetSum % 2 == 1) return 0;
        targetSum /= 2;
        
        int targetLen = n / 2;
        long ways = (factorial[targetLen] * factorial[n - targetLen]) % MOD;
        
        var dp = new long[10, targetLen + 1, targetSum + 1];
        for (int i = 0; i < 10; i++)
            for (int j = 0; j <= targetLen; j++)
                for (int k = 0; k <= targetSum; k++)
                    dp[i, j, k] = -1;
        
        long Go(int i, int len1, int sum1) {
            if (i >= 10) {
                return (len1 == targetLen && sum1 == targetSum) ? ways : 0;
            }
            if (len1 > targetLen || sum1 > targetSum) {
                return 0;
            }
            if (dp[i, len1, sum1] != -1) {
                return dp[i, len1, sum1];
            }
            
            long ans = 0;
            for (int take = 0; take <= freq[i]; take++) {
                long w = Go(i + 1, len1 + take, sum1 + take * i);
                w = (w * invFactorial[take]) % MOD;
                w = (w * invFactorial[freq[i] - take]) % MOD;
                ans = (ans + w) % MOD;
            }
            
            return dp[i, len1, sum1] = ans;
        }
        
        return (int)Go(0, 0, 0);
    }
    
    private static long ModExp(long baseNum, long exp) {
        baseNum %= MOD;
        long ans = 1;
        while (exp > 0) {
            if ((exp & 1) == 1) {
                ans = (ans * baseNum) % MOD;
            }
            exp >>= 1;
            baseNum = (baseNum * baseNum) % MOD;
        }
        return ans;
    }
}