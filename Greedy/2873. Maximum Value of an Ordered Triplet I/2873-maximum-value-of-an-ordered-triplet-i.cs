namespace LeetCodeSolutions.Greedy;

/*
 * 2873. Maximum Value of an Ordered Triplet I
 * Difficulty: Easy
 * Submission Time: 2025-04-02 04:35:48
 * Created by vahtyah on 2025-04-02 04:36:13
*/
 
public class Solution {
    public long MaximumTripletValue(int[] nums) {
        long maxValue = 0, maxDiff = 0, maxTriplet = 0;

        for(int i = 0; i < nums.Length; i++){
            maxTriplet = Math.Max(maxTriplet, maxDiff * nums[i]);
            maxDiff = Math.Max(maxDiff, maxValue - nums[i]);
            maxValue = Math.Max(maxValue, nums[i]);
        }

        return maxTriplet;
    }
}