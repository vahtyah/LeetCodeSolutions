namespace LeetCodeSolutions.BitManipulation;

/*
 * 0190. Reverse Bits
 * Difficulty: Easy
 * Submission Time: 2025-06-27 12:42:43
 * Created by vahtyah on 2025-06-27 12:43:07
*/
 
public class Solution {
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public uint reverseBits(uint n) {
        uint result = 0;

        for (int i = 0; i < 32; i++) {
            result = (result << 1) | (n & 1);
            n >>= 1;
        }
        
        return result;
    }
}