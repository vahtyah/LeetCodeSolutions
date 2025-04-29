namespace LeetCodeSolutions.SlidingWindow;

/*
 * 2962. Count Subarrays Where Max Element Appears at Least K Times
 * Difficulty: Medium
 * Submission Time: 2025-04-29 05:39:04
 * Created by vahtyah on 2025-04-29 05:39:29
*/
 
public class Solution {
    public long CountSubarrays(int[] nums, int k) {
        int maxVal = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            if(maxVal < nums[i]) maxVal = nums[i];
        }

        long result = 0;
        int maxCount = 0;
        int left = 0;
        
        for (int right = 0; right < nums.Length; right++) {
            if (nums[right] == maxVal) maxCount++;
            
            while (maxCount >= k) {
                if (nums[left++] == maxVal) maxCount--;
            }
            
            result += left;
        }
        
        return result;
    }
}