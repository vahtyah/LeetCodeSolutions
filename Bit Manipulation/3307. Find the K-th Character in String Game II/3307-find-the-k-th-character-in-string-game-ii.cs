namespace LeetCodeSolutions.BitManipulation;

/*
 * 3307. Find the K-th Character in String Game II
 * Difficulty: Hard
 * Submission Time: 2025-07-04 08:02:53
 * Created by vahtyah on 2025-07-04 08:03:16
*/
 
public class Solution {
    public char KthCharacter(long k, int[] operations) {
        ulong mask = 0;
        for (int i = operations.Length - 1; i >= 0; i--) {
            mask = (mask << 1) | (ulong) operations[i];
        }
        return (char) ((int) 'a' + BitOperations.PopCount(((ulong) k - 1) & mask) % 26);
    }
}