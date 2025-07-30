namespace LeetCodeSolutions.Greedy;

/*
 * 2419. Longest Subarray With Maximum Bitwise AND
 * Difficulty: Medium
 * Submission Time: 2025-07-30 03:33:58
 * Created by vahtyah on 2025-07-30 03:36:13
*/
 
public class Solution {
    public int LongestSubarray(int[] nums) {
        int maxValue = nums[0];
        int maxLength = 1;
        int currentLength = 1;
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > maxValue) {
                maxValue = nums[i];
                maxLength = 1;
                currentLength = 1;
            } else if (nums[i] == maxValue) {
                currentLength++;
                maxLength = Math.Max(maxLength, currentLength);
            } else {
                currentLength = 0;
            }
        }
        
        return maxLength;
    }
}