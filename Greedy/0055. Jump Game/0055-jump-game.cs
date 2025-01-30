namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0055. Jump Game
 * Difficulty: Medium
 * Submission Time: 2025-01-29 21:23:03
 * Created by vahtyah on 2025-01-29 21:33:22
 */
 
public class Solution {
    public bool CanJump(int[] nums) {
        int maxReach = 0;
        
        for (int i = 0; i <= maxReach && i < nums.Length; i++) {
            // Update maxReach if current position + jump length is greater
            maxReach = Math.Max(maxReach, i + nums[i]);
            
            if (maxReach >= nums.Length - 1) {
                return true;
            }
        }
        
        return false;
    }
}