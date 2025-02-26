namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 1749. Maximum Absolute Sum of Any Subarray
 * Difficulty: Medium
 * Submission Time: 2025-02-26 09:28:58
 * Created by vahtyah on 2025-02-26 09:32:44
*/
 
public class Solution {
    public int MaxAbsoluteSum(int[] nums) {
        int maxSum = 0;    
        int minSum = 0;    
        int currentMax = 0;
        int currentMin = 0;
        
        foreach (var num in nums) {
            currentMax = Math.Max(currentMax + num, num);
            maxSum = Math.Max(maxSum, currentMax);
            
            currentMin = Math.Min(currentMin + num, num);
            minSum = Math.Min(minSum, currentMin);
        }
        
        return Math.Max(maxSum, -minSum);
    }
}