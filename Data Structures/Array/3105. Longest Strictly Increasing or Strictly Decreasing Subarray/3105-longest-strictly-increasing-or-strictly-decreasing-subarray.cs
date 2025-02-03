namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3105. Longest Strictly Increasing or Strictly Decreasing Subarray
 * Difficulty: Easy
 * Submission Time: 2025-02-03 05:56:51
 * Created by vahtyah on 2025-02-03 05:57:12
 */
 
public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        if (nums.Length <= 1) return nums.Length;
        
        int maxLength = 1;
        int increasing = 1;
        int decreasing = 1;
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > nums[i - 1]) {
                increasing++;
                decreasing = 1;
            } else if (nums[i] < nums[i - 1]) {
                decreasing++;
                increasing = 1;
            } else {
                increasing = decreasing = 1;
            }
            
            maxLength = Math.Max(maxLength, Math.Max(increasing, decreasing));
        }
        
        return maxLength;
    }
}