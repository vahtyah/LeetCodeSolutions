namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3689. Maximum Total Subarray Value I
 * Difficulty: Medium
 * Submission Time: 2026-06-09 09:06:03
 * Created by vahtyah on 2026-06-09 09:06:46
*/
 
public class Solution {
    public long MaxTotalValue(int[] nums, int k) {
        var max = 0;
        var min = int.MaxValue;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > max) max = nums[i];
            if(nums[i] < min) min = nums[i];
        }

        return (long)(max - min) * k;
    }
}