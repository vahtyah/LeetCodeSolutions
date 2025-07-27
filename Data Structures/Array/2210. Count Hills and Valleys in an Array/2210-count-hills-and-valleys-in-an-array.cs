namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2210. Count Hills and Valleys in an Array
 * Difficulty: Easy
 * Submission Time: 2025-07-27 00:20:21
 * Created by vahtyah on 2025-07-27 00:20:58
*/
 
public class Solution {
    public int CountHillValley(int[] nums) {
        var result = 0;

        for(int i = 1; i < nums.Length - 1; i++){
            if(nums[i] == nums[i + 1]){
                nums[i] = nums[i - 1];
                continue;
            }
            
            if(nums[i] > nums[i - 1] && nums[i] > nums[i + 1]) result++;
            else if(nums[i] < nums[i - 1] && nums[i] < nums[i + 1]) result++;
        }

        return result;
    }
}