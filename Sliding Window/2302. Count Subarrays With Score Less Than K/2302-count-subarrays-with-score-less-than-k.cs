namespace LeetCodeSolutions.SlidingWindow;

/*
 * 2302. Count Subarrays With Score Less Than K
 * Difficulty: Hard
 * Submission Time: 2025-04-28 07:14:09
 * Created by vahtyah on 2025-04-28 07:16:40
*/
 
public class Solution {
    public long CountSubarrays(int[] nums, long k) {
        long count = 0;
        long currentSum = 0;
        
        for (int start = 0, end = 0; end < nums.Length; end++) {
            currentSum += nums[end];
            
            while (currentSum * (end - start + 1) >= k) {
                currentSum -= nums[start];
                start++;
            }
            
            count += (end - start + 1);
        }
        
        return count;
    }
}