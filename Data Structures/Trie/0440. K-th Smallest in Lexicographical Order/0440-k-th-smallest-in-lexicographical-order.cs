namespace LeetCodeSolutions.DataStructures/Trie;

/*
 * 0440. K-th Smallest in Lexicographical Order
 * Difficulty: Hard
 * Submission Time: 2025-06-09 06:07:22
 * Created by vahtyah on 2025-06-09 06:08:03
*/
 
public class Solution {
    public int FindKthNumber(int n, int k) {
        var current = 1;
        k--;
        
        while (k > 0) {
            //Virtual Trie Traversal
            var steps = CountSteps(current, n);
            if (steps <= k) {
                current++;
                k -= (int)steps;
            } else {
                current *= 10;
                k--;
            }
        }
        
        return current;
    }
    
    private long CountSteps(int prefix, int n) {
        long first = prefix, last = prefix, totalSteps = 0;
        
        while (first <= n) {
            totalSteps += Math.Min(n + 1L, last + 1L) - first;
            
            first *= 10;
            last = last * 10 + 9;
        }
        
        return totalSteps;
    }
}