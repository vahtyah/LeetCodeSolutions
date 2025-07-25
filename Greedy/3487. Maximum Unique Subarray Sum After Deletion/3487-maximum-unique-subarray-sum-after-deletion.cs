namespace LeetCodeSolutions.Greedy;

/*
 * 3487. Maximum Unique Subarray Sum After Deletion
 * Difficulty: Easy
 * Submission Time: 2025-07-25 00:59:47
 * Created by vahtyah on 2025-07-25 01:03:31
*/
 
public class Solution {
    public int MaxSum(int[] nums) {
        var seen = new bool[202];
        seen[nums[0] + 100] = true;
        
        var result = nums[0];
        
        for(int i = 1; i < nums.Length; i++){
            if(seen[nums[i] + 100]) continue;
            result = Math.Max(result, result + nums[i]);
            result = Math.Max(result, nums[i]);
            seen[nums[i] + 100] = true;
        }

        return result;
    }
}