namespace LeetCodeSolutions.SlidingWindow;

/*
 * 0209. Minimum Size Subarray Sum
 * Difficulty: Medium
 * Submission Time: 2025-02-06 07:03:45
 * Created by vahtyah on 2025-02-06 07:07:38
 */
 
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        var minLength = int.MaxValue;
        var windowSum = 0;
        var windowStart = 0;

        for(int windowEnd = 0; windowEnd < nums.Length; windowEnd++){
            windowSum += nums[windowEnd];
            while(windowSum >= target){
                minLength = Math.Min(minLength, windowEnd - windowStart + 1);
                windowSum -= nums[windowStart];
                windowStart++;
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}