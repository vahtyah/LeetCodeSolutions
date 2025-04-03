namespace LeetCodeSolutions.Greedy;

/*
 * 2874. Maximum Value of an Ordered Triplet II
 * Difficulty: Medium
 * Submission Time: 2025-04-03 05:14:56
 * Created by vahtyah on 2025-04-03 05:16:58
*/
 
public class Solution {
    public long MaximumTripletValue(int[] nums) {
        long maxTriplet = 0, maxDiff = 0, maxValue = 0;

        for(int i = 0; i < nums.Length; i++){
            maxTriplet = Math.Max(maxDiff * nums[i], maxTriplet);
            maxDiff = Math.Max(maxValue - nums[i], maxDiff);
            maxValue = Math.Max(nums[i], maxValue);
        }

        return maxTriplet;
    }
}