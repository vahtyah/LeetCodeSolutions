namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0485. Max Consecutive Ones
 * Difficulty: Easy
 * Submission Time: 2025-11-22 17:15:02
 * Created by vahtyah on 2025-12-11 14:57:01
*/
 
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var maxSoFar = 0;
        var max = 0;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 1) maxSoFar++;
            else maxSoFar = 0;
            max = Math.Max(max, maxSoFar);
        }

        return max;
    }
}