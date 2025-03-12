namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 2529. Maximum Count of Positive Integer and Negative Integer
 * Difficulty: Easy
 * Submission Time: 2025-03-12 04:58:44
 * Created by vahtyah on 2025-03-12 04:59:07
*/
 
public class Solution {
    public int MaximumCount(int[] nums) {
        var negativeCount = BinarySearch(nums, 0);
        var positiveCount = nums.Length - BinarySearch(nums, 1);
        
        return Math.Max(negativeCount, positiveCount);
    }
    
    private int BinarySearch(int[] nums, int target) {
        var left = 0;
        var right = nums.Length;
        
        while (left < right) {
            var mid = left + (right - left) / 2;
            
            if (nums[mid] < target) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        
        return left;
    }
}