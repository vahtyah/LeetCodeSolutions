namespace LeetCodeSolutions.SlidingWindow;

/*
 * 1493. Longest Subarray of 1's After Deleting One Element
 * Difficulty: Medium
 * Submission Time: 2025-08-24 10:26:31
 * Created by vahtyah on 2025-08-24 10:27:59
*/
 
public class Solution {
    public int LongestSubarray(int[] nums) {
        int left = 0;
        int zeroCount = 0;
        int maxLength = 0;
        
        for (int right = 0; right < nums.Length; right++) {
            if (nums[right] == 0) {
                zeroCount++;
            }
            
            while (zeroCount > 1) {
                if (nums[left] == 0) {
                    zeroCount--;
                }
                left++;
            }
            
            maxLength = Math.Max(maxLength, right - left);
        }
        
        return maxLength;
    }
}