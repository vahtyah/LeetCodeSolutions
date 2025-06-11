namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0053. Maximum Subarray
 * Difficulty: Medium
 * Submission Time: 2025-06-11 06:46:30
 * Created by vahtyah on 2025-06-11 06:47:10
*/
 
public class Solution {
    public int MaxSubArray(int[] nums) {
        var maxSoFar = nums[0];
        var maxEndingHere = 0;

        foreach(var num in nums){
            maxEndingHere = Math.Max(num, maxEndingHere + num);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }
}