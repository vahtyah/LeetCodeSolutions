namespace LeetCodeSolutions.TwoPointers;

/*
 * 1498. Number of Subsequences That Satisfy the Given Sum Condition
 * Difficulty: Medium
 * Submission Time: 2025-06-29 18:54:23
 * Created by vahtyah on 2025-06-29 18:55:44
*/
 
public class Solution {
    public int NumSubseq(int[] nums, int target) {
        const int MOD = 1000000007;
        var n = nums.Length;
        
        Array.Sort(nums);
        
        var powers = new int[n];
        powers[0] = 1;
        for (int i = 1; i < n; i++) {
            powers[i] = (powers[i - 1] * 2) % MOD;
        }
        
        int left = 0, right = n - 1;
        int result = 0;
        
        while (left <= right) {
            if (nums[left] + nums[right] <= target) {
                result = (result + powers[right - left]) % MOD;
                left++;
            } else {
                right--;
            }
        }
        
        return result;
    }
}