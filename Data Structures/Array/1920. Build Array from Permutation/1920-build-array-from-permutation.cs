namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 1920. Build Array from Permutation
 * Difficulty: Easy
 * Submission Time: 2025-05-06 06:34:14
 * Created by vahtyah on 2025-05-06 06:34:38
*/
 
public class Solution {
    public int[] BuildArray(int[] nums) {
        var result = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++){
            result[i] = nums[nums[i]];
        }

        return result;
    }
}