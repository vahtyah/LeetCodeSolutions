namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0368. Largest Divisible Subset
 * Difficulty: Medium
 * Submission Time: 2025-04-06 05:03:23
 * Created by vahtyah on 2025-04-06 05:03:44
*/
 
public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        if (nums == null || nums.Length == 0)
            return new List<int>();
        
        Array.Sort(nums);
        
        int n = nums.Length;
        int[] dp = new int[n];
        int[] prev = new int[n];
        
        for (int i = 0; i < n; i++) {
            dp[i] = 1;      
            prev[i] = -1;   
        }
        
        int maxIndex = 0;
        int maxLen = 1;
        for (int i = 1; i < n; i++) {
            for (int j = 0; j < i; j++) {
                if (nums[i] % nums[j] == 0 && dp[i] < dp[j] + 1) {
                    dp[i] = dp[j] + 1;
                    prev[i] = j;
                }
            }
            
            if (dp[i] > dp[maxIndex]) {
                maxIndex = i;
                maxLen = dp[i];
            }
        }
        
        List<int> result = new List<int>(maxLen);
        while (maxIndex != -1) {
            result.Add(nums[maxIndex]);
            maxIndex = prev[maxIndex];
        }
        
        result.Reverse();
        return result;
    }
}