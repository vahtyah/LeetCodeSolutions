namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0717. 1-bit and 2-bit Characters
 * Difficulty: Easy
 * Submission Time: 2025-11-18 14:54:53
 * Created by vahtyah on 2025-11-18 14:58:00
*/
 
public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int i = 0;
        int n = bits.Length;

        while (i < n - 1) {
            if (bits[i] == 1) {
                i += 2;   
            } else {
                i += 1;   
            }
        }

        return i == n - 1;
    }
}