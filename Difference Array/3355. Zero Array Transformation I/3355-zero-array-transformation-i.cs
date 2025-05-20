namespace LeetCodeSolutions.DifferenceArray;

/*
 * 3355. Zero Array Transformation I
 * Difficulty: Medium
 * Submission Time: 2025-05-20 05:43:39
 * Created by vahtyah on 2025-05-20 05:57:12
*/
 
public class Solution {
    public bool IsZeroArray(int[] nums, int[][] queries) {
        var n = nums.Length;
        Span<int> diff = stackalloc int[n + 1];
        
        foreach (var query in queries) {
            diff[query[0]]++;
            diff[query[1] + 1]--;
        }
        
        var prefixSum = 0;
        for (int i = 0; i < n; i++) {
            prefixSum += diff[i];
            if (nums[i] > prefixSum) return false;
        }
        
        return true;
    }
}