namespace LeetCodeSolutions.Greedy;

/*
 * 2016. Maximum Difference Between Increasing Elements
 * Difficulty: Easy
 * Submission Time: 2025-06-16 06:02:18
 * Created by vahtyah on 2025-06-16 06:03:44
*/
 
public class Solution {
    public int MaximumDifference(int[] nums) {
        var maxDiff = -1;
        var maxValueSoFar = 0;

        for(int i = nums.Length - 1; i >= 0; i--){
            maxDiff = Math.Max(maxDiff, maxValueSoFar - nums[i]);
            maxValueSoFar = Math.Max(nums[i], maxValueSoFar);
        }

        return maxDiff == 0 ? -1 : maxDiff;
    }
}