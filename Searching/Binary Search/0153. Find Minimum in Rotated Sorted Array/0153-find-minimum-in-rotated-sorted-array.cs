namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 0153. Find Minimum in Rotated Sorted Array
 * Difficulty: Medium
 * Submission Time: 2025-06-12 20:56:56
 * Created by vahtyah on 2025-06-12 20:57:20
*/
 
public class Solution {
    public int FindMin(int[] nums) {
        int left = 0, right = nums.Length - 1;
        
        while (left < right) {
            var mid = left + ((right - left) >> 1);
            
            if (nums[mid] > nums[right]) left = mid + 1;
            else right = mid;
        }
        
        return nums[left];
    }
}