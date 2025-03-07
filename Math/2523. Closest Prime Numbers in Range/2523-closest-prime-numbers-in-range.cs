namespace LeetCodeSolutions.Math;

/*
 * 2523. Closest Prime Numbers in Range
 * Difficulty: Medium
 * Submission Time: 2025-03-07 06:18:37
 * Created by vahtyah on 2025-03-07 06:19:14
*/
 
using System;
using System.Collections.Generic;

public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        // Use Sieve of Eratosthenes to efficiently find all primes in range
        List<int> primes = SieveOfEratosthenesRange(left, right);
        
        if (primes.Count < 2) {
            return new int[] { -1, -1 };
        }
        
        int minDistance = int.MaxValue;
        int[] result = new int[] { -1, -1 };
        
        for (int i = 1; i < primes.Count; i++) {
            int distance = primes[i] - primes[i - 1];
            if (distance < minDistance) {
                minDistance = distance;
                result[0] = primes[i - 1];
                result[1] = primes[i];
            }
        }
        
        return result;
    }
    
    private List<int> SieveOfEratosthenesRange(int left, int right) {
        left = Math.Max(2, left);
        
        bool[] isPrime = new bool[right + 1];
        
        for (int i = 0; i <= right; i++) {
            isPrime[i] = true;
        }
        
        if (right >= 0) isPrime[0] = false;
        if (right >= 1) isPrime[1] = false;
        
        int sqrt = (int)Math.Sqrt(right);
        for (int p = 2; p <= sqrt; p++) {
            if (isPrime[p]) {
                for (int i = p * p; i <= right; i += p) {
                    isPrime[i] = false;
                }
            }
        }
        
        List<int> primes = new List<int>();
        for (int i = left; i <= right; i++) {
            if (isPrime[i]) {
                primes.Add(i);
            }
        }
        
        return primes;
    }
}