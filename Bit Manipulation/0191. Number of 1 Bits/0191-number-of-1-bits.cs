namespace LeetCodeSolutions.BitManipulation;

/*
 * 0191. Number of 1 Bits
 * Difficulty: Easy
 * Submission Time: 2025-06-27 12:46:04
 * Created by vahtyah on 2025-06-27 12:46:26
*/
 
public class Solution {
    public int HammingWeight(int n) {
        var countBits = 0;
        
        while(n > 0) {
            countBits += n & 1;
            n >>= 1;
        }

        return countBits;
    }
}