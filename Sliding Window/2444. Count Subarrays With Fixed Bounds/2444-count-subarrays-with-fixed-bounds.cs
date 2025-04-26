namespace LeetCodeSolutions.SlidingWindow;

/*
 * 2444. Count Subarrays With Fixed Bounds
 * Difficulty: Hard
 * Submission Time: 2025-04-26 05:45:17
 * Created by vahtyah on 2025-04-26 05:45:50
*/
 
public class Solution {
    public long CountSubarrays(int[] nums, int minK, int maxK) {
        long result = 0;
        int lastOutOfBounds = -1;
        int lastMin = -1;
        int lastMax = -1;
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < minK || nums[i] > maxK) {
                lastOutOfBounds = i;
            }
            
            if (nums[i] == minK) {
                lastMin = i;
            }
            
            if (nums[i] == maxK) {
                lastMax = i;
            }
            
            if (lastMin > lastOutOfBounds && lastMax > lastOutOfBounds) {
                result += Math.Min(lastMin, lastMax) - lastOutOfBounds;
            }
        }
        
        return result;
    }
}