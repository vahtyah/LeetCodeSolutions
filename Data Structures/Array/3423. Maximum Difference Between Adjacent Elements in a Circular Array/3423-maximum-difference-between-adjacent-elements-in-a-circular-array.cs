namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3423. Maximum Difference Between Adjacent Elements in a Circular Array
 * Difficulty: Easy
 * Submission Time: 2025-06-12 05:02:42
 * Created by vahtyah on 2025-06-12 05:03:10
*/
 
public class Solution {
    public int MaxAdjacentDistance(int[] nums) {
        var maxDiff = int.MinValue;

        for(int i = 1; i < nums.Length; i++) maxDiff = Math.Max(maxDiff, Math.Abs(nums[i] - nums[i - 1]));

        return Math.Max(maxDiff, Math.Max(maxDiff, Math.Abs(nums[0] - nums[nums.Length - 1])));
    }
}