namespace LeetCodeSolutions.BitManipulation;

/*
 * 1680. Concatenation of Consecutive Binary Numbers
 * Difficulty: Medium
 * Submission Time: 2026-02-28 12:50:05
 * Created by vahtyah on 2026-02-28 12:50:26
*/
 
public class Solution {
    private static int MOD = 1_000_000_007;

    public int ConcatenatedBinary(int n) {
        long result = 0;
        int bits = 0;

        for(int i = 1; i <= n; i++){
            if((i & (i - 1)) == 0) bits++;

            result = ((result << bits) + i) % MOD;
        }

        return (int)result;
    }
}