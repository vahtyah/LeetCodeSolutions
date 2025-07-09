namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0198. House Robber
 * Difficulty: Medium
 * Submission Time: 2025-07-09 20:28:10
 * Created by vahtyah on 2025-07-09 20:28:53
*/
 
public class Solution {
    public int Rob(int[] nums) {
        var n = nums.Length;
        if(n == 1) return nums[0];

        var dp = new int[n];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);

        for(int i = 2; i < n; i++){
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
        } 
        
        return dp[n - 1];
    }
}