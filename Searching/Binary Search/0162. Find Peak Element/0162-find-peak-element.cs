namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 0162. Find Peak Element
 * Difficulty: Medium
 * Submission Time: 2025-01-02 21:00:27
 * Created by vahtyah on 2025-02-21 07:04:51
*/
 
public class Solution {
    public int FindPeakElement(int[] nums) {
        var left = 0;
        var right = nums.Length - 1;
        while (left < right) {
            var mid = left + (right - left) / 2;
            if(nums[mid] < nums[mid + 1]) left = mid + 1;
            else right = mid;
        }
        
        return left;
    }
}