namespace LeetCodeSolutions.Math;

/*
 * 3405. Count the Number of Arrays with K Matching Adjacent Elements
 * Difficulty: Hard
 * Submission Time: 2025-06-17 14:09:54
 * Created by vahtyah on 2025-06-17 14:11:53
*/
 
public class Solution 
{
    private const int MOD = 1000000007;
    private const int MAXN = 100005;
    
    private static readonly long[] Fact = new long[MAXN];
    private static readonly long[] InvFact = new long[MAXN];
    
    static Solution()
    {
        InitializeFactorials();
    }
    
    public int CountGoodArrays(int n, int m, int k) 
    {
        // Formula: m * (m-1)^(n-k-1) * C(n-1, k) mod (10^9 + 7)
        
        long power = ModPow(m - 1, n - k - 1);
        long combination = FastCombination(n - 1, k);
        
        return (int)(((long)m * power % MOD) * combination % MOD);
    }
    
    private static void InitializeFactorials()
    {
        if(Fact[0] != 0) return;
        Fact[0] = 1;
        for (int i = 1; i < MAXN; i++)
        {
            Fact[i] = Fact[i - 1] * i % MOD;
        }
        
        InvFact[MAXN - 1] = ModPow(Fact[MAXN - 1], MOD - 2);
        for (int i = MAXN - 2; i >= 0; i--)
        {
            InvFact[i] = InvFact[i + 1] * (i + 1) % MOD;
        }
    }
    
    private static long ModPow(long baseNum, long exp)
    {
        if (exp == 0) return 1;
        if (exp == 1) return baseNum % MOD;
        
        long result = 1;
        baseNum %= MOD;
        
        while (exp > 0)
        {
            if ((exp & 1) == 1)
            {
                result = result * baseNum % MOD;
            }
            baseNum = baseNum * baseNum % MOD;
            exp >>= 1;
        }
        
        return result;
    }
    
    private static long FastCombination(int n, int k)
    {
        if (k > n || k < 0) return 0;
        if (k == 0 || k == n) return 1;
        
        return Fact[n] * InvFact[k] % MOD * InvFact[n - k] % MOD;
    }
}