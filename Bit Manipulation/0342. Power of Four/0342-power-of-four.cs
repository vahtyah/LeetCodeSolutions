namespace LeetCodeSolutions.BitManipulation;

/*
 * 0342. Power of Four
 * Difficulty: Easy
 * Submission Time: 2025-08-15 12:37:56
 * Created by vahtyah on 2025-08-15 12:38:29
*/
 
public class Solution {
    public bool IsPowerOfFour(int n) {
        return n > 0 && (n & (n - 1)) == 0 && (n - 1) % 3 == 0;
    }
}