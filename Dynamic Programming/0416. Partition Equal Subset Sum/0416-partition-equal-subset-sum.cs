namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0416. Partition Equal Subset Sum
 * Difficulty: Medium
 * Submission Time: 2025-04-07 05:43:36
 * Created by vahtyah on 2025-04-07 05:43:58
*/
 
public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = 0;
        int maxNum = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            maxNum = Math.Max(maxNum, nums[i]);
        }
        
        if ((sum & 1) == 1) {
            return false;
        }
        
        int target = sum >> 1; 
        
        if (maxNum > target) {
            return maxNum == target; 
        }
        
        bool[] dp = new bool[target + 1];
        dp[0] = true;
        
        foreach (int num in nums) {
            for (int i = target; i >= num; i--) {
                if (dp[target]) return true;
                dp[i] |= dp[i - num]; 
            }
        }
        
        return dp[target];
    }
}