namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3392. Count Subarrays of Length Three With a Condition
 * Difficulty: Easy
 * Submission Time: 2025-04-27 08:39:49
 * Created by vahtyah on 2025-04-27 08:40:09
*/
 
public class Solution {
    public int CountSubarrays(int[] nums) {
        var result = 0;
        for(int i = 2; i < nums.Length; i++){
            if((nums[i - 2] + nums[i]) << 1 == nums[i - 1]) result++;
        }

        return result;
    }
}