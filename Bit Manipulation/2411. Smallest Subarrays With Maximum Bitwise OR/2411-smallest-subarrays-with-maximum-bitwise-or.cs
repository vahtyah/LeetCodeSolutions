namespace LeetCodeSolutions.BitManipulation;

/*
 * 2411. Smallest Subarrays With Maximum Bitwise OR
 * Difficulty: Medium
 * Submission Time: 2025-07-29 14:04:38
 * Created by vahtyah on 2025-07-29 15:04:04
*/
 
public class Solution {
    public int[] SmallestSubarrays(int[] nums) {
        int n = nums.Length;
        int[] lastBitPosition = new int[32];
        int[] result = new int[n];

        for (int i = n - 1; i >= 0; i--) {
            result[i] = 1;
            var currentNum = nums[i];
            int furthestRequiredPosition = 0;
            
            for (int bit = 0; bit < 32; bit++) {
                if ((currentNum & 1) > 0) {
                    lastBitPosition[bit] = i;
                }

                furthestRequiredPosition = Math.Max(furthestRequiredPosition, lastBitPosition[bit]);
                currentNum >>= 1;
            }
            
            result[i] = Math.Max(result[i], furthestRequiredPosition - i + 1);
        }

        return result;
    }
}