namespace LeetCodeSolutions.Math;

/*
 * 3577. Count the Number of Computer Unlocking Permutations
 * Difficulty: Medium
 * Submission Time: 2025-12-10 14:44:56
 * Created by vahtyah on 2025-12-10 14:46:33
*/
 
public class Solution {
    private const int MOD = 1_000_000_007;

    public int CountPermutations(int[] complexity) {
        var n = complexity.Length;
        
        var firstComplexity = complexity[0];
        for(int i = 1; i < n; i++){
            if(complexity[i] <= firstComplexity) return 0;
        }

        var result = 1;
        for (int i = 2; i < n; i++) {
            result = (int)((long)result * i % MOD);
        }

        return (int)result;
    }
}