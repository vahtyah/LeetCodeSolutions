namespace LeetCodeSolutions.Greedy;

/*
 * 0045. Jump Game II
 * Difficulty: Medium
 * Submission Time: 2025-01-30 13:03:25
 * Created by vahtyah on 2025-01-30 13:04:48
 */
 
public class Solution {
    public int Jump(int[] nums) {
        if (nums.Length <= 1) return 0;
        
        int jumps = 0;          
        int currentMax = 0;     
        int nextMax = 0;        
        
        for (int i = 0; i < nums.Length - 1; i++) {
            nextMax = Math.Max(nextMax, i + nums[i]);
            
            if (i == currentMax) {
                jumps++;
                currentMax = nextMax;
                
                if (currentMax >= nums.Length - 1) {
                    return jumps;
                }
            }
        }
        
        return jumps;
    }
}