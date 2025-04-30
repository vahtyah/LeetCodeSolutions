namespace LeetCodeSolutions.Math;

/*
 * 1295. Find Numbers with Even Number of Digits
 * Difficulty: Easy
 * Submission Time: 2025-04-30 03:55:41
 * Created by vahtyah on 2025-04-30 03:56:51
*/
 
public class Solution {
    public int FindNumbers(int[] nums) {
        var result = 0;
        
        for(int i = 0; i < nums.Length; i++){
            if((((int)Math.Log10(nums[i]) + 1) & 1) == 0) result++;
        }

        return result;
    }
}