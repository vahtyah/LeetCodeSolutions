namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0053. Maximum Subarray
 * Difficulty: Medium
 * Submission Time: 2025-06-11 06:31:03
 * Created by vahtyah on 2025-06-11 06:31:36
*/
 
public class Solution {
    public int MaxSubArray(int[] nums) {
        var maxSoFar = nums[0];
        var maxEndingHere = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }
}