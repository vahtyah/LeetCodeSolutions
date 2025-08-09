namespace LeetCodeSolutions.BitManipulation;

/*
 * 0231. Power of Two
 * Difficulty: Easy
 * Submission Time: 2025-08-09 10:54:46
 * Created by vahtyah on 2025-08-09 10:56:12
*/
 
public class Solution {
    public bool IsPowerOfTwo(int n) {
        return n > 0 && (n & (n - 1)) == 0;
    }
}