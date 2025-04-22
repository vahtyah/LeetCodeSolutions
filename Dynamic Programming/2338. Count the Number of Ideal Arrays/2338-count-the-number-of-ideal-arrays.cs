namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 2338. Count the Number of Ideal Arrays
 * Difficulty: Hard
 * Submission Time: 2025-04-22 08:01:13
 * Created by vahtyah on 2025-04-22 08:01:59
*/
 
public class Solution {
    private const int MOD = (int)1e9 + 7;

    public int IdealArrays(int n, int maxValue) {
        long totalWays = 0;
        int size = n + maxValue;
        long[] inverses = new long[size];
        long[] factorials = new long[size];
        long[] factorialInverses = new long[size];
        
        // Initialize base cases
        inverses[1] = factorials[0] = factorials[1] = factorialInverses[0] = factorialInverses[1] = 1;
        
        // Precompute factorials and their modular inverses
        for (int i = 2; i < size; i++) {
            inverses[i] = MOD - MOD / i * inverses[MOD % i] % MOD;
            factorials[i] = factorials[i - 1] * i % MOD;
            factorialInverses[i] = factorialInverses[i - 1] * inverses[i] % MOD;
        }
        
        // Calculate contribution of each possible value
        for (int value = 1; value <= maxValue; value++) {
            int remaining = value;
            var primeFactors = new Dictionary<int, int>();
            
            // Prime factorization
            for (int factor = 2; factor * factor <= remaining; factor++) {
                while (remaining % factor == 0) {
                    remaining /= factor;
                    if (primeFactors.ContainsKey(factor)) {
                        primeFactors[factor]++;
                    } else {
                        primeFactors[factor] = 1;
                    }
                }
            }
            
            // Handle remaining prime factor if any
            if (remaining > 1) {
                if (primeFactors.ContainsKey(remaining)) {
                    primeFactors[remaining]++;
                } else {
                    primeFactors[remaining] = 1;
                }
            }
            
            // Calculate ways to arrange prime factors
            long valueWays = 1;
            foreach (var exponent in primeFactors.Values) {
                valueWays = (valueWays * Combination(n + exponent - 1, exponent, factorials, factorialInverses)) % MOD;
            }
            
            totalWays = (totalWays + valueWays) % MOD;
        }

        return (int)totalWays;
    }

    // Calculate combination C(a,b) using precomputed factorials
    private long Combination(int a, int b, long[] factorials, long[] factorialInverses) {
        return factorials[a] * factorialInverses[b] % MOD * factorialInverses[a - b] % MOD;
    }
}