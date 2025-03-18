namespace LeetCodeSolutions.BitManipulation;

/*
 * 2401. Longest Nice Subarray
 * Difficulty: Medium
 * Submission Time: 2025-03-18 05:03:26
 * Created by vahtyah on 2025-03-18 05:08:28
*/
 
public class Solution {
    public int LongestNiceSubarray(int[] nums) {
        int maxLength = 1; // At minimum, a subarray of length 1 is always "nice"
        int start = 0;
        int bitwise = 0; // Used to track the bitwise OR of all elements in current window
        
        for (int end = 0; end < nums.Length; end++) {
            // While the new number has a bit conflict with our current subarray
            while ((bitwise & nums[end]) != 0) {
                // Remove the leftmost number from our subarray by removing its bits
                bitwise ^= nums[start];
                start++;
            }
            
            // Add the current number to our subarray
            bitwise |= nums[end];
            
            // Update the max length
            maxLength = Math.Max(maxLength, end - start + 1);
        }
        
        return maxLength;
    }
}