namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 1800. Maximum Ascending Subarray Sum
 * Difficulty: Easy
 * Submission Time: 2025-02-04 07:49:39
 * Created by vahtyah on 2025-02-04 07:50:08
 */
 
public class Solution {
    public int MaxAscendingSum(int[] nums) {
        if(nums.Length == 1) return nums[0];
        int maxSum = nums[0];
        int currentSum = nums[0];
        
        for (int i = 1; i < nums.Length; i++) {
            currentSum = nums[i] > nums[i - 1] ? currentSum + nums[i] : nums[i];
            maxSum = Math.Max(maxSum, currentSum);
        }
        
        return maxSum;
    }
}