namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0918. Maximum Sum Circular Subarray
 * Difficulty: Medium
 * Submission Time: 2025-06-12 06:36:02
 * Created by vahtyah on 2025-06-12 06:36:21
*/
 
public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int n = nums.Length;
        
        int maxEndingHere = nums[0], maxSoFar = nums[0];
        int minEndingHere = nums[0], minSoFar = nums[0];
        int totalSum = nums[0];

        // Kadane's algorithm
        for (int i = 1; i < n; i++) {
            maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            
            minEndingHere = Math.Min(nums[i], minEndingHere + nums[i]);
            minSoFar = Math.Min(minSoFar, minEndingHere);
            
            totalSum += nums[i];
        }
        
        return minSoFar == totalSum ? maxSoFar : Math.Max(maxSoFar, totalSum - minSoFar);
    }
}